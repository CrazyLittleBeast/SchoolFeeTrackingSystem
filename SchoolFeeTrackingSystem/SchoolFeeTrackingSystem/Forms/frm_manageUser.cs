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
    public partial class frm_manageUser : Form
    {

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

        public static frm_manageUser instance = null;
        public static readonly object padlock = new object();
        DataTable dt_user;

        private frm_manageUser()
        {
            InitializeComponent();
        }

        public static frm_manageUser Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_manageUser();
                    }
                }
                return instance;
            }
        }

        #region User Defined
        /*User Defined START*/

        private void psswrdMatch()
        {
            string psswrd1, psswrd2;
            psswrd1 = txt_psswrd.Text;
            psswrd2 = txt_psswrd2.Text;

            if (psswrd1.Equals(psswrd2) && psswrd1.Length > 4)
            {
                pb_chk.Image = Properties.Resources.check_16;
            }
            else 
            {
                pb_chk.Image = Properties.Resources.warning_16;
            }

        }

        private void setDGVuser()
        {
            dt_user = this.STFS_UserTableAdapter.GetACTIVE_USER();
            dgv_user.DataSource = dt_user;
        }

        private void clearFields()
        { 
            txt_userName.Clear();
            txt_psswrd.Clear();
            txt_psswrd2.Clear();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_mi.Clear();

            txt_userName.Focus();
        }


        public string WhoIsUser()
        {
            string userName, fname, lname, mi;

             int u_index = dgv_user.CurrentRow.Index;
             userName = dt_user.Rows[u_index]["user_name"].ToString();
             fname = dt_user.Rows[u_index]["Fname"].ToString();
             lname = dt_user.Rows[u_index]["Lname"].ToString();
             mi = dt_user.Rows[u_index]["MI"].ToString();

        return lname+", "+fname+" "+mi+"("+userName+")";
        }


        /*User Defined END*/
        #endregion

        private void frm_manageUser_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
            cmb_type.SelectedIndex = 0;
            this.TopMost = true;
            setDGVuser();
        }

        private void frm_manageUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;    
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string user_name,password,psswrd2,Fname,Lname,MI,utype;
            password = txt_psswrd.Text;
            psswrd2 = txt_psswrd2.Text;

            if (password.Equals(psswrd2) && password.Length > 4)
            {
                try
                {
                    user_name = txt_userName.Text.Trim().ToUpper();

                    password = mod_encryption.s_encrypt(password);
                    Fname = txt_fname.Text.Trim().ToUpper();
                    Lname = txt_lname.Text.Trim().ToUpper();
                    MI = txt_mi.Text.Trim().ToUpper();
                    utype = cmb_type.Text;
                    this.STFS_UserTableAdapter.Insert(user_name, password, Fname, Lname, MI, utype,"ACTIVE");
                    setDGVuser();
                    MessageBox.Show("Successfully Added new user", "Added New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    tabControl1.SelectedIndex = 0;
                }
                catch
                {
                    MessageBox.Show("Username already in use (ACTIVE/INACTIVE)");
                }
            }
            else
            {
                MessageBox.Show("Failed to add new user.\nPassword length must be greater than or equal to 6 characters");
            }

        }

        private void txt_psswrd2_TextChanged(object sender, EventArgs e)
        {
            psswrdMatch();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int u_index, user_ID;
            int user_count = Convert.ToInt32(this.STFS_UserTableAdapter.user_count_ADMIN().ToString());
            DialogResult yn;
             u_index = dgv_user.CurrentRow.Index;

             string u_type = dt_user.Rows[u_index]["user_TYPE"].ToString();

             if (u_type.Equals("ADMINISRATOR"))
             {

                 if (user_count >= 3)
                 {
                     
                     yn = MessageBox.Show("Are you sure you want to delete this User?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                     if (yn == DialogResult.Yes)
                     {
                         try
                         {
                             user_ID = Convert.ToInt32(dt_user.Rows[u_index]["user_ID"].ToString());
                             this.STFS_UserTableAdapter.DeleteUser(user_ID);
                             setDGVuser();
                         }
                         catch
                         { }
                     }
                 }
                 else
                 {
                     MessageBox.Show("DELETE NOT ALLOWED!\nSystem must maintain at least 3 USER ADMINISTRATOR", "DELETE NOT ALLOWED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
             else
             {
                 yn = MessageBox.Show("Are you sure you want to delete this User?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 if (yn == DialogResult.Yes)
                 {
                     try
                     {
                         user_ID = Convert.ToInt32(dt_user.Rows[u_index]["user_ID"].ToString());
                         this.STFS_UserTableAdapter.DeleteUser(user_ID);
                         setDGVuser();
                     }
                     catch
                     { }
                 }
             }
            
        }

        private void btn_deactivate_Click(object sender, EventArgs e)
        {
            int u_index;
            int user_count = Convert.ToInt32(this.STFS_UserTableAdapter.user_count_ADMIN().ToString());
            u_index = dgv_user.CurrentRow.Index;
            int user_ID = Convert.ToInt32(dt_user.Rows[u_index]["user_ID"].ToString());
            string u_type = dt_user.Rows[u_index]["user_TYPE"].ToString();

            if (u_type.Equals("ADMINISRATOR"))
            {
                if (user_count >= 3)
                {
                    try
                    {
                        frm_deactivate frm_deac = frm_deactivate.Instance;
                     

                        if (frm_deac.ShowDialog() == DialogResult.OK)
                        {
                            
                            this.STFS_UserTableAdapter.DEACTIVATE_USER(user_ID);
                            setDGVuser();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }//U_TYPE CHECK
            else
            {
                try
                {
                    frm_deactivate frm_deac = frm_deactivate.Instance;
                   

                    if (frm_deac.ShowDialog() == DialogResult.OK)
                    {

                        this.STFS_UserTableAdapter.DEACTIVATE_USER(user_ID);
                        setDGVuser();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_addnew_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
      

       
    }
}
