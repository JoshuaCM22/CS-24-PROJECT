namespace CS_24_PROJECT.Forms
{
    partial class Form_CreateAnotherAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CreateAnotherAccount));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cmbSecretQuestion = new System.Windows.Forms.ComboBox();
            this.chkShowSecretAnswer = new System.Windows.Forms.CheckBox();
            this.txtSecretAnswer = new System.Windows.Forms.TextBox();
            this.lblSecretAnswer = new System.Windows.Forms.Label();
            this.lblSecretQuestion = new System.Windows.Forms.Label();
            this.txtGivenName = new System.Windows.Forms.TextBox();
            this.lblGivenName = new System.Windows.Forms.Label();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.txtSuffix);
            this.GroupBox1.Controls.Add(this.lblSuffix);
            this.GroupBox1.Controls.Add(this.txtLastName);
            this.GroupBox1.Controls.Add(this.lblLastName);
            this.GroupBox1.Controls.Add(this.txtMiddleInitial);
            this.GroupBox1.Controls.Add(this.lblMiddleInitial);
            this.GroupBox1.Controls.Add(this.txtGivenName);
            this.GroupBox1.Controls.Add(this.lblGivenName);
            this.GroupBox1.Controls.Add(this.txtPassword);
            this.GroupBox1.Controls.Add(this.chkShowPassword);
            this.GroupBox1.Controls.Add(this.txtUsername);
            this.GroupBox1.Controls.Add(this.lblPassword);
            this.GroupBox1.Controls.Add(this.lblUsername);
            this.GroupBox1.Controls.Add(this.cmbSecretQuestion);
            this.GroupBox1.Controls.Add(this.chkShowSecretAnswer);
            this.GroupBox1.Controls.Add(this.txtSecretAnswer);
            this.GroupBox1.Controls.Add(this.lblSecretAnswer);
            this.GroupBox1.Controls.Add(this.lblSecretQuestion);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBox1.Location = new System.Drawing.Point(46, 25);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(435, 424);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(149, 86);
            this.txtPassword.MaxLength = 14;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.FlatAppearance.BorderSize = 0;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.White;
            this.chkShowPassword.Location = new System.Drawing.Point(149, 117);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(118, 21);
            this.chkShowPassword.TabIndex = 0;
            this.chkShowPassword.TabStop = false;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(149, 48);
            this.txtUsername.MaxLength = 14;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(234, 25);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(74, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(69, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // cmbSecretQuestion
            // 
            this.cmbSecretQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecretQuestion.FormattingEnabled = true;
            this.cmbSecretQuestion.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.cmbSecretQuestion.Items.AddRange(new object[] {
            "None",
            "What is your favorite color?",
            "What is your contact number?",
            "When is your birthday?",
            "What is love for you?",
            "Where were you born ?",
            "What is the meaning of life?",
            "What is your gender?",
            "What is your civil status in life?",
            "What is your dream in life?",
            "What things that makes you happy?",
            "What things that makes you sad?",
            "What things that makes you mad?",
            "What is your job?",
            "What is your favorite song?",
            "What is your favorite band?",
            "What is your favorite singer?"});
            this.cmbSecretQuestion.Location = new System.Drawing.Point(149, 296);
            this.cmbSecretQuestion.Name = "cmbSecretQuestion";
            this.cmbSecretQuestion.Size = new System.Drawing.Size(234, 25);
            this.cmbSecretQuestion.TabIndex = 7;
            // 
            // chkShowSecretAnswer
            // 
            this.chkShowSecretAnswer.AutoSize = true;
            this.chkShowSecretAnswer.BackColor = System.Drawing.Color.Transparent;
            this.chkShowSecretAnswer.FlatAppearance.BorderSize = 0;
            this.chkShowSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowSecretAnswer.ForeColor = System.Drawing.Color.White;
            this.chkShowSecretAnswer.Location = new System.Drawing.Point(147, 367);
            this.chkShowSecretAnswer.Name = "chkShowSecretAnswer";
            this.chkShowSecretAnswer.Size = new System.Drawing.Size(144, 21);
            this.chkShowSecretAnswer.TabIndex = 0;
            this.chkShowSecretAnswer.TabStop = false;
            this.chkShowSecretAnswer.Text = "Show Secret Answer";
            this.chkShowSecretAnswer.UseVisualStyleBackColor = false;
            this.chkShowSecretAnswer.CheckedChanged += new System.EventHandler(this.chkShowSecretAnswer_CheckedChanged);
            // 
            // txtSecretAnswer
            // 
            this.txtSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretAnswer.Location = new System.Drawing.Point(149, 330);
            this.txtSecretAnswer.MaxLength = 50;
            this.txtSecretAnswer.Name = "txtSecretAnswer";
            this.txtSecretAnswer.Size = new System.Drawing.Size(234, 25);
            this.txtSecretAnswer.TabIndex = 8;
            this.txtSecretAnswer.UseSystemPasswordChar = true;
            // 
            // lblSecretAnswer
            // 
            this.lblSecretAnswer.AutoSize = true;
            this.lblSecretAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretAnswer.ForeColor = System.Drawing.Color.White;
            this.lblSecretAnswer.Location = new System.Drawing.Point(44, 331);
            this.lblSecretAnswer.Name = "lblSecretAnswer";
            this.lblSecretAnswer.Size = new System.Drawing.Size(102, 20);
            this.lblSecretAnswer.TabIndex = 0;
            this.lblSecretAnswer.Text = "Secret Answer";
            // 
            // lblSecretQuestion
            // 
            this.lblSecretQuestion.AutoSize = true;
            this.lblSecretQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretQuestion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretQuestion.ForeColor = System.Drawing.Color.White;
            this.lblSecretQuestion.Location = new System.Drawing.Point(32, 297);
            this.lblSecretQuestion.Name = "lblSecretQuestion";
            this.lblSecretQuestion.Size = new System.Drawing.Size(113, 20);
            this.lblSecretQuestion.TabIndex = 0;
            this.lblSecretQuestion.Text = "Secret Question";
            // 
            // txtGivenName
            // 
            this.txtGivenName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGivenName.Location = new System.Drawing.Point(149, 153);
            this.txtGivenName.MaxLength = 15;
            this.txtGivenName.Name = "txtGivenName";
            this.txtGivenName.Size = new System.Drawing.Size(234, 25);
            this.txtGivenName.TabIndex = 3;
            // 
            // lblGivenName
            // 
            this.lblGivenName.AutoSize = true;
            this.lblGivenName.BackColor = System.Drawing.Color.Transparent;
            this.lblGivenName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGivenName.ForeColor = System.Drawing.Color.White;
            this.lblGivenName.Location = new System.Drawing.Point(55, 155);
            this.lblGivenName.Name = "lblGivenName";
            this.lblGivenName.Size = new System.Drawing.Size(90, 20);
            this.lblGivenName.TabIndex = 0;
            this.lblGivenName.Text = "Given Name";
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.Location = new System.Drawing.Point(149, 189);
            this.txtMiddleInitial.MaxLength = 1;
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(234, 25);
            this.txtMiddleInitial.TabIndex = 4;
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddleInitial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleInitial.ForeColor = System.Drawing.Color.White;
            this.lblMiddleInitial.Location = new System.Drawing.Point(50, 191);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(97, 20);
            this.lblMiddleInitial.TabIndex = 0;
            this.lblMiddleInitial.Text = "Middle Initial";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(149, 225);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(234, 25);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(67, 227);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuffix.Location = new System.Drawing.Point(149, 261);
            this.txtSuffix.MaxLength = 2;
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(234, 25);
            this.txtSuffix.TabIndex = 6;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.BackColor = System.Drawing.Color.Transparent;
            this.lblSuffix.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.ForeColor = System.Drawing.Color.White;
            this.lblSuffix.Location = new System.Drawing.Point(99, 264);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(46, 20);
            this.lblSuffix.TabIndex = 0;
            this.lblSuffix.Text = "Suffix";
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
            this.btnBack.Location = new System.Drawing.Point(276, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(85, 488);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(162, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form_CreateAnotherAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS_24_PROJECT.Properties.Resources.BG1;
            this.ClientSize = new System.Drawing.Size(530, 555);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CreateAnotherAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREATE ANOTHER ACCOUNT";
            this.Load += new System.EventHandler(this.Form_CreateAnotherAccount_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtSuffix;
        internal System.Windows.Forms.Label lblSuffix;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtMiddleInitial;
        internal System.Windows.Forms.Label lblMiddleInitial;
        internal System.Windows.Forms.TextBox txtGivenName;
        internal System.Windows.Forms.Label lblGivenName;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.CheckBox chkShowPassword;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.Label lblUsername;
        internal System.Windows.Forms.ComboBox cmbSecretQuestion;
        internal System.Windows.Forms.CheckBox chkShowSecretAnswer;
        internal System.Windows.Forms.TextBox txtSecretAnswer;
        internal System.Windows.Forms.Label lblSecretAnswer;
        internal System.Windows.Forms.Label lblSecretQuestion;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnCreate;
    }
}