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
    public partial class frm_deactivate : Form
    {
        public static frm_deactivate instance = null;
        public static readonly object padlock = new object();

        private frm_deactivate()
        {
            InitializeComponent();
        }

        public static frm_deactivate Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_deactivate();
                    }
                }
                return instance;
            }
        }

        private void frm_deactivate_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
           
            var frm_mngUser = Application.OpenForms.OfType<frm_manageUser>().Single();
            lbl_user.Text = frm_mngUser.WhoIsUser();
        }

        private void frm_deactivate_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
