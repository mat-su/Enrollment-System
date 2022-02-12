namespace EnrollmentSystem.Revised_Forms
{
    partial class ClassList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassList));
            this.btn_SchoolYr = new System.Windows.Forms.Button();
            this.btn_ClassLists = new System.Windows.Forms.Button();
            this.btn_Subjects = new System.Windows.Forms.Button();
            this.btn_Masterlist = new System.Windows.Forms.Button();
            this.btn_Enrollment = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Sections = new System.Windows.Forms.Button();
            this.btn_WdwList = new System.Windows.Forms.Button();
            this.btn_EnrHistory = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lbl_YR = new System.Windows.Forms.Label();
            this.dgv_ClassList = new System.Windows.Forms.DataGridView();
            this.lRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLVLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLENRLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ES_FINAL = new EnrollmentSystem.DB_ES_FINAL();
            this.cbo_Sec = new System.Windows.Forms.ComboBox();
            this.cbo_Glvl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_LimtSec = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBL_ENR_LISTTableAdapter = new EnrollmentSystem.DB_ES_FINALTableAdapters.TBL_ENR_LISTTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClassList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLENRLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ES_FINAL)).BeginInit();
            this.SuspendLayout();
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
            // btn_ClassLists
            // 
            this.btn_ClassLists.BackColor = System.Drawing.Color.Teal;
            this.btn_ClassLists.Enabled = false;
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
            this.flowLayoutPanel1.TabIndex = 42;
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
            // btn_EnrHistory
            // 
            this.btn_EnrHistory.BackColor = System.Drawing.Color.Teal;
            this.btn_EnrHistory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnrHistory.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_EnrHistory.Location = new System.Drawing.Point(2, 603);
            this.btn_EnrHistory.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_EnrHistory.Name = "btn_EnrHistory";
            this.btn_EnrHistory.Size = new System.Drawing.Size(171, 44);
            this.btn_EnrHistory.TabIndex = 66;
            this.btn_EnrHistory.Text = "ENROLLMENT \r\nHISTORY";
            this.btn_EnrHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_EnrHistory.UseVisualStyleBackColor = false;
            this.btn_EnrHistory.Click += new System.EventHandler(this.btn_EnrHistory_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Brown;
            this.label.Location = new System.Drawing.Point(194, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 25);
            this.label.TabIndex = 89;
            this.label.Text = "CLASS LISTS";
            // 
            // lbl_YR
            // 
            this.lbl_YR.AutoSize = true;
            this.lbl_YR.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YR.ForeColor = System.Drawing.Color.Brown;
            this.lbl_YR.Location = new System.Drawing.Point(363, 13);
            this.lbl_YR.Name = "lbl_YR";
            this.lbl_YR.Size = new System.Drawing.Size(90, 25);
            this.lbl_YR.TabIndex = 90;
            this.lbl_YR.Text = "---- ----";
            // 
            // dgv_ClassList
            // 
            this.dgv_ClassList.AllowUserToAddRows = false;
            this.dgv_ClassList.AllowUserToDeleteRows = false;
            this.dgv_ClassList.AutoGenerateColumns = false;
            this.dgv_ClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ClassList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lRNDataGridViewTextBoxColumn,
            this.sTUDNAMEDataGridViewTextBoxColumn,
            this.sYDataGridViewTextBoxColumn,
            this.gLVLDataGridViewTextBoxColumn,
            this.sECTIONDataGridViewTextBoxColumn});
            this.dgv_ClassList.DataSource = this.tBLENRLISTBindingSource;
            this.dgv_ClassList.Location = new System.Drawing.Point(183, 114);
            this.dgv_ClassList.Name = "dgv_ClassList";
            this.dgv_ClassList.ReadOnly = true;
            this.dgv_ClassList.Size = new System.Drawing.Size(859, 457);
            this.dgv_ClassList.TabIndex = 91;
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
            // sECTIONDataGridViewTextBoxColumn
            // 
            this.sECTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sECTIONDataGridViewTextBoxColumn.DataPropertyName = "SECTION";
            this.sECTIONDataGridViewTextBoxColumn.HeaderText = "SECTION";
            this.sECTIONDataGridViewTextBoxColumn.Name = "sECTIONDataGridViewTextBoxColumn";
            this.sECTIONDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cbo_Sec
            // 
            this.cbo_Sec.DisplayMember = "SECTION_NAME";
            this.cbo_Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Sec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Sec.FormattingEnabled = true;
            this.cbo_Sec.Location = new System.Drawing.Point(674, 77);
            this.cbo_Sec.Name = "cbo_Sec";
            this.cbo_Sec.Size = new System.Drawing.Size(123, 24);
            this.cbo_Sec.TabIndex = 109;
            this.cbo_Sec.ValueMember = "SECTION_NAME";
            this.cbo_Sec.SelectedIndexChanged += new System.EventHandler(this.cbo_Sec_SelectedIndexChanged);
            // 
            // cbo_Glvl
            // 
            this.cbo_Glvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Glvl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Glvl.FormattingEnabled = true;
            this.cbo_Glvl.Items.AddRange(new object[] {
            "GRADE 1",
            "GRADE 2",
            "GRADE 3",
            "GRADE 4",
            "GRADE 5",
            "GRADE 6"});
            this.cbo_Glvl.Location = new System.Drawing.Point(418, 77);
            this.cbo_Glvl.Name = "cbo_Glvl";
            this.cbo_Glvl.Size = new System.Drawing.Size(123, 24);
            this.cbo_Glvl.TabIndex = 108;
            this.cbo_Glvl.SelectedIndexChanged += new System.EventHandler(this.cbo_Glvl_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(313, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 107;
            this.label6.Text = "GRADE LEVEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(603, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 106;
            this.label5.Text = "SECTION:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(923, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 39);
            this.button2.TabIndex = 124;
            this.button2.Text = "&PRINT PREVIEW";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbl_LimtSec
            // 
            this.lbl_LimtSec.AutoSize = true;
            this.lbl_LimtSec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LimtSec.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_LimtSec.Location = new System.Drawing.Point(196, 84);
            this.lbl_LimtSec.Name = "lbl_LimtSec";
            this.lbl_LimtSec.Size = new System.Drawing.Size(95, 16);
            this.lbl_LimtSec.TabIndex = 132;
            this.lbl_LimtSec.Text = "Filter Records\r\n";
            this.lbl_LimtSec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_LimtSec.Visible = false;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_count.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.ForeColor = System.Drawing.Color.Red;
            this.lbl_count.Location = new System.Drawing.Point(293, 634);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(15, 16);
            this.lbl_count.TabIndex = 146;
            this.lbl_count.Text = "0";
            this.lbl_count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(180, 634);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 145;
            this.label8.Text = "Record(s) Count:\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tBL_ENR_LISTTableAdapter
            // 
            this.tBL_ENR_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(327, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 147;
            this.label1.Text = "SY:";
            // 
            // ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_LimtSec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbo_Sec);
            this.Controls.Add(this.cbo_Glvl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_ClassList);
            this.Controls.Add(this.lbl_YR);
            this.Controls.Add(this.label);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ClassList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassList";
            this.Load += new System.EventHandler(this.ClassList_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClassList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLENRLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ES_FINAL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SchoolYr;
        private System.Windows.Forms.Button btn_ClassLists;
        private System.Windows.Forms.Button btn_Subjects;
        private System.Windows.Forms.Button btn_Masterlist;
        private System.Windows.Forms.Button btn_Enrollment;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Sections;
        private System.Windows.Forms.Button btn_WdwList;
        private System.Windows.Forms.Button btn_EnrHistory;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl_YR;
        private System.Windows.Forms.DataGridView dgv_ClassList;
        private System.Windows.Forms.ComboBox cbo_Sec;
        private System.Windows.Forms.ComboBox cbo_Glvl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_LimtSec;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Label label8;
        private DB_ES_FINAL dB_ES_FINAL;
        private System.Windows.Forms.BindingSource tBLENRLISTBindingSource;
        private DB_ES_FINALTableAdapters.TBL_ENR_LISTTableAdapter tBL_ENR_LISTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLVLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}