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

namespace EnrollmentSystem
{
    public partial class EnrHistory : Form
    {
        public EnrHistory()
        {
            InitializeComponent();
            dgv_EnrHis.DataSource = null;
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");

        private void EnrHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_ES_FINAL.TBL_SECTIONS' table. You can move, or remove it, as needed.
            this.tBL_SECTIONSTableAdapter.Fill(this.dB_ES_FINAL.TBL_SECTIONS);
            // TODO: This line of code loads data into the 'dB_ES_FINAL.TBL_GLVL' table. You can move, or remove it, as needed.
            this.tBL_GLVLTableAdapter.Fill(this.dB_ES_FINAL.TBL_GLVL);
            // TODO: This line of code loads data into the 'dB_ES_FINAL.TBL_SY' table. You can move, or remove it, as needed.
            this.tBL_SYTableAdapter.Fill(this.dB_ES_FINAL.TBL_SY);
            // TODO: This line of code loads data into the 'dB_ES_FINAL.TBL_ENR_LIST' table. You can move, or remove it, as needed.
            this.tBL_ENR_LISTTableAdapter.Fill(this.dB_ES_FINAL.TBL_ENR_LIST);
        }
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

        private void btn_Sections_Click(object sender, EventArgs e)
        {
            Section form = new Section();
            form.Show();
            this.Hide();
        }

        private void btn_ClassLists_Click(object sender, EventArgs e)
        {
            Revised_Forms.ClassList form = new Revised_Forms.ClassList();
            form.Show();
            this.Hide();
        }

        private void btn_WdwList_Click(object sender, EventArgs e)
        {
            Withdraw_List form = new Withdraw_List();
            form.Show();
            this.Hide();
        }

        private void btn_SchoolYr_Click(object sender, EventArgs e)
        {
            SchoolYear form = new SchoolYear();
            form.Show();
            this.Hide();
        }

        private void cbo_SY_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_ENR_LIST WHERE SY = '"+((DataRowView)(cbo_SY.SelectedItem))["SCHOOL YEAR"].ToString()+"'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_EnrHis.DataSource = dt;
            countRecord = dt.Rows.Count;
            lbl_count.Text = Convert.ToString(countRecord);
        }

        private void cbo_glvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_ENR_LIST WHERE SY = '" + ((DataRowView)(cbo_SY.SelectedItem))["SCHOOL YEAR"].ToString() + "' AND GLVL = '"+ ((DataRowView)(cbo_glvl.SelectedItem))["GLVL"].ToString() + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_EnrHis.DataSource = dt;
            countRecord = dt.Rows.Count;
            lbl_count.Text = Convert.ToString(countRecord);
        }

        private void cbo_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_ENR_LIST WHERE SY = '" + ((DataRowView)(cbo_SY.SelectedItem))["SCHOOL YEAR"].ToString() + "' AND GLVL = '" + ((DataRowView)(cbo_glvl.SelectedItem))["GLVL"].ToString() + "' AND SECTION = '"+ ((DataRowView)(cbo_sec.SelectedItem))["SECTION_NAME"].ToString() + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_EnrHis.DataSource = dt;
            countRecord = dt.Rows.Count;
            lbl_count.Text = Convert.ToString(countRecord);
        }

    }
}
