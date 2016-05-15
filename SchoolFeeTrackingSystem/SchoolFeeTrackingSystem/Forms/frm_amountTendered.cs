using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolFeeTrackingSystem.Forms
{
    public partial class frm_amountTendered : Form
    {
        public static frm_amountTendered instance = null;
        public static readonly object padlock = new object();

        Boolean isDigit = false;

        private frm_amountTendered()
        {
            InitializeComponent();
        }

        public static frm_amountTendered Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_amountTendered();
                    }
                }
                return instance;
            }
        }

        private void frm_amountTendered_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {       
            isDigit = SFTS_Functions.digitCheckWithDecimal(txt_amount.Text.Trim());
            SFTS_Functions.digitValidateWithDecimal(txt_amount, pb_status);
            if (isDigit==true && txt_amount.Text.Length > 0)
            {
                decimal amount = Convert.ToDecimal(txt_amount.Text.Trim());    
            }
        }

        private void frm_amountTendered_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (isDigit)
            {
                var frm_cashier = Application.OpenForms.OfType<frm_cashier>().Single();
                frm_cashier.getAmountTendered(Convert.ToDecimal(txt_amount.Text.Trim()));
                this.Close();
            }
        }
    }
}
