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
    public partial class frm_sectionUpdate : Form
    {
        public static frm_sectionUpdate instance = null;
        public static readonly object padlock = new object();

        private frm_sectionUpdate()
        {
            InitializeComponent();
        }
        public static frm_sectionUpdate Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_sectionUpdate();
                    }
                }
                return instance;
            }
        }

        int SECTION_ID;

        private void frm_sectionUpdate_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            cmb_level.SelectedIndex = 0;

            var frm_sec = Application.OpenForms.OfType<frm_section>().Single();
            SECTION_ID = frm_sec.getSectionID();
            txt_name.Text =  frm_sec.getDescription("A");
            cmb_level.Text = frm_sec.getDescription("B");



           
        }

        private void frm_sectionUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            try
            {
                var frm_sec = Application.OpenForms.OfType<frm_section>().Single();

                string s_name, s_level;
                s_name = txt_name.Text.ToUpper().Trim();
                s_level = cmb_level.Text.ToUpper().Trim();
                this.sectionTableAdapter.UpdateSection(s_name, s_level, SECTION_ID);
                MessageBox.Show("Update Successfull!", "Update Complete");
                frm_sec.FilterSection();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! something went wrong: frm_sectionUpdate", "frm_sectionUpdate");
            }
        }
    }
}
