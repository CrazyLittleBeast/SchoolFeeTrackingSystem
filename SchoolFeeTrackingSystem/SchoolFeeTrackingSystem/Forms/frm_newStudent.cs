using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchoolFeeTrackingSystem.Forms
{
    public partial class frm_newStudent : Form
    {

        byte[] img_byte;
        DataTable dt_guardian;
        DataTable dt_section;
        Boolean isValidLRN = false;

        private static frm_newStudent instance = null;
        private static readonly object padlock = new object();


        #region user_defined
        /* USER DEFINED */

        public void setGuardian()
        {
            dt_guardian = this.guardianTableAdapter.GetDataByGuardianName();
            cmb_guardian.DataSource = dt_guardian;
            cmb_guardian.DisplayMember = "guardian_name";    
        }

        private void setSection()
        {
            dt_section = this.sectionTableAdapter.GetDataBySection_Level();
            cmb_section.DataSource = dt_section;
            cmb_section.DisplayMember = "name_level";
        }

        private int getGuardian_ID()
        {
            int id, index;
            index = cmb_guardian.SelectedIndex;
            id = Convert.ToInt32(dt_guardian.Rows[index]["guardian_ID"].ToString());

            return id;
        }

        private int getSection_ID()
        {
            int id, index;
            index = cmb_section.SelectedIndex;
            id = Convert.ToInt32(dt_section.Rows[index]["Section_ID"].ToString());

            return id;
        }

       

        /* END REGION   */
        #endregion



        private frm_newStudent()
        {
            InitializeComponent();
        }

        public static frm_newStudent Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_newStudent();
                    }
                }
                return instance;
            }
        }

        private void frm_newStudent_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            setGuardian();
            setSection();
        }

        private void frm_newStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Image student_image;
            MemoryStream ms;
            
            DateTime DOB = dtp_dob.Value;
            DateTime reg_date;

            try
            {
                long LRN = Convert.ToInt64(txt_LRN.Text);
                string fname, lname, mname, addrss, g_relation, student_status;
                int g_id, section_ID, dup_count;
                char gender = Convert.ToChar(cmb_gender.Text);


                g_id = getGuardian_ID();
                section_ID = getSection_ID();

                fname = txt_first.Text.ToUpper().Trim();
                lname = txt_last.Text.ToUpper().Trim();
                mname = txt_mid.Text.ToUpper().Trim();
                addrss = txt_addrs.Text.ToUpper().Trim();
                g_relation = txt_relation.Text.ToUpper().Trim();
                student_status = "ACTIVE";
                reg_date = DateTime.Now;

                if (pb_image.Image != null)
                {
                    ms = new MemoryStream();
                    student_image = pb_image.Image;
                    student_image.Save(ms, student_image.RawFormat);

                    img_byte = ms.GetBuffer();
                }

                if (isValidLRN)
                {
                    dup_count = Convert.ToInt16(this.studentTableAdapter.DuplicateCount(fname, lname, mname).ToString());

                    if (dup_count == 0)
                    {
                        this.studentTableAdapter.Insert(LRN, fname, lname, mname, gender.ToString(), DOB, addrss, g_id, g_relation, img_byte, section_ID, DateTime.Now, student_status);
                        MessageBox.Show("Successfully added " + lname + ", " + fname, "Successfully added Student");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("This student is already registered!", "Double entry detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid LRN Format","Invalid LRN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "frm_newStudent");
            }



        }

        private void btn_brwse_Click(object sender, EventArgs e)
        {
            DialogResult result;
            this.openFileDialog1.Filter = "Pictures (*JPG; *.PNG; *.BMP)|*.JPG; *.PNG; *.BMP";
            result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
           {
                return;
            }
            this.pb_image.Image = System.Drawing.Image.FromFile(this.openFileDialog1.FileName);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newG_Click(object sender, EventArgs e)
        {
            frm_NewGuardian frm_newG = frm_NewGuardian.Instance;
            frm_newG.Show();
        }

        private void txt_LRN_TextChanged(object sender, EventArgs e)
        {
            if (txt_LRN.Text.Length == 12)
            {
                SFTS_Functions.digitValidate(txt_LRN, pb_status);
                isValidLRN = SFTS_Functions.digitCheck(txt_LRN.Text);
            }
            else 
            {
                pb_status.Image = Properties.Resources.warning_16;
            }
        }

    }
}
