using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_SetANewPassword : Form
    {
        public string accountID;
        public Form_SetANewPassword()
        {
            InitializeComponent();
        }
        private void Form_SetANewPassword_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtNewPassword.Clear();
            txtConfirmNewPassword.Clear();
            chkShowPassword.Checked = false;
            this.ActiveControl = txtNewPassword;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
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
                Comparing();
            }
        }
        private void Comparing()
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("Your New Password and Confirm New Password are not the same!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtConfirmNewPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Your New Password and Confirm New Password are not the same!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SettingANewPassword();
            }
        }
        private void SettingANewPassword()
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("UPDATE [tbl_accounts] SET [password]=@password WHERE [ID]=@ID ", Objects.con);
                Objects.cmd.CommandType = System.Data.CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@password", BCrypt.Net.BCrypt.HashPassword(txtConfirmNewPassword.Text)));
                Objects.cmd.Parameters.Add(new OleDbParameter("@ID", accountID));
                Objects.cmd.ExecuteNonQuery();
                Objects.con.Close();
                MessageBox.Show("SUCCESSFULLY UPDATED YOUR PASSWORD", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Reset();
                var nextForm = new Form_Login();
                nextForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnBack.Text == "BACK")
            {
                this.Hide();
                Reset();
                Form_ForgotPassword nextForm = new Form_ForgotPassword();
                nextForm.ShowDialog();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel ?", "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    Reset();
                    Form_ForgotPassword nextForm = new Form_ForgotPassword();
                    nextForm.ShowDialog();
                }
            }
        }
        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == String.Empty)
            {
                btnBack.Text = "BACK";
            }
            else
            {
                btnBack.Text = "CANCEL";
            }
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool verifying;
            verifying = chkShowPassword.Checked == true ? txtNewPassword.UseSystemPasswordChar = false : txtNewPassword.UseSystemPasswordChar = true;
            verifying = chkShowPassword.Checked == true ? txtConfirmNewPassword.UseSystemPasswordChar = false : txtConfirmNewPassword.UseSystemPasswordChar = true;
            this.ActiveControl = lblNewPassword;
        }
        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtConfirmNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
