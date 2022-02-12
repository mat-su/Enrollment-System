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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Enrollment form = new Enrollment();
            form.Show();
            this.Hide();
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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");
        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Sname.Text != "" && txt_Fname.Text != "" && txt_Mname.Text != "" && txt_Age.Text != "" && cbo_Sex.Text != "" &&
                dtP_Bday.Text != "" && txt_Bplace.Text != "" && txt_Add.Text != "" && txt_Lrn.Text != "" && txt_Cno.Text != "" &&
                txt_FaName.Text != "" && txt_MoName.Text != "" && txt_Gname.Text != "")
            {
                sqlcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SP_MASTERLIST", sqlcon);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "INSERT";
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

                MessageBox.Show("Successfully Registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetTabData();
                Enrollment form = new Enrollment();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please do not leave blank sections with asterisk.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void resetTabData()
        {
            txt_Sname.Text = "";
            txt_Fname.Text = "";
            txt_Mname.Text = "";
            txt_Ext.Text = "";
            txt_Age.Text = "";
            dtP_Bday.Text = "";
            txt_Bplace.Text = "";
            txt_Religion.Text = "";
            txt_Add.Text = "";
            txt_Lrn.Text = "";
            txt_Cno.Text = "";
            txt_Cship.Text = "";
            txt_FaName.Text = "";
            txt_FaCo.Text = "";
            txt_FaOc.Text = "";
            txt_MoName.Text = "";
            txt_MoCo.Text = "";
            txt_MoOc.Text = "";
            txt_Gname.Text = "";
            txt_GCo.Text = "";
            chb_PSAyes.Checked = false;
            chb_Frm137yes.Checked = false;
            chb_GMCyes.Checked = false;
            chb_BCyes.Checked = false;
            chb_RcmdFrmyes.Checked = false;
            chb_PicYes.Checked = false;
            cbo_Sex.SelectedIndex = 0;
            tabControl1.SelectedTab = tabPage1;
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

        private void cbo_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
