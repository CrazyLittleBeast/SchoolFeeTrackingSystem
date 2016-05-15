using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SchoolFeeTrackingSystem.Forms
{
    public partial class frm_receipt : Form
    {

        #region user defined

        public void setParams()
        {
            var frm_cash = Application.OpenForms.OfType<frm_cashier>().Single();
            string current_user,lrn,student,guardian,balance,cash;

            current_user = frm_cash.getTransactionDetail(1);
            lrn = frm_cash.getTransactionDetail(2);
            student = frm_cash.getTransactionDetail(3);
            guardian = frm_cash.getTransactionDetail(4);
            balance = frm_cash.getTransactionDetail(5);
            cash = frm_cash.getTransactionDetail(6);

            ReportParameter[] param = new ReportParameter[6];
            param[0] = new ReportParameter("lrn", lrn);
            param[1] = new ReportParameter("student", student);
            param[2] = new ReportParameter("guardian", guardian);
            param[3] = new ReportParameter("current_balance", balance);
            param[4] = new ReportParameter("cash", cash);
            param[5] = new ReportParameter("current_user", current_user);

            this.reportViewer1.LocalReport.SetParameters(param);
        }


        #endregion

        public frm_receipt()
        {
            InitializeComponent();
        }

        private void frm_receipt_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            setParams();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
        }
    }
}
