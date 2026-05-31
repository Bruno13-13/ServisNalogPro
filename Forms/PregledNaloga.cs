using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ServisNalogPro.Repositories;

namespace ServisNalogPro.Forms
{
    public partial class PregledNaloga : Form
    {
        public PregledNaloga()
        {
            InitializeComponent();

            cmbFilterStatus.Items.Add("Svi");
            cmbFilterStatus.Items.Add("U tijeku");
            cmbFilterStatus.Items.Add("Završeno");
            cmbFilterStatus.SelectedIndex = 0;

            UcitajNaloge();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void UcitajNaloge()
        {
            string connectionString = Program.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query;

                if (cmbFilterStatus.Text == "U tijeku")
                {
                    query = @"SELECT rn.IdNaloga, rn.OpisKvara, rn.Datum, rn.Status, 
                              z.Ime + ' ' + z.Prezime AS Tehnicar
                              FROM RadniNalog rn
                              JOIN Zaposlenik z ON rn.IdZaposlenika = z.IdZaposlenika
                              WHERE rn.Status = 'U tijeku'
                              ORDER BY rn.IdNaloga DESC";
                }
                else if (cmbFilterStatus.Text == "Završeno")
                {
                    query = @"SELECT rn.IdNaloga, rn.OpisKvara, rn.Datum, rn.Status, 
                              z.Ime + ' ' + z.Prezime AS Tehnicar
                              FROM RadniNalog rn
                              JOIN Zaposlenik z ON rn.IdZaposlenika = z.IdZaposlenika
                              WHERE rn.Status = 'Završeno'
                              ORDER BY rn.IdNaloga DESC";
                }
                else
                {
                    query = @"SELECT rn.IdNaloga, rn.OpisKvara, rn.Datum, rn.Status, 
                              z.Ime + ' ' + z.Prezime AS Tehnicar
                              FROM RadniNalog rn
                              JOIN Zaposlenik z ON rn.IdZaposlenika = z.IdZaposlenika
                              ORDER BY rn.IdNaloga DESC";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdNaloga"].Value);
                RadniNalogRepository repo = new RadniNalogRepository();
                repo.Obrisi(id);
                MessageBox.Show("Nalog obrisan!");
                UcitajNaloge();
            }

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdNaloga"].Value);
                FormaKreiranjaNaloga forma = new FormaKreiranjaNaloga(id);
                forma.ShowDialog();
                UcitajNaloge();
            }
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajNaloge();
        }
    }
}
