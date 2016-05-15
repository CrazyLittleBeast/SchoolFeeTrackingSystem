namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_newStudent
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
            this.btn_newG = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_section = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_addrs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_relation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_guardian = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.btn_brwse = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.txt_mid = new System.Windows.Forms.TextBox();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.txt_LRN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.studentTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter();
            this.guardianTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.GuardianTableAdapter();
            this.sectionTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.SectionTableAdapter();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_newG);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_brwse);
            this.panel1.Controls.Add(this.pb_image);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 584);
            this.panel1.TabIndex = 1;
            
            // 
            // btn_newG
            // 
            this.btn_newG.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_newG.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_newG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newG.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newG.ForeColor = System.Drawing.Color.White;
            this.btn_newG.Image = global::SchoolFeeTrackingSystem.Properties.Resources.user_basic_blue_32;
            this.btn_newG.Location = new System.Drawing.Point(498, 405);
            this.btn_newG.Name = "btn_newG";
            this.btn_newG.Size = new System.Drawing.Size(129, 56);
            this.btn_newG.TabIndex = 4;
            this.btn_newG.Text = "Register New Guardian";
            this.btn_newG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_newG.UseVisualStyleBackColor = false;
            this.btn_newG.Click += new System.EventHandler(this.btn_newG_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.cmb_section);
            this.panel7.Location = new System.Drawing.Point(15, 494);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(449, 66);
            this.panel7.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(12, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Section:";
            // 
            // cmb_section
            // 
            this.cmb_section.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_section.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_section.FormattingEnabled = true;
            this.cmb_section.Location = new System.Drawing.Point(89, 22);
            this.cmb_section.Name = "cmb_section";
            this.cmb_section.Size = new System.Drawing.Size(300, 24);
            this.cmb_section.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Salmon;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_cross_basic_red_32;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(498, 276);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(129, 56);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_check_basic_green_32;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(498, 216);
            this.btn_save.Name = "btn_save";
            this.btn_save.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_save.Size = new System.Drawing.Size(129, 56);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "SAVE";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txt_addrs);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(15, 301);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(449, 100);
            this.panel6.TabIndex = 4;
            // 
            // txt_addrs
            // 
            this.txt_addrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_addrs.Location = new System.Drawing.Point(74, 9);
            this.txt_addrs.MaxLength = 125;
            this.txt_addrs.Multiline = true;
            this.txt_addrs.Name = "txt_addrs";
            this.txt_addrs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_addrs.Size = new System.Drawing.Size(361, 81);
            this.txt_addrs.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(8, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Address";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txt_relation);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.cmb_guardian);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(15, 405);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 83);
            this.panel5.TabIndex = 5;
            // 
            // txt_relation
            // 
            this.txt_relation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_relation.Location = new System.Drawing.Point(89, 46);
            this.txt_relation.MaxLength = 24;
            this.txt_relation.Name = "txt_relation";
            this.txt_relation.Size = new System.Drawing.Size(333, 23);
            this.txt_relation.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(14, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Relation:";
            // 
            // cmb_guardian
            // 
            this.cmb_guardian.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_guardian.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_guardian.FormattingEnabled = true;
            this.cmb_guardian.Location = new System.Drawing.Point(89, 13);
            this.cmb_guardian.Name = "cmb_guardian";
            this.cmb_guardian.Size = new System.Drawing.Size(333, 24);
            this.cmb_guardian.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Guardian:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtp_dob);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cmb_gender);
            this.panel4.Location = new System.Drawing.Point(15, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 81);
            this.panel4.TabIndex = 3;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(171, 43);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(263, 23);
            this.dtp_dob.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(10, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "DATE OF BIRTH (DOB)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(110, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gender";
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmb_gender.Location = new System.Drawing.Point(170, 8);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(121, 24);
            this.cmb_gender.TabIndex = 0;
            // 
            // btn_brwse
            // 
            this.btn_brwse.Location = new System.Drawing.Point(507, 140);
            this.btn_brwse.Name = "btn_brwse";
            this.btn_brwse.Size = new System.Drawing.Size(120, 29);
            this.btn_brwse.TabIndex = 6;
            this.btn_brwse.Text = "Browse Image";
            this.btn_brwse.UseVisualStyleBackColor = true;
            this.btn_brwse.Click += new System.EventHandler(this.btn_brwse_Click);
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(507, 11);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(120, 120);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 4;
            this.pb_image.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_last);
            this.panel3.Controls.Add(this.txt_mid);
            this.panel3.Controls.Add(this.txt_first);
            this.panel3.Location = new System.Drawing.Point(15, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 145);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "MIDDLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(38, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "LAST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "FIRST";
            // 
            // txt_last
            // 
            this.txt_last.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_last.Location = new System.Drawing.Point(89, 92);
            this.txt_last.MaxLength = 48;
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(333, 23);
            this.txt_last.TabIndex = 3;
            // 
            // txt_mid
            // 
            this.txt_mid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mid.Location = new System.Drawing.Point(89, 60);
            this.txt_mid.MaxLength = 48;
            this.txt_mid.Name = "txt_mid";
            this.txt_mid.Size = new System.Drawing.Size(333, 23);
            this.txt_mid.TabIndex = 2;
            // 
            // txt_first
            // 
            this.txt_first.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_first.Location = new System.Drawing.Point(89, 28);
            this.txt_first.MaxLength = 48;
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(333, 23);
            this.txt_first.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pb_status);
            this.panel2.Controls.Add(this.txt_LRN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 52);
            this.panel2.TabIndex = 1;
            // 
            // pb_status
            // 
            this.pb_status.Location = new System.Drawing.Point(353, 12);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(25, 25);
            this.pb_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_status.TabIndex = 2;
            this.pb_status.TabStop = false;
            // 
            // txt_LRN
            // 
            this.txt_LRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LRN.Location = new System.Drawing.Point(58, 13);
            this.txt_LRN.MaxLength = 12;
            this.txt_LRN.Name = "txt_LRN";
            this.txt_LRN.Size = new System.Drawing.Size(288, 23);
            this.txt_LRN.TabIndex = 0;
            this.txt_LRN.TextChanged += new System.EventHandler(this.txt_LRN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "LRN:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(654, 584);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(498, 8);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(136, 172);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // guardianTableAdapter
            // 
            this.guardianTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // frm_newStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(686, 608);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_newStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW STUDENT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_newStudent_FormClosing);
            this.Load += new System.EventHandler(this.frm_newStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_last;
        private System.Windows.Forms.TextBox txt_mid;
        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_LRN;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btn_brwse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmb_guardian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_relation;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_addrs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private DB.SFTS_DBDataSetTableAdapters.GuardianTableAdapter guardianTableAdapter;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_section;
        private DB.SFTS_DBDataSetTableAdapters.SectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.Button btn_newG;
        private System.Windows.Forms.PictureBox pb_status;
    }
}