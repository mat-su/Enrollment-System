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
    public partial class frm_Login : Form
    {

        public frm_Login()
        {
            InitializeComponent();

        }
        private int loginAttempt = 1;

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Username")
            {
                txt_Username.Text = "";
                txt_Username.ForeColor = Color.Black;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "Password")
            {
                txt_Pass.Text = "";
                txt_Pass.PasswordChar = '*';
                txt_Pass.ForeColor = Color.Black;
            }
        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                txt_Username.Text = "Username";
                txt_Username.ForeColor = Color.Silver;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Pass.Text == "")
            {
                txt_Pass.Text = "Password";
                txt_Pass.ForeColor = Color.Silver;
            }
        }


        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");


        private void btn_Login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void link_regi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            New_Account form = new New_Account();
            form.Show();
            this.Hide();
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
        private void login()
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("sp_ACCOUNTS", sqlcon);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "LOGIN";
            sda.SelectCommand.Parameters.Add("@S_NAME", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@F_NAME", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@C_NO", SqlDbType.VarChar, (50)).Value = "";
            sda.SelectCommand.Parameters.Add("@ADDRESS", SqlDbType.VarChar, (200)).Value = "";
            sda.SelectCommand.Parameters.Add("@USERNAME", SqlDbType.VarChar, (200)).Value = txt_Username.Text;
            sda.SelectCommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar, (200)).Value = txt_Pass.Text;
            sda.SelectCommand.ExecuteNonQuery();

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Dashboard form = new Dashboard();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Log in Failed!!\nCheck your username and password.\nAttempts done: " + loginAttempt + " out of 3", "WARNING", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                loginAttempt++;

                txt_Username.Text = "";
                txt_Pass.Text = "";

                if (loginAttempt == 4)
                {
                    MessageBox.Show("You have reached the maximum number of attempts. \nProgram will now close.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
            sqlcon.Close();
        }
    }
}
