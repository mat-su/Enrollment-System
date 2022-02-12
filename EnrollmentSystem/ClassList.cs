using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem.Revised_Forms
{
    public partial class ClassList : Form
    {
        public ClassList()
        {
            InitializeComponent();
            SchoolYear form = new SchoolYear();
            form.setYear();
            lbl_YR.Text = form.displayYr;

            dgv_ClassList.DataSource = null;

        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");
        private static int countRecord;
        
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.Show();
            this.Hide();
        }

        private void btn_Enrollment_Click(object sender, EventArgs e)
        {
            Enrollment form = new Enrollment();
            form.Show();
            this.Hide();
        }

        private void btn_Masterlist_Click(object sender, EventArgs e)
        {
            Revised_Forms.Masterlist form = new Revised_Forms.Masterlist();
            form.Show();
            this.Hide();
        }

        private void btn_Subjects_Click(object sender, EventArgs e)
        {
            Subjects form = new Subjects();
            form.Show();
            this.Hide();
        }

        private void btn_ClassLists_Click(object sender, EventArgs e)
        {
            // this is classlist form
        }

        private void btn_SchoolYr_Click(object sender, EventArgs e)
        {
            SchoolYear form = new SchoolYear();
            form.Show();
            this.Hide();
        }

        private void btn_Sections_Click(object sender, EventArgs e)
        {
            Section form = new Section();
            form.Show();
            this.Hide();
        }

        private void btn_WdwList_Click(object sender, EventArgs e)
        {
            Withdraw_List form = new Withdraw_List();
            form.Show();
            this.Hide();
        }

        private void ClassList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_ES_FINAL.TBL_ENR_LIST' table. You can move, or remove it, as needed.
            this.tBL_ENR_LISTTableAdapter.Fill(this.dB_ES_FINAL.TBL_ENR_LIST);

        }

        private void btn_EnrHistory_Click(object sender, EventArgs e)
        {
            EnrHistory form = new EnrHistory();
            form.Show();
            this.Hide();
        }

        private void cbo_Glvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int glvlId = 0;
            if (cbo_Glvl.SelectedIndex == 0)
            {
                glvlId = 1;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_SECTIONS WHERE GLVL_ID = '" + glvlId +"'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbo_Sec.DataSource = dt;
                cbo_Sec.DisplayMember = "SECTION_NAME";
                cbo_Sec.ValueMember = "SECTION_NAME";

                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
            }
            if (cbo_Glvl.SelectedIndex == 1)
            {
                glvlId = 2;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_SECTIONS WHERE GLVL_ID = '" + glvlId + "'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbo_Sec.DataSource = dt;
                cbo_Sec.DisplayMember = "SECTION_NAME";
                cbo_Sec.ValueMember = "SECTION_NAME";

                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
            }
            if (cbo_Glvl.SelectedIndex == 2)
            {
                glvlId = 3;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_SECTIONS WHERE GLVL_ID = '" + glvlId + "'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbo_Sec.DataSource = dt;
                cbo_Sec.DisplayMember = "SECTION_NAME";
                cbo_Sec.ValueMember = "SECTION_NAME";

                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
            }
            if (cbo_Glvl.SelectedIndex == 3)
            {
                glvlId = 4;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_SECTIONS WHERE GLVL_ID = '" + glvlId + "'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbo_Sec.DataSource = dt;
                cbo_Sec.DisplayMember = "SECTION_NAME";
                cbo_Sec.ValueMember = "SECTION_NAME";

                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
            }
            if (cbo_Glvl.SelectedIndex == 4)
            {
                glvlId = 5;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_SECTIONS WHERE GLVL_ID = '" + glvlId + "'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbo_Sec.DataSource = dt;
                cbo_Sec.DisplayMember = "SECTION_NAME";
                cbo_Sec.ValueMember = "SECTION_NAME";

                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
            }
            if (cbo_Glvl.SelectedIndex == 5)
            {
                glvlId = 6;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_SECTIONS WHERE GLVL_ID = '" + glvlId + "'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cbo_Sec.DataSource = dt;
                cbo_Sec.DisplayMember = "SECTION_NAME";
                cbo_Sec.ValueMember = "SECTION_NAME";

                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
            }

            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM TBL_ENR_LIST WHERE SY = '" + lbl_YR.Text + "' AND GLVL = '" + cbo_Glvl.SelectedItem + "'", sqlcon);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            countRecord = dt1.Rows.Count;
            lbl_count.Text = Convert.ToString(countRecord);
            dgv_ClassList.DataSource = dt1;


        }

        private void cbo_Sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM TBL_ENR_LIST WHERE SY = '" + lbl_YR.Text + "' AND GLVL = '" + cbo_Glvl.SelectedItem + "' AND SECTION = '"+((DataRowView)(cbo_Sec.SelectedItem))["SECTION_NAME"].ToString()+"'", sqlcon);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            countRecord = dt1.Rows.Count;
            lbl_count.Text = Convert.ToString(countRecord);

            dgv_ClassList.DataSource = dt1;

        }
    }
}
