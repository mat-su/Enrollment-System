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
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
            cbo_glvl.SelectedIndex = 0;
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");


        //method for viewing all sections
        private void View1()
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "VIEW1";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dgv_Section.DataSource = dtbl;

        }

        //method for viewing specific gradelvl with sections
        private void View2()
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "VIEW2";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = cbo_glvl.SelectedIndex;
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = cbo_glvl.SelectedIndex;
            sda.SelectCommand.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dgv_Section.DataSource = dtbl;
        }

        //method for inserting with COMBOBOX ALL enable
        private void Add1(int val)
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "ADD";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = val;
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = txt_SecName.Text;
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = ""; 
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            txt_SecName.Text = "";
            txt_GradeLvl.Text = "";
        }

        //method for inserting with COMBOBOX specific glvl enable
        private void Add2()
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "ADD";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = cbo_glvl.SelectedIndex; ;
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = txt_SecName.Text;
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            txt_SecName.Text = "";
            txt_GradeLvl.Text = "";
        }
      
        //method for updating with COMBOBOX ALL enable
        private void Update1(int val)
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "UPDATE";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = val;
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = txt_SecName.Text;
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = reference.Text; 
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            txt_SecName.Text = "";
            txt_GradeLvl.Text = "";
        }

        //method for updating with COMBOBOX specific glvl enable
        private void Update2()
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "UPDATE";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = cbo_glvl.SelectedIndex;
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = txt_SecName.Text;
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = reference.Text;
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            txt_SecName.Text = "";
            txt_GradeLvl.Text = "";
        }

        //method for deleting with COMBOBOX ALL enable
        private void Delete1(int val)
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "DELETE";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = val;
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = txt_SecName.Text;
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = "";
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record? ", "DELETE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
            }
            txt_SecName.Text = "";
            txt_GradeLvl.Text = "";
        }

        //method for deleting with COMBOBOX specific glvl enable
        private void Delete2()
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "DELETE";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = cbo_glvl.SelectedIndex;
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = txt_SecName.Text;
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = "";
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record? ", "DELETE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
            }
            txt_SecName.Text = "";
            txt_GradeLvl.Text = "";
        }

        //method for searching with COMBOBOX ALL enable
        private void Search1(int val)
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "SEARCH";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = val;
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = txt_SecName.Text;
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.ExecuteNonQuery();
            txt_SecName.Text = "";
            txt_GradeLvl.Text = "";
        }

        //method for searching with COMBOBOX ALL enable
        private void Search2()
        {
            SqlDataAdapter sda = new SqlDataAdapter("sp_SECTIONS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "SEARCH";
            sda.SelectCommand.Parameters.Add("@GLVL_ID", SqlDbType.VarChar, (50)).Value = cbo_glvl.SelectedIndex;
            sda.SelectCommand.Parameters.Add("@SECNAME", SqlDbType.VarChar, (50)).Value = txt_SecName.Text;
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.ExecuteNonQuery();
            txt_SecName.Text = "";
            txt_GradeLvl.Text = "";
        }


        private void cbo_glvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlcon.Open();
            if (cbo_glvl.SelectedIndex == 0)
            {
                lbl_GradeLvl.Visible = true;
                txt_GradeLvl.Visible = true;
                txt_SecName.Text = "";
                txt_GradeLvl.Text = "";
                View1();
            }
            else 

            {
                lbl_GradeLvl.Visible = false;
                txt_GradeLvl.Visible = false;
                txt_SecName.Text = "";
                txt_GradeLvl.Text = "";
                View2();
            }
            sqlcon.Close();
        }


        private void dgv_Section_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow == -1)
            {
                return;
            }
            DataGridViewRow row = dgv_Section.Rows[indexRow];

            txt_SecName.Text = row.Cells[1].Value.ToString();
            txt_GradeLvl.Text = row.Cells[0].Value.ToString();
            reference.Text = row.Cells[1].Value.ToString();
        }

        private void btn_AddSec_Click(object sender, EventArgs e)
        {
            if (cbo_glvl.SelectedIndex != 0)
            {
                txt_GradeLvl.Focus();
                if (txt_SecName.Text != string.Empty)
                {
                    sqlcon.Open();
                    Add2();
                    View2();
                    sqlcon.Close();
                }
            }
            else
            {
                txt_GradeLvl.Focus();
                if (txt_SecName.Text != string.Empty)
                {
                    sqlcon.Open();
                    
                    if(txt_GradeLvl.Text=="GRADE 1" || txt_GradeLvl.Text == "grade 1")
                    {
                        Add1(1);
                    }
                    if (txt_GradeLvl.Text == "GRADE 2" || txt_GradeLvl.Text == "grade 2")
                    {
                        Add1(2);
                    }
                    if (txt_GradeLvl.Text == "GRADE 3" || txt_GradeLvl.Text == "grade 3")
                    {
                        Add1(3);
                    }
                    if (txt_GradeLvl.Text == "GRADE 4" || txt_GradeLvl.Text == "grade 4")
                    {
                        Add1(4);
                    }
                    if (txt_GradeLvl.Text == "GRADE 5" || txt_GradeLvl.Text == "grade 5")
                    {
                        Add1(5);
                    }
                    if (txt_GradeLvl.Text == "GRADE 6" || txt_GradeLvl.Text == "grade 6")
                    {
                        Add1(6);
                    }
                    View1();
                    sqlcon.Close();
                }
            }
        }

        private void btn_UpdSec_Click(object sender, EventArgs e)
        {
            if (cbo_glvl.SelectedIndex != 0)
            {
                if (txt_SecName.Text != string.Empty)
                {
                    sqlcon.Open();
                    Update2();
                    View2();
                    sqlcon.Close();
                }
            }
            else
            {
                if (txt_SecName.Text != string.Empty)
                {
                    sqlcon.Open();
                    if (txt_GradeLvl.Text == "GRADE 1" || txt_GradeLvl.Text == "grade 1")
                    {
                        Update1(1);
                    }
                    if (txt_GradeLvl.Text == "GRADE 2" || txt_GradeLvl.Text == "grade 2")
                    {
                        Update1(2);
                    }
                    if (txt_GradeLvl.Text == "GRADE 3" || txt_GradeLvl.Text == "grade 3")
                    {
                        Update1(3);
                    }
                    if (txt_GradeLvl.Text == "GRADE 4" || txt_GradeLvl.Text == "grade 4")
                    {
                        Update1(4);
                    }
                    if (txt_GradeLvl.Text == "GRADE 5" || txt_GradeLvl.Text == "grade 5")
                    {
                        Update1(5);
                    }
                    if (txt_GradeLvl.Text == "GRADE 6" || txt_GradeLvl.Text == "grade 6")
                    {
                        Update1(6);
                    }
                    View1();
                    sqlcon.Close();   
                }
            }
        }

        private void btn_DeleteSec_Click(object sender, EventArgs e)
        {
            if (cbo_glvl.SelectedIndex != 0)
            {
                if (txt_SecName.Text != string.Empty)
                {
                    sqlcon.Open();
                    Delete2();
                    View2();
                    sqlcon.Close();
                }
            }
            else
            {
                if (txt_SecName.Text != string.Empty)
                {
                    sqlcon.Open();

                    if (txt_GradeLvl.Text == "GRADE 1" || txt_GradeLvl.Text == "grade 1")
                    {
                        Delete1(1);
                    }
                    if (txt_GradeLvl.Text == "GRADE 2" || txt_GradeLvl.Text == "grade 2")
                    {
                        Delete1(2);
                    }
                    if (txt_GradeLvl.Text == "GRADE 3" || txt_GradeLvl.Text == "grade 3")
                    {
                        Delete1(3);
                    }
                    if (txt_GradeLvl.Text == "GRADE 4" || txt_GradeLvl.Text == "grade 4")
                    {
                        Delete1(4);
                    }
                    if (txt_GradeLvl.Text == "GRADE 5" || txt_GradeLvl.Text == "grade 5")
                    {
                        Delete1(5);
                    }
                    if (txt_GradeLvl.Text == "GRADE 6" || txt_GradeLvl.Text == "grade 6")
                    {
                        Delete1(6);
                    }
                    View1();
                    sqlcon.Close();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbo_glvl.SelectedIndex != 0)
            {
                sqlcon.Open();
                Search2();
                View2();
                sqlcon.Close();
            }
            else
            {
                sqlcon.Open();

                if (txt_GradeLvl.Text == "GRADE 1" || txt_GradeLvl.Text == "grade 1")
                {
                    Search1(1);
                }
                if (txt_GradeLvl.Text == "GRADE 2" || txt_GradeLvl.Text == "grade 2")
                {
                    Search1(2);
                }
                if (txt_GradeLvl.Text == "GRADE 3" || txt_GradeLvl.Text == "grade 3")
                {
                    Search1(3);
                }
                if (txt_GradeLvl.Text == "GRADE 4" || txt_GradeLvl.Text == "grade 4")
                {
                    Search1(4);
                }
                if (txt_GradeLvl.Text == "GRADE 5" || txt_GradeLvl.Text == "grade 5")
                {
                    Search1(5);
                }
                if (txt_GradeLvl.Text == "GRADE 6" || txt_GradeLvl.Text == "grade 6")
                {
                    Search1(6);
                }
                View1();
                sqlcon.Close();

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
            //this is section form
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
