using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolFeeTrackingSystem.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frm_authentication frm_auth = new frm_authentication();

            if (frm_auth.ShowDialog() == DialogResult.OK)
            {
                if (Properties.Settings.Default.SFTS_UTYPE.Equals("ADMINISRATOR"))
                {
                    Application.Run(new frm_main());
                }
                else if (Properties.Settings.Default.SFTS_UTYPE.Equals("CASHIER"))
                {
                    frm_cashier.Instance.Show();
                    Application.Run();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
