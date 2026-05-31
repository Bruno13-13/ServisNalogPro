using ServisNalogPro.Models;
using ServisNalogPro.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisNalogPro.Forms
{
    public partial class FormaKreiranjaNaloga : Form
    {
        private int idNaloga = 0;

        public FormaKreiranjaNaloga()
        {
            InitializeComponent();
            UcitajZaposlenike();
        }
        public FormaKreiranjaNaloga(int id)
        {
            InitializeComponent();
            idNaloga = id;

            UcitajZaposlenike();
            UcitajNalog();
        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            RadniNalog nalog = new RadniNalog();

            nalog.IdNaloga = idNaloga;
            nalog.OpisKvara = txtOpis.Text;
            nalog.Datum = dtpDatum.Value;
            nalog.Status = cmbStatus.Text;
            nalog.IdZaposlenika = (int)cmbZaposlenik.SelectedValue;

            RadniNalogRepository repo = new RadniNalogRepository();

            if (idNaloga == 0)
            {
                repo.Spremi(nalog); 
                MessageBox.Show("Nalog spremljen!");
            }
            else
            {
                repo.Azuriraj(nalog); 
                MessageBox.Show("Nalog ažuriran!");
            }
                this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UcitajZaposlenike()
        {
            cmbZaposlenik.DataSource = null;
            cmbZaposlenik.Items.Clear();

            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
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
        private void UcitajNalog()
        {
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM RadniNalog WHERE IdNaloga = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", idNaloga);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtOpis.Text = reader["OpisKvara"].ToString();
                        dtpDatum.Value = Convert.ToDateTime(reader["Datum"]);
                        cmbStatus.Text = reader["Status"].ToString();
                        cmbZaposlenik.SelectedValue = reader["IdZaposlenika"];
                    }
                }
            }
        }
    }
}
