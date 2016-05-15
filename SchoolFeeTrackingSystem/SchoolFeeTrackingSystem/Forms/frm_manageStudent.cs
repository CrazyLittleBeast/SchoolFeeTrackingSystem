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
    public partial class frm_manageStudent : Form
    {
        DataTable dt_student;

        public static frm_manageStudent instance = null;
        public static readonly object padlock = new object();


        #region user defined
        /* USER DEFINED  */

        public long getLRN()
        {
         
            int index;
            long lrn;

            index = dgv_student.CurrentRow.Index;
            lrn = Convert.ToInt64(dgv_student.Rows[index].Cells["LRN"].Value.ToString());

            return lrn;   
        }


        private void search_Student(string search_text)
        {
            try
            {
                dt_student = this.studentTableAdapter.GetSearchData(search_text, search_text, search_text);
                dgv_student.DataSource = dt_student;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }



        /* END OF REGION*/
        #endregion

        private frm_manageStudent()
        {
            InitializeComponent();
        }

        public static frm_manageStudent Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_manageStudent();
                    }
                    return instance;
                }           
            }
        }

        private void frm_manageStudent_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void frm_manageStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_newStudent frm_nStudent = frm_newStudent.Instance;
            frm_nStudent.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search_text = txt_search.Text.Trim().ToUpper();
            if (txt_search.Text.Length > 0)
            {

                search_Student(search_text + "%");
            }
            else
            {
                search_Student(search_text);
            }
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            int rowCount;
            rowCount = dgv_student.SelectedRows.Count;
            if (rowCount > 0)
            {
                frm_profile frm_profile = frm_profile.Instance;
                frm_profile.Show();
            }
        }

        private void txt_search_Enter(object sender, EventArgs e)
        {
            txt_search.Text = "";
            txt_search.Font = new Font("Verdana", 10, FontStyle.Regular);
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if (txt_search.Text.Length == 0)
            {
                txt_search.Text = "SEARCH";
                txt_search.Font = new Font("Verdana", 10, FontStyle.Italic);

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult yn;
            yn = MessageBox.Show("Are you sure you want to delete this record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (yn == DialogResult.Yes)
            {

                try
                {
                    int index;
                    long LRN;

                    index = dgv_student.CurrentRow.Index;
                    LRN = Convert.ToInt64(dgv_student.Rows[index].Cells["LRN"].Value.ToString());

                    this.studentTableAdapter.DeleteStudent(LRN);
                    MessageBox.Show("Record Successfully Deleted", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_search.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Student have transaction Records.\nYou are not allowed to delete this student: \n"+ex.Message,"Delete Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
