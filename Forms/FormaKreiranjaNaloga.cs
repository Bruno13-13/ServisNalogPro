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
    }
    
}
