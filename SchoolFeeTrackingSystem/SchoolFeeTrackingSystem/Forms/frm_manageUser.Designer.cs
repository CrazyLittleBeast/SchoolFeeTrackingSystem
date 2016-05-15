namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_manageUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_manageUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_deactivate = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.user_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_chk = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_psswrd2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mi = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_psswrd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.STFS_UserTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.SFTS_UserTableAdapter();
            this.btn_addnew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(39, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 411);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_addnew);
            this.tabPage1.Controls.Add(this.btn_deactivate);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.dgv_user);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MANAGE USER";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_deactivate
            // 
            this.btn_deactivate.BackColor = System.Drawing.Color.Salmon;
            this.btn_deactivate.BackgroundImage = global::SchoolFeeTrackingSystem.Properties.Resources.deactivate;
            this.btn_deactivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deactivate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_deactivate.FlatAppearance.BorderSize = 2;
            this.btn_deactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deactivate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deactivate.ForeColor = System.Drawing.Color.Maroon;
            this.btn_deactivate.Image = global::SchoolFeeTrackingSystem.Properties.Resources.user_basic_red_32;
            this.btn_deactivate.Location = new System.Drawing.Point(498, 304);
            this.btn_deactivate.Name = "btn_deactivate";
            this.btn_deactivate.Size = new System.Drawing.Size(125, 52);
            this.btn_deactivate.TabIndex = 2;
            this.btn_deactivate.Text = "DEACTIVATE USER";
            this.btn_deactivate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deactivate.UseVisualStyleBackColor = false;
            this.btn_deactivate.Click += new System.EventHandler(this.btn_deactivate_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Salmon;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_delete.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Delete32;
            this.btn_delete.Location = new System.Drawing.Point(125, 309);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 42);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_user.ColumnHeadersHeight = 25;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_ID,
            this.user_name,
            this.u_password,
            this.Fname,
            this.Lname,
            this.MI,
            this.user_type});
            this.dgv_user.EnableHeadersVisualStyles = false;
            this.dgv_user.GridColor = System.Drawing.Color.DimGray;
            this.dgv_user.Location = new System.Drawing.Point(20, 15);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersVisible = false;
            this.dgv_user.RowTemplate.Height = 24;
            this.dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_user.Size = new System.Drawing.Size(602, 282);
            this.dgv_user.TabIndex = 0;
            // 
            // user_ID
            // 
            this.user_ID.DataPropertyName = "user_ID";
            this.user_ID.HeaderText = "user_ID";
            this.user_ID.Name = "user_ID";
            this.user_ID.ReadOnly = true;
            this.user_ID.Visible = false;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "Username";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            this.user_name.Width = 120;
            // 
            // u_password
            // 
            this.u_password.DataPropertyName = "u_password";
            this.u_password.HeaderText = "u_password";
            this.u_password.Name = "u_password";
            this.u_password.ReadOnly = true;
            this.u_password.Visible = false;
            // 
            // Fname
            // 
            this.Fname.DataPropertyName = "Fname";
            this.Fname.HeaderText = "First";
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Width = 120;
            // 
            // Lname
            // 
            this.Lname.DataPropertyName = "Lname";
            this.Lname.HeaderText = "Last";
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Width = 120;
            // 
            // MI
            // 
            this.MI.DataPropertyName = "MI";
            this.MI.HeaderText = "MI";
            this.MI.Name = "MI";
            this.MI.ReadOnly = true;
            this.MI.Width = 50;
            // 
            // user_type
            // 
            this.user_type.DataPropertyName = "user_TYPE";
            this.user_type.HeaderText = "Type";
            this.user_type.Name = "user_type";
            this.user_type.ReadOnly = true;
            this.user_type.Width = 115;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.pb_chk);
            this.tabPage2.Controls.Add(this.btn_clear);
            this.tabPage2.Controls.Add(this.btn_ok);
            this.tabPage2.Controls.Add(this.txt_psswrd2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmb_type);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_mi);
            this.tabPage2.Controls.Add(this.txt_lname);
            this.tabPage2.Controls.Add(this.txt_fname);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_psswrd);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt_userName);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADD NEW";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(232, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password should be greater than or equal to 5 characters";
            // 
            // pb_chk
            // 
            this.pb_chk.Location = new System.Drawing.Point(502, 103);
            this.pb_chk.Name = "pb_chk";
            this.pb_chk.Size = new System.Drawing.Size(24, 24);
            this.pb_chk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_chk.TabIndex = 17;
            this.pb_chk.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Salmon;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_cross_basic_red_32;
            this.btn_clear.Location = new System.Drawing.Point(322, 298);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(132, 45);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.Black;
            this.btn_ok.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_check_basic_green_32;
            this.btn_ok.Location = new System.Drawing.Point(177, 298);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(132, 45);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "OK";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_psswrd2
            // 
            this.txt_psswrd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_psswrd2.Location = new System.Drawing.Point(234, 105);
            this.txt_psswrd2.MaxLength = 24;
            this.txt_psswrd2.Name = "txt_psswrd2";
            this.txt_psswrd2.PasswordChar = '*';
            this.txt_psswrd2.Size = new System.Drawing.Size(267, 21);
            this.txt_psswrd2.TabIndex = 3;
            this.txt_psswrd2.TextChanged += new System.EventHandler(this.txt_psswrd2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(94, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "RE-TYPE PASSWORD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(180, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TYPE:";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "CASHIER",
            "ADMINISRATOR"});
            this.cmb_type.Location = new System.Drawing.Point(234, 251);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(249, 21);
            this.cmb_type.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(203, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(185, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "LAST:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(180, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FIRST:";
            // 
            // txt_mi
            // 
            this.txt_mi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mi.Location = new System.Drawing.Point(234, 219);
            this.txt_mi.MaxLength = 1;
            this.txt_mi.Name = "txt_mi";
            this.txt_mi.Size = new System.Drawing.Size(55, 21);
            this.txt_mi.TabIndex = 6;
            // 
            // txt_lname
            // 
            this.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lname.Location = new System.Drawing.Point(234, 190);
            this.txt_lname.MaxLength = 49;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(267, 21);
            this.txt_lname.TabIndex = 5;
            // 
            // txt_fname
            // 
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fname.Location = new System.Drawing.Point(234, 161);
            this.txt_fname.MaxLength = 49;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(267, 21);
            this.txt_fname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(146, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD:";
            // 
            // txt_psswrd
            // 
            this.txt_psswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_psswrd.Location = new System.Drawing.Point(234, 79);
            this.txt_psswrd.MaxLength = 24;
            this.txt_psswrd.Name = "txt_psswrd";
            this.txt_psswrd.PasswordChar = '*';
            this.txt_psswrd.Size = new System.Drawing.Size(267, 21);
            this.txt_psswrd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(147, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER NAME:";
            // 
            // txt_userName
            // 
            this.txt_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_userName.Location = new System.Drawing.Point(234, 53);
            this.txt_userName.MaxLength = 24;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(267, 21);
            this.txt_userName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Close_16_copy;
            this.btn_close.Location = new System.Drawing.Point(692, 14);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(16, 16);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(107, 26);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(309, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "MANAGE USER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // STFS_UserTableAdapter
            // 
            this.STFS_UserTableAdapter.ClearBeforeFill = true;
            // 
            // btn_addnew
            // 
            this.btn_addnew.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_addnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addnew.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addnew.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_addnew.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Add_32;
            this.btn_addnew.Location = new System.Drawing.Point(20, 309);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(99, 42);
            this.btn_addnew.TabIndex = 3;
            this.btn_addnew.Text = "NEW USER";
            this.btn_addnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addnew.UseVisualStyleBackColor = false;
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // frm_manageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolFeeTrackingSystem.Properties.Resources.card1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 498);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_manageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_manageUser_FormClosing);
            this.Load += new System.EventHandler(this.frm_manageUser_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseUp);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_psswrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_mi;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_psswrd2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.PictureBox pb_chk;
        private DB.SFTS_DBDataSetTableAdapters.SFTS_UserTableAdapter STFS_UserTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MI;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_type;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_deactivate;
        private System.Windows.Forms.Button btn_addnew;
    }
}