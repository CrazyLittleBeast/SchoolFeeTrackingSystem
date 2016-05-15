namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_profile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_section = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_lrn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_relation = new System.Windows.Forms.Label();
            this.lbl_guardian = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_saveADRS = new System.Windows.Forms.Button();
            this.btn_updateADRS = new System.Windows.Forms.Button();
            this.txt_addrss = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_SY = new System.Windows.Forms.ComboBox();
            this.dgv_translog = new System.Windows.Forms.DataGridView();
            this.trans_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_editGender = new System.Windows.Forms.Button();
            this.btn_updateDOB = new System.Windows.Forms.Button();
            this.btn_updateName = new System.Windows.Forms.Button();
            this.btn_updateSection = new System.Windows.Forms.Button();
            this.brn_updateGuardian = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pb_profilePic = new System.Windows.Forms.PictureBox();
            this.searched_StudentTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.Searched_StudentTableAdapter();
            this.cTE_Trans_HistoryTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.CTE_Trans_HistoryTableAdapter();
            this.school_YearTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.School_YearTableAdapter();
            this.studentTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_translog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_generate);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.pb_profilePic);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 507);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(182, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 462);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INFO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_editGender);
            this.panel3.Controls.Add(this.btn_updateDOB);
            this.panel3.Controls.Add(this.btn_updateName);
            this.panel3.Controls.Add(this.lbl_gender);
            this.panel3.Controls.Add(this.lbl_age);
            this.panel3.Controls.Add(this.lbl_dob);
            this.panel3.Controls.Add(this.lbl_name);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(59, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 129);
            this.panel3.TabIndex = 3;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_gender.Location = new System.Drawing.Point(115, 91);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(62, 16);
            this.lbl_gender.TabIndex = 9;
            this.lbl_gender.Text = "*gender";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_age.Location = new System.Drawing.Point(115, 65);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(41, 16);
            this.lbl_age.TabIndex = 8;
            this.lbl_age.Text = "*age";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_dob.Location = new System.Drawing.Point(115, 39);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(41, 16);
            this.lbl_dob.TabIndex = 7;
            this.lbl_dob.Text = "*dob";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_name.Location = new System.Drawing.Point(115, 13);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 16);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "*name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(49, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(11, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(70, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(59, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_updateSection);
            this.panel2.Controls.Add(this.lbl_section);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lbl_lrn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(59, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 77);
            this.panel2.TabIndex = 2;
            // 
            // lbl_section
            // 
            this.lbl_section.AutoSize = true;
            this.lbl_section.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_section.Location = new System.Drawing.Point(115, 41);
            this.lbl_section.Name = "lbl_section";
            this.lbl_section.Size = new System.Drawing.Size(65, 16);
            this.lbl_section.TabIndex = 3;
            this.lbl_section.Text = "*section";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(45, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Section:";
            // 
            // lbl_lrn
            // 
            this.lbl_lrn.AutoSize = true;
            this.lbl_lrn.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_lrn.Location = new System.Drawing.Point(115, 14);
            this.lbl_lrn.Name = "lbl_lrn";
            this.lbl_lrn.Size = new System.Drawing.Size(41, 16);
            this.lbl_lrn.TabIndex = 1;
            this.lbl_lrn.Text = "*LRN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(71, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "LRN:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.brn_updateGuardian);
            this.panel5.Controls.Add(this.lbl_relation);
            this.panel5.Controls.Add(this.lbl_guardian);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(59, 343);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 72);
            this.panel5.TabIndex = 7;
            // 
            // lbl_relation
            // 
            this.lbl_relation.AutoSize = true;
            this.lbl_relation.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_relation.Location = new System.Drawing.Point(115, 39);
            this.lbl_relation.Name = "lbl_relation";
            this.lbl_relation.Size = new System.Drawing.Size(66, 16);
            this.lbl_relation.TabIndex = 11;
            this.lbl_relation.Text = "*relation";
            // 
            // lbl_guardian
            // 
            this.lbl_guardian.AutoSize = true;
            this.lbl_guardian.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_guardian.Location = new System.Drawing.Point(115, 14);
            this.lbl_guardian.Name = "lbl_guardian";
            this.lbl_guardian.Size = new System.Drawing.Size(73, 16);
            this.lbl_guardian.TabIndex = 10;
            this.lbl_guardian.Text = "*guardian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(43, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Relation:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(38, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Guardian:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_saveADRS);
            this.panel4.Controls.Add(this.btn_updateADRS);
            this.panel4.Controls.Add(this.txt_addrss);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(59, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 112);
            this.panel4.TabIndex = 6;
            // 
            // btn_saveADRS
            // 
            this.btn_saveADRS.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_saveADRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveADRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveADRS.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveADRS.Location = new System.Drawing.Point(5, 73);
            this.btn_saveADRS.Name = "btn_saveADRS";
            this.btn_saveADRS.Size = new System.Drawing.Size(75, 23);
            this.btn_saveADRS.TabIndex = 3;
            this.btn_saveADRS.Text = "SAVE";
            this.btn_saveADRS.UseVisualStyleBackColor = false;
            this.btn_saveADRS.Click += new System.EventHandler(this.btn_saveADRS_Click);
            // 
            // btn_updateADRS
            // 
            this.btn_updateADRS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_updateADRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateADRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateADRS.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateADRS.Location = new System.Drawing.Point(5, 44);
            this.btn_updateADRS.Name = "btn_updateADRS";
            this.btn_updateADRS.Size = new System.Drawing.Size(75, 23);
            this.btn_updateADRS.TabIndex = 2;
            this.btn_updateADRS.Text = "UPDATE";
            this.btn_updateADRS.UseVisualStyleBackColor = false;
            this.btn_updateADRS.Click += new System.EventHandler(this.btn_updateADRS_Click);
            // 
            // txt_addrss
            // 
            this.txt_addrss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_addrss.ForeColor = System.Drawing.Color.DimGray;
            this.txt_addrss.Location = new System.Drawing.Point(86, 13);
            this.txt_addrss.Multiline = true;
            this.txt_addrss.Name = "txt_addrss";
            this.txt_addrss.ReadOnly = true;
            this.txt_addrss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_addrss.Size = new System.Drawing.Size(249, 83);
            this.txt_addrss.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(14, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address:";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cmb_SY);
            this.tabPage2.Controls.Add(this.dgv_translog);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TRANSACTION HISTORY";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "SY:";
            // 
            // cmb_SY
            // 
            this.cmb_SY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SY.FormattingEnabled = true;
            this.cmb_SY.Location = new System.Drawing.Point(280, 23);
            this.cmb_SY.Name = "cmb_SY";
            this.cmb_SY.Size = new System.Drawing.Size(154, 24);
            this.cmb_SY.TabIndex = 1;
            // 
            // dgv_translog
            // 
            this.dgv_translog.AllowUserToAddRows = false;
            this.dgv_translog.AllowUserToDeleteRows = false;
            this.dgv_translog.AllowUserToResizeColumns = false;
            this.dgv_translog.AllowUserToResizeRows = false;
            this.dgv_translog.BackgroundColor = System.Drawing.Color.White;
            this.dgv_translog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_translog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_translog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_translog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_translog.ColumnHeadersHeight = 30;
            this.dgv_translog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_translog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trans_date,
            this.Total,
            this.u_name});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_translog.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_translog.EnableHeadersVisualStyles = false;
            this.dgv_translog.Location = new System.Drawing.Point(15, 76);
            this.dgv_translog.Name = "dgv_translog";
            this.dgv_translog.ReadOnly = true;
            this.dgv_translog.RowHeadersVisible = false;
            this.dgv_translog.RowTemplate.Height = 24;
            this.dgv_translog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_translog.Size = new System.Drawing.Size(438, 270);
            this.dgv_translog.TabIndex = 0;
            this.dgv_translog.SelectionChanged += new System.EventHandler(this.dgv_translog_SelectionChanged);
            // 
            // trans_date
            // 
            this.trans_date.DataPropertyName = "trans_date";
            this.trans_date.HeaderText = "Date";
            this.trans_date.Name = "trans_date";
            this.trans_date.ReadOnly = true;
            this.trans_date.Width = 162;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "Amount";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // u_name
            // 
            this.u_name.DataPropertyName = "u_name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.u_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.u_name.HeaderText = "Cashier";
            this.u_name.Name = "u_name";
            this.u_name.ReadOnly = true;
            this.u_name.Width = 175;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.AutoScroll = true;
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(694, 507);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(19, 13);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(140, 140);
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.Gold;
            this.btn_generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Edit_page_32;
            this.btn_generate.Location = new System.Drawing.Point(27, 181);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(109, 48);
            this.btn_generate.TabIndex = 3;
            this.btn_generate.Text = "Generate Transaction History";
            this.btn_generate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_editGender
            // 
            this.btn_editGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editGender.FlatAppearance.BorderSize = 0;
            this.btn_editGender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_editGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editGender.Image = global::SchoolFeeTrackingSystem.Properties.Resources.edit_16;
            this.btn_editGender.Location = new System.Drawing.Point(345, 91);
            this.btn_editGender.Name = "btn_editGender";
            this.btn_editGender.Size = new System.Drawing.Size(20, 20);
            this.btn_editGender.TabIndex = 11;
            this.btn_editGender.UseVisualStyleBackColor = true;
            this.btn_editGender.Click += new System.EventHandler(this.btn_editGender_Click);
            // 
            // btn_updateDOB
            // 
            this.btn_updateDOB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateDOB.FlatAppearance.BorderSize = 0;
            this.btn_updateDOB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_updateDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateDOB.Image = global::SchoolFeeTrackingSystem.Properties.Resources.edit_16;
            this.btn_updateDOB.Location = new System.Drawing.Point(345, 37);
            this.btn_updateDOB.Name = "btn_updateDOB";
            this.btn_updateDOB.Size = new System.Drawing.Size(20, 20);
            this.btn_updateDOB.TabIndex = 10;
            this.btn_updateDOB.UseVisualStyleBackColor = true;
            this.btn_updateDOB.Click += new System.EventHandler(this.btn_updateDOB_Click);
            // 
            // btn_updateName
            // 
            this.btn_updateName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateName.FlatAppearance.BorderSize = 0;
            this.btn_updateName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_updateName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateName.Image = global::SchoolFeeTrackingSystem.Properties.Resources.edit_16;
            this.btn_updateName.Location = new System.Drawing.Point(345, 11);
            this.btn_updateName.Name = "btn_updateName";
            this.btn_updateName.Size = new System.Drawing.Size(20, 20);
            this.btn_updateName.TabIndex = 5;
            this.btn_updateName.UseVisualStyleBackColor = true;
            this.btn_updateName.Click += new System.EventHandler(this.btn_updateName_Click);
            // 
            // btn_updateSection
            // 
            this.btn_updateSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateSection.FlatAppearance.BorderSize = 0;
            this.btn_updateSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_updateSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateSection.Image = global::SchoolFeeTrackingSystem.Properties.Resources.edit_16;
            this.btn_updateSection.Location = new System.Drawing.Point(345, 41);
            this.btn_updateSection.Name = "btn_updateSection";
            this.btn_updateSection.Size = new System.Drawing.Size(20, 20);
            this.btn_updateSection.TabIndex = 4;
            this.btn_updateSection.UseVisualStyleBackColor = true;
            this.btn_updateSection.Click += new System.EventHandler(this.btn_updateSection_Click);
            // 
            // brn_updateGuardian
            // 
            this.brn_updateGuardian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brn_updateGuardian.FlatAppearance.BorderSize = 0;
            this.brn_updateGuardian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.brn_updateGuardian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brn_updateGuardian.Image = global::SchoolFeeTrackingSystem.Properties.Resources.edit_16;
            this.brn_updateGuardian.Location = new System.Drawing.Point(348, 3);
            this.brn_updateGuardian.Name = "brn_updateGuardian";
            this.brn_updateGuardian.Size = new System.Drawing.Size(20, 20);
            this.brn_updateGuardian.TabIndex = 12;
            this.brn_updateGuardian.UseVisualStyleBackColor = true;
            this.brn_updateGuardian.Click += new System.EventHandler(this.brn_updateGuardian_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Salmon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_cross_basic_red_32;
            this.btn_close.Location = new System.Drawing.Point(27, 375);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(109, 48);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "CLOSE";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pb_profilePic
            // 
            this.pb_profilePic.Location = new System.Drawing.Point(27, 20);
            this.pb_profilePic.Name = "pb_profilePic";
            this.pb_profilePic.Size = new System.Drawing.Size(125, 125);
            this.pb_profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_profilePic.TabIndex = 1;
            this.pb_profilePic.TabStop = false;
            // 
            // searched_StudentTableAdapter
            // 
            this.searched_StudentTableAdapter.ClearBeforeFill = true;
            // 
            // cTE_Trans_HistoryTableAdapter
            // 
            this.cTE_Trans_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // school_YearTableAdapter
            // 
            this.school_YearTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // frm_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(723, 532);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFILE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_profile_FormClosing);
            this.Load += new System.EventHandler(this.frm_profile_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_translog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.PictureBox pb_profilePic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_lrn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_addrss;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_section;
        private System.Windows.Forms.Label lbl_age;
        private DB.SFTS_DBDataSetTableAdapters.Searched_StudentTableAdapter searched_StudentTableAdapter;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_guardian;
        private System.Windows.Forms.Label lbl_relation;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_translog;
        private DB.SFTS_DBDataSetTableAdapters.CTE_Trans_HistoryTableAdapter cTE_Trans_HistoryTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_SY;
        private DB.SFTS_DBDataSetTableAdapters.School_YearTableAdapter school_YearTableAdapter;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_name;
        private System.Windows.Forms.Button btn_updateSection;
        private System.Windows.Forms.Button btn_updateName;
        private System.Windows.Forms.Button btn_updateDOB;
        private System.Windows.Forms.Button btn_updateADRS;
        private System.Windows.Forms.Button btn_saveADRS;
        private DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button btn_editGender;
        private System.Windows.Forms.Button brn_updateGuardian;
    }
}