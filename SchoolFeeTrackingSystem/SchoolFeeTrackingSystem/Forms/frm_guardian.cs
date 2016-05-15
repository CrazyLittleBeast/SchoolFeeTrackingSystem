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
    public partial class frm_guardian : Form
    {

        #region user_defined
        //USER DEFINED

        DataTable dt_guardian;

        public void setDataGrid()
        {
            dt_guardian = guardianTableAdapter.GetData();
            dgv_guardian.DataSource = dt_guardian;
        }


        //END
        #endregion


        public static frm_guardian instance = null;
        public static readonly object padlock = new object();

        private frm_guardian()
        {
            InitializeComponent();
        }

        public static frm_guardian Instance
        {
            get {
                lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new frm_guardian();
                        }
                    }
                return instance;
                }
        }

        private void frm_guardian_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            setDataGrid();
        }

        private void frm_guardian_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_NewGuardian frm_nGuardian = frm_NewGuardian.Instance;
            frm_nGuardian.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int index, guardian_ID;
                index = dgv_guardian.CurrentRow.Index;
                guardian_ID = Convert.ToInt32(dgv_guardian.Rows[index].Cells["guardian_ID"].Value.ToString());

                this.guardianTableAdapter.DeleteGuardian(guardian_ID);
                setDataGrid();
            }
            catch
            {
                MessageBox.Show("Whoops! You are not allowed to delete this guardian.\n-Guardian has a student.","Delet not allowed");
            }
        }
    }
}
