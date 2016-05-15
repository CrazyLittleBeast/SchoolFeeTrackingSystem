using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace SchoolFeeTrackingSystem.Forms
{
    class SFTS_Functions
    {
        public static Boolean digitCheck(string digits)
        {
            Regex rg = new Regex("^[0-9]*$");
            return rg.IsMatch(digits);
        }

        public static Boolean digitCheckWithDecimal(string digits)
        {
            //regex allows only 1 decimal point
            Regex rg = new Regex(@"^[0-9]+(\.[0-9]+)?$");
            return rg.IsMatch(digits);
        }

        public static void digitValidate(TextBox txt_box, PictureBox pb_box)
        {
            if (txt_box.TextLength > 0)
            {
                if (SFTS_Functions.digitCheck(txt_box.Text))
                {
                    pb_box.Image = Properties.Resources.check_16;
                }
                else
                {
                    pb_box.Image = Properties.Resources.warning_16;
                }
            }
            else
            {
                pb_box.Image = null;
            }
        }

        public static void digitValidateWithDecimal(TextBox txt_box, PictureBox pb_box)
        {
            if (txt_box.TextLength > 0)
            {
                if (SFTS_Functions.digitCheckWithDecimal(txt_box.Text))
                {
                    pb_box.Image = Properties.Resources.check_16;
                }
                else
                {
                    pb_box.Image = Properties.Resources.warning_16;
                }
            }
            else
            {
                pb_box.Image = null;
            }
        }

        public static decimal getPercentOfTotal(decimal val, decimal total_val)
        { 
            decimal ret_val = (val / total_val);
            return ret_val;
        }

        public static bool IsServerConnected()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.SFTS_DBConnectionString);
                conn.Open();
                return true; 
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
