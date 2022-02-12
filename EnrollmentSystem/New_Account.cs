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
using System.Text.RegularExpressions;


namespace EnrollmentSystem
{
    public partial class New_Account : Form
    {
        public New_Account()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            frm_Login form = new frm_Login();
            form.Show();
            this.Hide();
        }

        private void btn_regAccount_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[()\"":;'\/\.,\\{}|?>[\]<~`!@#$%^&*=+_-])[0-9a-zA-Z()\"":;'\/\.,\\{}|?>[\]<~`!@#$%^&*=+_-]{8,}$");

            if (surname.Text != "" && firstname.Text != "" && contactno.Text != "" && address.Text != "" && username.Text != "" && password.Text != "" && txt_VerPass.Text != "")
            {
                if (regex.IsMatch(password.Text))
                {
                    if (password.Text == txt_VerPass.Text)
                    {
                        sqlcon.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("sp_ACCOUNTS", sqlcon);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "CREATE";
                        sda.SelectCommand.Parameters.Add("@S_NAME", SqlDbType.VarChar, (50)).Value = surname.Text;
                        sda.SelectCommand.Parameters.Add("@F_NAME", SqlDbType.VarChar, (50)).Value = firstname.Text;
                        sda.SelectCommand.Parameters.Add("@C_NO", SqlDbType.VarChar, (50)).Value = contactno.Text;
                        sda.SelectCommand.Parameters.Add("@ADDRESS", SqlDbType.VarChar, (200)).Value = address.Text;
                        sda.SelectCommand.Parameters.Add("@USERNAME", SqlDbType.VarChar, (200)).Value = username.Text;
                        sda.SelectCommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar, (200)).Value = password.Text;
                        sda.SelectCommand.ExecuteNonQuery();
                        sqlcon.Close();

                        MessageBox.Show("You are successfully registered! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frm_Login form = new frm_Login();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password not matched in confirm password...please reenter it again.");
                        txt_VerPass.Focus();
                    }
                }
                else
                {
                    lbl_restrict.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please fill up all the information required! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            lbl_restrict.Visible = false;
        }

    }
}
