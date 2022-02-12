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
    public partial class Masterlist : Form
    {
        public Masterlist()
        {
            InitializeComponent();
            txt_Search.Visible = false;
            btn_Search.Visible = false;
            btn_Clear.Visible = false;
            sqlcon.Open();
            refresh();
            sqlcon.Close();
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
            //this is Masterlist form
        }

        private void btn_Enrollment_Click(object sender, EventArgs e)
        {
            Enrollment form = new Enrollment();
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

        private void Masterlist_Load(object sender, EventArgs e)
        {
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_vLRN.Text != "" && txt_vStud.Text != "")
            {
                dgv_Masterlist.Visible = false;
                grb_Master.Visible = false;
                cbo_SearchBy.Visible = false;
                txt_Search.Visible = false;
                btn_Search.Visible = false;
                btn_Clear.Visible = false;
                pnl_Update.Visible = true;
            }
        }
        private static int countRecord;
        private void refresh()
        {
            dgv_Masterlist.Visible = true;
            SqlDataAdapter sda = new SqlDataAdapter("EXEC sp_MASTERLIST 'VIEW1','','','','','','','','','','','','','','','','','','','','','','','','','','','',''", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Masterlist.DataSource = dt;
            countRecord = dt.Rows.Count;
            lbl_count.Text = Convert.ToString(countRecord);
        }

        private void clear()
        {
            txt_Search.Text = "";
            txt_vLRN.Text = "";
            txt_vStud.Text = "";
        }
        private void cbo_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_SearchBy.SelectedIndex == 0)
            {
                txt_Search.Visible = false;
                btn_Search.Visible = false;
                btn_Clear.Visible = false;
                lbl_format.Visible = false;
                refresh();
                clear();
            }
            if (cbo_SearchBy.SelectedIndex == 1)
            {
                txt_Search.Visible = true;
                btn_Search.Visible = true;
                btn_Clear.Visible = true;
                lbl_format.Visible = false;
                txt_Search.Focus();
                refresh();
                clear();
            }
            if (cbo_SearchBy.SelectedIndex == 2)
            {
                txt_Search.Visible = true;
                btn_Search.Visible = true;
                btn_Clear.Visible = true;
                lbl_format.Visible = true;
                txt_Search.Focus();
                refresh();
                clear();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcmd;

            if (cbo_SearchBy.SelectedIndex == 1)
            {

                sqlcmd = new SqlCommand("EXEC sp_MASTERLIST 'VIEW2','','','','','','','','','','','','"+txt_Search.Text+"','','','','','','','','','','','','','','','',''", sqlcon);

                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Masterlist.DataSource = dt;
                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
                if (dt.Rows.Count == 0)
                {
                    clear();
                    DialogResult dialogResult = MessageBox.Show("No results found. Do you want to retry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txt_Search.Focus();
                    }
                
                }
                if (dt.Rows.Count == 1)
                {
                    txt_vLRN.Text = txt_Search.Text;
                    dataStudInfo(txt_vLRN.Text);
                }
                sqlcmd.Dispose();
            }

            if (cbo_SearchBy.SelectedIndex == 2)
            {
                sqlcmd = new SqlCommand("EXEC sp_MASTERLIST 'VIEW3','" + txt_Search.Text + "','','','','','','','','','','','','','','','','','','','','','','','','','','',''", sqlcon);

                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Masterlist.DataSource = dt;
                countRecord = dt.Rows.Count;
                lbl_count.Text = Convert.ToString(countRecord);
                if (dt.Rows.Count == 0)
                {
                    clear();
                    DialogResult dialogResult = MessageBox.Show("No results found. Do you want to retry?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dialogResult == DialogResult.Yes)
                    {
                        txt_Search.Focus();
                    }

                }
                if (dt.Rows.Count == 1)
                {
                    sqlcon.Open();
                    SqlDataReader dataReader = sqlcmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        txt_vLRN.Text = dataReader.GetValue(7).ToString();
                    }
                    sqlcon.Close();
                    
                    dataStudInfo(txt_vLRN.Text);
                }
                sqlcmd.Dispose();
            }
        }

        private void btn_Cancel_Upd_Click(object sender, EventArgs e)
        {
            dgv_Masterlist.Visible = true;
            grb_Master.Visible = true;
            cbo_SearchBy.Visible = true;
            txt_Search.Visible = true;
            btn_Search.Visible = true;
            btn_Clear.Visible = true;
            pnl_Update.Visible = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
            txt_Search.Focus();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void btn_Back2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void btn_Next2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        public void getInputs(string get)
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SP_MASTERLIST", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = get;
            sda.SelectCommand.Parameters.Add("@REF", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@S_NAME", SqlDbType.VarChar, (50)).Value = txt_Sname.Text;
            sda.SelectCommand.Parameters.Add("@F_NAME", SqlDbType.VarChar, (50)).Value = txt_Fname.Text;
            sda.SelectCommand.Parameters.Add("@M_NAME", SqlDbType.VarChar, (50)).Value = txt_Mname.Text;
            sda.SelectCommand.Parameters.Add("@EXT", SqlDbType.VarChar, (50)).Value = txt_Ext.Text;
            sda.SelectCommand.Parameters.Add("@AGE", SqlDbType.VarChar, (50)).Value = txt_Age.Text;
            sda.SelectCommand.Parameters.Add("@SEX", SqlDbType.VarChar, (50)).Value = cbo_Sex.SelectedItem;
            sda.SelectCommand.Parameters.Add("@BDAY", SqlDbType.VarChar, (50)).Value = dtP_Bday.Text;
            sda.SelectCommand.Parameters.Add("@BPLACE", SqlDbType.VarChar, (50)).Value = txt_Bplace.Text;
            sda.SelectCommand.Parameters.Add("@REL", SqlDbType.VarChar, (50)).Value = txt_Religion.Text;
            sda.SelectCommand.Parameters.Add("@ADDR", SqlDbType.VarChar, (100)).Value = txt_Add.Text;
            sda.SelectCommand.Parameters.Add("@LRN", SqlDbType.VarChar, (50)).Value = txt_Lrn.Text;
            sda.SelectCommand.Parameters.Add("@CON_NO", SqlDbType.VarChar, (50)).Value = txt_Cno.Text;
            sda.SelectCommand.Parameters.Add("@CSHIP", SqlDbType.VarChar, (50)).Value = txt_Cship.Text;
            sda.SelectCommand.Parameters.Add("@FA_NAME", SqlDbType.VarChar, (50)).Value = txt_FaName.Text;
            sda.SelectCommand.Parameters.Add("@FA_OCC", SqlDbType.VarChar, (50)).Value = txt_FaOc.Text;
            sda.SelectCommand.Parameters.Add("@FA_CNO", SqlDbType.VarChar, (50)).Value = txt_FaCo.Text;
            sda.SelectCommand.Parameters.Add("@MO_NAME", SqlDbType.VarChar, (50)).Value = txt_MoName.Text;
            sda.SelectCommand.Parameters.Add("@MO_OCC", SqlDbType.VarChar, (50)).Value = txt_MoOc.Text;
            sda.SelectCommand.Parameters.Add("@MO_CNO", SqlDbType.VarChar, (50)).Value = txt_MoCo.Text;
            sda.SelectCommand.Parameters.Add("@G_NAME", SqlDbType.VarChar, (50)).Value = txt_Gname.Text;
            sda.SelectCommand.Parameters.Add("@G_CNO", SqlDbType.VarChar, (50)).Value = txt_GCo.Text;
            sda.SelectCommand.Parameters.Add("@PSA", SqlDbType.Bit).Value = chb_PSAyes.Checked;
            sda.SelectCommand.Parameters.Add("@F137", SqlDbType.Bit).Value = chb_Frm137yes.Checked;
            sda.SelectCommand.Parameters.Add("@GMC", SqlDbType.Bit).Value = chb_GMCyes.Checked;
            sda.SelectCommand.Parameters.Add("@BC", SqlDbType.Bit).Value = chb_BCyes.Checked;
            sda.SelectCommand.Parameters.Add("@REC_FRM", SqlDbType.Bit).Value = chb_RcmdFrmyes.Checked;
            sda.SelectCommand.Parameters.Add("@PIC", SqlDbType.Bit).Value = chb_PicYes.Checked;
            sda.SelectCommand.ExecuteNonQuery();
            sda.SelectCommand.Dispose();
            sqlcon.Close();
        }

        private void btn_Upd_Save_Click(object sender, EventArgs e)
        {
            if (txt_Sname.Text != "" && txt_Fname.Text != "" && txt_Mname.Text != "" && txt_Age.Text != "" && cbo_Sex.Text != "" &&
                dtP_Bday.Text != "" && txt_Bplace.Text != "" && txt_Add.Text != "" && txt_Lrn.Text != "" && txt_Cno.Text != "" &&
                txt_FaName.Text != "" && txt_MoName.Text != "" && txt_Gname.Text != "")
            {
                string sp_cmd = "UPDATE";
                getInputs(sp_cmd);
                MessageBox.Show("Successfully Updated and Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgv_Masterlist.Visible = true;
                grb_Master.Visible = true;
                cbo_SearchBy.Visible = true;
                txt_Search.Visible = true;
                btn_Search.Visible = true;
                pnl_Update.Visible = false;
                clear();

                Register form = new Register();
                form.resetTabData();

                refresh();
            }
            else
            {
                MessageBox.Show("Please do not leave blank sections with asterisk.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_vLRN.Text != "" && txt_vStud.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record? ", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand("EXEC SP_MASTERLIST 'DELETE','','','','','','','','','','','','" + txt_vLRN.Text + "','','','','','','','','','','','','','','','',''", sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd.Dispose();
                    sqlcon.Close();
                    MessageBox.Show("Record has been successfully deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    refresh();
                }
            }
        }



        private void dgv_Masterlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow == -1)
            {
                return;
            }
            DataGridViewRow row = dgv_Masterlist.Rows[indexRow];
            txt_vLRN.Text = row.Cells[7].Value.ToString();
            txt_vStud.Text = row.Cells[0].Value.ToString();
            dataStudInfo(txt_vLRN.Text);
        }


        public void dataStudInfo(string LRN)
        {
            SqlCommand sqlcmd = new SqlCommand("SELECT * FROM TBL_STUD_INFO WHERE LRN = @LRN", sqlcon);
            sqlcmd.Parameters.AddWithValue("@LRN", LRN);
            sqlcon.Open();
            SqlDataReader dataReader = sqlcmd.ExecuteReader();
            while (dataReader.Read())
            {
                txt_vLRN.Text = dataReader.GetValue(10).ToString();
                txt_vStud.Text = dataReader.GetValue(0).ToString() + ", " + dataReader.GetValue(1).ToString() + " " + dataReader.GetValue(2).ToString() + " " + dataReader.GetValue(3).ToString();


                ///pnl_TabUpdate
                txt_Sname.Text = dataReader.GetValue(0).ToString();
                txt_Fname.Text = dataReader.GetValue(1).ToString();
                txt_Mname.Text = dataReader.GetValue(2).ToString();
                txt_Ext.Text = dataReader.GetValue(3).ToString();
                txt_Age.Text = dataReader.GetValue(4).ToString();
                cbo_Sex.SelectedItem = dataReader.GetValue(5).ToString();
                dtP_Bday.Text = dataReader.GetValue(6).ToString();
                txt_Bplace.Text = dataReader.GetValue(7).ToString();
                txt_Religion.Text = dataReader.GetValue(8).ToString();
                txt_Add.Text = dataReader.GetValue(9).ToString();
                txt_Lrn.Text = dataReader.GetValue(10).ToString();
                txt_Cno.Text = dataReader.GetValue(11).ToString();
                txt_Cship.Text = dataReader.GetValue(12).ToString();
                txt_FaName.Text = dataReader.GetValue(13).ToString();
                txt_FaOc.Text = dataReader.GetValue(14).ToString();
                txt_FaCo.Text = dataReader.GetValue(15).ToString();
                txt_MoName.Text = dataReader.GetValue(16).ToString();
                txt_MoOc.Text = dataReader.GetValue(17).ToString();
                txt_MoCo.Text = dataReader.GetValue(18).ToString();
                txt_Gname.Text = dataReader.GetValue(19).ToString();
                txt_GCo.Text = dataReader.GetValue(20).ToString();

                if (dataReader.GetValue(21).ToString() == "True")
                {
                    chb_PSAyes.Checked = true;
                }
                else
                {
                    chb_PSAyes.Checked = false;
                }
                if (dataReader.GetValue(22).ToString() == "True")
                {
                    chb_Frm137yes.Checked = true;
                }
                else
                {
                    chb_Frm137yes.Checked = false;
                }
                if (dataReader.GetValue(23).ToString() == "True")
                {
                    chb_GMCyes.Checked = true;
                }
                else
                {
                    chb_GMCyes.Checked = false;
                }
                if (dataReader.GetValue(24).ToString() == "True")
                {
                    chb_BCyes.Checked = true;
                }
                else
                {
                    chb_BCyes.Checked = false;
                }
                if (dataReader.GetValue(25).ToString() == "True")
                {
                    chb_RcmdFrmyes.Checked = true;
                }
                else
                {
                    chb_RcmdFrmyes.Checked = false;
                }
                if (dataReader.GetValue(26).ToString() == "True")
                {
                    chb_PicYes.Checked = true;
                }
                else
                {
                    chb_PicYes.Checked = false;
                }


            }
            dataReader.Close();
            sqlcmd.Dispose();
            sqlcon.Close();
        }

        private void txt_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbo_SearchBy.SelectedIndex == 1)
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

        private void txt_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            int countChar = this.txt_Age.Text.Length;
            if (countChar < 2)
            {
                e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }
            else if (countChar == 2)
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Lrn_KeyPress(object sender, KeyPressEventArgs e)
        {
            int countChar = this.txt_Lrn.Text.Length;
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

        private void btn_EnrHistory_Click(object sender, EventArgs e)
        {
            EnrHistory form = new EnrHistory();
            form.Show();
            this.Hide();

        }
    }
}
