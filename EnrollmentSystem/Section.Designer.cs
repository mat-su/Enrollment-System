namespace EnrollmentSystem
{
    partial class Section
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Section));
            this.dgv_Section = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_glvl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SecName = new System.Windows.Forms.TextBox();
            this.lbl_SecName = new System.Windows.Forms.Label();
            this.lbl_GradeLvl = new System.Windows.Forms.Label();
            this.txt_GradeLvl = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.reference = new System.Windows.Forms.Label();
            this.btn_UpdSec = new System.Windows.Forms.Button();
            this.btn_DeleteSec = new System.Windows.Forms.Button();
            this.btn_AddSec = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Section)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Section
            // 
            this.dgv_Section.AllowUserToAddRows = false;
            this.dgv_Section.AllowUserToDeleteRows = false;
            this.dgv_Section.AllowUserToResizeColumns = false;
            this.dgv_Section.AllowUserToResizeRows = false;
            this.dgv_Section.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Section.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Section.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_Section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Section.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgv_Section.Location = new System.Drawing.Point(563, 221);
            this.dgv_Section.Name = "dgv_Section";
            this.dgv_Section.ReadOnly = true;
            this.dgv_Section.Size = new System.Drawing.Size(374, 317);
            this.dgv_Section.TabIndex = 134;
            this.dgv_Section.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Section_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GLVL";
            this.Column2.HeaderText = "GRADE LEVEL";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cbo_glvl
            // 
            this.cbo_glvl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_glvl.FormattingEnabled = true;
            this.cbo_glvl.Items.AddRange(new object[] {
            "ALL",
            "GRADE 1",
            "GRADE 2",
            "GRADE 3",
            "GRADE 4",
            "GRADE 5",
            "GRADE 6"});
            this.cbo_glvl.Location = new System.Drawing.Point(255, 226);
            this.cbo_glvl.Name = "cbo_glvl";
            this.cbo_glvl.Size = new System.Drawing.Size(187, 28);
            this.cbo_glvl.TabIndex = 135;
            this.cbo_glvl.SelectedIndexChanged += new System.EventHandler(this.cbo_glvl_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(255, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 143;
            this.label3.Text = "Sort by:";
            // 
            // txt_SecName
            // 
            this.txt_SecName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SecName.Location = new System.Drawing.Point(382, 299);
            this.txt_SecName.Name = "txt_SecName";
            this.txt_SecName.Size = new System.Drawing.Size(138, 26);
            this.txt_SecName.TabIndex = 144;
            // 
            // lbl_SecName
            // 
            this.lbl_SecName.AutoSize = true;
            this.lbl_SecName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SecName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SecName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_SecName.Location = new System.Drawing.Point(255, 299);
            this.lbl_SecName.Name = "lbl_SecName";
            this.lbl_SecName.Size = new System.Drawing.Size(115, 20);
            this.lbl_SecName.TabIndex = 145;
            this.lbl_SecName.Text = "Section Name:";
            // 
            // lbl_GradeLvl
            // 
            this.lbl_GradeLvl.AutoSize = true;
            this.lbl_GradeLvl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GradeLvl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GradeLvl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_GradeLvl.Location = new System.Drawing.Point(255, 266);
            this.lbl_GradeLvl.Name = "lbl_GradeLvl";
            this.lbl_GradeLvl.Size = new System.Drawing.Size(109, 20);
            this.lbl_GradeLvl.TabIndex = 146;
            this.lbl_GradeLvl.Text = "Grade Level: ";
            // 
            // txt_GradeLvl
            // 
            this.txt_GradeLvl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GradeLvl.Location = new System.Drawing.Point(382, 263);
            this.txt_GradeLvl.Name = "txt_GradeLvl";
            this.txt_GradeLvl.Size = new System.Drawing.Size(138, 26);
            this.txt_GradeLvl.TabIndex = 147;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(448, 337);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(72, 27);
            this.btn_Search.TabIndex = 148;
            this.btn_Search.Text = "SEARCH";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // reference
            // 
            this.reference.AutoSize = true;
            this.reference.Location = new System.Drawing.Point(442, 413);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(0, 13);
            this.reference.TabIndex = 149;
            this.reference.Visible = false;
            // 
            // btn_UpdSec
            // 
            this.btn_UpdSec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdSec.Image = global::EnrollmentSystem.Properties.Resources.update_icon1;
            this.btn_UpdSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdSec.Location = new System.Drawing.Point(370, 445);
            this.btn_UpdSec.Name = "btn_UpdSec";
            this.btn_UpdSec.Size = new System.Drawing.Size(150, 41);
            this.btn_UpdSec.TabIndex = 138;
            this.btn_UpdSec.Text = "UPDATE SECTION";
            this.btn_UpdSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UpdSec.UseVisualStyleBackColor = true;
            this.btn_UpdSec.Click += new System.EventHandler(this.btn_UpdSec_Click);
            // 
            // btn_DeleteSec
            // 
            this.btn_DeleteSec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteSec.Image = global::EnrollmentSystem.Properties.Resources.blue_document_cross_icon;
            this.btn_DeleteSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteSec.Location = new System.Drawing.Point(370, 492);
            this.btn_DeleteSec.Name = "btn_DeleteSec";
            this.btn_DeleteSec.Size = new System.Drawing.Size(150, 41);
            this.btn_DeleteSec.TabIndex = 137;
            this.btn_DeleteSec.Text = "DELETE SECTION";
            this.btn_DeleteSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteSec.UseVisualStyleBackColor = true;
            this.btn_DeleteSec.Click += new System.EventHandler(this.btn_DeleteSec_Click);
            // 
            // btn_AddSec
            // 
            this.btn_AddSec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSec.Image = global::EnrollmentSystem.Properties.Resources.Add_icon;
            this.btn_AddSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddSec.Location = new System.Drawing.Point(370, 399);
            this.btn_AddSec.Name = "btn_AddSec";
            this.btn_AddSec.Size = new System.Drawing.Size(150, 41);
            this.btn_AddSec.TabIndex = 136;
            this.btn_AddSec.Text = "ADD SECTION";
            this.btn_AddSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddSec.UseVisualStyleBackColor = true;
            this.btn_AddSec.Click += new System.EventHandler(this.btn_AddSec_Click);
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
            this.flowLayoutPanel1.TabIndex = 150;
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
            this.btn_Sections.Enabled = false;
            this.btn_Sections.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sections.ForeColor = System.Drawing.Color.SeaShell;
            this.btn_Sections.Location = new System.Drawing.Point(2, 395);
            this.btn_Sections.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Sections.Name = "btn_Sections";
            this.btn_Sections.Size = new System.Drawing.Size(171, 44);
            this.btn_Sections.TabIndex = 61;
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
            this.btn_WdwList.TabIndex = 151;
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
            this.btn_EnrHistory.TabIndex = 151;
            this.btn_EnrHistory.Text = "ENROLLMENT \r\nHISTORY";
            this.btn_EnrHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_EnrHistory.UseVisualStyleBackColor = false;
            this.btn_EnrHistory.Click += new System.EventHandler(this.btn_EnrHistory_Click);
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::EnrollmentSystem.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 655);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.reference);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_GradeLvl);
            this.Controls.Add(this.lbl_GradeLvl);
            this.Controls.Add(this.lbl_SecName);
            this.Controls.Add(this.txt_SecName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_UpdSec);
            this.Controls.Add(this.btn_DeleteSec);
            this.Controls.Add(this.btn_AddSec);
            this.Controls.Add(this.cbo_glvl);
            this.Controls.Add(this.dgv_Section);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Section";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrollment System ► Section";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Section)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Section;
        private System.Windows.Forms.ComboBox cbo_glvl;
        private System.Windows.Forms.Button btn_AddSec;
        private System.Windows.Forms.Button btn_DeleteSec;
        private System.Windows.Forms.Button btn_UpdSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SecName;
        private System.Windows.Forms.Label lbl_SecName;
        private System.Windows.Forms.Label lbl_GradeLvl;
        private System.Windows.Forms.TextBox txt_GradeLvl;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
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
        private System.Windows.Forms.Button btn_SchoolYr;
        private System.Windows.Forms.Button btn_WdwList;
        private System.Windows.Forms.Button btn_EnrHistory;
    }
}