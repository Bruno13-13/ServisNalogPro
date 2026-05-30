using ServisNalogPro.Models;
using ServisNalogPro.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisNalogPro.Forms
{
    public partial class FormaKreiranjaNaloga : Form
    {
        public FormaKreiranjaNaloga()
        {
            InitializeComponent();
            UcitajZaposlenike();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            RadniNalog nalog = new RadniNalog();

            nalog.OpisKvara = txtOpis.Text;
            nalog.Datum = dtpDatum.Value;
            nalog.Status = cmbStatus.Text;
            nalog.IdZaposlenika = 1;

            RadniNalogRepository repo = new RadniNalogRepository();
            repo.Spremi(nalog);

            MessageBox.Show("Nalog spremljen u bazu!");

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UcitajZaposlenike()
        {
            cmbZaposlenik.DataSource = null; 
            cmbZaposlenik.Items.Clear();

            string connectionString = Program.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT IdZaposlenika, Ime + ' ' + Prezime AS Ime FROM Zaposlenik";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    var lista = new List<dynamic>();

                    while (reader.Read())
                    {
                        lista.Add(new
                        {
                            Text = reader["Ime"].ToString(),
                            Value = reader["IdZaposlenika"]
                        });
                    }

                    cmbZaposlenik.DataSource = lista;
                    cmbZaposlenik.DisplayMember = "Text";
                    cmbZaposlenik.ValueMember = "Value";
                }
            }
        }
    }
    
}
