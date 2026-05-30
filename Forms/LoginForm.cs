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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                

                this.Hide(); 

                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Pogrešni podaci.");
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Jeste li sigurni da želite izaći?",
                "Izlaz",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                {
                Application.Exit();
            }   
        }
    }
}
