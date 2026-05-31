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

namespace ServisNalogPro.Forms
{
    public partial class PregledNaloga : Form
    {
        public PregledNaloga()
        {
            InitializeComponent();
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

                string query = @"SELECT rn.IdNaloga, rn.OpisKvara, rn.Datum, rn.Status, 
                                z.Ime + ' ' + z.Prezime AS Tehnicar
                                FROM RadniNalog rn
                                JOIN Zaposlenik z ON rn.IdZaposlenika = z.IdZaposlenika
                                ORDER BY r.IdNaloga DESC";
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }

        }
    }
}
