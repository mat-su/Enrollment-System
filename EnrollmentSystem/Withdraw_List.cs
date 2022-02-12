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
    public partial class Withdraw_List : Form
    {
        public Withdraw_List()
        {
            InitializeComponent();
            SchoolYear form = new SchoolYear();
            form.setYear();
            lbl_YR.Text = form.displayYr;

            refresh();
            txt_Search.Visible = false;
            btn_Search.Visible = false;
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");


        private void Withdraw_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_ES_FINAL.TBL_WDW_LIST' table. You can move, or remove it, as needed.
            this.tBL_WDW_LISTTableAdapter.Fill(this.dB_ES_FINAL.TBL_WDW_LIST);

        }
        private static int countRecord;
        private void refresh()
        {
            SqlDataAdapter sda = new SqlDataAdapter("exec sp_WITHDRAW 'VIEW1','','','"+lbl_YR.Text + "','','',''", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Wdw.DataSource = dt;
            countRecord = dt.Rows.Count;
            lbl_count.Text = Convert.ToString(countRecord);
        }

        private void cbo_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_SearchBy.SelectedIndex == 0)
            {
                txt_Search.Visible = false;
                btn_Search.Visible = false;
                lbl_format.Visible = false;
                refresh();
            }
            if (cbo_SearchBy.SelectedIndex == 1)
            {
                txt_Search.Visible = true;
                btn_Search.Visible = true;
                lbl_format.Visible = false;
                refresh();
            }
            if (cbo_SearchBy.SelectedIndex == 2)
            {
                txt_Search.Visible = true;
                btn_Search.Visible = true;
                lbl_format.Visible = true;
                refresh();
            }
            if (cbo_SearchBy.SelectedIndex == 3)
            {
                txt_Search.Visible = true;
                btn_Search.Visible = true;
                lbl_format.Visible = false;
                refresh();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbo_SearchBy.SelectedIndex == 1)
            {
                SqlDataAdapter sda = new SqlDataAdapter("EXEC SP_WITHDRAW 'VIEW2','"+txt_Search.Text+"','','"+lbl_YR.Text+"','','',''", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Wdw.DataSource = dt;
                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No results found. Do you want to retry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
                txt_Search.Focus();
                txt_Search.Text = "";
            }
            if (cbo_SearchBy.SelectedIndex == 2)
            {
                SqlDataAdapter sda = new SqlDataAdapter("EXEC SP_WITHDRAW 'VIEW3','','"+txt_Search.Text+"','"+lbl_YR.Text+"','','',''", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Wdw.DataSource = dt;
                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No results found. Do you want to retry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
                txt_Search.Focus();
                txt_Search.Text = "";
            }
            if (cbo_SearchBy.SelectedIndex == 3)
            {
                SqlDataAdapter sda = new SqlDataAdapter("EXEC SP_WITHDRAW 'VIEW4','','','"+lbl_YR.Text+"','','','"+txt_Search.Text+"'", sqlcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Wdw.DataSource = dt;
                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No results found. Do you want to retry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
                txt_Search.Focus();
                txt_Search.Text = "";
            }
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
            //this is withdraw list form
        }

        private void btn_SchoolYr_Click(object sender, EventArgs e)
        {
            SchoolYear form = new SchoolYear();
            form.Show();
            this.Hide();
        }

        private void btn_EnrHistory_Click(object sender, EventArgs e)
        {
            EnrHistory form = new EnrHistory();
            form.Show();
            this.Hide();
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbo_SearchBy.SelectedIndex == 1)
            {
                int countChar = this.txt_Search.Text.Length;
                if (countChar < 12)
                {
                    e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
                }
                else if (countChar == 12)
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
