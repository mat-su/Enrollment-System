namespace EnrollmentSystem
{
    partial class SchoolYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolYear));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Yr = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Set = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.cbo_Yr = new System.Windows.Forms.ComboBox();
            this.vSYSTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ES_FINAL = new EnrollmentSystem.DB_ES_FINAL();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_Enrollment = new System.Windows.Forms.Button();
            this.btn_Masterlist = new System.Windows.Forms.Button();
            this.btn_Subjects = new System.Windows.Forms.Button();
            this.btn_Sections = new System.Windows.Forms.Button();
            this.btn_ClassLists = new System.Windows.Forms.Button();
            this.btn_WdwList = new System.Windows.Forms.Button();
            this.btn_SchoolYr = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_EnrHistory = new System.Windows.Forms.Button();
            this.sCHOOLYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_SY = new System.Windows.Forms.DataGridView();
            this.sCHOOLYEARDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Yr = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.vSY_STATUSTableAdapter = new EnrollmentSystem.DB_ES_FINALTableAdapters.vSY_STATUSTableAdapter();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSYSTATUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ES_FINAL)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SY)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Yr);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Set);
            this.groupBox1.Controls.Add(this.btn_Change);
            this.groupBox1.Controls.Add(this.cbo_Yr);
            this.groupBox1.Location = new System.Drawing.Point(677, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 256);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Swis721 Ex BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 50);
            this.label1.TabIndex = 52;
            this.label1.Text = "Enrollment is now \r\nOPEN for SY:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Yr
            // 
            this.lbl_Yr.AutoSize = true;
            this.lbl_Yr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Yr.Font = new System.Drawing.Font("Swis721 Ex BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Yr.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Yr.Location = new System.Drawing.Point(104, 79);
            this.lbl_Yr.Name = "lbl_Yr";
            this.lbl_Yr.Size = new System.Drawing.Size(96, 22);
            this.lbl_Yr.TabIndex = 53;
            this.lbl_Yr.Text = "---- ---- ";
            this.lbl_Yr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(194, 216);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(74, 25);
            this.btn_Cancel.TabIndex = 56;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Set
            // 
            this.btn_Set.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Set.Location = new System.Drawing.Point(194, 185);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(74, 25);
            this.btn_Set.TabIndex = 55;
            this.btn_Set.Text = "SET";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Visible = false;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(126, 118);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(82, 39);
            this.btn_Change.TabIndex = 54;
            this.btn_Change.Text = "CHANGE";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // cbo_Yr
            // 
            this.cbo_Yr.DataSource = this.vSYSTATUSBindingSource;
            this.cbo_Yr.DisplayMember = "SCHOOL YEAR";
            this.cbo_Yr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Yr.FormattingEnabled = true;
            this.cbo_Yr.Location = new System.Drawing.Point(56, 196);
            this.cbo_Yr.Name = "cbo_Yr";
            this.cbo_Yr.Size = new System.Drawing.Size(129, 29);
            this.cbo_Yr.TabIndex = 48;
            this.cbo_Yr.ValueMember = "SCHOOL YEAR";
            this.cbo_Yr.Visible = false;
            // 
            // vSYSTATUSBindingSource
            // 
            this.vSYSTATUSBindingSource.DataMember = "vSY_STATUS";
            this.vSYSTATUSBindingSource.DataSource = this.dB_ES_FINAL;
            // 
            // dB_ES_FINAL
            // 
            this.dB_ES_FINAL.DataSetName = "DB_ES_FINAL";
            this.dB_ES_FINAL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btn_SchoolYr.Enabled = false;
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
            this.flowLayoutPanel1.TabIndex = 57;
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
            // sCHOOLYEARDataGridViewTextBoxColumn
            // 
            this.sCHOOLYEARDataGridViewTextBoxColumn.DataPropertyName = "SCHOOL YEAR";
            this.sCHOOLYEARDataGridViewTextBoxColumn.HeaderText = "SCHOOL YEAR";
            this.sCHOOLYEARDataGridViewTextBoxColumn.Name = "sCHOOLYEARDataGridViewTextBoxColumn";
            // 
            // dgv_SY
            // 
            this.dgv_SY.AllowUserToAddRows = false;
            this.dgv_SY.AllowUserToDeleteRows = false;
            this.dgv_SY.AutoGenerateColumns = false;
            this.dgv_SY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCHOOLYEARDataGridViewTextBoxColumn1,
            this.sTATUSDataGridViewTextBoxColumn});
            this.dgv_SY.DataSource = this.vSYSTATUSBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SY.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SY.Location = new System.Drawing.Point(407, 200);
            this.dgv_SY.Name = "dgv_SY";
            this.dgv_SY.ReadOnly = true;
            this.dgv_SY.Size = new System.Drawing.Size(245, 256);
            this.dgv_SY.TabIndex = 67;
            // 
            // sCHOOLYEARDataGridViewTextBoxColumn1
            // 
            this.sCHOOLYEARDataGridViewTextBoxColumn1.DataPropertyName = "SCHOOL YEAR";
            this.sCHOOLYEARDataGridViewTextBoxColumn1.HeaderText = "SCHOOL YEAR";
            this.sCHOOLYEARDataGridViewTextBoxColumn1.Name = "sCHOOLYEARDataGridViewTextBoxColumn1";
            this.sCHOOLYEARDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txt_Yr
            // 
            this.txt_Yr.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Yr.Location = new System.Drawing.Point(254, 264);
            this.txt_Yr.Multiline = true;
            this.txt_Yr.Name = "txt_Yr";
            this.txt_Yr.Size = new System.Drawing.Size(130, 37);
            this.txt_Yr.TabIndex = 65;
            this.txt_Yr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Yr_KeyPress);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(322, 329);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(62, 39);
            this.btn_Delete.TabIndex = 68;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 66;
            this.label3.Text = "YEAR:";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(254, 329);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(62, 39);
            this.btn_Add.TabIndex = 64;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // vSY_STATUSTableAdapter
            // 
            this.vSY_STATUSTableAdapter.ClearBeforeFill = true;
            // 
            // SchoolYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnrollmentSystem.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 655);
            this.Controls.Add(this.dgv_SY);
            this.Controls.Add(this.txt_Yr);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "SchoolYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolYear";
            this.Load += new System.EventHandler(this.SchoolYear_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vSYSTATUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ES_FINAL)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.ComboBox cbo_Yr;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Enrollment;
        private System.Windows.Forms.Button btn_Masterlist;
        private System.Windows.Forms.Button btn_Subjects;
        private System.Windows.Forms.Button btn_Sections;
        private System.Windows.Forms.Button btn_ClassLists;
        private System.Windows.Forms.Button btn_WdwList;
        private System.Windows.Forms.Button btn_SchoolYr;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCHOOLYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgv_SY;
        private System.Windows.Forms.TextBox txt_Yr;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Yr;
        private System.Windows.Forms.Button btn_EnrHistory;
        private DB_ES_FINAL dB_ES_FINAL;
        private System.Windows.Forms.BindingSource vSYSTATUSBindingSource;
        private DB_ES_FINALTableAdapters.vSY_STATUSTableAdapter vSY_STATUSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCHOOLYEARDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
    }
}