namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_authentication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_pswrd = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.sftS_UserTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.SFTS_UserTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.txt_pswrd);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 203);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SchoolFeeTrackingSystem.Properties.Resources.lock_basic_blue;
            this.pictureBox2.Location = new System.Drawing.Point(46, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SchoolFeeTrackingSystem.Properties.Resources.user_basic_blue;
            this.pictureBox1.Location = new System.Drawing.Point(46, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Salmon;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.Maroon;
            this.btn_cancel.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_cross_basic_red_32;
            this.btn_cancel.Location = new System.Drawing.Point(196, 121);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 45);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_ok.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_check_basic_green_32;
            this.btn_ok.Location = new System.Drawing.Point(90, 121);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 45);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_pswrd
            // 
            this.txt_pswrd.BackColor = System.Drawing.Color.White;
            this.txt_pswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pswrd.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pswrd.Location = new System.Drawing.Point(78, 79);
            this.txt_pswrd.MaxLength = 18;
            this.txt_pswrd.Name = "txt_pswrd";
            this.txt_pswrd.PasswordChar = '*';
            this.txt_pswrd.Size = new System.Drawing.Size(264, 23);
            this.txt_pswrd.TabIndex = 2;
            this.txt_pswrd.Text = "Password";
            this.txt_pswrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pswrd.Enter += new System.EventHandler(this.txt_pswrd_Enter);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.White;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.DimGray;
            this.txt_user.Location = new System.Drawing.Point(78, 39);
            this.txt_user.MaxLength = 25;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(264, 22);
            this.txt_user.TabIndex = 1;
            this.txt_user.Text = "User Name";
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            // 
            // sftS_UserTableAdapter
            // 
            this.sftS_UserTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "SQL Connection:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_status.Location = new System.Drawing.Point(87, 182);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(16, 15);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "---";
            // 
            // frm_authentication
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(397, 228);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG-IN";
            this.Load += new System.EventHandler(this.frm_authentication_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_pswrd;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DB.SFTS_DBDataSetTableAdapters.SFTS_UserTableAdapter sftS_UserTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_status;
    }
}