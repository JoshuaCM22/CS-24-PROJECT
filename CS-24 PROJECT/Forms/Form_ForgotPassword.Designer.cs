namespace CS_24_PROJECT.Forms
{
    partial class Form_ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ForgotPassword));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSecretQuestion = new System.Windows.Forms.ComboBox();
            this.chkShowSecretAnswer = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSecretAnswer = new System.Windows.Forms.TextBox();
            this.lblSecretAnswer = new System.Windows.Forms.Label();
            this.lblSecretQuestion = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.cmbSecretQuestion);
            this.GroupBox1.Controls.Add(this.chkShowSecretAnswer);
            this.GroupBox1.Controls.Add(this.btnSubmit);
            this.GroupBox1.Controls.Add(this.txtSecretAnswer);
            this.GroupBox1.Controls.Add(this.lblSecretAnswer);
            this.GroupBox1.Controls.Add(this.lblSecretQuestion);
            this.GroupBox1.Controls.Add(this.txtUsername);
            this.GroupBox1.Controls.Add(this.lblUsername);
            this.GroupBox1.Location = new System.Drawing.Point(20, 30);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(406, 283);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // cmbSecretQuestion
            // 
            this.cmbSecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecretQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecretQuestion.FormattingEnabled = true;
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
            this.cmbSecretQuestion.Location = new System.Drawing.Point(135, 89);
            this.cmbSecretQuestion.Name = "cmbSecretQuestion";
            this.cmbSecretQuestion.Size = new System.Drawing.Size(240, 25);
            this.cmbSecretQuestion.TabIndex = 2;
            // 
            // chkShowSecretAnswer
            // 
            this.chkShowSecretAnswer.AutoSize = true;
            this.chkShowSecretAnswer.BackColor = System.Drawing.Color.Transparent;
            this.chkShowSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowSecretAnswer.ForeColor = System.Drawing.Color.White;
            this.chkShowSecretAnswer.Location = new System.Drawing.Point(135, 169);
            this.chkShowSecretAnswer.Name = "chkShowSecretAnswer";
            this.chkShowSecretAnswer.Size = new System.Drawing.Size(144, 21);
            this.chkShowSecretAnswer.TabIndex = 0;
            this.chkShowSecretAnswer.TabStop = false;
            this.chkShowSecretAnswer.Text = "Show Secret Answer";
            this.chkShowSecretAnswer.UseVisualStyleBackColor = false;
            this.chkShowSecretAnswer.CheckedChanged += new System.EventHandler(this.chkShowSecretAnswer_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(135, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(162, 35);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSecretAnswer
            // 
            this.txtSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretAnswer.Location = new System.Drawing.Point(135, 129);
            this.txtSecretAnswer.MaxLength = 50;
            this.txtSecretAnswer.Name = "txtSecretAnswer";
            this.txtSecretAnswer.Size = new System.Drawing.Size(240, 25);
            this.txtSecretAnswer.TabIndex = 3;
            this.txtSecretAnswer.UseSystemPasswordChar = true;
            // 
            // lblSecretAnswer
            // 
            this.lblSecretAnswer.AutoSize = true;
            this.lblSecretAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretAnswer.ForeColor = System.Drawing.Color.White;
            this.lblSecretAnswer.Location = new System.Drawing.Point(30, 132);
            this.lblSecretAnswer.Name = "lblSecretAnswer";
            this.lblSecretAnswer.Size = new System.Drawing.Size(102, 20);
            this.lblSecretAnswer.TabIndex = 0;
            this.lblSecretAnswer.Text = "Secret Answer";
            // 
            // lblSecretQuestion
            // 
            this.lblSecretQuestion.AutoSize = true;
            this.lblSecretQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSecretQuestion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretQuestion.ForeColor = System.Drawing.Color.White;
            this.lblSecretQuestion.Location = new System.Drawing.Point(19, 92);
            this.lblSecretQuestion.Name = "lblSecretQuestion";
            this.lblSecretQuestion.Size = new System.Drawing.Size(113, 20);
            this.lblSecretQuestion.TabIndex = 0;
            this.lblSecretQuestion.Text = "Secret Question";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(135, 47);
            this.txtUsername.MaxLength = 14;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 25);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(57, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
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
            this.btnBack.Location = new System.Drawing.Point(315, 346);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form_ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS_24_PROJECT.Properties.Resources.BG1;
            this.ClientSize = new System.Drawing.Size(447, 397);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORGOT PASSWORD ?";
            this.Load += new System.EventHandler(this.Form_ForgotPassword_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cmbSecretQuestion;
        internal System.Windows.Forms.CheckBox chkShowSecretAnswer;
        internal System.Windows.Forms.TextBox txtSecretAnswer;
        internal System.Windows.Forms.Label lblSecretAnswer;
        internal System.Windows.Forms.Label lblSecretQuestion;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label lblUsername;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnSubmit;
    }
}