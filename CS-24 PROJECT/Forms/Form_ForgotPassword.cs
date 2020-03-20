using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_ForgotPassword : Form
    {
        private string username = "";
        public Form_ForgotPassword()
        {
            InitializeComponent();
        }
        private void Form_ForgotPassword_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtUsername.Clear();
            cmbSecretQuestion.Text = "None";
            txtSecretAnswer.Clear();
            chkShowSecretAnswer.Checked = false;
            this.ActiveControl = txtUsername;
            btnBack.Text = "BACK";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnBack.Text == "BACK")
            {
                this.Hide();
                Reset();
                Form_Login nextForm = new Form_Login();
                nextForm.ShowDialog();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel ?", "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    Reset();
                    Form_Login nextForm = new Form_Login();
                    nextForm.ShowDialog();
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "" && cmbSecretQuestion.Text == "None" && txtSecretAnswer.Text == ""))
            {
                MessageBox.Show("Fill up account details!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("No Username Found!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if (cmbSecretQuestion.Text == "None")
            {
                MessageBox.Show("No Secret Question Found!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = cmbSecretQuestion;
            }
            else if (txtSecretAnswer.Text == "")
            {
                MessageBox.Show("No Secret Answer Found!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtSecretAnswer;
            }
            else
            {
                try
                {
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_accounts] WHERE [username]= @username AND StrComp(secret_question,@secretquestion,0) = 0;", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@secretquestion", cmbSecretQuestion.Text));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        if (BCrypt.Net.BCrypt.Verify(txtSecretAnswer.Text, Objects.dr["Secret_Answer"].ToString()))
                        {
                            Form_SetANewPassword nextForm = new Form_SetANewPassword();
                            nextForm.accountID = Objects.dr["ID"].ToString();
                            Objects.con.Close();
                            Objects.dr.Close();
                            Reset();
                            this.Hide();
                            nextForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Your account details is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Objects.dr.Close();
                            Objects.con.Close();
                            txtSecretAnswer.Clear();
                            txtSecretAnswer.Focus();
                        }
                    }
                    else
                    {
                        Reset();
                        MessageBox.Show("Your account details is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                }
                finally
                {
                    Objects.con.Close();
                }
            }
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT secret_question FROM [tbl_accounts] WHERE [username]=@username", Objects.con);
                Objects.cmd.CommandType = System.Data.CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                Objects.dr = Objects.cmd.ExecuteReader();
                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    cmbSecretQuestion.Text = Objects.dr["secret_question"].ToString();
                    Objects.con.Close();
                    username = txtUsername.Text;
                }
                else
                {
                    cmbSecretQuestion.Text = "None";
                    Objects.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Objects.con.Close();
            }

            if (txtUsername.Text == String.Empty)
            {
                btnBack.Text = "BACK";
            }
            else
            {
                btnBack.Text = "CANCEL";
            }
        }
        private void chkShowSecretAnswer_CheckedChanged(object sender, EventArgs e)
        {
            bool verifying = chkShowSecretAnswer.Checked == true ? txtSecretAnswer.UseSystemPasswordChar = false : txtSecretAnswer.UseSystemPasswordChar = true;
            this.ActiveControl = lblUsername;
        }
    }
}
