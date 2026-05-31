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
            UcitajStatistiku();
        }

        private void StatistikaForm_Load(object sender, EventArgs e)
        {

        }
        private void UcitajStatistiku()
        {
            using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
            {
                conn.Open();
                SqlCommand cmdUkupno = new SqlCommand("SELECT COUNT(*) FROM RadniNalog", conn);
                int ukupno = (int)cmdUkupno.ExecuteScalar();
                lblUkupno.Text = "Ukupno naloga: " + ukupno;

                SqlCommand cmdUTijeku = new SqlCommand("SELECT COUNT(*) FROM RadniNalog WHERE Status = 'U tijeku'", conn);
                int uTijeku = (int)cmdUTijeku.ExecuteScalar();
                lblUTijeku.Text = "Nalog u tijeku: " + uTijeku;

                SqlCommand cmdZavrseno = new SqlCommand("SELECT COUNT(*) FROM RadniNalog WHERE Status = 'Završeno'", conn);
                int zavrseno = (int)cmdZavrseno.ExecuteScalar();
                lblZavrseno.Text = "Završeno naloga: " + zavrseno;
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
