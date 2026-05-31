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
    public partial class StatistikaForm : Form
    {
        public StatistikaForm()
        {
            InitializeComponent();

            
            UcitajStatistiku(new DateTime(1753, 1, 1), DateTime.Now);
        }

        private void UcitajStatistiku(DateTime od, DateTime doDatuma)
        {
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();

               
                SqlCommand cmdUkupno = new SqlCommand(
                    "SELECT COUNT(*) FROM RadniNalog WHERE Datum BETWEEN @od AND @do", conn);

                cmdUkupno.Parameters.AddWithValue("@od", od);
                cmdUkupno.Parameters.AddWithValue("@do", doDatuma);

                int ukupno = (int)cmdUkupno.ExecuteScalar();
                lblUkupno.Text = "Ukupno naloga: " + ukupno;

               
                SqlCommand cmdUTijeku = new SqlCommand(
                    "SELECT COUNT(*) FROM RadniNalog WHERE Datum BETWEEN @od AND @do AND Status = 'U tijeku'", conn);

                cmdUTijeku.Parameters.AddWithValue("@od", od);
                cmdUTijeku.Parameters.AddWithValue("@do", doDatuma);

                int uTijeku = (int)cmdUTijeku.ExecuteScalar();
                lblUTijeku.Text = "U tijeku: " + uTijeku;

               
                SqlCommand cmdZavrseno = new SqlCommand(
                    "SELECT COUNT(*) FROM RadniNalog WHERE Datum BETWEEN @od AND @do AND Status = 'Završeno'", conn);

                cmdZavrseno.Parameters.AddWithValue("@od", od);
                cmdZavrseno.Parameters.AddWithValue("@do", doDatuma);

                int zavrseno = (int)cmdZavrseno.ExecuteScalar();
                lblZavrseno.Text = "Završeno naloga: " + zavrseno;

                
                SqlCommand cmdTablica = new SqlCommand(@"
                    SELECT 
                        z.Ime + ' ' + z.Prezime AS Zaposlenik,
                        SUM(CASE WHEN rn.Status = 'Završeno' THEN 1 ELSE 0 END) AS Zavrseni,
                        SUM(CASE WHEN rn.Status = 'U tijeku' THEN 1 ELSE 0 END) AS UTijeku,
                        COUNT(*) AS Ukupno
                    FROM RadniNalog rn
                    JOIN Zaposlenik z ON rn.IdZaposlenika = z.IdZaposlenika
                    WHERE rn.Datum BETWEEN @od AND @do
                    GROUP BY z.Ime, z.Prezime
                ", conn);

                cmdTablica.Parameters.AddWithValue("@od", od);
                cmdTablica.Parameters.AddWithValue("@do", doDatuma);

                SqlDataAdapter adapter = new SqlDataAdapter(cmdTablica);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime od = dtpOd.Value.Date;
            DateTime doDatuma = dtpDo.Value.Date.AddDays(1).AddSeconds(-1); 

            UcitajStatistiku(od, doDatuma);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           dtpOd.Value = DateTime.Today;
            dtpDo.Value = DateTime.Today;

            UcitajStatistiku(new DateTime(1753, 1, 1), DateTime.Now);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UcitajStatistiku(new DateTime(1753, 1, 1), DateTime.Now);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatistikaForm_Load(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        { }
        
    }
}
