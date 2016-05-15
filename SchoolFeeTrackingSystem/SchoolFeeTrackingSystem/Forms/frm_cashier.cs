using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SchoolFeeTrackingSystem.Forms
{
    public partial class frm_cashier : Form
    {
        public static frm_cashier instance = null;
        public static readonly object padlock = new object();

        DataTable dt_guardianFee, dt_student_Fee, dt_sy, dt_student;
        long SELECTED_STUDENT   = 0;
        decimal AMOUNT_TENDERED = 0;
        decimal G_PERCENT, S_PERCENT, TOTAL_SUM,GTOTAL,STOTAL, BALANCE;
       

        private frm_cashier()
        {
            InitializeComponent();
        }
        public static frm_cashier Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_cashier();
                    }
                }
                return instance;
            }
        }

        #region UserDefined
        /********************************************
         *               USER DEFINED               *                                           
         ********************************************/

        /*PRIVATE*/
        private void setcmbSY()
        {
            try
            {
                dt_sy = this.school_YearTableAdapter.GetData();
                cmb_sy.DataSource = dt_sy;
                cmb_sy.DisplayMember = "SY";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error At setcmbSY: frm_cashier Error:" + ex.Message, "frm_cashier");
            }
        }

        private void setDGFee()
        {
            try
            {
                string sy;
                sy = cmb_sy.Text;

                dt_guardianFee = this.guardian_FeeTableAdapter.GetFeeBySY(sy);
                dt_student_Fee = this.student_FeeTableAdapter.GetFeeBySY(sy);

                dgv_GuardianFee.DataSource = dt_guardianFee;
                dgv_StudentFee.DataSource = dt_student_Fee;

                dgv_GuardianFee.ClearSelection();
                dgv_StudentFee.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("setDGFee Error: " +ex.Message, "frm_cashier");
            }
        }

        private void search_Student(string search_text)
        {
            try
            {
               
                dt_student = this.studentTableAdapter.SearchStudent(search_text, search_text, search_text);
                dgv_student.DataSource = dt_student;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private decimal GuardianFeeSum(string SY)
        {
            decimal total_amount;
            total_amount = Convert.ToDecimal(this.guardian_FeeTableAdapter.TotalBySY(SY));

            return total_amount;
        }

        private decimal StudentFeeSum(string SY)
        {
            decimal total_amount;
            total_amount = Convert.ToDecimal(this.student_FeeTableAdapter.TotalBySY(SY));

            return total_amount;
        }

        private decimal getTotalPay(long lrn)
        {
                decimal totalPay = 0;
                decimal gTotal=0, sTotal=0;
            try
            {
              

                string sy = cmb_sy.Text.Trim();
                int selected_index = dgv_student.CurrentRow.Index;
                int guardian_ID = Convert.ToInt32(dgv_student.Rows[selected_index].Cells["guardian_ID"].Value.ToString());


                gTotal = Convert.ToDecimal(this.g_Trans_LOGTableAdapter.GTotalPayment_SY(guardian_ID, sy));
                sTotal = Convert.ToDecimal(this.s_Trans_LogTableAdapter.STotalPayment_SY(lrn, sy));

                GTOTAL = gTotal;
                STOTAL = sTotal;

                label13.Text = gTotal.ToString("\u20B1 0.00");
                label14.Text = sTotal.ToString("\u20B1 0.00");

                totalPay = gTotal + sTotal;
            }
            catch
            {
                totalPay = 0;
            }

            return totalPay;
        } //STUDENT TOTAL PAY

        private void setTotals()
        {
            try
            {
                string sy = cmb_sy.Text;
                decimal gFeeSum, sFeeSum;
                gFeeSum = GuardianFeeSum(sy);
                sFeeSum = StudentFeeSum(sy);
                TOTAL_SUM = (gFeeSum + sFeeSum);

                G_PERCENT = SFTS_Functions.getPercentOfTotal(gFeeSum, TOTAL_SUM);
                S_PERCENT = SFTS_Functions.getPercentOfTotal(sFeeSum, TOTAL_SUM);


                lbl_GuardianFeetotal.Text = gFeeSum.ToString("\u20B1 #.##") + G_PERCENT.ToString(" (0%)");
                lbl_StudentFeetotal.Text =  sFeeSum.ToString("\u20B1 #.##") + S_PERCENT.ToString(" (0%)");
                lbl_total.Text = TOTAL_SUM.ToString("\u20B1 0.00");
              
            }
            catch
            { }
        } //SET TOTALS

        private void deSelect()
        {
            SELECTED_STUDENT = 0;
            AMOUNT_TENDERED = 0;
            GTOTAL = 0;
            STOTAL = 0;

            lbl_LRN.Text = "---";
            lbl_name.Text = "---";
            lbl_section.Text = "---";
            lbl_guardian.Text = "---";
            lbl_tendered.Text = "---";
            lbl_accountVal.Text = "---";
            lbl_balance.Text = "---";
        }

        private void distributePayment()
        {

            if(SELECTED_STUDENT > 0 && AMOUNT_TENDERED > 0)
            {
               try
               {
                    decimal gFee = 0, sFee = 0,g_balance,s_balance,excessPay=0;
                    int guardian_ID, selected_index;
                    string sy = cmb_sy.Text.Trim();

                    gFee = AMOUNT_TENDERED * G_PERCENT;
                    sFee = AMOUNT_TENDERED * S_PERCENT;

                    /* CALCULATING BALANCE */
                    g_balance = (GuardianFeeSum(sy)-GTOTAL);
                    s_balance = (StudentFeeSum(sy) - STOTAL);

                    if (g_balance < gFee)
                    {
                        excessPay = gFee - g_balance;
                        gFee = gFee - excessPay;
                        sFee = sFee + excessPay;
                    }

                    if (s_balance < sFee)
                    {
                        excessPay = sFee - s_balance;
                        sFee = sFee - excessPay;
                        lbl_change.Text = excessPay.ToString("\u20B1 0.00");
                    }
                    /* END OF CALCULATING BALANCE*/



                    selected_index = dgv_student.CurrentRow.Index;
                    guardian_ID = Convert.ToInt32(dgv_student.Rows[selected_index].Cells["guardian_ID"].Value.ToString());

                    int user_id = Properties.Settings.Default.SFTS_USERID;

                    this.g_Trans_LOGTableAdapter.Insert(gFee, user_id, guardian_ID, sy);
                    this.s_Trans_LogTableAdapter.Insert(sFee, user_id, SELECTED_STUDENT, sy);

                    MessageBox.Show("Successfully Logged Transaction!", "Transaction Log successful");

                    frm_receipt frm_receipt = new frm_receipt();
                    frm_receipt.Show();


                    AMOUNT_TENDERED = 0;
                    lbl_tendered.Text = "---";
               }
               catch (Exception ex) 
                {
                    MessageBox.Show("Error on distribute payment. Error: " + ex.Message, "frm_cashier");
                }
            }

        }

        private void calcBalance()
        {
          
                decimal balance, c_payment;
                c_payment = getTotalPay(SELECTED_STUDENT);
                balance = TOTAL_SUM - c_payment;
                BALANCE = balance;
                lbl_balance.Text = balance.ToString("\u20B1 0.00");
           
              
        }

        private void setUserDetail()
        {
            lbl_cUser.Text = Properties.Settings.Default.SFTS_USER.ToString().ToUpper();
            lbl_userType.Text = Properties.Settings.Default.SFTS_UTYPE.ToString().ToUpper();
        }

        /*PUBLIC*/
        public void getAmountTendered(decimal amount)
        {
            AMOUNT_TENDERED = amount;
            lbl_tendered.Text = amount.ToString("\u20B1 0.00");
        }

        public string getTransactionDetail(int x)
        { 
            string ret_val;
            if (x == 1)
            {
                ret_val = Properties.Settings.Default.SFTS_USER.ToString();
            }
            else if (x == 2)
            {
                ret_val = lbl_LRN.Text;
            }
            else if (x == 3)
            {
                ret_val = lbl_name.Text;
            }
            else if (x == 4)
            {
                ret_val = lbl_guardian.Text;
            }
            else if (x == 5)
            {
                ret_val = BALANCE.ToString("#.##");
            }
            else if (x == 6)
            {
                ret_val = AMOUNT_TENDERED.ToString();
            }
            else
            {
                ret_val = "N/A";
            }

            return ret_val;
        }

        /********************************************
        *                   END                     *                                           
        ********************************************/
        #endregion



        private void frm_cashier_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
               this.ClientSize.Width / 2 - panel1.Size.Width / 2,
               this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            lbl_version.Text = Properties.Settings.Default.STFS_VER.ToString();

          
            setcmbSY();
            setDGFee();
            setTotals();
            setUserDetail();
    
        }

     
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["frm_main"] != null)
            {
                instance = null;
            }
            else
            {
                Application.Exit();
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

        private void dgv_GuardianFee_Leave(object sender, EventArgs e)
        {
            dgv_GuardianFee.ClearSelection();
        }

        private void dgv_StudentFee_Leave(object sender, EventArgs e)
        {
            dgv_StudentFee.ClearSelection();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dgv_GuardianFee.ClearSelection();
            dgv_StudentFee.ClearSelection();
            dgv_student.ClearSelection();
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
            dgv_student.ClearSelection();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {

            try
            {

                string full_name, section_level, lrn, guardian;
                int selected_index;
                selected_index = dgv_student.CurrentRow.Index;

                lrn = this.dt_student.Rows[selected_index]["LRN"].ToString();
                full_name = this.dt_student.Rows[selected_index]["full_name"].ToString();
                section_level = this.dt_student.Rows[selected_index]["section_level"].ToString();
                guardian = this.dt_student.Rows[selected_index]["guardian_name"].ToString();

                SELECTED_STUDENT = Convert.ToInt64(lrn);
                lbl_accountVal.Text = getTotalPay(SELECTED_STUDENT).ToString("\u20B1 0.00");

                

                lbl_LRN.Text = lrn;
                lbl_name.Text = full_name;
                lbl_section.Text = section_level;
                lbl_guardian.Text = guardian;

                lbl_change.Text = "---";

                
            }

            catch (Exception ex)
            {
            }
               

        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            if (SELECTED_STUDENT > 0)
            {
                frm_amountTendered frm_amntTen = frm_amountTendered.Instance;
                frm_amntTen.Show();
            }
            else
            {
                MessageBox.Show("NO SELECTED STUDENT", "NO SELECTED STUDENT", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }
        }

        private void btn_deselect_Click(object sender, EventArgs e)
        {
            deSelect();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            AMOUNT_TENDERED = 0;
            lbl_tendered.Text = "---";
            lbl_change.Text = "---";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
           
            distributePayment();
            lbl_accountVal.Text = getTotalPay(SELECTED_STUDENT).ToString("\u20B1 #.##");
           
        }

        private void lbl_accountVal_TextChanged(object sender, EventArgs e)
        {

            calcBalance();
              
        }

        private void btn_set_Click(object sender, EventArgs e)
        {

            setDGFee();        
            setTotals();
            deSelect();
        }

    }
}
