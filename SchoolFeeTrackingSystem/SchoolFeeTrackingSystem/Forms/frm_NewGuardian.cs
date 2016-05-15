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
    public partial class frm_NewGuardian : Form
    {
        public static frm_NewGuardian instance = null;
        public static readonly object padlock = new object();

        private frm_NewGuardian()
        {
            InitializeComponent();
        }

        public static frm_NewGuardian Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new frm_NewGuardian();
                    }
                }
                return instance;         
            }  
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string fname,lname,mname,gender,addrss;
                DateTime dob = dtp_dob.Value;
                int g_count=0;

                fname = txt_fname.Text.ToUpper().Trim();
                lname=txt_Lname.Text.ToUpper().Trim();
                mname = txt_Mname.Text.ToUpper().Trim();
                addrss = txt_address.Text.ToUpper().Trim();
                gender = cmb_gender.Text;

                g_count = Convert.ToInt16(this.guardianTableAdapter.GuardianCount(fname, lname, mname).ToString());

                if (g_count == 0)
                {
                    this.guardianTableAdapter.Insert(fname, lname, mname, gender, dob, addrss);

                    try
                    {
                        var frm_g = Application.OpenForms.OfType<frm_guardian>().Single();
                        frm_g.setDataGrid();
                    }
                    catch 
                    {
                        var frm_ns = Application.OpenForms.OfType<frm_newStudent>().Single();
                        frm_ns.setGuardian();
                    }
                      

                    MessageBox.Show("Guardian successfully added", "Successfull add");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This Guardian is already registered!","Double entry detected.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
            catch { }
        }

        private void frm_NewGuardian_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            cmb_gender.SelectedIndex = 0;
        }

        private void frm_NewGuardian_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

   
    }
}
