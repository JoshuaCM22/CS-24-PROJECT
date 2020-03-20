namespace CS_24_PROJECT.Forms
{
    partial class Form_ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChangePassword));
            this.btnBack = new System.Windows.Forms.Button();
            this.chkShowPassword2 = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.chkShowPassword1 = new System.Windows.Forms.CheckBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(268, 299);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkShowPassword2
            // 
            this.chkShowPassword2.AutoSize = true;
            this.chkShowPassword2.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword2.ForeColor = System.Drawing.Color.White;
            this.chkShowPassword2.Location = new System.Drawing.Point(209, 211);
            this.chkShowPassword2.Name = "chkShowPassword2";
            this.chkShowPassword2.Size = new System.Drawing.Size(118, 21);
            this.chkShowPassword2.TabIndex = 0;
            this.chkShowPassword2.TabStop = false;
            this.chkShowPassword2.Text = "Show Password";
            this.chkShowPassword2.UseVisualStyleBackColor = false;
            this.chkShowPassword2.CheckedChanged += new System.EventHandler(this.chkShowPassword2_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Black;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(77, 297);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(162, 30);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(209, 171);
            this.txtConfirmNewPassword.MaxLength = 14;
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(240, 25);
            this.txtConfirmNewPassword.TabIndex = 3;
            this.txtConfirmNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(42, 172);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(164, 20);
            this.lblConfirmNewPassword.TabIndex = 0;
            this.lblConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(209, 135);
            this.txtNewPassword.MaxLength = 14;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(240, 25);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(99, 140);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(107, 20);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "New Password:";
            // 
            // chkShowPassword1
            // 
            this.chkShowPassword1.AutoSize = true;
            this.chkShowPassword1.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword1.ForeColor = System.Drawing.Color.White;
            this.chkShowPassword1.Location = new System.Drawing.Point(209, 95);
            this.chkShowPassword1.Name = "chkShowPassword1";
            this.chkShowPassword1.Size = new System.Drawing.Size(118, 21);
            this.chkShowPassword1.TabIndex = 0;
            this.chkShowPassword1.TabStop = false;
            this.chkShowPassword1.Text = "Show Password";
            this.chkShowPassword1.UseVisualStyleBackColor = false;
            this.chkShowPassword1.CheckedChanged += new System.EventHandler(this.chkShowPassword1_CheckedChanged);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(209, 55);
            this.txtCurrentPassword.MaxLength = 14;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(240, 25);
            this.txtCurrentPassword.TabIndex = 1;
            this.txtCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPassword.Location = new System.Drawing.Point(81, 56);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(125, 20);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // Form_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS_24_PROJECT.Properties.Resources.BG1;
            this.ClientSize = new System.Drawing.Size(500, 372);
            this.Controls.Add(this.chkShowPassword1);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkShowPassword2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHANGE PASSWORD";
            this.Load += new System.EventHandler(this.Form_ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.CheckBox chkShowPassword2;
        internal System.Windows.Forms.Button btnConfirm;
        internal System.Windows.Forms.TextBox txtConfirmNewPassword;
        internal System.Windows.Forms.Label lblConfirmNewPassword;
        internal System.Windows.Forms.TextBox txtNewPassword;
        internal System.Windows.Forms.Label lblNewPassword;
        internal System.Windows.Forms.CheckBox chkShowPassword1;
        internal System.Windows.Forms.TextBox txtCurrentPassword;
        internal System.Windows.Forms.Label lblCurrentPassword;
    }
}