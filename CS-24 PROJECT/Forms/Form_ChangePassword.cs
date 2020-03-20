using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_ChangePassword : Form
    {
        public Form_ChangePassword()
        {
            InitializeComponent();
        }
        public static string usernameGetter, passwordGetter;
        private void Form_ChangePassword_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmNewPassword.Clear();
            chkShowPassword1.Checked = false;
            chkShowPassword2.Checked = false;
            this.ActiveControl = txtCurrentPassword;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if ((txtCurrentPassword.Text == "" && txtNewPassword.Text == "" && txtConfirmNewPassword.Text == ""))
            {
                MessageBox.Show("Fill up your password details", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtCurrentPassword;
            }
            else if (txtCurrentPassword.Text == "")
            {
                MessageBox.Show("No Current Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtCurrentPassword;
            }
            else if (txtNewPassword.Text == "")
            {
                MessageBox.Show("No New Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtNewPassword;
            }
            else if (txtConfirmNewPassword.Text == "")
            {
                MessageBox.Show("No Confirm Password Found", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtConfirmNewPassword;
            }
            else
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_accounts] WHERE [username] = @username", Objects.con);
                Objects.cmd.CommandType = System.Data.CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@username", usernameGetter));
                Objects.dr = Objects.cmd.ExecuteReader();
                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    if (BCrypt.Net.BCrypt.Verify(txtCurrentPassword.Text, Objects.dr["password"].ToString()))
                    {
                        Objects.dr.Close();
                        Objects.con.Close();
                        Comparing();
                    }
                    else
                    {
                        Objects.dr.Close();
                        Objects.con.Close();
                        MessageBox.Show("Current Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCurrentPassword.Clear();
                        this.ActiveControl = txtCurrentPassword;
                    }
                }
            }
        }
        private void Comparing()
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("Your New Password and Confirm New Password are not same!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtConfirmNewPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Your New Password and Confirm New Password are not same!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_accounts] WHERE [username] = @username", Objects.con);
                    Objects.cmd.CommandType = System.Data.CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@username", usernameGetter));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        if (BCrypt.Net.BCrypt.Verify(txtConfirmNewPassword.Text, Objects.dr["password"].ToString()))
                        {
                            Objects.dr.Close();
                            Objects.con.Close();
                            MessageBox.Show("Your new and confirm password is currently used, please try another password!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Objects.dr.Close();
                            Objects.con.Close();
                            Updating();
                        }
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
        private void Updating()
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("UPDATE [tbl_accounts] SET [password] = @password WHERE [username] = @username", Objects.con);
                Objects.cmd.CommandType = System.Data.CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@password", BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text)));
                Objects.cmd.Parameters.Add(new OleDbParameter("@username", usernameGetter));
                Objects.cmd.ExecuteNonQuery();
                Objects.con.Close();
                MessageBox.Show("SUCCESSFULLY CHANGED", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passwordGetter = txtNewPassword.Text;
                this.Hide();
                Reset();
                var nextForm = new Form_Main();
                nextForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
        private void chkShowPassword1_CheckedChanged(object sender, EventArgs e)
        {
            bool verifying;
            verifying = chkShowPassword1.Checked == true ? txtCurrentPassword.UseSystemPasswordChar = false : txtCurrentPassword.UseSystemPasswordChar = true;
            this.ActiveControl = lblNewPassword;
        }
        private void chkShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            bool verifying;
            verifying = chkShowPassword2.Checked == true ? txtNewPassword.UseSystemPasswordChar = false : txtNewPassword.UseSystemPasswordChar = true;
            verifying = chkShowPassword2.Checked == true ? txtConfirmNewPassword.UseSystemPasswordChar = false : txtConfirmNewPassword.UseSystemPasswordChar = true;
            this.ActiveControl = lblNewPassword;
        }
        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text == String.Empty)
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
