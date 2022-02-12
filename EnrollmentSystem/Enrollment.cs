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
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
            txt_Search.Visible = false;
            btn_Search.Visible = false;
            btn_Clear.Visible = false;
            
            SchoolYear form = new SchoolYear();

            form.setYear();
            lbl_YR.Text = form.displayYr;
            txt_SY.Text = lbl_YR.Text;
            refresh_EnrList();

            if (txt_SY.Text == "")
            {
                MessageBox.Show("Please set the SY in SCHOOL YEAR menu \nto proceed in Enrolling a Student.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
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

        private void btn_SchoolYr_Click(object sender, EventArgs e)
        {
            SchoolYear form = new SchoolYear();
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

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Show();
            this.Hide();
        }

        private void cbo_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_SearchBy.SelectedIndex == 0)
            {
                txt_Search.Visible = false;
                btn_Search.Visible = false;
                btn_Clear.Visible = false;
                lbl_format.Visible = false;
                txt_Search.Text = "";
                txt_Search.Focus();
                refresh_EnrList();
            }
            if (cbo_SearchBy.SelectedIndex == 1)
            {
                txt_Search.Visible = true;
                btn_Search.Visible = true;
                btn_Clear.Visible = true;
                lbl_format.Visible = false;
                txt_Search.Text = "";
                txt_Search.Focus();
                refresh_EnrList();
            }
            if (cbo_SearchBy.SelectedIndex == 2)
            {
                txt_Search.Visible = true;
                btn_Search.Visible = true;
                btn_Clear.Visible = true;
                lbl_format.Visible = true;
                txt_Search.Text = "";
                txt_Search.Focus();
                refresh_EnrList();
            }
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_ES_FINAL.TBL_ENR_LIST' table. You can move, or remove it, as needed.
            this.tBL_ENR_LISTTableAdapter.Fill(this.dB_ES_FINAL.TBL_ENR_LIST);
            // TODO: This line of code loads data into the 'dB_ES_FINAL.TBL_SECTIONS' table. You can move, or remove it, as needed.
            this.tBL_SECTIONSTableAdapter.Fill(this.dB_ES_FINAL.TBL_SECTIONS);
            // TODO: This line of code loads data into the 'dB_ES_FINAL.TBL_GLVL' table. You can move, or remove it, as needed.
            this.tBL_GLVLTableAdapter.Fill(this.dB_ES_FINAL.TBL_GLVL);
        }

        private static int countRecord;
        public void refresh_EnrList()
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("sp_ENROLL", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "VIEW1";
            sda.SelectCommand.Parameters.Add("@LRN", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@STUD_NAME", SqlDbType.VarChar, (150)).Value = "";
            sda.SelectCommand.Parameters.Add("@SY", SqlDbType.VarChar, (50)).Value = txt_SY.Text;
            sda.SelectCommand.Parameters.Add("@GLVL", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@SECTION", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@DATE", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@STATUS", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgv_EnrList.DataSource = dt;

            countRecord = dt.Rows.Count;
            lbl_count.Text = Convert.ToString(countRecord);
            
            sqlcon.Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbo_SearchBy.SelectedIndex == 1)
            {
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_ENROLL", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "VIEW2";
                sda.SelectCommand.Parameters.Add("@LRN", SqlDbType.VarChar, (50)).Value = txt_Search.Text;
                sda.SelectCommand.Parameters.Add("@STUD_NAME", SqlDbType.VarChar, (150)).Value = "";
                sda.SelectCommand.Parameters.Add("@SY", SqlDbType.VarChar, (50)).Value = txt_SY.Text;
                sda.SelectCommand.Parameters.Add("@GLVL", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.Parameters.Add("@SECTION", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.Parameters.Add("@DATE", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.Parameters.Add("@STATUS", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_EnrList.DataSource = dt;
                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);

                if (dt.Rows.Count == 0)
                {
                    txt_Search.Text = "";
                    DialogResult dialogResult = MessageBox.Show("No results found. Do you want to retry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txt_Search.Focus();
                    }

                }
                sda.Dispose();
                sqlcon.Close();
            }
            if (cbo_SearchBy.SelectedIndex == 2)
            {
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_ENROLL", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "VIEW3";
                sda.SelectCommand.Parameters.Add("@LRN", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.Parameters.Add("@STUD_NAME", SqlDbType.VarChar, (150)).Value = txt_Search.Text;
                sda.SelectCommand.Parameters.Add("@SY", SqlDbType.VarChar, (50)).Value = txt_SY.Text;
                sda.SelectCommand.Parameters.Add("@GLVL", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.Parameters.Add("@SECTION", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.Parameters.Add("@DATE", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.Parameters.Add("@STATUS", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_EnrList.DataSource = dt;
                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);

                if (dt.Rows.Count == 0)
                {
                    txt_Search.Text = "";
                    DialogResult dialogResult = MessageBox.Show("No results found. Do you want to retry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txt_Search.Focus();
                    }
                }
                sda.Dispose();
                sqlcon.Close();
            }
        }

        public static string LRN, StudName, SY, GLVL;

        private void Enrollment_Click(object sender, EventArgs e)
        {
            lbx_ListNames.Visible = false;
        }

        private void btn_Enroll_Click(object sender, EventArgs e)
        {
            
            if (txt_Lrn.Text != "" && txt_StudName.Text != "" && txt_SY.Text != "")
            {
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_WITHDRAW", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "VIEW2";
                sda.SelectCommand.Parameters.Add("@LRN", SqlDbType.VarChar, (50)).Value = txt_Lrn.Text;
                sda.SelectCommand.Parameters.Add("@STUD_NAME", SqlDbType.VarChar, (150)).Value = "";
                sda.SelectCommand.Parameters.Add("@SY", SqlDbType.VarChar, (50)).Value = txt_SY.Text;
                sda.SelectCommand.Parameters.Add("@GLVL", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.Parameters.Add("@REASON", SqlDbType.VarChar, (150)).Value = "";
                sda.SelectCommand.Parameters.Add("DATE_WDW", SqlDbType.VarChar, (50)).Value = "";
                sda.SelectCommand.ExecuteNonQuery();
                DataTable  dt = new DataTable();
                sda.Fill(dt);
                

                if (dt.Rows.Count == 0)
                {
                    sda = new SqlDataAdapter("sp_ENROLL", sqlcon);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "VIEW2";
                    sda.SelectCommand.Parameters.Add("@LRN", SqlDbType.VarChar, (50)).Value = txt_Lrn.Text;
                    sda.SelectCommand.Parameters.Add("@STUD_NAME", SqlDbType.VarChar, (150)).Value = "";
                    sda.SelectCommand.Parameters.Add("@SY", SqlDbType.VarChar, (50)).Value = txt_SY.Text;
                    sda.SelectCommand.Parameters.Add("@GLVL", SqlDbType.VarChar, (50)).Value = "";
                    sda.SelectCommand.Parameters.Add("@SECTION", SqlDbType.VarChar, (50)).Value = "";
                    sda.SelectCommand.Parameters.Add("@DATE", SqlDbType.VarChar, (50)).Value = "";
                    sda.SelectCommand.Parameters.Add("@STATUS", SqlDbType.VarChar, (50)).Value = "";
                    sda.SelectCommand.ExecuteNonQuery();
                    DataTable dt1 = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count == 0 && dt1.Rows.Count == 0)
                    {
                        sda = new SqlDataAdapter("sp_ENROLL", sqlcon);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "ENROLL";
                        sda.SelectCommand.Parameters.Add("@LRN", SqlDbType.VarChar, (50)).Value = txt_Lrn.Text;
                        sda.SelectCommand.Parameters.Add("@STUD_NAME", SqlDbType.VarChar, (150)).Value = txt_StudName.Text;
                        sda.SelectCommand.Parameters.Add("@SY", SqlDbType.VarChar, (50)).Value = txt_SY.Text;
                        sda.SelectCommand.Parameters.Add("@GLVL", SqlDbType.VarChar, (50)).Value = ((DataRowView)(cbo_Glvl.SelectedItem))["GLVL"].ToString();
                        sda.SelectCommand.Parameters.Add("@SECTION", SqlDbType.VarChar, (50)).Value = ((DataRowView)(cbo_Sec.SelectedItem))["SECTION_NAME"].ToString();
                        sda.SelectCommand.Parameters.Add("@DATE", SqlDbType.VarChar, (50)).Value = DateTime.Now.ToShortDateString();
                        sda.SelectCommand.Parameters.Add("@STATUS", SqlDbType.VarChar, (50)).Value = "ENROLLED";
                        sda.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("Student was ENROLLED SUCCESSFULLY", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (sqlcon.State == ConnectionState.Open)
                        {
                            sqlcon.Close();
                        }
                        refresh_EnrList();
                        sda.Dispose();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Student was ALREADY ENROLLED.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Student was WITHDRAWN.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                sqlcon.Close();
            }
        }

        private void ClearAll()
        {
            txt_SearchName.Text = "";
            txt_Lrn.Text = "";
            txt_StudName.Text = "";
            cbo_Glvl.SelectedIndex = 0;
            cbo_Sec.SelectedIndex = 0;
            cbo_Sec.Enabled = false;
            cbo_Glvl.Enabled = false;
        }

        private void cbo_Glvl_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_ENR_LIST WHERE SY = '" + txt_SY.Text + "' AND GLVL = '" + ((DataRowView)(cbo_Glvl.SelectedItem))["GLVL"].ToString() + "' AND SECTION = '" + ((DataRowView)(cbo_Sec.SelectedItem))["SECTION_NAME"].ToString() + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 2)
            {
                lbl_LimtSec.Visible = true;
                btn_Enroll.Enabled = false;
            }
            else
            {
                lbl_LimtSec.Visible = false;
                btn_Enroll.Enabled = true;
            }

        }

        private void cbo_Sec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_ENR_LIST WHERE SY = '" + txt_SY.Text + "' AND GLVL = '" + ((DataRowView)(cbo_Glvl.SelectedItem))["GLVL"].ToString() + "' AND SECTION = '" + ((DataRowView)(cbo_Sec.SelectedItem))["SECTION_NAME"].ToString() + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 2)
            {
                lbl_LimtSec.Visible = true;
                btn_Enroll.Enabled = false;
            }
            else
            {
                lbl_LimtSec.Visible = false;
                btn_Enroll.Enabled = true;
            }

        }

        private void btn_EnrHistory_Click(object sender, EventArgs e)
        {
            EnrHistory form = new EnrHistory();
            form.Show();
            this.Hide();
        }


        private void lbx_ListNames_MouseClick(object sender, MouseEventArgs e)
        {
            txt_SearchName.Text = ((DataRowView)(lbx_ListNames.SelectedItem))["STUDENT NAME"].ToString();
            lbx_ListNames.Visible = false;
            cbo_Sec.Enabled = true;
            cbo_Glvl.Enabled = true;
            sqlcon.Open();

            SqlCommand sqlcmd = new SqlCommand("EXEC sp_MASTERLIST 'VIEW3','" + txt_SearchName.Text + "','','','','','','','','','','','','','','','','','','','','','','','','','','',''", sqlcon);
            SqlDataReader dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                txt_Lrn.Text = dr.GetValue(7).ToString();
                txt_StudName.Text = dr.GetValue(0).ToString();
            }
            sqlcmd.Dispose();
            sqlcon.Close();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TBL_ENR_LIST WHERE SY = '" + txt_SY.Text + "' AND GLVL = '" + ((DataRowView)(cbo_Glvl.SelectedItem))["GLVL"].ToString() + "' AND SECTION = '" + ((DataRowView)(cbo_Sec.SelectedItem))["SECTION_NAME"].ToString() + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 2)
            {
                lbl_LimtSec.Visible = true;
                btn_Enroll.Enabled = false;
            }
            else
            {
                lbl_LimtSec.Visible = false;
                btn_Enroll.Enabled = true;
            }
        }

        private void txt_SearchName_KeyDown(object sender, KeyEventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT [STUDENT NAME] FROM vMASTERLIST WHERE [STUDENT NAME] LIKE '" + txt_SearchName.Text + "%' ORDER BY [STUDENT NAME]", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbx_ListNames.Visible = true;
            lbx_ListNames.DataSource = dt;
            lbx_ListNames.DisplayMember = "STUDENT NAME";

            if (dt.Rows.Count == 0)
            {
                lbx_ListNames.Visible = false;
            }
        }

        private void dgv_EnrList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow == -1)
            {
                return;
            }

            DataGridViewRow row = dgv_EnrList.Rows[indexRow]; 
   
            int indexCol = e.ColumnIndex;
            DataGridViewColumn column = dgv_EnrList.Columns[indexCol];
            
            if (indexCol == 7)
            {
               //regform SAP Crystal Report
            }
            if (indexCol == 8)
            {
                LRN = row.Cells[0].Value.ToString();
                StudName = row.Cells[1].Value.ToString();
                SY = row.Cells[2].Value.ToString();
                GLVL = row.Cells[3].Value.ToString();
                
                WithdrawalForm form = new WithdrawalForm();
                form.Show();
                this.Hide();
            }
        }
    }
}
