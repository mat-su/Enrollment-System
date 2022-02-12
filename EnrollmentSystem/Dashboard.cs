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
    public partial class Dashboard : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");

        public Dashboard()
        {
            InitializeComponent();

            SchoolYear form = new SchoolYear();
            form.setYear();
            lbl_YR.Text = form.displayYr;
            if (lbl_YR.Text == "")
            {
               lbl_YR.Text = "---- ----";
            }
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login form = new frm_Login();
            MessageBox.Show("You have logged out.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            form.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            //this is dashboard form
        }

        private void btn_Enrollment_Click(object sender, EventArgs e)
        {
            Enrollment form = new Enrollment();
            this.Hide();
            form.Show();

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
            Revised_Forms.ClassList form = new Revised_Forms.ClassList();
            form.Show();
            this.Hide();
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

        private void btn_EnrHistory_Click(object sender, EventArgs e)
        {
            EnrHistory form = new EnrHistory();
            form.Show();
            this.Hide();
        }
    }
}
    
