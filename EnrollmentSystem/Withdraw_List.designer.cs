namespace EnrollmentSystem
{
    partial class Withdraw_List
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw_List));
            this.btn_Print = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cbo_SearchBy = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_Enrollment = new System.Windows.Forms.Button();
            this.btn_Masterlist = new System.Windows.Forms.Button();
            this.btn_Subjects = new System.Windows.Forms.Button();
            this.btn_Sections = new System.Windows.Forms.Button();
            this.btn_ClassLists = new System.Windows.Forms.Button();
            this.btn_WdwList = new System.Windows.Forms.Button();
            this.btn_SchoolYr = new System.Windows.Forms.Button();
            this.btn_EnrHistory = new System.Windows.Forms.Button();
            this.lbl_YR = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Wdw = new System.Windows.Forms.DataGridView();
            this.lRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLVLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEWDWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLWDWLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ES_FINAL = new EnrollmentSystem.DB_ES_FINAL();
            this.tBL_WDW_LISTTableAdapter = new EnrollmentSystem.DB_ES_FINALTableAdapters.TBL_WDW_LISTTableAdapter();
            this.lbl_format = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Wdw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWDWLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ES_FINAL)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(919, 191);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(119, 39);
            this.btn_Print.TabIndex = 123;
            this.btn_Print.Text = "&PRINT PREVIEW";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 111;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.Location = new System.Drawing.Point(712, 197);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(71, 27);
            this.btn_Search.TabIndex = 127;
            this.btn_Search.Text = "Seach";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(306, 199);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(400, 23);
            this.txt_Search.TabIndex = 126;
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // cbo_SearchBy
            // 
            this.cbo_SearchBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_SearchBy.FormattingEnabled = true;
            this.cbo_SearchBy.Items.AddRange(new object[] {
            "ALL",
            "LRN",
            "STUDENT NAME",
            "DATE"});
            this.cbo_SearchBy.Location = new System.Drawing.Point(183, 199);
            this.cbo_SearchBy.Name = "cbo_SearchBy";
            this.cbo_SearchBy.Size = new System.Drawing.Size(116, 25);
            this.cbo_SearchBy.TabIndex = 125;
            this.cbo_SearchBy.Text = "Search By: ";
            this.cbo_SearchBy.SelectedIndexChanged += new System.EventHandler(this.cbo_SearchBy_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.btn_Dashboard);
            this.flowLayoutPanel1.Controls.Add(this.btn_Enrollment);
            this.flowLayoutPanel1.Controls.Add(this.btn_Masterlist);
            this.flowLayoutPanel1.Controls.Add(this.btn_Subjects);
            this.flowLayoutPanel1.Controls.Add(this.btn_Sections);
            this.flowLayoutPanel1.Controls.Add(this.btn_ClassLists);
            this.flowLayoutPanel1.Controls.Add(this.btn_WdwList);
            this.flowLayoutPanel1.Controls.Add(this.btn_SchoolYr);
            this.flowLayoutPanel1.Controls.Add(this.btn_EnrHistory);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 655);
            this.flowLayoutPanel1.TabIndex = 128;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(2, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(174, 175);
            this.panel5.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "WELCOME ADMIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.Teal;
            this.btn_Dashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Dashboard.Location = new System.Drawing.Point(2, 187);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(171, 44);
            this.btn_Dashboard.TabIndex = 53;
            this.btn_Dashboard.Text = "DASHBOARD";
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_Enrollment
            // 
            this.btn_Enrollment.BackColor = System.Drawing.Color.Teal;
            this.btn_Enrollment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enrollment.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Enrollment.Location = new System.Drawing.Point(2, 239);
            this.btn_Enrollment.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Enrollment.Name = "btn_Enrollment";
            this.btn_Enrollment.Size = new System.Drawing.Size(171, 44);
            this.btn_Enrollment.TabIndex = 54;
            this.btn_Enrollment.Text = "ENROLLMENT";
            this.btn_Enrollment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Enrollment.UseVisualStyleBackColor = false;
            this.btn_Enrollment.Click += new System.EventHandler(this.btn_Enrollment_Click);
            // 
            // btn_Masterlist
            // 
            this.btn_Masterlist.BackColor = System.Drawing.Color.Teal;
            this.btn_Masterlist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Masterlist.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Masterlist.Location = new System.Drawing.Point(2, 291);
            this.btn_Masterlist.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Masterlist.Name = "btn_Masterlist";
            this.btn_Masterlist.Size = new System.Drawing.Size(171, 44);
            this.btn_Masterlist.TabIndex = 55;
            this.btn_Masterlist.Text = "MASTERLIST";
            this.btn_Masterlist.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Masterlist.UseVisualStyleBackColor = false;
            this.btn_Masterlist.Click += new System.EventHandler(this.btn_Masterlist_Click);
            // 
            // btn_Subjects
            // 
            this.btn_Subjects.BackColor = System.Drawing.Color.Teal;
            this.btn_Subjects.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subjects.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Subjects.Location = new System.Drawing.Point(2, 343);
            this.btn_Subjects.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Subjects.Name = "btn_Subjects";
            this.btn_Subjects.Size = new System.Drawing.Size(171, 44);
            this.btn_Subjects.TabIndex = 57;
            this.btn_Subjects.Text = "SUBJECTS";
            this.btn_Subjects.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Subjects.UseVisualStyleBackColor = false;
            this.btn_Subjects.Click += new System.EventHandler(this.btn_Subjects_Click);
            // 
            // btn_Sections
            // 
            this.btn_Sections.BackColor = System.Drawing.Color.Teal;
            this.btn_Sections.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sections.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Sections.Location = new System.Drawing.Point(2, 395);
            this.btn_Sections.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Sections.Name = "btn_Sections";
            this.btn_Sections.Size = new System.Drawing.Size(171, 44);
            this.btn_Sections.TabIndex = 62;
            this.btn_Sections.Text = "SECTIONS";
            this.btn_Sections.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Sections.UseVisualStyleBackColor = false;
            this.btn_Sections.Click += new System.EventHandler(this.btn_Sections_Click);
            // 
            // btn_ClassLists
            // 
            this.btn_ClassLists.BackColor = System.Drawing.Color.Teal;
            this.btn_ClassLists.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClassLists.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_ClassLists.Location = new System.Drawing.Point(2, 447);
            this.btn_ClassLists.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_ClassLists.Name = "btn_ClassLists";
            this.btn_ClassLists.Size = new System.Drawing.Size(171, 44);
            this.btn_ClassLists.TabIndex = 58;
            this.btn_ClassLists.Text = "CLASS LISTS";
            this.btn_ClassLists.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ClassLists.UseVisualStyleBackColor = false;
            this.btn_ClassLists.Click += new System.EventHandler(this.btn_ClassLists_Click);
            // 
            // btn_WdwList
            // 
            this.btn_WdwList.BackColor = System.Drawing.Color.Teal;
            this.btn_WdwList.Enabled = false;
            this.btn_WdwList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WdwList.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_WdwList.Location = new System.Drawing.Point(2, 499);
            this.btn_WdwList.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_WdwList.Name = "btn_WdwList";
            this.btn_WdwList.Size = new System.Drawing.Size(171, 44);
            this.btn_WdwList.TabIndex = 63;
            this.btn_WdwList.Text = "WITHDRAW LIST";
            this.btn_WdwList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_WdwList.UseVisualStyleBackColor = false;
            this.btn_WdwList.Click += new System.EventHandler(this.btn_WdwList_Click);
            // 
            // btn_SchoolYr
            // 
            this.btn_SchoolYr.BackColor = System.Drawing.Color.Teal;
            this.btn_SchoolYr.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SchoolYr.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_SchoolYr.Location = new System.Drawing.Point(2, 551);
            this.btn_SchoolYr.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_SchoolYr.Name = "btn_SchoolYr";
            this.btn_SchoolYr.Size = new System.Drawing.Size(171, 44);
            this.btn_SchoolYr.TabIndex = 56;
            this.btn_SchoolYr.Text = "SCHOOL YEAR";
            this.btn_SchoolYr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_SchoolYr.UseVisualStyleBackColor = false;
            this.btn_SchoolYr.Click += new System.EventHandler(this.btn_SchoolYr_Click);
            // 
            // btn_EnrHistory
            // 
            this.btn_EnrHistory.BackColor = System.Drawing.Color.Teal;
            this.btn_EnrHistory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnrHistory.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_EnrHistory.Location = new System.Drawing.Point(2, 603);
            this.btn_EnrHistory.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_EnrHistory.Name = "btn_EnrHistory";
            this.btn_EnrHistory.Size = new System.Drawing.Size(171, 44);
            this.btn_EnrHistory.TabIndex = 129;
            this.btn_EnrHistory.Text = "ENROLLMENT \r\nHISTORY";
            this.btn_EnrHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_EnrHistory.UseVisualStyleBackColor = false;
            this.btn_EnrHistory.Click += new System.EventHandler(this.btn_EnrHistory_Click);
            // 
            // lbl_YR
            // 
            this.lbl_YR.AutoSize = true;
            this.lbl_YR.BackColor = System.Drawing.Color.Transparent;
            this.lbl_YR.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YR.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_YR.Location = new System.Drawing.Point(253, 64);
            this.lbl_YR.Name = "lbl_YR";
            this.lbl_YR.Size = new System.Drawing.Size(90, 25);
            this.lbl_YR.TabIndex = 130;
            this.lbl_YR.Text = "---- ----";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkGray;
            this.label.Location = new System.Drawing.Point(205, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(269, 25);
            this.label.TabIndex = 129;
            this.label.Text = "WITHDRAWN STUDENT LIST";
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_count.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_count.Location = new System.Drawing.Point(296, 629);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(15, 16);
            this.lbl_count.TabIndex = 144;
            this.lbl_count.Text = "0";
            this.lbl_count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(183, 629);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 143;
            this.label8.Text = "Record(s) Count:\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_Wdw
            // 
            this.dgv_Wdw.AllowUserToAddRows = false;
            this.dgv_Wdw.AllowUserToDeleteRows = false;
            this.dgv_Wdw.AutoGenerateColumns = false;
            this.dgv_Wdw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Wdw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lRNDataGridViewTextBoxColumn,
            this.sTUDNAMEDataGridViewTextBoxColumn,
            this.sYDataGridViewTextBoxColumn,
            this.gLVLDataGridViewTextBoxColumn,
            this.rEASONDataGridViewTextBoxColumn,
            this.dATEWDWDataGridViewTextBoxColumn});
            this.dgv_Wdw.DataSource = this.tBLWDWLISTBindingSource;
            this.dgv_Wdw.Location = new System.Drawing.Point(183, 239);
            this.dgv_Wdw.Name = "dgv_Wdw";
            this.dgv_Wdw.ReadOnly = true;
            this.dgv_Wdw.Size = new System.Drawing.Size(855, 387);
            this.dgv_Wdw.TabIndex = 145;
            // 
            // lRNDataGridViewTextBoxColumn
            // 
            this.lRNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lRNDataGridViewTextBoxColumn.DataPropertyName = "LRN";
            this.lRNDataGridViewTextBoxColumn.HeaderText = "LRN";
            this.lRNDataGridViewTextBoxColumn.Name = "lRNDataGridViewTextBoxColumn";
            this.lRNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUDNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTUDNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUD_NAME";
            this.sTUDNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENT NAME";
            this.sTUDNAMEDataGridViewTextBoxColumn.Name = "sTUDNAMEDataGridViewTextBoxColumn";
            this.sTUDNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sYDataGridViewTextBoxColumn
            // 
            this.sYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sYDataGridViewTextBoxColumn.DataPropertyName = "SY";
            this.sYDataGridViewTextBoxColumn.HeaderText = "SY";
            this.sYDataGridViewTextBoxColumn.Name = "sYDataGridViewTextBoxColumn";
            this.sYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gLVLDataGridViewTextBoxColumn
            // 
            this.gLVLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gLVLDataGridViewTextBoxColumn.DataPropertyName = "GLVL";
            this.gLVLDataGridViewTextBoxColumn.HeaderText = "GRADE LEVEL";
            this.gLVLDataGridViewTextBoxColumn.Name = "gLVLDataGridViewTextBoxColumn";
            this.gLVLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEASONDataGridViewTextBoxColumn
            // 
            this.rEASONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rEASONDataGridViewTextBoxColumn.DataPropertyName = "REASON";
            this.rEASONDataGridViewTextBoxColumn.HeaderText = "REASON";
            this.rEASONDataGridViewTextBoxColumn.Name = "rEASONDataGridViewTextBoxColumn";
            this.rEASONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEWDWDataGridViewTextBoxColumn
            // 
            this.dATEWDWDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dATEWDWDataGridViewTextBoxColumn.DataPropertyName = "DATE_WDW";
            this.dATEWDWDataGridViewTextBoxColumn.HeaderText = "DATE WITHDRAWN";
            this.dATEWDWDataGridViewTextBoxColumn.Name = "dATEWDWDataGridViewTextBoxColumn";
            this.dATEWDWDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBLWDWLISTBindingSource
            // 
            this.tBLWDWLISTBindingSource.DataMember = "TBL_WDW_LIST";
            this.tBLWDWLISTBindingSource.DataSource = this.dB_ES_FINAL;
            // 
            // dB_ES_FINAL
            // 
            this.dB_ES_FINAL.DataSetName = "DB_ES_FINAL";
            this.dB_ES_FINAL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_WDW_LISTTableAdapter
            // 
            this.tBL_WDW_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_format
            // 
            this.lbl_format.AutoSize = true;
            this.lbl_format.BackColor = System.Drawing.Color.Transparent;
            this.lbl_format.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_format.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_format.Location = new System.Drawing.Point(306, 180);
            this.lbl_format.Name = "lbl_format";
            this.lbl_format.Size = new System.Drawing.Size(257, 16);
            this.lbl_format.TabIndex = 146;
            this.lbl_format.Text = "[Surname], [Firstname] [Middlename] [Ext]";
            this.lbl_format.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(205, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 147;
            this.label1.Text = "SY:";
            // 
            // Withdraw_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::EnrollmentSystem.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_format);
            this.Controls.Add(this.dgv_Wdw);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_YR);
            this.Controls.Add(this.label);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cbo_SearchBy);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Withdraw_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment System ►Withdraw List";
            this.Load += new System.EventHandler(this.Withdraw_List_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Wdw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLWDWLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ES_FINAL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox cbo_SearchBy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Enrollment;
        private System.Windows.Forms.Button btn_Masterlist;
        private System.Windows.Forms.Button btn_Subjects;
        private System.Windows.Forms.Button btn_Sections;
        private System.Windows.Forms.Button btn_ClassLists;
        private System.Windows.Forms.Button btn_WdwList;
        private System.Windows.Forms.Button btn_SchoolYr;
        private System.Windows.Forms.Button btn_EnrHistory;
        private System.Windows.Forms.Label lbl_YR;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_Wdw;
        private DB_ES_FINAL dB_ES_FINAL;
        private System.Windows.Forms.BindingSource tBLWDWLISTBindingSource;
        private DB_ES_FINALTableAdapters.TBL_WDW_LISTTableAdapter tBL_WDW_LISTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLVLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEWDWDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_format;
        private System.Windows.Forms.Label label1;
    }
}