namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_updateGender
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
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.bnt_update = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.studentTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter();
            this.SuspendLayout();
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmb_gender.Location = new System.Drawing.Point(81, 52);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(153, 23);
            this.cmb_gender.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "GENDER";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Salmon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Maroon;
            this.btn_close.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_cross_basic_red_32;
            this.btn_close.Location = new System.Drawing.Point(147, 103);
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
            this.bnt_update.Location = new System.Drawing.Point(39, 103);
            this.bnt_update.Name = "bnt_update";
            this.bnt_update.Size = new System.Drawing.Size(102, 43);
            this.bnt_update.TabIndex = 8;
            this.bnt_update.Text = "UPDATE";
            this.bnt_update.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bnt_update.UseVisualStyleBackColor = false;
            this.bnt_update.Click += new System.EventHandler(this.bnt_update_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(282, 176);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.White;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.Location = new System.Drawing.Point(9, 12);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(262, 149);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // frm_updateGender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(282, 176);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.bnt_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_updateGender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDIT GENDER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_updateGender_FormClosing);
            this.Load += new System.EventHandler(this.frm_updateGender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button bnt_update;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}