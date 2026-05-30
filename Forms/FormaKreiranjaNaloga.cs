using ServisNalogPro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtOpis.Text == "" || 
                cmbStatus.Text == "" ||
                cmbTehnicar.Text =="")
            {
                MessageBox.Show("Popunite sva polja!");
                return;
            }
            RadniNalog nalog = new RadniNalog();

            nalog.OpisKvara = txtOpis.Text;
            nalog.Datum = dtpDatum.Value;
            nalog.Status = cmbStatus.Text;
            nalog.IdZaposlenika = 1;

            MessageBox.Show("Nalog kreiran)");
                
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
