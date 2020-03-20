using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.chkShowPassword.Checked = false;
            this.ActiveControl = txtUsername;
        }
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool verifying = chkShowPassword.Checked == true ? txtPassword.UseSystemPasswordChar = false : txtPassword.UseSystemPasswordChar = true;
            this.ActiveControl = lblUsername;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "" && txtPassword.Text == ""))
            {
                MessageBox.Show("No Username and Password Found!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if ((txtUsername.Text == ""))
            {
                MessageBox.Show("No Username Found!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtUsername;
            }
            else if ((txtPassword.Text == ""))
            {
                MessageBox.Show("No Password Found!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtPassword;
            }
            else
            {
                LoginMethod();
            }
        }
        private void LoginMethod()
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("spLogin", Objects.con);
                Objects.cmd.CommandType = CommandType.StoredProcedure;
                Objects.cmd.Parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                Objects.dr = Objects.cmd.ExecuteReader();
                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    if (BCrypt.Net.BCrypt.Verify(txtPassword.Text, Objects.dr["Password"].ToString()))
                    {
                        var nextForm = new Form_Main();
                        Form_ChangePassword.usernameGetter = this.txtUsername.Text;
                        Form_ChangePassword.passwordGetter = this.txtPassword.Text;
                        Form_Main.accountName = Objects.dr["Full_Name"].ToString();
                        Form_Main.accountIDGetter = Convert.ToInt32(Objects.dr["ID"].ToString());
                        Objects.con.Close();
                        this.Hide();
                        Reset();
                        nextForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username And/Or Password!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        this.ActiveControl = txtPassword;
                        Objects.con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username And/Or Password!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                    Objects.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset();
            var nextForm = new Form_ForgotPassword();
            nextForm.ShowDialog();
        }
    }
}
