using ServisNalogPro.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisNalogPro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            FormaKreiranjaNaloga formaKreiranjaNaloga = new FormaKreiranjaNaloga();
            formaKreiranjaNaloga.Show();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Jeste li sigurni da želite izaći?", 
                "Izlaz",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                                Application.Exit();
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show
                ("Jeste li sigurni da želite odjaviti?", 
                "Odjava",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
