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
    public partial class frm_profile : Form
    {
        long LRN;
        DataTable dt_transHistory,dt_detail;

        public static frm_profile instance = null;
        public static readonly object padlock = new object();

        #region user_defined
        //USER DEFINED

        private int calculateAge(DateTime DOB)
        {
            int age;
            TimeSpan elapsedDays = DateTime.Now.Subtract(DOB);
            age = Convert.ToInt16(elapsedDays.Days / 365.25);

            return age;
        }

        private void setdgvHistory(long lrn)
        {
            try
            {
                string sy = cmb_SY.Text;
                int guardian_ID;
                guardian_ID = Convert.ToInt32(dt_detail.Rows[0]["guardian_ID"].ToString());
               

                dt_transHistory = this.cTE_Trans_HistoryTableAdapter.GetData(guardian_ID,sy,lrn);
                dgv_translog.DataSource = dt_transHistory;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! Something went wrong! frm_profile: setdgvHistory: " + ex.Message);
            }
        }

        private void setcmbSY()
        {
            DataTable dt_sy = this.school_YearTableAdapter.GetData();
            cmb_SY.DataSource = dt_sy;
            cmb_SY.DisplayMember = "SY";
            cmb_SY.SelectedIndex = 0;
        }

        public void setDetails()
        {
          
            

            dt_detail = this.searched_StudentTableAdapter.GetFillSearchedStudent(LRN);

            DateTime dob;
            dob = Convert.ToDateTime(dt_detail.Rows[0]["DOB"].ToString());
            
            lbl_lrn.Text = dt_detail.Rows[0]["LRN"].ToString();
            lbl_section.Text = dt_detail.Rows[0]["section_lelvel"].ToString();
            lbl_name.Text = dt_detail.Rows[0]["full_name"].ToString();
            lbl_dob.Text = dob.ToString("MMMM dd yyyy");
            lbl_gender.Text = dt_detail.Rows[0]["gender"].ToString();
            txt_addrss.Text = dt_detail.Rows[0]["address"].ToString();
            lbl_guardian.Text = dt_detail.Rows[0]["guardian_name"].ToString();
            lbl_relation.Text = dt_detail.Rows[0]["g_relation"].ToString();
            lbl_age.Text = calculateAge(dob).ToString();
        }

        public string getSection()
    {
        string section = lbl_section.Text;
        return section;
    }

        public long getLRN()
        {
            return LRN;
        }

        public string getName(int x)
        {
            string ret_val, fname, lname, mname;
            try
            {
                
                fname = dt_detail.Rows[0]["Fname"].ToString();
                lname = dt_detail.Rows[0]["Lname"].ToString();
                mname = dt_detail.Rows[0]["Mname"].ToString();

                if (x == 1)
                {
                    ret_val = fname;
                }
                else if (x == 2)
                {
                    ret_val = lname;
                }
                else if (x == 3)
                {
                    ret_val = mname;
                }
                else
                {
                    ret_val = null;
                }
             
            }
            catch 
            {
                MessageBox.Show("Whoops! something went wrong with the getName function!", "frm_profile");
                ret_val = null;
            
            }
            return ret_val;
            
        }

        public DateTime getDOB()
        { 
            DateTime dob;
            dob = Convert.ToDateTime(dt_detail.Rows[0]["DOB"].ToString());
            return dob;
        }

        public string getGuardian()
        {
            return lbl_guardian.Text;
        }

        public string getGRelation()
        {
            return lbl_relation.Text;
        }


        //END REGION
        #endregion


        private frm_profile()
        {
            InitializeComponent();
        }

        public static frm_profile Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_profile();
                    }
                }

                return instance;
            }
        }

        private void frm_profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void frm_profile_Load(object sender, EventArgs e)
        {
            var frm_mngPro = Application.OpenForms.OfType<frm_manageStudent>().Single();
            LRN=frm_mngPro.getLRN();

            setcmbSY();
            
            setDetails();
           
            this.TopMost = true;
       
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            dt_detail = this.searched_StudentTableAdapter.GetFillSearchedStudent(LRN);
            setdgvHistory(LRN);
            dgv_translog.ClearSelection();
        }

        private void dgv_translog_SelectionChanged(object sender, EventArgs e)
        {
            dgv_translog.ClearSelection();
        }

        private void btn_updateSection_Click(object sender, EventArgs e)
        {
            frm_updateSection frm_upSec = frm_updateSection.Instance;
            frm_upSec.Show();
        }

        private void btn_updateName_Click(object sender, EventArgs e)
        {
            frm_updateName frm_upName = frm_updateName.Instance;
            frm_upName.Show();
        }

        private void btn_updateDOB_Click(object sender, EventArgs e)
        {
            frm_updateDOB frm_updateDOB = frm_updateDOB.Instance;
            frm_updateDOB.Show();
        }

        private void btn_updateADRS_Click(object sender, EventArgs e)
        {
            txt_addrss.ReadOnly = false;
        }

        private void btn_saveADRS_Click(object sender, EventArgs e)
        {
            try
            {
                string address = txt_addrss.Text.Trim().ToUpper();
                this.studentTableAdapter.UpdateAddress(address, getLRN());
                MessageBox.Show("Update Successfull", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_addrss.ReadOnly = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Whoops! Something went wrong during update address!\nError:" + ex.Message, "frm_profile");
            }
        }

        private void btn_editGender_Click(object sender, EventArgs e)
        {
            frm_updateGender frm_upGen = frm_updateGender.Instance;
            frm_upGen.Show();
        }

        private void brn_updateGuardian_Click(object sender, EventArgs e)
        {
            frm_updateGuardian frm_upG = frm_updateGuardian.Instance;
            frm_upG.Show();
        }

        
    }
}
