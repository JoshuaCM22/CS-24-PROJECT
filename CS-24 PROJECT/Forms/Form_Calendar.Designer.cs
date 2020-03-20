namespace CS_24_PROJECT.Forms
{
    partial class Form_Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Calendar));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotalMonth = new System.Windows.Forms.Label();
            this.lblTotalDay = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProject3Calendar = new System.Windows.Forms.Label();
            this.lblProject2Calendar = new System.Windows.Forms.Label();
            this.lblProject1Calendar = new System.Windows.Forms.Label();
            this.btnProject1Calendar = new System.Windows.Forms.Button();
            this.btnProject2Calendar = new System.Windows.Forms.Button();
            this.btnProject3Calendar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrintPreviewOfMonthlyTotal = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Black;
            this.GroupBox1.Controls.Add(this.lblTitle);
            this.GroupBox1.Controls.Add(this.lblTotalMonth);
            this.GroupBox1.Controls.Add(this.lblTotalDay);
            this.GroupBox1.Controls.Add(this.DateTimePicker1);
            this.GroupBox1.Location = new System.Drawing.Point(302, 44);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(523, 329);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(182, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PROJECT-1";
            // 
            // lblTotalMonth
            // 
            this.lblTotalMonth.AutoSize = true;
            this.lblTotalMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMonth.ForeColor = System.Drawing.Color.White;
            this.lblTotalMonth.Location = new System.Drawing.Point(114, 193);
            this.lblTotalMonth.Name = "lblTotalMonth";
            this.lblTotalMonth.Size = new System.Drawing.Size(181, 25);
            this.lblTotalMonth.TabIndex = 0;
            this.lblTotalMonth.Text = "TOTAL MONTH:";
            // 
            // lblTotalDay
            // 
            this.lblTotalDay.AutoSize = true;
            this.lblTotalDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDay.ForeColor = System.Drawing.Color.White;
            this.lblTotalDay.Location = new System.Drawing.Point(147, 136);
            this.lblTotalDay.Name = "lblTotalDay";
            this.lblTotalDay.Size = new System.Drawing.Size(146, 25);
            this.lblTotalDay.TabIndex = 0;
            this.lblTotalDay.Text = "TOTAL DAY:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Location = new System.Drawing.Point(113, 252);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(309, 26);
            this.DateTimePicker1.TabIndex = 0;
            this.DateTimePicker1.TabStop = false;
            this.DateTimePicker1.Value = new System.DateTime(2018, 8, 7, 12, 15, 55, 0);
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.lblProject3Calendar);
            this.GroupBox2.Controls.Add(this.lblProject2Calendar);
            this.GroupBox2.Controls.Add(this.lblProject1Calendar);
            this.GroupBox2.Controls.Add(this.btnProject1Calendar);
            this.GroupBox2.Controls.Add(this.btnProject2Calendar);
            this.GroupBox2.Controls.Add(this.btnProject3Calendar);
            this.GroupBox2.Location = new System.Drawing.Point(38, 154);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(210, 219);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            // 
            // lblProject3Calendar
            // 
            this.lblProject3Calendar.AutoSize = true;
            this.lblProject3Calendar.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblProject3Calendar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblProject3Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject3Calendar.ForeColor = System.Drawing.Color.White;
            this.lblProject3Calendar.Location = new System.Drawing.Point(54, 157);
            this.lblProject3Calendar.Name = "lblProject3Calendar";
            this.lblProject3Calendar.Size = new System.Drawing.Size(101, 18);
            this.lblProject3Calendar.TabIndex = 0;
            this.lblProject3Calendar.Text = "PROJECT-3";
            // 
            // lblProject2Calendar
            // 
            this.lblProject2Calendar.AutoSize = true;
            this.lblProject2Calendar.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblProject2Calendar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblProject2Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject2Calendar.ForeColor = System.Drawing.Color.White;
            this.lblProject2Calendar.Location = new System.Drawing.Point(55, 100);
            this.lblProject2Calendar.Name = "lblProject2Calendar";
            this.lblProject2Calendar.Size = new System.Drawing.Size(101, 18);
            this.lblProject2Calendar.TabIndex = 0;
            this.lblProject2Calendar.Text = "PROJECT-2";
            // 
            // lblProject1Calendar
            // 
            this.lblProject1Calendar.AutoSize = true;
            this.lblProject1Calendar.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblProject1Calendar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblProject1Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject1Calendar.ForeColor = System.Drawing.Color.White;
            this.lblProject1Calendar.Location = new System.Drawing.Point(55, 41);
            this.lblProject1Calendar.Name = "lblProject1Calendar";
            this.lblProject1Calendar.Size = new System.Drawing.Size(101, 18);
            this.lblProject1Calendar.TabIndex = 0;
            this.lblProject1Calendar.Text = "PROJECT-1";
            // 
            // btnProject1Calendar
            // 
            this.btnProject1Calendar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProject1Calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject1Calendar.Enabled = false;
            this.btnProject1Calendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnProject1Calendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnProject1Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject1Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnProject1Calendar.ForeColor = System.Drawing.Color.White;
            this.btnProject1Calendar.Location = new System.Drawing.Point(36, 33);
            this.btnProject1Calendar.Name = "btnProject1Calendar";
            this.btnProject1Calendar.Size = new System.Drawing.Size(139, 35);
            this.btnProject1Calendar.TabIndex = 0;
            this.btnProject1Calendar.TabStop = false;
            this.btnProject1Calendar.UseVisualStyleBackColor = false;
            this.btnProject1Calendar.Click += new System.EventHandler(this.btnProject1Calendar_Click);
            // 
            // btnProject2Calendar
            // 
            this.btnProject2Calendar.BackColor = System.Drawing.Color.Black;
            this.btnProject2Calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject2Calendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnProject2Calendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnProject2Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject2Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject2Calendar.ForeColor = System.Drawing.Color.White;
            this.btnProject2Calendar.Location = new System.Drawing.Point(36, 92);
            this.btnProject2Calendar.Name = "btnProject2Calendar";
            this.btnProject2Calendar.Size = new System.Drawing.Size(139, 35);
            this.btnProject2Calendar.TabIndex = 0;
            this.btnProject2Calendar.TabStop = false;
            this.btnProject2Calendar.Text = "PROJECT-2";
            this.btnProject2Calendar.UseVisualStyleBackColor = false;
            this.btnProject2Calendar.Click += new System.EventHandler(this.btnProject2Calendar_Click);
            // 
            // btnProject3Calendar
            // 
            this.btnProject3Calendar.BackColor = System.Drawing.Color.Black;
            this.btnProject3Calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProject3Calendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnProject3Calendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnProject3Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProject3Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject3Calendar.ForeColor = System.Drawing.Color.White;
            this.btnProject3Calendar.Location = new System.Drawing.Point(36, 149);
            this.btnProject3Calendar.Name = "btnProject3Calendar";
            this.btnProject3Calendar.Size = new System.Drawing.Size(139, 35);
            this.btnProject3Calendar.TabIndex = 0;
            this.btnProject3Calendar.TabStop = false;
            this.btnProject3Calendar.Text = "PROJECT-3";
            this.btnProject3Calendar.UseVisualStyleBackColor = false;
            this.btnProject3Calendar.Click += new System.EventHandler(this.btnProject3Calendar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(38, 48);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrintPreviewOfMonthlyTotal
            // 
            this.btnPrintPreviewOfMonthlyTotal.BackColor = System.Drawing.Color.Black;
            this.btnPrintPreviewOfMonthlyTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPreviewOfMonthlyTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnPrintPreviewOfMonthlyTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnPrintPreviewOfMonthlyTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreviewOfMonthlyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreviewOfMonthlyTotal.ForeColor = System.Drawing.Color.White;
            this.btnPrintPreviewOfMonthlyTotal.Location = new System.Drawing.Point(408, 407);
            this.btnPrintPreviewOfMonthlyTotal.Name = "btnPrintPreviewOfMonthlyTotal";
            this.btnPrintPreviewOfMonthlyTotal.Size = new System.Drawing.Size(316, 43);
            this.btnPrintPreviewOfMonthlyTotal.TabIndex = 1;
            this.btnPrintPreviewOfMonthlyTotal.TabStop = false;
            this.btnPrintPreviewOfMonthlyTotal.Text = "PRINT PREVIEW OF MONTHLY TOTAL";
            this.btnPrintPreviewOfMonthlyTotal.UseVisualStyleBackColor = false;
            this.btnPrintPreviewOfMonthlyTotal.Click += new System.EventHandler(this.btnPrintPreviewOfMonthlyTotal_Click);
            // 
            // Form_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS_24_PROJECT.Properties.Resources.BG1;
            this.ClientSize = new System.Drawing.Size(865, 498);
            this.Controls.Add(this.btnPrintPreviewOfMonthlyTotal);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALENDAR";
            this.Load += new System.EventHandler(this.Form_Calendar_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label lblTotalMonth;
        internal System.Windows.Forms.Label lblTotalDay;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnProject1Calendar;
        internal System.Windows.Forms.Button btnProject2Calendar;
        internal System.Windows.Forms.Button btnProject3Calendar;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Label lblProject3Calendar;
        internal System.Windows.Forms.Label lblProject2Calendar;
        internal System.Windows.Forms.Label lblProject1Calendar;
        internal System.Windows.Forms.Button btnPrintPreviewOfMonthlyTotal;
    }
}