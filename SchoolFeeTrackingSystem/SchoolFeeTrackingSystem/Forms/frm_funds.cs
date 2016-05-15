using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SchoolFeeTrackingSystem.Forms
{
    public partial class frm_funds : Form
    {
        public static frm_funds instance = null;
        public static readonly object padlock = new object();
        DataTable dt_sy, dt_gFeeALLO, dt_sFeeALLO;

        #region user_defined

        private void setcmbSY()
        {
            try
            {
                dt_sy = this.school_YearTableAdapter.GetData();
                cmb_sy.DataSource = dt_sy;
                cmb_sy.DisplayMember = "SY";
                cmb_sy.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error At setcmbSY: frm_cashier Error:" + ex.Message, "frm_cashier");
            }
        }

        private void setLabels()
        {
            try
            {
                string sy = cmb_sy.Text;
                decimal gTotal, sTotal,gFee_TC,sFee_TC;
                gTotal = Convert.ToDecimal(this.guardian_FeeTableAdapter.TotalBySY(sy));
                sTotal = Convert.ToDecimal(this.student_FeeTableAdapter.TotalBySY(sy));

                gFee_TC = Convert.ToDecimal(this.g_Trans_LOGTableAdapter.SY_TotalAmount(sy));
                sFee_TC = Convert.ToDecimal(this.s_Trans_LogTableAdapter.SY_TotalAmount(sy));

                lbl_GTotal.Text = gTotal.ToString("0.00");
                lbl_STotal.Text = sTotal.ToString("0.00");

              
                lbl_GFeeCollection.Text = gFee_TC.ToString("n");
                lbl_SFeeCollection.Text = sFee_TC.ToString("n");
                lbl_total.Text = (gFee_TC + sFee_TC).ToString("n");
                lbl_date.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
                lbl_time.Text = DateTime.Now.ToString("hh:mm tt");

            }
            catch
            {
                MessageBox.Show("Whoops! Something went wrong in setLabels: frm_funds");
            }
        
        }


        private void setDG_GFeeAllo()
        {
            try
            {
                string sy = cmb_sy.Text;

                dt_gFeeALLO = this.cTE_GuardianFeeALLOTableAdapter.GetData(sy);
                dgv_G_ALLO.DataSource = dt_gFeeALLO;
                dgv_G_ALLO.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! something went wrong! frm_funds: setDG_GFeeAllo, Error:" + ex.Message, "Something went wrong");
            }
        }

        private void setDG_SFeeAllo()
        {
            try
            {
                string sy = cmb_sy.Text;
                dt_sFeeALLO = this.ctE_StudentFeeALLOTableAdapter.GetData(sy);
                dgv_S_ALLO.DataSource = dt_sFeeALLO;
                dgv_S_ALLO.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! something went wrong! frm_funds: setDG_SFeeAllo, Error:" + ex.Message, "Something went wrong");
            }
           
        
        }

        private void FillChartDataSource()
        {
            this.student_FeeTableAdapter.FillFeeBySY(this.sFTS_DBDataSet.Student_Fee, cmb_sy.Text);
            this.guardian_FeeTableAdapter.FillFeeBySY(this.sFTS_DBDataSet.Guardian_Fee, cmb_sy.Text);
        }
        private void refreshCharts()
        {
            chart_guardianFee.Series["Series1"].XValueMember = "Fee_name";
            chart_guardianFee.Series["Series1"].YValueMembers = "amount_req";

            chart_studentFee.Series["Series1"].XValueMember = "Fee_name";
            chart_studentFee.Series["Series1"].YValueMembers = "amount_req";
        }

        #endregion


        private frm_funds()
        {
            InitializeComponent();
        }
        public static frm_funds Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_funds();
                    }
                }
                return instance;
            }
        
        }

        private void frm_funds_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
               this.ClientSize.Width / 2 - panel1.Size.Width / 2,
               this.ClientSize.Height / 2 - panel1.Size.Height / 2);

            setcmbSY();

            FillChartDataSource();
            setDG_GFeeAllo();
            setDG_SFeeAllo();

            setLabels();
            this.TopMost = true;
        }

        private void frm_funds_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void dgv_G_ALLO_SelectionChanged(object sender, EventArgs e)
        {
            dgv_G_ALLO.ClearSelection();
        }

        private void dgv_S_ALLO_SelectionChanged(object sender, EventArgs e)
        {
            dgv_S_ALLO.ClearSelection();
        }

        private void cmb_sy_SelectedIndexChanged(object sender, EventArgs e)
        {
           FillChartDataSource();

            chart_guardianFee.DataSource = guardianFeeBindingSource;
            chart_studentFee.DataSource = studentFeeBindingSource;         
            refreshCharts();

            chart_guardianFee.Refresh();
            chart_studentFee.Refresh();

            setDG_GFeeAllo();
            setDG_SFeeAllo();
            setLabels();
            lbl_SY.Text = cmb_sy.Text;
        }

        private void frm_funds_SizeChanged(object sender, EventArgs e)
        {
            panel1.Location = new Point(
               this.ClientSize.Width / 2 - panel1.Size.Width / 2,
               this.ClientSize.Height / 2 - panel1.Size.Height / 2);
        }

    }
}
