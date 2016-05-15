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
    public partial class frm_updateName : Form
    {
        long LRN;

        #region User Defined

        public void setName()
        {
            var frm_pro = Application.OpenForms.OfType<frm_profile>().Single();

            LRN = frm_pro.getLRN();

            txt_first.Text = frm_pro.getName(1);
            txt_last.Text = frm_pro.getName(2);
            txt_mid.Text = frm_pro.getName(3);
        }

        #endregion

        public static frm_updateName instance = null;
        public static readonly object padlock = new object();

        private frm_updateName()
        {
            InitializeComponent();
        }

        public static frm_updateName Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_updateName();
                    }
                }
                return instance;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_updateName_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            setName();
        }

        private void frm_updateName_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void bnt_update_Click(object sender, EventArgs e)
        {
            string fname, lname, mname;
            

            try
            {
                var frm_pro = Application.OpenForms.OfType<frm_profile>().Single();
               

                fname = txt_first.Text.Trim().ToUpper();
                lname = txt_last.Text.Trim().ToUpper();
                mname = txt_mid.Text.Trim().ToUpper();
                this.studentTableAdapter.UpdateName(fname, lname, mname, LRN);
                MessageBox.Show("Update Successfull!", "Name Update Successfull");
                frm_pro.setDetails();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Whoops! Something went wrong during update!\nError:" + ex.Message, "frm_updateName");
            }
        }

    }
}
