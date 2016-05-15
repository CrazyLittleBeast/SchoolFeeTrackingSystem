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
    public partial class frm_section : Form
    {
        public static frm_section instance = null;
        public static readonly object padlock = new object();
        DataTable dt_section;

        string FILTER_TEXT;

        private frm_section()
        {
            InitializeComponent();
        }
        public static frm_section Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_section();
                    }           
                }
                return instance;
            }
        }

        #region user_defined
        /****************************************/
        /*                User Defined          */
        /****************************************/

        private void sectionNameFocus()
        {
            txt_secName.Focus();
            txt_secName.SelectionStart = 0;
            txt_secName.SelectionLength = txt_secName.Text.Length;
        }

        public void setDataGrid()
        {
            dt_section = this.sectionTableAdapter.GetData();
            dgv_section.DataSource = dt_section;
        }

        private void levelFilter(Object sender, EventArgs e)
        {
            string level;
            if(((RadioButton)sender).Checked)
            {
                RadioButton rb = (RadioButton)sender;
                level = rb.Text;
                FILTER_TEXT = level;
                if (level.Equals("ALL"))
                {
                    setDataGrid();
                }
                else
                { 
                    dt_section = this.sectionTableAdapter.GetDataByLevel(level);
                    dgv_section.DataSource = dt_section;
                }                                 
               
            }

        }

          public string getDescription(string opt)
        {
            string ret_val;
            int index;
            index = dgv_section.CurrentRow.Index;

            if (opt.Equals("A"))
            {
                ret_val = dgv_section.Rows[index].Cells["section_name"].Value.ToString();
            }
            else if (opt.Equals("B"))
            {
                ret_val = dgv_section.Rows[index].Cells["section_level"].Value.ToString();
            }
            else 
            {
                ret_val = null;
            }

            return ret_val;
        }

          public int getSectionID()
          { 
            int id, index;
              index = dgv_section.CurrentRow.Index;
              id = Convert.ToInt32(dgv_section.Rows[index].Cells["Section_ID"].Value.ToString());

              return id;
          }

          public void FilterSection()
          {
              if (FILTER_TEXT.Equals("ALL"))
              {
                  setDataGrid();
              }
              else
              {
                  dt_section = this.sectionTableAdapter.GetDataByLevel(FILTER_TEXT);
                  dgv_section.DataSource = dt_section;
              }     
          }
    
        /******************END******************/
        #endregion


        private void frm_section_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            setDataGrid();
            cmb_level.SelectedIndex = 0;
            rbtn_all.Select();
        }

        private void frm_section_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         
            string section_name,section_level;

            section_name = txt_secName.Text.ToUpper().Trim();
            section_level = cmb_level.Text;

            try
            {
                int dup_count = this.sectionTableAdapter.duplicate_chk(section_name).Value;
                if (section_name.Length > 2)
                {
                    if (dup_count > 0)
                    {
                        MessageBox.Show("Section name already in use!", "Section Name Existing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        sectionNameFocus();
                    }
                    else
                    {
                        this.sectionTableAdapter.Insert(section_name, section_level);
                        txt_secName.Clear();
                        MessageBox.Show("Successfully added " + section_name + "-" + section_level, "Successful ADD");
                        setDataGrid();
                        rbtn_all.Select();
                        txt_secName.Focus();
                    }
                }
                else 
                {
                    MessageBox.Show("SECTION NAME TOO SHORT!", "Section name too short", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    sectionNameFocus();            
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in frm_section: " + ex.Message + ".\nKindly Inform the Developer.","Error Detected");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_secName.Clear();
            txt_secName.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {

                int index = dgv_section.CurrentRow.Index;
                int section_id = Convert.ToInt16(dgv_section.Rows[index].Cells["Section_ID"].Value.ToString());

                this.sectionTableAdapter.DeleteSection(section_id);

                FilterSection();

            }
            catch
            { }
          
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int row_count = dgv_section.SelectedRows.Count;

            if (row_count > 0)
            {
                frm_sectionUpdate frm_sectionUpdate = frm_sectionUpdate.Instance;
                frm_sectionUpdate.Show();
            }

        }

 
    }
}
