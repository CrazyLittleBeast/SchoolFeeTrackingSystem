namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_manageStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.LRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.register_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardian_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_relation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.studentTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_profile);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.dgv_student);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 445);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Salmon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::SchoolFeeTrackingSystem.Properties.Resources.button_cross_basic_red_32;
            this.btn_close.Location = new System.Drawing.Point(20, 380);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(123, 46);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "CLOSE";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.Black;
            this.btn_profile.Image = global::SchoolFeeTrackingSystem.Properties.Resources.id_card_32;
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(20, 94);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_profile.Size = new System.Drawing.Size(123, 46);
            this.btn_profile.TabIndex = 4;
            this.btn_profile.Text = "VIEW PROFILE";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_search.Location = new System.Drawing.Point(166, 41);
            this.txt_search.MaxLength = 50;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(503, 21);
            this.txt_search.TabIndex = 3;
            this.txt_search.Text = "SEARCH";
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // dgv_student
            // 
            this.dgv_student.AllowUserToAddRows = false;
            this.dgv_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            this.dgv_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_student.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LRN,
            this.register_date,
            this.student_status,
            this.Section_ID,
            this.student_picture,
            this.guardian_ID,
            this.gender,
            this.DOB,
            this.address,
            this.Fname,
            this.Lname,
            this.Mname,
            this.student_name,
            this.g_relation});
            this.dgv_student.EnableHeadersVisualStyles = false;
            this.dgv_student.Location = new System.Drawing.Point(166, 68);
            this.dgv_student.MultiSelect = false;
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_student.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_student.RowHeadersVisible = false;
            this.dgv_student.RowTemplate.Height = 24;
            this.dgv_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_student.Size = new System.Drawing.Size(503, 358);
            this.dgv_student.TabIndex = 1;
            // 
            // LRN
            // 
            this.LRN.DataPropertyName = "LRN";
            this.LRN.HeaderText = "LRN";
            this.LRN.Name = "LRN";
            this.LRN.ReadOnly = true;
            this.LRN.Visible = false;
            // 
            // register_date
            // 
            this.register_date.DataPropertyName = "register_date";
            this.register_date.HeaderText = "register_date";
            this.register_date.Name = "register_date";
            this.register_date.ReadOnly = true;
            this.register_date.Visible = false;
            // 
            // student_status
            // 
            this.student_status.DataPropertyName = "student_status";
            this.student_status.HeaderText = "student_status";
            this.student_status.Name = "student_status";
            this.student_status.ReadOnly = true;
            this.student_status.Visible = false;
            // 
            // Section_ID
            // 
            this.Section_ID.DataPropertyName = "Section_ID";
            this.Section_ID.HeaderText = "Section_ID";
            this.Section_ID.Name = "Section_ID";
            this.Section_ID.ReadOnly = true;
            this.Section_ID.Visible = false;
            // 
            // student_picture
            // 
            this.student_picture.DataPropertyName = "student_picture";
            this.student_picture.HeaderText = "student_picture";
            this.student_picture.Name = "student_picture";
            this.student_picture.ReadOnly = true;
            this.student_picture.Visible = false;
            // 
            // guardian_ID
            // 
            this.guardian_ID.DataPropertyName = "guardian_ID";
            this.guardian_ID.HeaderText = "guardian_ID";
            this.guardian_ID.Name = "guardian_ID";
            this.guardian_ID.ReadOnly = true;
            this.guardian_ID.Visible = false;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Visible = false;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Visible = false;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Visible = false;
            // 
            // Fname
            // 
            this.Fname.DataPropertyName = "Fname";
            this.Fname.HeaderText = "Fname";
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Visible = false;
            // 
            // Lname
            // 
            this.Lname.DataPropertyName = "Lname";
            this.Lname.HeaderText = "Lname";
            this.Lname.Name = "Lname";
            this.Lname.ReadOnly = true;
            this.Lname.Visible = false;
            // 
            // Mname
            // 
            this.Mname.DataPropertyName = "Mname";
            this.Mname.HeaderText = "Mname";
            this.Mname.Name = "Mname";
            this.Mname.ReadOnly = true;
            this.Mname.Visible = false;
            // 
            // student_name
            // 
            this.student_name.DataPropertyName = "student_name";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.DefaultCellStyle = dataGridViewCellStyle11;
            this.student_name.HeaderText = "Name";
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            this.student_name.Width = 500;
            // 
            // g_relation
            // 
            this.g_relation.DataPropertyName = "g_relation";
            this.g_relation.HeaderText = "g_relation";
            this.g_relation.Name = "g_relation";
            this.g_relation.ReadOnly = true;
            this.g_relation.Visible = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Add_32;
            this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.Location = new System.Drawing.Point(20, 42);
            this.btn_new.Name = "btn_new";
            this.btn_new.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_new.Size = new System.Drawing.Size(123, 46);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "NEW";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Salmon;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Image = global::SchoolFeeTrackingSystem.Properties.Resources.Delete32;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(20, 146);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_delete.Size = new System.Drawing.Size(123, 46);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // frm_manageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_manageStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGE STUDENT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_manageStudent_FormClosing);
            this.Load += new System.EventHandler(this.frm_manageStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.TextBox txt_search;
        private DB.SFTS_DBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn LRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn register_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardian_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_relation;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;

    }
}