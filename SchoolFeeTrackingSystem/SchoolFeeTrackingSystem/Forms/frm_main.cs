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
    public partial class frm_main : Form
    {

        #region USER DEFINED

        private void setColors()
        {
            this.BackColor = ColorTranslator.FromHtml("#4D5057");
        
        }

        private void setUserDetail()
        {
            lbl_cUser.Text = Properties.Settings.Default.SFTS_USER.ToString().ToUpper();
            lbl_userType.Text = Properties.Settings.Default.SFTS_UTYPE.ToString().ToUpper();
        }


        #endregion



        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);

            lbl_version.Text = Properties.Settings.Default.STFS_VER.ToString();

            setColors();
            setUserDetail();
          
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            frm_manageStudent frm_mngStudent = frm_manageStudent.Instance;
            frm_mngStudent.Show();
        }

        private void btn_section_Click(object sender, EventArgs e)
        {
            frm_section frm_sec = frm_section.Instance;
            frm_sec.Show();
        }

        private void btn_guardian_Click(object sender, EventArgs e)
        {
            frm_guardian frm_grdian = frm_guardian.Instance;
                frm_grdian.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_month.Text = DateTime.Now.ToString("MMMM");
            lbl_day.Text = DateTime.Now.ToString("dd dddd");
            lbl_time.Text = DateTime.Now.ToString("hh:mm");
            lbl_sec.Text = DateTime.Now.ToString("ss");
            lbl_ampm.Text = DateTime.Now.ToString("tt");
        }

        private void btn_fees_Click(object sender, EventArgs e)
        {
            frm_schoolFee frm_schoolFee = frm_schoolFee.Instance;
            frm_schoolFee.Show();
        }

        private void btn_cashier_Click(object sender, EventArgs e)
        {
            frm_cashier frm_cashier = frm_cashier.Instance;
            frm_cashier.Show();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            frm_manageUser frm_mngUser = frm_manageUser.Instance;
            frm_mngUser.Show();
        }

        private void btn_fumds_Click(object sender, EventArgs e)
        {
            frm_funds frm_funds = frm_funds.Instance;
            frm_funds.Show();
        }

       
    }
}
