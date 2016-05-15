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
    public partial class frm_updateGuardian : Form
    {
        public static frm_updateGuardian instance = null;
        public static readonly object padlock = new object();

        DataTable dt_guardian;

        #region user defined

        public void setGuardinCMB()
        {
            try
            {
                dt_guardian = this.guardianTableAdapter.GetDataByGuardianName();
                cmb_guardian.DataSource = dt_guardian;
                cmb_guardian.DisplayMember = "guardian_name";
            }
            catch { }
        }

        #endregion

        private frm_updateGuardian()
        {
            InitializeComponent();
        }
        public static frm_updateGuardian Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_updateGuardian();
                    }
                }
                return instance;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_updateGuardian_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void frm_updateGuardian_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            setGuardinCMB();
            try
            {
                var frm_pro = Application.OpenForms.OfType<frm_profile>().Single();
                cmb_guardian.Text = frm_pro.getGuardian();
                txt_gRelation.Text = frm_pro.getGRelation();
            }
            catch { }

        }

        private void bnt_update_Click(object sender, EventArgs e)
        {
            try
            {
                long lrn;
                int guardian_ID,g_index;
                var frm_pro = Application.OpenForms.OfType<frm_profile>().Single();
                string guardian_relation = txt_gRelation.Text.Trim().ToUpper();
                g_index = cmb_guardian.SelectedIndex;
                lrn = frm_pro.getLRN();

                guardian_ID = Convert.ToInt32(dt_guardian.Rows[g_index]["guardian_ID"].ToString());
                this.studentTableAdapter.UpdateGuardian(guardian_ID, guardian_relation,lrn);
                MessageBox.Show("Update Complete!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_pro.setDetails();
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops something went wrong during the update!\nError: " + ex.Message, "frm_updateGuardian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
