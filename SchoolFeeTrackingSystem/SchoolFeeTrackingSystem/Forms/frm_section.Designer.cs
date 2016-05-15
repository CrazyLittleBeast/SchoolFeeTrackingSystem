namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_section
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_senior = new System.Windows.Forms.RadioButton();
            this.rbtn_junior = new System.Windows.Forms.RadioButton();
            this.rbtn_all = new System.Windows.Forms.RadioButton();
            this.rbtn_grd7 = new System.Windows.Forms.RadioButton();
            this.rbtn_grd10 = new System.Windows.Forms.RadioButton();
            this.rbtn_grd8 = new System.Windows.Forms.RadioButton();
            this.rbtn_grd9 = new System.Windows.Forms.RadioButton();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_section = new System.Windows.Forms.DataGridView();
            this.Section_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_level = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_secName = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.sectionTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.SectionTableAdapter();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_section)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 435);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btn_edit);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.dgv_section);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Section";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_senior);
            this.groupBox2.Controls.Add(this.rbtn_junior);
            this.groupBox2.Controls.Add(this.rbtn_all);
            this.groupBox2.Controls.Add(this.rbtn_grd7);
            this.groupBox2.Controls.Add(this.rbtn_grd10);
            this.groupBox2.Controls.Add(this.rbtn_grd8);
            this.groupBox2.Controls.Add(this.rbtn_grd9);
            this.groupBox2.Location = new System.Drawing.Point(11, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YEAR LEVEL FILTER";
            // 
            // rbtn_senior
            // 
            this.rbtn_senior.AutoSize = true;
            this.rbtn_senior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_senior.Location = new System.Drawing.Point(15, 158);
            this.rbtn_senior.Name = "rbtn_senior";
            this.rbtn_senior.Size = new System.Drawing.Size(84, 17);
            this.rbtn_senior.TabIndex = 7;
            this.rbtn_senior.TabStop = true;
            this.rbtn_senior.Text = "GRADE 12";
            this.rbtn_senior.UseVisualStyleBackColor = true;
            this.rbtn_senior.CheckedChanged += new System.EventHandler(this.levelFilter);
            // 
            // rbtn_junior
            // 
            this.rbtn_junior.AutoSize = true;
            this.rbtn_junior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_junior.Location = new System.Drawing.Point(15, 135);
            this.rbtn_junior.Name = "rbtn_junior";
            this.rbtn_junior.Size = new System.Drawing.Size(84, 17);
            this.rbtn_junior.TabIndex = 6;
            this.rbtn_junior.TabStop = true;
            this.rbtn_junior.Text = "GRADE 11";
            this.rbtn_junior.UseVisualStyleBackColor = true;
            this.rbtn_junior.CheckedChanged += new System.EventHandler(this.levelFilter);
            // 
            // rbtn_all
            // 
            this.rbtn_all.AutoSize = true;
            this.rbtn_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_all.Location = new System.Drawing.Point(15, 20);
            this.rbtn_all.Name = "rbtn_all";
            this.rbtn_all.Size = new System.Drawing.Size(45, 17);
            this.rbtn_all.TabIndex = 1;
            this.rbtn_all.TabStop = true;
            this.rbtn_all.Text = "ALL";
            this.rbtn_all.UseVisualStyleBackColor = true;
            this.rbtn_all.CheckedChanged += new System.EventHandler(this.levelFilter);
            // 
            // rbtn_grd7
            // 
            this.rbtn_grd7.AutoSize = true;
            this.rbtn_grd7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_grd7.Location = new System.Drawing.Point(15, 43);
            this.rbtn_grd7.Name = "rbtn_grd7";
            this.rbtn_grd7.Size = new System.Drawing.Size(77, 17);
            this.rbtn_grd7.TabIndex = 2;
            this.rbtn_grd7.TabStop = true;
            this.rbtn_grd7.Text = "GRADE 7";
            this.rbtn_grd7.UseVisualStyleBackColor = true;
            this.rbtn_grd7.CheckedChanged += new System.EventHandler(this.levelFilter);
            // 
            // rbtn_grd10
            // 
            this.rbtn_grd10.AutoSize = true;
            this.rbtn_grd10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_grd10.Location = new System.Drawing.Point(15, 112);
            this.rbtn_grd10.Name = "rbtn_grd10";
            this.rbtn_grd10.Size = new System.Drawing.Size(84, 17);
            this.rbtn_grd10.TabIndex = 5;
            this.rbtn_grd10.TabStop = true;
            this.rbtn_grd10.Text = "GRADE 10";
            this.rbtn_grd10.UseVisualStyleBackColor = true;
            this.rbtn_grd10.CheckedChanged += new System.EventHandler(this.levelFilter);
            // 
            // rbtn_grd8
            // 
            this.rbtn_grd8.AutoSize = true;
            this.rbtn_grd8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_grd8.Location = new System.Drawing.Point(15, 66);
            this.rbtn_grd8.Name = "rbtn_grd8";
            this.rbtn_grd8.Size = new System.Drawing.Size(77, 17);
            this.rbtn_grd8.TabIndex = 3;
            this.rbtn_grd8.TabStop = true;
            this.rbtn_grd8.Text = "GRADE 8";
            this.rbtn_grd8.UseVisualStyleBackColor = true;
            this.rbtn_grd8.CheckedChanged += new System.EventHandler(this.levelFilter);
            // 
            // rbtn_grd9
            // 
            this.rbtn_grd9.AutoSize = true;
            this.rbtn_grd9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtn_grd9.Location = new System.Drawing.Point(15, 89);
            this.rbtn_grd9.Name = "rbtn_grd9";
            this.rbtn_grd9.Size = new System.Drawing.Size(77, 17);
            this.rbtn_grd9.TabIndex = 4;
            this.rbtn_grd9.TabStop = true;
            this.rbtn_grd9.Text = "GRADE 9";
            this.rbtn_grd9.UseVisualStyleBackColor = true;
            this.rbtn_grd9.CheckedChanged += new System.EventHandler(this.levelFilter);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(20, 31);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 40);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Salmon;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(20, 77);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 40);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_section
            // 
            this.dgv_section.AllowUserToAddRows = false;
            this.dgv_section.AllowUserToDeleteRows = false;
            this.dgv_section.AllowUserToResizeColumns = false;
            this.dgv_section.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_section.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_section.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_section.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_section.ColumnHeadersHeight = 25;
            this.dgv_section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_section.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Section_ID,
            this.section_name,
            this.section_level});
            this.dgv_section.EnableHeadersVisualStyles = false;
            this.dgv_section.Location = new System.Drawing.Point(165, 11);
            this.dgv_section.Name = "dgv_section";
            this.dgv_section.ReadOnly = true;
            this.dgv_section.RowHeadersVisible = false;
            this.dgv_section.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_section.RowTemplate.Height = 24;
            this.dgv_section.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_section.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_section.Size = new System.Drawing.Size(437, 353);
            this.dgv_section.TabIndex = 0;
            // 
            // Section_ID
            // 
            this.Section_ID.DataPropertyName = "Section_ID";
            this.Section_ID.HeaderText = "Section_ID";
            this.Section_ID.Name = "Section_ID";
            this.Section_ID.ReadOnly = true;
            this.Section_ID.Visible = false;
            // 
            // section_name
            // 
            this.section_name.DataPropertyName = "section_name";
            this.section_name.HeaderText = "SECTION";
            this.section_name.Name = "section_name";
            this.section_name.ReadOnly = true;
            this.section_name.Width = 285;
            // 
            // section_level
            // 
            this.section_level.DataPropertyName = "section_level";
            this.section_level.HeaderText = "LEVEL";
            this.section_level.Name = "section_level";
            this.section_level.ReadOnly = true;
            this.section_level.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADD NEW SECTION";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_level);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_secName);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Location = new System.Drawing.Point(63, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Section";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Salmon;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(228, 158);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 45);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(100, 158);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 45);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Section Level:";
            // 
            // cmb_level
            // 
            this.cmb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_level.FormattingEnabled = true;
            this.cmb_level.Items.AddRange(new object[] {
            "GRADE 7",
            "GRADE 8",
            "GRADE 9",
            "GRADE 10",
            "GRADE 11",
            "GRADE 12"});
            this.cmb_level.Location = new System.Drawing.Point(132, 96);
            this.cmb_level.Name = "cmb_level";
            this.cmb_level.Size = new System.Drawing.Size(289, 21);
            this.cmb_level.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Section Name:";
            // 
            // txt_secName
            // 
            this.txt_secName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_secName.Location = new System.Drawing.Point(132, 50);
            this.txt_secName.MaxLength = 24;
            this.txt_secName.Name = "txt_secName";
            this.txt_secName.Size = new System.Drawing.Size(289, 21);
            this.txt_secName.TabIndex = 0;
            this.txt_secName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 17);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(478, 215);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 23;
            this.lineShape1.X2 = 440;
            this.lineShape1.Y1 = 120;
            this.lineShape1.Y2 = 120;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // frm_section
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(698, 460);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_section";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Section";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_section_FormClosing);
            this.Load += new System.EventHandler(this.frm_section_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_section)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_secName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_level;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dgv_section;
        private DB.SFTS_DBDataSetTableAdapters.SectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_all;
        private System.Windows.Forms.RadioButton rbtn_grd7;
        private System.Windows.Forms.RadioButton rbtn_grd10;
        private System.Windows.Forms.RadioButton rbtn_grd8;
        private System.Windows.Forms.RadioButton rbtn_grd9;
        private System.Windows.Forms.RadioButton rbtn_senior;
        private System.Windows.Forms.RadioButton rbtn_junior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn section_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn section_level;
    }
}