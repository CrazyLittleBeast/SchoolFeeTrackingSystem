namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_schoolFee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_SFee = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_GFee = new System.Windows.Forms.DataGridView();
            this.Fee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_req = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GFee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.txt_sy2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FeeName = new System.Windows.Forms.TextBox();
            this.txt_sy1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cmb_sy = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.guardian_FeeTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.Guardian_FeeTableAdapter();
            this.student_FeeTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.Student_FeeTableAdapter();
            this.school_YearTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.School_YearTableAdapter();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GFee)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 591);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 541);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmb_sy);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.btn_edit);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dgv_SFee);
            this.tabPage1.Controls.Add(this.dgv_GFee);
            this.tabPage1.Controls.Add(this.shapeContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SCHOOL FEE";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Delete32;
            this.btn_delete.Location = new System.Drawing.Point(17, 190);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 48);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Edit_page_32;
            this.btn_edit.Location = new System.Drawing.Point(17, 137);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(139, 48);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(281, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "STUDENT FEE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(281, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "GUARDIAN FEE";
            // 
            // dgv_SFee
            // 
            this.dgv_SFee.AllowUserToAddRows = false;
            this.dgv_SFee.AllowUserToDeleteRows = false;
            this.dgv_SFee.AllowUserToResizeColumns = false;
            this.dgv_SFee.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_SFee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SFee.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SFee.ColumnHeadersHeight = 30;
            this.dgv_SFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_SFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_SFee.EnableHeadersVisualStyles = false;
            this.dgv_SFee.Location = new System.Drawing.Point(281, 283);
            this.dgv_SFee.Name = "dgv_SFee";
            this.dgv_SFee.ReadOnly = true;
            this.dgv_SFee.RowHeadersVisible = false;
            this.dgv_SFee.RowTemplate.Height = 24;
            this.dgv_SFee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_SFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SFee.Size = new System.Drawing.Size(475, 220);
            this.dgv_SFee.TabIndex = 2;
            this.dgv_SFee.Enter += new System.EventHandler(this.dgv_SFee_Enter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Fee_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SY";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "SY";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "amount_req";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount Req";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SFee_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "GFee_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dgv_GFee
            // 
            this.dgv_GFee.AllowUserToAddRows = false;
            this.dgv_GFee.AllowUserToDeleteRows = false;
            this.dgv_GFee.AllowUserToResizeColumns = false;
            this.dgv_GFee.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_GFee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_GFee.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_GFee.ColumnHeadersHeight = 30;
            this.dgv_GFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_GFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fee_name,
            this.SY,
            this.amount_req,
            this.GFee_ID});
            this.dgv_GFee.EnableHeadersVisualStyles = false;
            this.dgv_GFee.Location = new System.Drawing.Point(281, 27);
            this.dgv_GFee.Name = "dgv_GFee";
            this.dgv_GFee.ReadOnly = true;
            this.dgv_GFee.RowHeadersVisible = false;
            this.dgv_GFee.RowTemplate.Height = 24;
            this.dgv_GFee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_GFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GFee.Size = new System.Drawing.Size(475, 220);
            this.dgv_GFee.TabIndex = 0;
            this.dgv_GFee.Enter += new System.EventHandler(this.dgv_GFee_Enter);
            // 
            // Fee_name
            // 
            this.Fee_name.DataPropertyName = "Fee_name";
            this.Fee_name.HeaderText = "Description";
            this.Fee_name.Name = "Fee_name";
            this.Fee_name.ReadOnly = true;
            this.Fee_name.Width = 200;
            // 
            // SY
            // 
            this.SY.DataPropertyName = "SY";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SY.DefaultCellStyle = dataGridViewCellStyle7;
            this.SY.HeaderText = "SY";
            this.SY.Name = "SY";
            this.SY.ReadOnly = true;
            this.SY.Width = 150;
            // 
            // amount_req
            // 
            this.amount_req.DataPropertyName = "amount_req";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.amount_req.DefaultCellStyle = dataGridViewCellStyle8;
            this.amount_req.HeaderText = "Amount Req";
            this.amount_req.Name = "amount_req";
            this.amount_req.ReadOnly = true;
            this.amount_req.Width = 125;
            // 
            // GFee_ID
            // 
            this.GFee_ID.DataPropertyName = "GFee_ID";
            this.GFee_ID.HeaderText = "GFee_ID";
            this.GFee_ID.Name = "GFee_ID";
            this.GFee_ID.ReadOnly = true;
            this.GFee_ID.Visible = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(773, 506);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 275;
            this.lineShape2.X2 = 757;
            this.lineShape2.Y1 = 255;
            this.lineShape2.Y2 = 255;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 242;
            this.lineShape1.X2 = 242;
            this.lineShape1.Y1 = 15;
            this.lineShape1.Y2 = 492;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btn_ok);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CREATE NEW FEE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(292, 302);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(112, 40);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmb_type);
            this.panel2.Controls.Add(this.pb_status);
            this.panel2.Controls.Add(this.txt_sy2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_FeeName);
            this.panel2.Controls.Add(this.txt_sy1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_amount);
            this.panel2.Location = new System.Drawing.Point(168, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 203);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(81, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type:";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "GUARDIAN",
            "STUDENT"});
            this.cmb_type.Location = new System.Drawing.Point(134, 28);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 24);
            this.cmb_type.TabIndex = 9;
            // 
            // pb_status
            // 
            this.pb_status.Location = new System.Drawing.Point(287, 142);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(18, 18);
            this.pb_status.TabIndex = 8;
            this.pb_status.TabStop = false;
            // 
            // txt_sy2
            // 
            this.txt_sy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sy2.Location = new System.Drawing.Point(222, 139);
            this.txt_sy2.MaxLength = 4;
            this.txt_sy2.Name = "txt_sy2";
            this.txt_sy2.Size = new System.Drawing.Size(61, 23);
            this.txt_sy2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(202, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // txt_FeeName
            // 
            this.txt_FeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FeeName.Location = new System.Drawing.Point(134, 63);
            this.txt_FeeName.MaxLength = 50;
            this.txt_FeeName.Name = "txt_FeeName";
            this.txt_FeeName.Size = new System.Drawing.Size(297, 23);
            this.txt_FeeName.TabIndex = 1;
            // 
            // txt_sy1
            // 
            this.txt_sy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sy1.Location = new System.Drawing.Point(134, 139);
            this.txt_sy1.MaxLength = 4;
            this.txt_sy1.Name = "txt_sy1";
            this.txt_sy1.Size = new System.Drawing.Size(61, 23);
            this.txt_sy1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount Req:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(96, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "SY:";
            // 
            // txt_amount
            // 
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_amount.Location = new System.Drawing.Point(134, 101);
            this.txt_amount.MaxLength = 5;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(157, 23);
            this.txt_amount.TabIndex = 3;
            // 
            // cmb_sy
            // 
            this.cmb_sy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sy.FormattingEnabled = true;
            this.cmb_sy.Location = new System.Drawing.Point(35, 54);
            this.cmb_sy.Name = "cmb_sy";
            this.cmb_sy.Size = new System.Drawing.Size(177, 24);
            this.cmb_sy.TabIndex = 8;
            this.cmb_sy.SelectedIndexChanged += new System.EventHandler(this.cmb_sy_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GreenYellow;
            this.label8.Location = new System.Drawing.Point(35, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "School Year:";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.GreenYellow;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(16, 21);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(209, 78);
            // 
            // guardian_FeeTableAdapter
            // 
            this.guardian_FeeTableAdapter.ClearBeforeFill = true;
            // 
            // student_FeeTableAdapter
            // 
            this.student_FeeTableAdapter.ClearBeforeFill = true;
            // 
            // school_YearTableAdapter
            // 
            this.school_YearTableAdapter.ClearBeforeFill = true;
            // 
            // frm_schoolFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 616);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_schoolFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Fee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_schoolFee_FormClosing);
            this.Load += new System.EventHandler(this.frm_schoolFee_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GFee)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_GFee;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sy2;
        private System.Windows.Forms.TextBox txt_sy1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label5;
        private DB.SFTS_DBDataSetTableAdapters.Guardian_FeeTableAdapter guardian_FeeTableAdapter;
        private DB.SFTS_DBDataSetTableAdapters.Student_FeeTableAdapter student_FeeTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SY;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_req;
        private System.Windows.Forms.DataGridViewTextBoxColumn GFee_ID;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dgv_SFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_sy;
        private DB.SFTS_DBDataSetTableAdapters.School_YearTableAdapter school_YearTableAdapter;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}