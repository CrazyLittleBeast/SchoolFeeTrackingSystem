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
    public partial class frm_updateDOB : Form
    {
        long LRN;

        public static frm_updateDOB instance = null;
        public static readonly object padlock = new object();

        private frm_updateDOB()
        {
            InitializeComponent();
        }

        public static frm_updateDOB Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_updateDOB();
                    }
                }
                return instance;
            }
        }

        private void frm_updateDOB_Load(object sender, EventArgs e)
        {
            var frm_pro = Application.OpenForms.OfType<frm_profile>().Single();
            LRN = frm_pro.getLRN();
            dtp_dob.Value = frm_pro.getDOB();
            this.TopMost = true;
        }

        private void frm_updateDOB_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void bnt_update_Click(object sender, EventArgs e)
        {
            try
            {
                var frm_pro = Application.OpenForms.OfType<frm_profile>().Single();

                string dob;
                dob = dtp_dob.Value.ToString();
                this.studentTableAdapter.UpdateDOB(dob, LRN);
                MessageBox.Show("Successfully Updated!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_pro.setDetails();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! Something went wrong during update!\nError:" + ex.Message, "frm_updateDOB");
            }
        }
    }
}
