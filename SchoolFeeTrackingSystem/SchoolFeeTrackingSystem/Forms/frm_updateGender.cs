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
    public partial class frm_updateGender : Form
    {
        public static frm_updateGender instance = null;
        public static readonly object padlock = new object();

        private frm_updateGender()
        {
            InitializeComponent();
        }

        public static frm_updateGender Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_updateGender();
                    }
                }
                return instance;
            }
        }

        private void frm_updateGender_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            cmb_gender.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_updateGender_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void bnt_update_Click(object sender, EventArgs e)
        {
            long LRN;
            string g;
            try
            {
                var frm_pro = Application.OpenForms.OfType<frm_profile>().Single();
                LRN = frm_pro.getLRN();

                if (cmb_gender.Text.Equals("MALE"))
                {
                    g = "M";
                }
                else
                {
                    g = "F";
                }
                this.studentTableAdapter.UpdateGender(g, LRN);
                MessageBox.Show("Update Complete!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_pro.setDetails();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops something went wrong during update!\nError:" + ex.Message, "frm_updateGender");
            }
        }
    }
}
