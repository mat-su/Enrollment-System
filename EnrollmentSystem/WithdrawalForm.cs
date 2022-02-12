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
    public partial class WithdrawalForm : Form
    {
        public WithdrawalForm()
        {
            InitializeComponent();

            lbl_LRN.Text = Enrollment.LRN;
            lbl_FullName.Text = Enrollment.StudName;
            lbl_SY.Text = Enrollment.SY;
            lbl_Glvl.Text = Enrollment.GLVL;
            
        }
        Enrollment form = new Enrollment();
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=DB_ES;Integrated Security=True");
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            dtp_date.Text = DateTime.Now.ToShortDateString();
            String reason = "";
            if (chb_tran.Checked == true)
                reason = "Transferring";
            if (chb_Ill.Checked == true)
                reason = "Illness";
            if (chb_change.Checked == true)
                reason = "Change of home address";
            if (chb_others.Checked == true)
                reason = txt_reason.Text;


            if (chb_tran.Checked == true || chb_Ill.Checked == true || chb_change.Checked == true || chb_others.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to  withdraw this student?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("sp_WITHDRAW",sqlcon);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.Add("@CMD", SqlDbType.VarChar, (50)).Value = "WITHDRAW";
                    sda.SelectCommand.Parameters.Add("@LRN", SqlDbType.VarChar, (50)).Value = lbl_LRN.Text;
                    sda.SelectCommand.Parameters.Add("@STUD_NAME", SqlDbType.VarChar, (150)).Value = lbl_FullName.Text;
                    sda.SelectCommand.Parameters.Add("@SY", SqlDbType.VarChar, (50)).Value = lbl_SY.Text;
                    sda.SelectCommand.Parameters.Add("@GLVL", SqlDbType.VarChar, (50)).Value = lbl_Glvl.Text;
                    sda.SelectCommand.Parameters.Add("@REASON", SqlDbType.VarChar, (150)).Value = reason;
                    sda.SelectCommand.Parameters.Add("DATE_WDW", SqlDbType.VarChar, (50)).Value = dtp_date.Text;
                    sda.SelectCommand.ExecuteNonQuery();

                    MessageBox.Show("Successfully WITHDRAWN", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    form.Show();
                    form.refresh_EnrList();


                    sda.Dispose();
                    sqlcon.Close();
                }

            }
            else
            {
                MessageBox.Show("Please choose your REASONS FOR LEAVING to proceed.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void chb_tran_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_tran.Checked == true)
            {
                chb_Ill.Checked = false;
                chb_change.Checked = false;
                chb_others.Checked = false;
                lbl_specify.Visible = false;
                txt_reason.Visible = false;
            }
        }

        private void chb_Ill_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Ill.Checked == true)
            {
                chb_tran.Checked = false;
                chb_change.Checked = false;
                chb_others.Checked = false;
                lbl_specify.Visible = false;
                txt_reason.Visible = false;
            }
        }

        private void chb_change_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_change.Checked == true)
            {
                chb_Ill.Checked = false;
                chb_tran.Checked = false;
                chb_others.Checked = false;
                lbl_specify.Visible = false;
                txt_reason.Visible = false;
            }
        }

        private void chb_others_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_others.Checked == true)
            {
                chb_Ill.Checked = false;
                chb_change.Checked = false;
                chb_tran.Checked = false;
                lbl_specify.Visible = true;
                txt_reason.Visible = true;
            }
        }
    }
}
