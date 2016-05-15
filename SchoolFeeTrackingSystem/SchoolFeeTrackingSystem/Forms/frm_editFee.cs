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
    public partial class frm_editFee : Form
    {
        public static frm_editFee instance = null;
        public static readonly object padlock = new object();

        int FEE_ID;
        DataGridView dgv = null;


        private frm_editFee()
        {
            InitializeComponent();
        }

        public static frm_editFee Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_editFee();
                    }
                }
                return instance;
            }
        }

        #region user_defined

        

        private void initializeText()
        {
            string sy, sy1, sy2;
            decimal amount_req;
            DataGridView dgv = null;

            var schlFee = Application.OpenForms.OfType<frm_schoolFee>().Single();
            dgv = schlFee.selectedDGV();
     
            FEE_ID = Convert.ToInt32(schlFee.GetDGVData("D", dgv).ToString());

            sy = schlFee.GetDGVData("B", dgv).ToString();
            sy1 = sy.Substring(0, 4);
            sy2 = sy.Substring(5, 4);
            amount_req = Convert.ToDecimal(schlFee.GetDGVData("C", dgv).ToString());

            txt_desc.Text = schlFee.GetDGVData("A", dgv).ToString();
            txt_sy1.Text = sy1;
            txt_sy2.Text = sy2;
            txt_amountReq.Text = amount_req.ToString("#.##");
        }

        #endregion

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_editFee_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void frm_editFee_Load(object sender, EventArgs e)
        {
            
            this.TopMost = true;
            initializeText();

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                string desc, sy,dgv_name;
                decimal amount_req;
                var schlFee = Application.OpenForms.OfType<frm_schoolFee>().Single();

                desc = txt_desc.Text.Trim().ToUpper();
                sy = txt_sy1.Text + '-' + txt_sy2.Text;
                amount_req = Convert.ToDecimal(txt_amountReq.Text);

                dgv = schlFee.selectedDGV();
                dgv_name = dgv.Name.ToString();

                if (dgv_name.Equals("dgv_GFee"))
                {            
                    this.guardian_FeeTableAdapter.UpdateGuardianFee(desc, sy, amount_req, FEE_ID);
                    schlFee.setDGguardian();
                }
                else
                {
                    this.student_FeeTableAdapter.UpdateStudentFee(desc, sy, amount_req, FEE_ID);
                    schlFee.setDGstudent();
                }
                MessageBox.Show("School Fee Successfully Updated!", "Update Successfull");
                this.Close();
        
            }
            catch(Exception ex)
            {
                MessageBox.Show("Whoops something went wrong! Error:"+ex.Message, "Frm_editFee Error");
            }
         
        }
    }
}
