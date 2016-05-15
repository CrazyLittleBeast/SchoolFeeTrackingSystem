namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_NewGuardian
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_Mname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.guardianTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.GuardianTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 476);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Salmon;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(280, 402);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(131, 52);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(132, 402);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(131, 52);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_fname);
            this.panel3.Controls.Add(this.txt_Mname);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_Lname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(25, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 122);
            this.panel3.TabIndex = 10;
            // 
            // txt_fname
            // 
            this.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fname.Location = new System.Drawing.Point(125, 24);
            this.txt_fname.MaxLength = 50;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(322, 21);
            this.txt_fname.TabIndex = 0;
            // 
            // txt_Mname
            // 
            this.txt_Mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mname.Location = new System.Drawing.Point(125, 49);
            this.txt_Mname.MaxLength = 50;
            this.txt_Mname.Name = "txt_Mname";
            this.txt_Mname.Size = new System.Drawing.Size(322, 21);
            this.txt_Mname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last";
            // 
            // txt_Lname
            // 
            this.txt_Lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lname.Location = new System.Drawing.Point(125, 74);
            this.txt_Lname.MaxLength = 50;
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(322, 21);
            this.txt_Lname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Middle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_address);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtp_dob);
            this.panel2.Controls.Add(this.cmb_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.shapeContainer2);
            this.panel2.Location = new System.Drawing.Point(25, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 231);
            this.panel2.TabIndex = 9;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_address.Location = new System.Drawing.Point(161, 120);
            this.txt_address.MaxLength = 99;
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_address.Size = new System.Drawing.Size(286, 83);
            this.txt_address.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ADDRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of Birth (DOB)";
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(219, 61);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(228, 21);
            this.dtp_dob.TabIndex = 9;
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmb_gender.Location = new System.Drawing.Point(219, 33);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(46, 21);
            this.cmb_gender.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(549, 231);
            this.shapeContainer2.TabIndex = 8;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 107;
            this.lineShape1.X2 = 445;
            this.lineShape1.Y1 = 99;
            this.lineShape1.Y2 = 99;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(74, 12);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(404, 206);
            // 
            // guardianTableAdapter
            // 
            this.guardianTableAdapter.ClearBeforeFill = true;
            // 
            // frm_NewGuardian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(617, 510);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_NewGuardian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Guardian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_NewGuardian_FormClosing);
            this.Load += new System.EventHandler(this.frm_NewGuardian_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.TextBox txt_Mname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_add;
        private DB.SFTS_DBDataSetTableAdapters.GuardianTableAdapter guardianTableAdapter;
    }
}