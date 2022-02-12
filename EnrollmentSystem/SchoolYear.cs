using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EnrollmentSystem
{
    public partial class SchoolYear : Form
    {
        public SchoolYear()
        {
            InitializeComponent();
            setYear();
            lbl_Yr.Text = displayYr;

            if (lbl_Yr.Text == "")
            {
                lbl_Yr.Text = "---- ----";
            }

             ///SET DATA SOURCE DGV & CBO
            sqlcon.Open();
            refresh();
            sqlcon.Close();
            
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");


        private void SchoolYear_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_ES_FINAL.vSY_STATUS' table. You can move, or remove it, as needed.
            this.vSY_STATUSTableAdapter.Fill(this.dB_ES_FINAL.vSY_STATUS);
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            cbo_Yr.Visible = true;
            btn_Set.Visible = true;
            btn_Cancel.Visible = true;
        }

        
        private void btn_Set_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("EXEC sp_SCHOOLYEAR 'SET','" +((DataRowView)(cbo_Yr.SelectedItem))["SCHOOL YEAR"].ToString()+ "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MessageBox.Show("Set Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();

            cbo_Yr.Visible = false;
            btn_Set.Visible = false;
            btn_Cancel.Visible = false;

            setYear();
            lbl_Yr.Text = displayYr;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Yr.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("EXEC sp_SCHOOLYEAR 'ADD','" + txt_Yr.Text + "'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("School Year Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refresh();
                txt_Yr.Text = "";
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_Yr.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("EXEC sp_SCHOOLYEAR 'DELETE','"+txt_Yr.Text+"'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("School Year Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refresh();
                txt_Yr.Text = "";
            }
        }

        private void refresh()
        {
            SqlDataAdapter sda = new SqlDataAdapter("EXEC sp_SCHOOLYEAR 'VIEW',''", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_SY.DataSource = dt;
            cbo_Yr.DataSource = dt;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            cbo_Yr.Visible = false;
            btn_Set.Visible = false;
            btn_Cancel.Visible = false;
        }

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

        private void txt_Yr_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int countChar = this.txt_Yr.Text.Length;

            //if (String.IsNullOrEmpty(this.txt_Yr.Text))
            //{
            //    e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            //}
            //else if (countChar <= 8)
            //{
            //    e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            //}
            
            //else if(countChar == 9)
            //{
            //    e.Handled = e.KeyChar != (char)Keys.Back;
            //}
            //else 
            //{
            //    e.Handled = true;
            //}

        }

        public string displayYr;

        public void setYear()
        {
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM TBL_SY WHERE SY_STAT_ID = 1", sqlcon);
            SqlDataReader dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                displayYr = dr.GetValue(0).ToString();
            }
            sqlcmd.Dispose();
            sqlcon.Close();
        }

        private void btn_EnrHistory_Click(object sender, EventArgs e)
        {
            EnrHistory form = new EnrHistory();
            form.Show();
            this.Hide();
        }
    }
}
