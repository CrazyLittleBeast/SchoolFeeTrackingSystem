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
    public partial class frm_schoolFee : Form
    {
        public static frm_schoolFee instance = null;
        public static readonly object padlock = new object();

        DataTable dt_StudentFee, dt_GuardianFee,dt_sy;
        DataGridView DGV;

        private frm_schoolFee()
        {
            InitializeComponent();
        }
        public static frm_schoolFee Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_schoolFee();
                    }

                }
                return instance;
            }
        }

        #region user defined
        //USER DEFINED

        private void setCMB_SY()
        {
            dt_sy = this.school_YearTableAdapter.GetData();
          
            cmb_sy.DataSource=dt_sy;
            cmb_sy.DisplayMember="SY";
            cmb_sy.SelectedIndex = 0;
        }

        public void setDGstudent()
        {
            try
            {
                string sy = cmb_sy.Text;


                dt_StudentFee = this.student_FeeTableAdapter.GetFeeBySY(sy);
                dgv_SFee.DataSource = dt_StudentFee;
                dgv_SFee.ClearSelection();
            }
            catch { }
        }

        public void setDGguardian()
        {
            try
            {
                string sy = cmb_sy.Text;
                dt_GuardianFee = this.guardian_FeeTableAdapter.GetFeeBySY(sy);
                dgv_GFee.DataSource = dt_GuardianFee;
                dgv_GFee.ClearSelection();
            }
            catch { }
        }

        public string GetDGVData(string x, DataGridView selected_DGV)
        { 
            string ret_val;
            int index;
            decimal amount;
            

           
                index = selected_DGV.CurrentRow.Index;
                if (x.Equals("A"))
                {
                    ret_val = selected_DGV.Rows[index].Cells[1].Value.ToString();
                   
                }
                else if (x.Equals("B"))
                {
                    ret_val = selected_DGV.Rows[index].Cells[2].Value.ToString();
                    
                }
                else if (x.Equals("C"))
                {
                    amount = Convert.ToDecimal(selected_DGV.Rows[index].Cells[3].Value.ToString());
                    ret_val =  amount.ToString();
                }
                else if (x.Equals("D"))
                {
                    ret_val = selected_DGV.Rows[index].Cells[0].Value.ToString(); //ID
                }
                else if (x.Equals("E"))
                {
                    ret_val = selected_DGV.Name.ToString();
                }
                else
                {
                    return ret_val = "Hello";
                }

                return ret_val;
        }

        public DataGridView selectedDGV()
        {
            return DGV;
        }

        //END REGION
        #endregion


        private void frm_schoolFee_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void frm_schoolFee_Load(object sender, EventArgs e)
        {
           
            this.TopMost = true;
            setCMB_SY();
            cmb_type.SelectedIndex = 0;
            setDGguardian();
            setDGstudent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                string fee_name, sy;
                decimal amount_req = Convert.ToDecimal(txt_amount.Text);

                fee_name = txt_FeeName.Text.Trim().ToUpper();
                sy = txt_sy1.Text + '-' + txt_sy2.Text;

                if (cmb_type.Text.Equals("GUARDIAN"))
                {
                    this.guardian_FeeTableAdapter.Insert(fee_name, sy, amount_req);
                    setDGguardian();
                }
                else
                {
                    this.student_FeeTableAdapter.Insert(fee_name, sy, amount_req);
                    setDGstudent();
                }

                MessageBox.Show("Successfully Added New Fee!", "New Fee Added");
                setCMB_SY();
                txt_amount.Clear();
                txt_FeeName.Clear();
                txt_sy1.Clear();
                txt_sy2.Clear();

                txt_FeeName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("frm_schoolFee Error msg: " + ex.Message, "frm_schoolFee");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dgv_GFee.ClearSelection();
            dgv_SFee.ClearSelection();
        }

        

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_editFee frm_editFee = frm_editFee.Instance;
            frm_editFee.Show();
        }

        private void dgv_GFee_Enter(object sender, EventArgs e)
        {
            DGV = dgv_GFee;          
            dgv_SFee.ClearSelection();
        }

        private void dgv_SFee_Enter(object sender, EventArgs e)
        {
            DGV = dgv_SFee;          
            dgv_GFee.ClearSelection();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult yn;

            yn = MessageBox.Show("Are you sure you want to remove this Fee?", "Remove Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (yn == DialogResult.Yes)
            {
                try
                {

                    int id, selected_index;
                    selected_index = DGV.CurrentRow.Index;
                    id = Convert.ToInt32(DGV.Rows[selected_index].Cells[0].Value.ToString());
                    if (DGV.Name.Equals("dgv_GFee"))
                    {
                        this.guardian_FeeTableAdapter.DeleteFee(id);
                        setDGguardian();
                    }
                    else if (DGV.Name.Equals("dgv_SFee"))
                    {
                        this.student_FeeTableAdapter.DeleteFee(id);
                        setDGstudent();
                    }
                    MessageBox.Show("Fee Successfully Removed!");
                }
                catch (Exception ex)
                { }
            }


        }

        private void cmb_sy_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDGguardian();
            setDGstudent();
        }

    

    
    }
}
