namespace EnrollmentSystem
{
    partial class Enrollment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enrollment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv_EnrList = new System.Windows.Forms.DataGridView();
            this.lRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLVLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Regform = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tBLENRLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ES_FINAL = new EnrollmentSystem.DB_ES_FINAL();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.cbo_SearchBy = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_format = new System.Windows.Forms.Label();
            this.tBLGLVLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKTBLSECTIONSTBLGLVLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBL_GLVLTableAdapter = new EnrollmentSystem.DB_ES_FINALTableAdapters.TBL_GLVLTableAdapter();
            this.tBL_SECTIONSTableAdapter = new EnrollmentSystem.DB_ES_FINALTableAdapters.TBL_SECTIONSTableAdapter();
            this.tBL_ENR_LISTTableAdapter = new EnrollmentSystem.DB_ES_FINALTableAdapters.TBL_ENR_LISTTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.lbx_ListNames = new System.Windows.Forms.ListBox();
            this.lbl_LimtSec = new System.Windows.Forms.Label();
            this.cbo_Sec = new System.Windows.Forms.ComboBox();
            this.cbo_Glvl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Lrn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SY = new System.Windows.Forms.TextBox();
            this.txt_StudName = new System.Windows.Forms.TextBox();
            this.btn_Enroll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_YR = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EnrList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLENRLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ES_FINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGLVLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLSECTIONSTBLGLVLBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.flowLayoutPanel1.TabIndex = 41;
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
            this.btn_Enrollment.Enabled = false;
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
            this.btn_WdwList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WdwList.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_WdwList.Location = new System.Drawing.Point(2, 499);
            this.btn_WdwList.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_WdwList.Name = "btn_WdwList";
            this.btn_WdwList.Size = new System.Drawing.Size(171, 44);
            this.btn_WdwList.TabIndex = 64;
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
            this.btn_EnrHistory.TabIndex = 65;
            this.btn_EnrHistory.Text = "ENROLLMENT \r\nHISTORY";
            this.btn_EnrHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_EnrHistory.UseVisualStyleBackColor = false;
            this.btn_EnrHistory.Click += new System.EventHandler(this.btn_EnrHistory_Click);
            // 
            // dgv_EnrList
            // 
            this.dgv_EnrList.AllowUserToAddRows = false;
            this.dgv_EnrList.AllowUserToDeleteRows = false;
            this.dgv_EnrList.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EnrList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_EnrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EnrList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lRNDataGridViewTextBoxColumn,
            this.sTUDNAMEDataGridViewTextBoxColumn,
            this.sYDataGridViewTextBoxColumn,
            this.gLVLDataGridViewTextBoxColumn,
            this.sECTIONDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.btn_Regform,
            this.btn_Action});
            this.dgv_EnrList.DataSource = this.tBLENRLISTBindingSource;
            this.dgv_EnrList.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_EnrList.Location = new System.Drawing.Point(183, 218);
            this.dgv_EnrList.Name = "dgv_EnrList";
            this.dgv_EnrList.ReadOnly = true;
            this.dgv_EnrList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EnrList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_EnrList.Size = new System.Drawing.Size(858, 409);
            this.dgv_EnrList.TabIndex = 42;
            this.dgv_EnrList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_EnrList_CellClick);
            // 
            // lRNDataGridViewTextBoxColumn
            // 
            this.lRNDataGridViewTextBoxColumn.DataPropertyName = "LRN";
            this.lRNDataGridViewTextBoxColumn.HeaderText = "LRN";
            this.lRNDataGridViewTextBoxColumn.Name = "lRNDataGridViewTextBoxColumn";
            this.lRNDataGridViewTextBoxColumn.ReadOnly = true;
            this.lRNDataGridViewTextBoxColumn.Width = 91;
            // 
            // sTUDNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUD_NAME";
            this.sTUDNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENT NAME";
            this.sTUDNAMEDataGridViewTextBoxColumn.Name = "sTUDNAMEDataGridViewTextBoxColumn";
            this.sTUDNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTUDNAMEDataGridViewTextBoxColumn.Width = 90;
            // 
            // sYDataGridViewTextBoxColumn
            // 
            this.sYDataGridViewTextBoxColumn.DataPropertyName = "SY";
            this.sYDataGridViewTextBoxColumn.HeaderText = "SY";
            this.sYDataGridViewTextBoxColumn.Name = "sYDataGridViewTextBoxColumn";
            this.sYDataGridViewTextBoxColumn.ReadOnly = true;
            this.sYDataGridViewTextBoxColumn.Width = 91;
            // 
            // gLVLDataGridViewTextBoxColumn
            // 
            this.gLVLDataGridViewTextBoxColumn.DataPropertyName = "GLVL";
            this.gLVLDataGridViewTextBoxColumn.HeaderText = "GRADE LEVEL";
            this.gLVLDataGridViewTextBoxColumn.Name = "gLVLDataGridViewTextBoxColumn";
            this.gLVLDataGridViewTextBoxColumn.ReadOnly = true;
            this.gLVLDataGridViewTextBoxColumn.Width = 90;
            // 
            // sECTIONDataGridViewTextBoxColumn
            // 
            this.sECTIONDataGridViewTextBoxColumn.DataPropertyName = "SECTION";
            this.sECTIONDataGridViewTextBoxColumn.HeaderText = "SECTION";
            this.sECTIONDataGridViewTextBoxColumn.Name = "sECTIONDataGridViewTextBoxColumn";
            this.sECTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECTIONDataGridViewTextBoxColumn.Width = 91;
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            this.dATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATEDataGridViewTextBoxColumn.Width = 90;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTATUSDataGridViewTextBoxColumn.Width = 91;
            // 
            // btn_Regform
            // 
            this.btn_Regform.HeaderText = "";
            this.btn_Regform.Name = "btn_Regform";
            this.btn_Regform.ReadOnly = true;
            this.btn_Regform.Text = "REGFORM";
            this.btn_Regform.UseColumnTextForButtonValue = true;
            this.btn_Regform.Width = 90;
            // 
            // btn_Action
            // 
            this.btn_Action.HeaderText = "";
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.ReadOnly = true;
            this.btn_Action.Text = "WITHDRAW";
            this.btn_Action.UseColumnTextForButtonValue = true;
            this.btn_Action.Width = 91;
            // 
            // tBLENRLISTBindingSource
            // 
            this.tBLENRLISTBindingSource.DataMember = "TBL_ENR_LIST";
            this.tBLENRLISTBindingSource.DataSource = this.dB_ES_FINAL;
            // 
            // dB_ES_FINAL
            // 
            this.dB_ES_FINAL.DataSetName = "DB_ES_FINAL";
            this.dB_ES_FINAL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.Location = new System.Drawing.Point(598, 181);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(71, 27);
            this.btn_Search.TabIndex = 75;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.btn_Register.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.Black;
            this.btn_Register.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Register.Location = new System.Drawing.Point(933, 4);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(108, 47);
            this.btn_Register.TabIndex = 76;
            this.btn_Register.Text = "Register \r\nNew Student";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(305, 185);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(270, 23);
            this.txt_Search.TabIndex = 79;
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Brown;
            this.label.Location = new System.Drawing.Point(183, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(244, 25);
            this.label.TabIndex = 88;
            this.label.Text = "STUDENT ENROLLED LIST";
            // 
            // cbo_SearchBy
            // 
            this.cbo_SearchBy.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbo_SearchBy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_SearchBy.FormattingEnabled = true;
            this.cbo_SearchBy.Items.AddRange(new object[] {
            "ALL",
            "LRN",
            "STUDENT NAME"});
            this.cbo_SearchBy.Location = new System.Drawing.Point(183, 183);
            this.cbo_SearchBy.Name = "cbo_SearchBy";
            this.cbo_SearchBy.Size = new System.Drawing.Size(116, 25);
            this.cbo_SearchBy.TabIndex = 90;
            this.cbo_SearchBy.Text = "Search By: ";
            this.cbo_SearchBy.SelectedIndexChanged += new System.EventHandler(this.cbo_SearchBy_SelectedIndexChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.Location = new System.Drawing.Point(687, 181);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(71, 27);
            this.btn_Clear.TabIndex = 91;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_format
            // 
            this.lbl_format.AutoSize = true;
            this.lbl_format.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_format.ForeColor = System.Drawing.Color.Brown;
            this.lbl_format.Location = new System.Drawing.Point(307, 166);
            this.lbl_format.Name = "lbl_format";
            this.lbl_format.Size = new System.Drawing.Size(257, 16);
            this.lbl_format.TabIndex = 92;
            this.lbl_format.Text = "[Surname], [Firstname] [Middlename] [Ext]";
            this.lbl_format.Visible = false;
            // 
            // tBLGLVLBindingSource
            // 
            this.tBLGLVLBindingSource.DataMember = "TBL_GLVL";
            this.tBLGLVLBindingSource.DataSource = this.dB_ES_FINAL;
            // 
            // fKTBLSECTIONSTBLGLVLBindingSource
            // 
            this.fKTBLSECTIONSTBLGLVLBindingSource.DataMember = "FK_TBL_SECTIONS_TBL_GLVL";
            this.fKTBLSECTIONSTBLGLVLBindingSource.DataSource = this.tBLGLVLBindingSource;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_count.Location = new System.Drawing.Point(293, 633);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(15, 16);
            this.lbl_count.TabIndex = 142;
            this.lbl_count.Text = "0";
            this.lbl_count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(180, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 141;
            this.label8.Text = "Record(s) Count:\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBL_GLVLTableAdapter
            // 
            this.tBL_GLVLTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_SECTIONSTableAdapter
            // 
            this.tBL_SECTIONSTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_ENR_LISTTableAdapter
            // 
            this.tBL_ENR_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(198, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 144;
            this.label9.Text = "Student Name:";
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_SearchName.Location = new System.Drawing.Point(312, 43);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(277, 23);
            this.txt_SearchName.TabIndex = 143;
            this.txt_SearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SearchName_KeyDown);
            // 
            // lbx_ListNames
            // 
            this.lbx_ListNames.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_ListNames.FormattingEnabled = true;
            this.lbx_ListNames.ItemHeight = 17;
            this.lbx_ListNames.Location = new System.Drawing.Point(312, 66);
            this.lbx_ListNames.Name = "lbx_ListNames";
            this.lbx_ListNames.Size = new System.Drawing.Size(277, 72);
            this.lbx_ListNames.TabIndex = 107;
            this.lbx_ListNames.Visible = false;
            this.lbx_ListNames.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbx_ListNames_MouseClick);
            // 
            // lbl_LimtSec
            // 
            this.lbl_LimtSec.AutoSize = true;
            this.lbl_LimtSec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LimtSec.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_LimtSec.Location = new System.Drawing.Point(715, 132);
            this.lbl_LimtSec.Name = "lbl_LimtSec";
            this.lbl_LimtSec.Size = new System.Drawing.Size(141, 32);
            this.lbl_LimtSec.TabIndex = 168;
            this.lbl_LimtSec.Text = "NO SLOTS available \r\nfor this section";
            this.lbl_LimtSec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_LimtSec.Visible = false;
            // 
            // cbo_Sec
            // 
            this.cbo_Sec.DataSource = this.fKTBLSECTIONSTBLGLVLBindingSource;
            this.cbo_Sec.DisplayMember = "SECTION_NAME";
            this.cbo_Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sec.Enabled = false;
            this.cbo_Sec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Sec.FormattingEnabled = true;
            this.cbo_Sec.Location = new System.Drawing.Point(718, 105);
            this.cbo_Sec.Name = "cbo_Sec";
            this.cbo_Sec.Size = new System.Drawing.Size(123, 24);
            this.cbo_Sec.TabIndex = 167;
            this.cbo_Sec.ValueMember = "SECTION_NAME";
            this.cbo_Sec.SelectionChangeCommitted += new System.EventHandler(this.cbo_Sec_SelectionChangeCommitted);
            // 
            // cbo_Glvl
            // 
            this.cbo_Glvl.DataSource = this.tBLGLVLBindingSource;
            this.cbo_Glvl.DisplayMember = "GLVL";
            this.cbo_Glvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Glvl.Enabled = false;
            this.cbo_Glvl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Glvl.FormattingEnabled = true;
            this.cbo_Glvl.Location = new System.Drawing.Point(718, 73);
            this.cbo_Glvl.Name = "cbo_Glvl";
            this.cbo_Glvl.Size = new System.Drawing.Size(123, 24);
            this.cbo_Glvl.TabIndex = 166;
            this.cbo_Glvl.ValueMember = "ID";
            this.cbo_Glvl.SelectionChangeCommitted += new System.EventHandler(this.cbo_Glvl_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(613, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 165;
            this.label6.Text = "GRADE LEVEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(644, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 164;
            this.label5.Text = "SECTION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(267, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 163;
            this.label3.Text = "LRN:";
            // 
            // txt_Lrn
            // 
            this.txt_Lrn.Enabled = false;
            this.txt_Lrn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lrn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Lrn.Location = new System.Drawing.Point(312, 73);
            this.txt_Lrn.Name = "txt_Lrn";
            this.txt_Lrn.Size = new System.Drawing.Size(161, 23);
            this.txt_Lrn.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(278, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 161;
            this.label4.Text = "SY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(198, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 160;
            this.label1.Text = "Student Name:";
            // 
            // txt_SY
            // 
            this.txt_SY.Enabled = false;
            this.txt_SY.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SY.Location = new System.Drawing.Point(312, 132);
            this.txt_SY.Name = "txt_SY";
            this.txt_SY.Size = new System.Drawing.Size(83, 23);
            this.txt_SY.TabIndex = 159;
            // 
            // txt_StudName
            // 
            this.txt_StudName.Enabled = false;
            this.txt_StudName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudName.Location = new System.Drawing.Point(312, 102);
            this.txt_StudName.Name = "txt_StudName";
            this.txt_StudName.Size = new System.Drawing.Size(277, 23);
            this.txt_StudName.TabIndex = 158;
            // 
            // btn_Enroll
            // 
            this.btn_Enroll.BackColor = System.Drawing.Color.Transparent;
            this.btn_Enroll.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enroll.ForeColor = System.Drawing.Color.Black;
            this.btn_Enroll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Enroll.Location = new System.Drawing.Point(864, 79);
            this.btn_Enroll.Name = "btn_Enroll";
            this.btn_Enroll.Size = new System.Drawing.Size(71, 46);
            this.btn_Enroll.TabIndex = 157;
            this.btn_Enroll.Text = "Enroll ";
            this.btn_Enroll.UseVisualStyleBackColor = false;
            this.btn_Enroll.Click += new System.EventHandler(this.btn_Enroll_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(433, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 170;
            this.label7.Text = "SY:";
            // 
            // lbl_YR
            // 
            this.lbl_YR.AutoSize = true;
            this.lbl_YR.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YR.ForeColor = System.Drawing.Color.Brown;
            this.lbl_YR.Location = new System.Drawing.Point(469, 13);
            this.lbl_YR.Name = "lbl_YR";
            this.lbl_YR.Size = new System.Drawing.Size(90, 25);
            this.lbl_YR.TabIndex = 169;
            this.lbl_YR.Text = "---- ----";
            // 
            // Enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 655);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_YR);
            this.Controls.Add(this.lbx_ListNames);
            this.Controls.Add(this.lbl_LimtSec);
            this.Controls.Add(this.cbo_Sec);
            this.Controls.Add(this.cbo_Glvl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Lrn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SY);
            this.Controls.Add(this.txt_StudName);
            this.Controls.Add(this.btn_Enroll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_SearchName);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_format);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.cbo_SearchBy);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_EnrList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Enrollment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.Enrollment_Load);
            this.Click += new System.EventHandler(this.Enrollment_Click);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EnrList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLENRLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ES_FINAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGLVLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLSECTIONSTBLGLVLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Enrollment;
        private System.Windows.Forms.Button btn_Masterlist;
        private System.Windows.Forms.Button btn_Subjects;
        private System.Windows.Forms.Button btn_ClassLists;
        private System.Windows.Forms.Button btn_SchoolYr;
        private System.Windows.Forms.Button btn_Sections;
        private System.Windows.Forms.Button btn_WdwList;
        private System.Windows.Forms.DataGridView dgv_EnrList;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbo_SearchBy;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_format;
        private System.Windows.Forms.Button btn_EnrHistory;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label label8;
        private DB_ES_FINAL dB_ES_FINAL;
        private System.Windows.Forms.BindingSource tBLGLVLBindingSource;
        private DB_ES_FINALTableAdapters.TBL_GLVLTableAdapter tBL_GLVLTableAdapter;
        private System.Windows.Forms.BindingSource fKTBLSECTIONSTBLGLVLBindingSource;
        private DB_ES_FINALTableAdapters.TBL_SECTIONSTableAdapter tBL_SECTIONSTableAdapter;
        private System.Windows.Forms.BindingSource tBLENRLISTBindingSource;
        private DB_ES_FINALTableAdapters.TBL_ENR_LISTTableAdapter tBL_ENR_LISTTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.ListBox lbx_ListNames;
        private System.Windows.Forms.Label lbl_LimtSec;
        private System.Windows.Forms.ComboBox cbo_Sec;
        private System.Windows.Forms.ComboBox cbo_Glvl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Lrn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SY;
        private System.Windows.Forms.TextBox txt_StudName;
        private System.Windows.Forms.Button btn_Enroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn lRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLVLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Regform;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Action;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_YR;
    }
}