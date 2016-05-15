namespace SchoolFeeTrackingSystem.Forms
{
    partial class frm_editFee
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_sy2 = new System.Windows.Forms.TextBox();
            this.txt_amountReq = new System.Windows.Forms.TextBox();
            this.txt_sy1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guardian_FeeTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.Guardian_FeeTableAdapter();
            this.student_FeeTableAdapter = new SchoolFeeTrackingSystem.DB.SFTS_DBDataSetTableAdapters.Student_FeeTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.txt_sy2);
            this.panel1.Controls.Add(this.txt_amountReq);
            this.panel1.Controls.Add(this.txt_sy1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_desc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 223);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(219, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Salmon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(222, 162);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(95, 34);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Location = new System.Drawing.Point(121, 162);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(95, 34);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_sy2
            // 
            this.txt_sy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sy2.ForeColor = System.Drawing.Color.DimGray;
            this.txt_sy2.Location = new System.Drawing.Point(240, 73);
            this.txt_sy2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sy2.MaxLength = 4;
            this.txt_sy2.Name = "txt_sy2";
            this.txt_sy2.Size = new System.Drawing.Size(82, 23);
            this.txt_sy2.TabIndex = 5;
            this.txt_sy2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_amountReq
            // 
            this.txt_amountReq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_amountReq.Location = new System.Drawing.Point(130, 109);
            this.txt_amountReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_amountReq.MaxLength = 6;
            this.txt_amountReq.Name = "txt_amountReq";
            this.txt_amountReq.Size = new System.Drawing.Size(82, 23);
            this.txt_amountReq.TabIndex = 6;
            // 
            // txt_sy1
            // 
            this.txt_sy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sy1.ForeColor = System.Drawing.Color.DimGray;
            this.txt_sy1.Location = new System.Drawing.Point(130, 73);
            this.txt_sy1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sy1.MaxLength = 4;
            this.txt_sy1.Name = "txt_sy1";
            this.txt_sy1.Size = new System.Drawing.Size(82, 23);
            this.txt_sy1.TabIndex = 4;
            this.txt_sy1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(29, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount Req:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(92, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SY:";
            // 
            // txt_desc
            // 
            this.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_desc.Location = new System.Drawing.Point(131, 39);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_desc.MaxLength = 45;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(247, 23);
            this.txt_desc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // guardian_FeeTableAdapter
            // 
            this.guardian_FeeTableAdapter.ClearBeforeFill = true;
            // 
            // student_FeeTableAdapter
            // 
            this.student_FeeTableAdapter.ClearBeforeFill = true;
            // 
            // frm_editFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(450, 259);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_editFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDIT FEE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_editFee_FormClosing);
            this.Load += new System.EventHandler(this.frm_editFee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_amountReq;
        private System.Windows.Forms.TextBox txt_sy1;
        private System.Windows.Forms.TextBox txt_sy2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label4;
        private DB.SFTS_DBDataSetTableAdapters.Guardian_FeeTableAdapter guardian_FeeTableAdapter;
        private DB.SFTS_DBDataSetTableAdapters.Student_FeeTableAdapter student_FeeTableAdapter;
    }
}