namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_updateSection
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
            this.cmb_section = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.sectionTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.SectionTableAdapter();
            this.studentTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.bnt_update);
            this.panel1.Controls.Add(this.cmb_section);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 163);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Salmon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Maroon;
            this.btn_close.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_cross_basic_red_32;
            this.btn_close.Location = new System.Drawing.Point(187, 99);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(102, 43);
            this.btn_close.TabIndex = 3;
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
            this.bnt_update.Location = new System.Drawing.Point(78, 99);
            this.bnt_update.Name = "bnt_update";
            this.bnt_update.Size = new System.Drawing.Size(102, 43);
            this.bnt_update.TabIndex = 2;
            this.bnt_update.Text = "UPDATE";
            this.bnt_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bnt_update.UseVisualStyleBackColor = false;
            this.bnt_update.Click += new System.EventHandler(this.bnt_update_Click);
            // 
            // cmb_section
            // 
            this.cmb_section.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_section.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_section.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_section.FormattingEnabled = true;
            this.cmb_section.Location = new System.Drawing.Point(106, 53);
            this.cmb_section.Name = "cmb_section";
            this.cmb_section.Size = new System.Drawing.Size(219, 24);
            this.cmb_section.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECTION:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(356, 163);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.Location = new System.Drawing.Point(12, 11);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(333, 145);
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // frm_updateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 187);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_updateSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE SECTION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateSection_FormClosing);
            this.Load += new System.EventHandler(this.updateSection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_section;
        private System.Windows.Forms.Label label1;
        private DB.SFTS_DBDataSetTableAdapters.SectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.Button bnt_update;
        private System.Windows.Forms.Button btn_close;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}