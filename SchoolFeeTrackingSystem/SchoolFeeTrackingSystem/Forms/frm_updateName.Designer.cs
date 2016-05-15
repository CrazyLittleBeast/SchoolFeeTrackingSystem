namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_updateName
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
            this.bnt_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.txt_mid = new System.Windows.Forms.TextBox();
            this.txt_first = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.studentTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.bnt_update);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_last);
            this.panel1.Controls.Add(this.txt_mid);
            this.panel1.Controls.Add(this.txt_first);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 228);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Salmon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Maroon;
            this.btn_close.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_cross_basic_red_32;
            this.btn_close.Location = new System.Drawing.Point(217, 150);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(102, 43);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "CANCEL";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // bnt_update
            // 
            this.bnt_update.BackColor = System.Drawing.Color.GreenYellow;
            this.bnt_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_update.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.bnt_update.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_check_basic_green_32;
            this.bnt_update.Location = new System.Drawing.Point(108, 150);
            this.bnt_update.Name = "bnt_update";
            this.bnt_update.Size = new System.Drawing.Size(102, 43);
            this.bnt_update.TabIndex = 6;
            this.bnt_update.Text = "UPDATE";
            this.bnt_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bnt_update.UseVisualStyleBackColor = false;
            this.bnt_update.Click += new System.EventHandler(this.bnt_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "LAST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "MIDDLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "FIRST";
            // 
            // txt_last
            // 
            this.txt_last.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_last.ForeColor = System.Drawing.Color.DimGray;
            this.txt_last.Location = new System.Drawing.Point(87, 93);
            this.txt_last.MaxLength = 49;
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(265, 23);
            this.txt_last.TabIndex = 2;
            this.txt_last.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mid
            // 
            this.txt_mid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mid.ForeColor = System.Drawing.Color.DimGray;
            this.txt_mid.Location = new System.Drawing.Point(87, 64);
            this.txt_mid.MaxLength = 49;
            this.txt_mid.Name = "txt_mid";
            this.txt_mid.Size = new System.Drawing.Size(265, 23);
            this.txt_mid.TabIndex = 1;
            this.txt_mid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_first
            // 
            this.txt_first.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_first.ForeColor = System.Drawing.Color.DimGray;
            this.txt_first.Location = new System.Drawing.Point(87, 35);
            this.txt_first.MaxLength = 49;
            this.txt_first.Name = "txt_first";
            this.txt_first.Size = new System.Drawing.Size(265, 23);
            this.txt_first.TabIndex = 0;
            this.txt_first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(405, 228);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.Location = new System.Drawing.Point(10, 7);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(384, 209);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // frm_updateName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 248);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_updateName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE NAME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_updateName_FormClosing);
            this.Load += new System.EventHandler(this.frm_updateName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_last;
        private System.Windows.Forms.TextBox txt_mid;
        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button bnt_update;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}