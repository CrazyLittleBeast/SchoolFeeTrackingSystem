namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_guardian
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_guardian = new System.Windows.Forms.DataGridView();
            this.guardian_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.guardianTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.GuardianTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guardian)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.dgv_guardian);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 425);
            this.panel1.TabIndex = 0;
            // 
            // dgv_guardian
            // 
            this.dgv_guardian.AllowUserToAddRows = false;
            this.dgv_guardian.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgv_guardian.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_guardian.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_guardian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_guardian.ColumnHeadersHeight = 30;
            this.dgv_guardian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_guardian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guardian_ID,
            this.Lname,
            this.Fname,
            this.Mname,
            this.DOB,
            this.gender,
            this.address});
            this.dgv_guardian.EnableHeadersVisualStyles = false;
            this.dgv_guardian.Location = new System.Drawing.Point(161, 16);
            this.dgv_guardian.Name = "dgv_guardian";
            this.dgv_guardian.ReadOnly = true;
            this.dgv_guardian.RowHeadersVisible = false;
            this.dgv_guardian.RowTemplate.Height = 24;
            this.dgv_guardian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_guardian.Size = new System.Drawing.Size(453, 390);
            this.dgv_guardian.TabIndex = 1;
            // 
            // guardian_ID
            // 
            this.guardian_ID.DataPropertyName = "guardian_ID";
            this.guardian_ID.HeaderText = "guardian_ID";
            this.guardian_ID.Name = "guardian_ID";
            this.guardian_ID.ReadOnly = true;
            this.guardian_ID.Visible = false;
            // 
            // Lname
            // 
            this.Lname.DataPropertyName = "Lname";
            this.Lname.HeaderText = "Last";
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Width = 150;
            // 
            // Fname
            // 
            this.Fname.DataPropertyName = "Fname";
            this.Fname.HeaderText = "First";
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Width = 150;
            // 
            // Mname
            // 
            this.Mname.DataPropertyName = "Mname";
            this.Mname.HeaderText = "Middle";
            this.Mname.Name = "Mname";
            this.Mname.ReadOnly = true;
            this.Mname.Width = 150;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Visible = false;
            this.DOB.Width = 150;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Visible = false;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Visible = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Add_32;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(19, 50);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(116, 45);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "NEW";
            this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Salmon;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Delete32;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(19, 102);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 45);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // guardianTableAdapter
            // 
            this.guardianTableAdapter.ClearBeforeFill = true;
            // 
            // frm_guardian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_guardian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_guardian_FormClosing);
            this.Load += new System.EventHandler(this.frm_guardian_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guardian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView dgv_guardian;
        private DB.SFTS_DBDataSetTableAdapters.GuardianTableAdapter guardianTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardian_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.Button btn_delete;
    }
}