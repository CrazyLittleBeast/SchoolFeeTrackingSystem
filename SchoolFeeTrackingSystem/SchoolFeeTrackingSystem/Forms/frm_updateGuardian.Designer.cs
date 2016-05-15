namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_updateGuardian
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
            this.cmb_guardian = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gRelation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btn_close = new System.Windows.Forms.Button();
            this.bnt_update = new System.Windows.Forms.Button();
            this.studentTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter();
            this.guardianTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.GuardianTableAdapter();
            this.SuspendLayout();
            // 
            // cmb_guardian
            // 
            this.cmb_guardian.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_guardian.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_guardian.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_guardian.FormattingEnabled = true;
            this.cmb_guardian.Location = new System.Drawing.Point(154, 51);
            this.cmb_guardian.Name = "cmb_guardian";
            this.cmb_guardian.Size = new System.Drawing.Size(222, 24);
            this.cmb_guardian.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(86, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guardian";
            // 
            // txt_gRelation
            // 
            this.txt_gRelation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gRelation.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gRelation.Location = new System.Drawing.Point(154, 79);
            this.txt_gRelation.MaxLength = 24;
            this.txt_gRelation.Name = "txt_gRelation";
            this.txt_gRelation.Size = new System.Drawing.Size(222, 22);
            this.txt_gRelation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(45, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Guardian Relation";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(414, 204);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.Location = new System.Drawing.Point(19, 20);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(383, 162);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Salmon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Maroon;
            this.btn_close.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_cross_basic_red_32;
            this.btn_close.Location = new System.Drawing.Point(204, 128);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(102, 43);
            this.btn_close.TabIndex = 9;
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
            this.bnt_update.Location = new System.Drawing.Point(95, 128);
            this.bnt_update.Name = "bnt_update";
            this.bnt_update.Size = new System.Drawing.Size(102, 43);
            this.bnt_update.TabIndex = 8;
            this.bnt_update.Text = "UPDATE";
            this.bnt_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bnt_update.UseVisualStyleBackColor = false;
            this.bnt_update.Click += new System.EventHandler(this.bnt_update_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // guardianTableAdapter
            // 
            this.guardianTableAdapter.ClearBeforeFill = true;
            // 
            // frm_updateGuardian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 204);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.bnt_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_gRelation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_guardian);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_updateGuardian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Guardian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_updateGuardian_FormClosing);
            this.Load += new System.EventHandler(this.frm_updateGuardian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_guardian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gRelation;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button bnt_update;
        private DB.SFTS_DBDataSetTableAdapters.GuardianTableAdapter guardianTableAdapter;
        private DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}