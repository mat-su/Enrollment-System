namespace EnrollmentSystem
{
    partial class WithdrawalForm
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
            this.pnl_withdrawal_form = new System.Windows.Forms.Panel();
            this.lbl_specify = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_SY = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Glvl = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_LRN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_others = new System.Windows.Forms.CheckBox();
            this.chb_change = new System.Windows.Forms.CheckBox();
            this.chb_tran = new System.Windows.Forms.CheckBox();
            this.chb_Ill = new System.Windows.Forms.CheckBox();
            this.pnl_Reason = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_withdrawal_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_withdrawal_form
            // 
            this.pnl_withdrawal_form.BackColor = System.Drawing.Color.Azure;
            this.pnl_withdrawal_form.Controls.Add(this.lbl_specify);
            this.pnl_withdrawal_form.Controls.Add(this.txt_reason);
            this.pnl_withdrawal_form.Controls.Add(this.label8);
            this.pnl_withdrawal_form.Controls.Add(this.dtp_date);
            this.pnl_withdrawal_form.Controls.Add(this.lbl_SY);
            this.pnl_withdrawal_form.Controls.Add(this.label7);
            this.pnl_withdrawal_form.Controls.Add(this.lbl_Glvl);
            this.pnl_withdrawal_form.Controls.Add(this.lbl_FullName);
            this.pnl_withdrawal_form.Controls.Add(this.lbl_LRN);
            this.pnl_withdrawal_form.Controls.Add(this.label5);
            this.pnl_withdrawal_form.Controls.Add(this.chb_others);
            this.pnl_withdrawal_form.Controls.Add(this.chb_change);
            this.pnl_withdrawal_form.Controls.Add(this.chb_tran);
            this.pnl_withdrawal_form.Controls.Add(this.chb_Ill);
            this.pnl_withdrawal_form.Controls.Add(this.pnl_Reason);
            this.pnl_withdrawal_form.Controls.Add(this.btn_cancel);
            this.pnl_withdrawal_form.Controls.Add(this.btn_withdraw);
            this.pnl_withdrawal_form.Controls.Add(this.label6);
            this.pnl_withdrawal_form.Controls.Add(this.label4);
            this.pnl_withdrawal_form.Controls.Add(this.label3);
            this.pnl_withdrawal_form.Controls.Add(this.label1);
            this.pnl_withdrawal_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_withdrawal_form.Location = new System.Drawing.Point(0, 0);
            this.pnl_withdrawal_form.Name = "pnl_withdrawal_form";
            this.pnl_withdrawal_form.Size = new System.Drawing.Size(730, 401);
            this.pnl_withdrawal_form.TabIndex = 78;
            // 
            // lbl_specify
            // 
            this.lbl_specify.AutoSize = true;
            this.lbl_specify.BackColor = System.Drawing.Color.White;
            this.lbl_specify.ForeColor = System.Drawing.Color.Red;
            this.lbl_specify.Location = new System.Drawing.Point(245, 280);
            this.lbl_specify.Name = "lbl_specify";
            this.lbl_specify.Size = new System.Drawing.Size(80, 13);
            this.lbl_specify.TabIndex = 173;
            this.lbl_specify.Text = "Please Specify:";
            this.lbl_specify.Visible = false;
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(330, 277);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(206, 20);
            this.txt_reason.TabIndex = 172;
            this.txt_reason.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 168;
            this.label8.Text = "Date:";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "MM/dd/yyyy";
            this.dtp_date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(110, 53);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(105, 26);
            this.dtp_date.TabIndex = 167;
            this.dtp_date.Value = new System.DateTime(2020, 3, 11, 0, 0, 0, 0);
            // 
            // lbl_SY
            // 
            this.lbl_SY.AutoSize = true;
            this.lbl_SY.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SY.Location = new System.Drawing.Point(155, 128);
            this.lbl_SY.Name = "lbl_SY";
            this.lbl_SY.Size = new System.Drawing.Size(38, 16);
            this.lbl_SY.TabIndex = 166;
            this.lbl_SY.Text = "------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 165;
            this.label7.Text = "School Year:";
            // 
            // lbl_Glvl
            // 
            this.lbl_Glvl.AutoSize = true;
            this.lbl_Glvl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Glvl.Location = new System.Drawing.Point(430, 128);
            this.lbl_Glvl.Name = "lbl_Glvl";
            this.lbl_Glvl.Size = new System.Drawing.Size(38, 16);
            this.lbl_Glvl.TabIndex = 164;
            this.lbl_Glvl.Text = "------";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(441, 96);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(38, 16);
            this.lbl_FullName.TabIndex = 163;
            this.lbl_FullName.Text = "------";
            // 
            // lbl_LRN
            // 
            this.lbl_LRN.AutoSize = true;
            this.lbl_LRN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LRN.Location = new System.Drawing.Point(97, 96);
            this.lbl_LRN.Name = "lbl_LRN";
            this.lbl_LRN.Size = new System.Drawing.Size(38, 16);
            this.lbl_LRN.TabIndex = 162;
            this.lbl_LRN.Text = "------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 19);
            this.label5.TabIndex = 161;
            this.label5.Text = "W I T H D R A W A L    F O R M\r\n";
            // 
            // chb_others
            // 
            this.chb_others.AutoSize = true;
            this.chb_others.BackColor = System.Drawing.Color.White;
            this.chb_others.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_others.Location = new System.Drawing.Point(246, 250);
            this.chb_others.Name = "chb_others";
            this.chb_others.Size = new System.Drawing.Size(68, 21);
            this.chb_others.TabIndex = 160;
            this.chb_others.Text = "Others";
            this.chb_others.UseVisualStyleBackColor = false;
            this.chb_others.CheckedChanged += new System.EventHandler(this.chb_others_CheckedChanged);
            // 
            // chb_change
            // 
            this.chb_change.AutoSize = true;
            this.chb_change.BackColor = System.Drawing.Color.White;
            this.chb_change.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_change.Location = new System.Drawing.Point(246, 220);
            this.chb_change.Name = "chb_change";
            this.chb_change.Size = new System.Drawing.Size(193, 21);
            this.chb_change.TabIndex = 157;
            this.chb_change.Text = "Change of Home Address";
            this.chb_change.UseVisualStyleBackColor = false;
            this.chb_change.CheckedChanged += new System.EventHandler(this.chb_change_CheckedChanged);
            // 
            // chb_tran
            // 
            this.chb_tran.AutoSize = true;
            this.chb_tran.BackColor = System.Drawing.Color.White;
            this.chb_tran.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_tran.Location = new System.Drawing.Point(246, 165);
            this.chb_tran.Name = "chb_tran";
            this.chb_tran.Size = new System.Drawing.Size(98, 21);
            this.chb_tran.TabIndex = 158;
            this.chb_tran.Text = "Transferirng";
            this.chb_tran.UseVisualStyleBackColor = false;
            this.chb_tran.CheckedChanged += new System.EventHandler(this.chb_tran_CheckedChanged);
            // 
            // chb_Ill
            // 
            this.chb_Ill.AutoSize = true;
            this.chb_Ill.BackColor = System.Drawing.Color.White;
            this.chb_Ill.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Ill.Location = new System.Drawing.Point(246, 192);
            this.chb_Ill.Name = "chb_Ill";
            this.chb_Ill.Size = new System.Drawing.Size(62, 21);
            this.chb_Ill.TabIndex = 159;
            this.chb_Ill.Text = "Illness";
            this.chb_Ill.UseVisualStyleBackColor = false;
            this.chb_Ill.CheckedChanged += new System.EventHandler(this.chb_Ill_CheckedChanged);
            // 
            // pnl_Reason
            // 
            this.pnl_Reason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.pnl_Reason.BackColor = System.Drawing.Color.White;
            this.pnl_Reason.Enabled = false;
            this.pnl_Reason.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Reason.Location = new System.Drawing.Point(213, 160);
            this.pnl_Reason.Multiline = true;
            this.pnl_Reason.Name = "pnl_Reason";
            this.pnl_Reason.ReadOnly = true;
            this.pnl_Reason.Size = new System.Drawing.Size(382, 155);
            this.pnl_Reason.TabIndex = 156;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(585, 357);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(114, 29);
            this.btn_cancel.TabIndex = 155;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw.Location = new System.Drawing.Point(314, 336);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(114, 29);
            this.btn_withdraw.TabIndex = 154;
            this.btn_withdraw.Text = "WITHDRAW";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 144;
            this.label6.Text = "Reasons for leaving:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 146;
            this.label4.Text = "Grade Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 147;
            this.label3.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 148;
            this.label1.Text = "LRN:";
            // 
            // WithdrawalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 401);
            this.Controls.Add(this.pnl_withdrawal_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WithdrawalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_withdrawal_form.ResumeLayout(false);
            this.pnl_withdrawal_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_withdrawal_form;
        private System.Windows.Forms.Label lbl_specify;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lbl_SY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Glvl;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_LRN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chb_others;
        private System.Windows.Forms.CheckBox chb_change;
        private System.Windows.Forms.CheckBox chb_tran;
        private System.Windows.Forms.CheckBox chb_Ill;
        private System.Windows.Forms.TextBox pnl_Reason;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}