using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisNalogPro
{
    static class Program
    {
        public static string ConnectionString =
            "Server=31.147.206.65;Database=PI2526_bmatusic22_DB;User Id=PI2526_bmatusic22;Password=28gVnDyL<Hi6&A(z;Encrypt=False;";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
