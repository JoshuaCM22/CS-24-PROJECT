using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_CreateAnotherAccount : Form
    {
        public Form_CreateAnotherAccount()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            chkShowPassword.Checked = false;
            txtGivenName.Clear();
            txtMiddleInitial.Clear();
            txtLastName.Clear();
            txtSuffix.Clear();
            cmbSecretQuestion.SelectedIndex = 0;
            txtSecretAnswer.Clear();
        }
        private void Form_CreateAnotherAccount_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool verifying;
            verifying = chkShowPassword.Checked == true ? txtPassword.UseSystemPasswordChar = false : txtPassword.UseSystemPasswordChar = true;
            this.ActiveControl = lblUsername;
        }
        private void chkShowSecretAnswer_CheckedChanged(object sender, EventArgs e)
        {
            bool verifying;
            verifying = chkShowSecretAnswer.Checked == true ? txtSecretAnswer.UseSystemPasswordChar = false : txtSecretAnswer.UseSystemPasswordChar = true;
            this.ActiveControl = lblUsername;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "" && txtPassword.Text == "" && txtGivenName.Text == "" && txtMiddleInitial.Text == "" && txtLastName.Text == "" && cmbSecretQuestion.Text == "None" && txtSecretAnswer.Text == ""))
            {
                MessageBox.Show("Fill up account details", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("No Username Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("No Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtPassword;
            }
            else if (txtGivenName.Text == "")
            {
                MessageBox.Show("No Given Name Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtGivenName;
            }
            else if (txtMiddleInitial.Text == "")
            {
                MessageBox.Show("No Middle Initial Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtMiddleInitial;
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("No Last Name Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtLastName;
            }
            else if (cmbSecretQuestion.Text == "None")
            {
                MessageBox.Show("No Secret Question Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = cmbSecretQuestion;
            }
            else if (txtSecretAnswer.Text == "")
            {
                MessageBox.Show("No Secret Answer Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtSecretAnswer;
            }
            else
            {
                try
                {
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_accounts] WHERE [username]=@username", Objects.con);
                    Objects.cmd.CommandType = System.Data.CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        MessageBox.Show("This Username is already taken, Please try different Username", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Objects.con.Close();
                        this.ActiveControl = txtUsername;
                    }
                    else
                    {
                        Objects.con.Close();
                        AutoIncrementID();
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
            }
        }
        private string accountID;
        private void AutoIncrementID()
        {
            Objects.con.Open();
            Objects.cmd = new OleDbCommand("SELECT (COUNT(ID) + 1) FROM [tbl_accounts]", Objects.con);
            accountID = Objects.cmd.ExecuteScalar().ToString();
            Objects.cmd.Dispose();
            Objects.con.Close();
            CreatingAccount();
        }
        private void CreatingAccount()
        {
            try
            {
                char space = ' ';
                string fullName = "";
                if (txtSuffix.Text == String.Empty)
                {
                    fullName = txtGivenName.Text + space + txtMiddleInitial.Text + "." + space + txtLastName.Text;
                }
                else
                {
                    fullName = txtGivenName.Text + space + txtMiddleInitial.Text + "." + space + txtLastName.Text + space + txtSuffix.Text + ".";
                }
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("spCreateNewAccount", Objects.con);
                Objects.cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Objects.cmd.Parameters.Add(new OleDbParameter("@ID", accountID));
                Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                Objects.cmd.Parameters.Add(new OleDbParameter("@password", BCrypt.Net.BCrypt.HashPassword(txtPassword.Text)));
                Objects.cmd.Parameters.Add(new OleDbParameter("@full_name", fullName));
                Objects.cmd.Parameters.Add(new OleDbParameter("@secret_question", cmbSecretQuestion.Text));
                Objects.cmd.Parameters.Add(new OleDbParameter("@secret_answer", BCrypt.Net.BCrypt.HashPassword(txtSecretAnswer.Text)));
                Objects.cmd.ExecuteNonQuery();
                Objects.con.Close();
                Reset();
                MessageBox.Show("Successfully Created!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnBack.Text == "BACK")
            {
                this.Hide();
                Reset();
                var nextForm = new Form_Main();
                nextForm.ShowDialog();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel ?", "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    Reset();
                    var nextForm = new Form_Main();
                    nextForm.ShowDialog();
                }
            }
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == String.Empty)
            {
                btnBack.Text = "BACK";
            }
            else
            {
                btnBack.Text = "CANCEL";
            }
        }
    }
}
