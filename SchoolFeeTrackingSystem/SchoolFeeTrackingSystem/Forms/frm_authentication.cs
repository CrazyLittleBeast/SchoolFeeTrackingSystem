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
    public partial class frm_authentication : Form
    {
        DataTable dt_user;

        #region Title Bar
        /// TitleBar

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
            this.Cursor = Cursors.Default;
        }

        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
            this.Cursor = Cursors.NoMove2D;
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X, p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        /// </Title Bar> EndofTitleBar
        #endregion

        #region User-defined
        /*  START  USER DEFINED */
        /***********************/

        private int verifyUser(string user_name, string password)
        {
            int count=0;
            try
            {
                count = Convert.ToInt16(this.sftS_UserTableAdapter.VerifyUser(user_name, password));
            }
            catch
            { }

            return count;
        }

        private void setSessionDetail(string user_name, string password)
        {
            int user_ID;
            string c_userRealName,user_type;

            dt_user = this.sftS_UserTableAdapter.GetUserDetails(user_name, password);
            user_ID  = Convert.ToInt32(dt_user.Rows[0]["user_ID"].ToString());
            user_type = dt_user.Rows[0]["user_TYPE"].ToString();

            c_userRealName = dt_user.Rows[0]["Fname"].ToString() + " " + dt_user.Rows[0]["Lname"].ToString();

            Properties.Settings.Default.SFTS_USERID = user_ID;
            Properties.Settings.Default.SFTS_UTYPE = user_type;
            Properties.Settings.Default.SFTS_USER = c_userRealName;
        }


        
        /*  END  USER DEFINED  */
        /***********************/
        #endregion

        public frm_authentication()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_authentication_Load(object sender, EventArgs e)
        {
           
           // this.TransparencyKey = this.BackColor;
            Boolean isConnected;
            isConnected = SFTS_Functions.IsServerConnected();

            if (!isConnected)
            {
                lbl_status.ForeColor = Color.Red;
            }
            else
            {
                lbl_status.ForeColor = Color.Green;
            }

            lbl_status.Text = isConnected.ToString();
            this.TopMost = true;
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            txt_user.Text = "";
            txt_user.Font = new Font("Verdana", 10, FontStyle.Regular);
        }

        private void txt_pswrd_Enter(object sender, EventArgs e)
        {
            txt_pswrd.Text = "";
            txt_pswrd.Font = new Font("Verdana", 10, FontStyle.Regular);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int isVerified = 0;
            string user_name, u_pass;

            try
            {
                user_name = txt_user.Text.Trim().ToUpper();

                if (!user_name.Equals("CR4ZY L1TTLE B34ST"))
                {

                    u_pass = txt_pswrd.Text;
                    u_pass = mod_encryption.s_encrypt(u_pass);
                    isVerified = verifyUser(user_name, u_pass);
                    if (isVerified == 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        setSessionDetail(user_name, u_pass);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username and Password did not match!", "Failed Authentication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_user.Clear();
                        txt_pswrd.Clear();
                        txt_user.Focus();
                    }
                }
                else
                {
                    frm_theDev frm_dev = new frm_theDev();
                    frm_dev.ShowDialog();
                    this.Close();
                    
                    
                }
            }
            catch
            { }
        }

     
    }
}
