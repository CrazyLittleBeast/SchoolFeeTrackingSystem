namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_sectionUpdate
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.cmb_level = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sectionTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.SectionTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.cmb_level);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 204);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Salmon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(206, 126);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(94, 32);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(106, 126);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(94, 32);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
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
            this.cmb_level.Location = new System.Drawing.Point(107, 84);
            this.cmb_level.Name = "cmb_level";
            this.cmb_level.Size = new System.Drawing.Size(193, 21);
            this.cmb_level.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Location = new System.Drawing.Point(107, 53);
            this.txt_name.MaxLength = 49;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(193, 21);
            this.txt_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(54, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LEVEL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME:";
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // frm_sectionUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(397, 229);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_sectionUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE SECTION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_sectionUpdate_FormClosing);
            this.Load += new System.EventHandler(this.frm_sectionUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cmb_level;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private DB.SFTS_DBDataSetTableAdapters.SectionTableAdapter sectionTableAdapter;
    }
}