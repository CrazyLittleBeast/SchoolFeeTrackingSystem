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
    public partial class frm_updateSection : Form
    {
        DataTable dt_section;
        
        #region user Defined

        public void setcmb()
        {
            cmb_section.DataSource = dt_section;
            cmb_section.DisplayMember = "name_level";
        }

        #endregion

        public static frm_updateSection instance = null;
        public static readonly object padlock = new object();

        private frm_updateSection()
        {
            InitializeComponent();
        }

        public static frm_updateSection Instance
        {
            get
            {
                lock (padlock) 
                {
                    if (instance == null)
                    {
                        instance = new frm_updateSection();
                    }
                }
                return instance;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateSection_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void updateSection_Load(object sender, EventArgs e)
        {
            dt_section = this.sectionTableAdapter.GetDataBySection_Level();
            setcmb();
            var pro = Application.OpenForms.OfType<frm_profile>().Single();
            cmb_section.Text = pro.getSection();
            this.TopMost = true;
        }

        private void bnt_update_Click(object sender, EventArgs e)
        {
            try
            {
                long LRN;
                int Section_ID, sec_index;
                sec_index = cmb_section.SelectedIndex;
                var pro = Application.OpenForms.OfType<frm_profile>().Single();
                LRN = pro.getLRN();
                Section_ID = Convert.ToInt32(dt_section.Rows[sec_index]["Section_ID"].ToString());
                this.studentTableAdapter.UpdateSection(Section_ID, LRN);

                MessageBox.Show("Update Successfull!", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);            
                pro.setDetails();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops something went wrong during update!\nError:"+ex.Message, "frm_updateSection");
            }
            
        }
    }
}
