using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_Calendar : Form
    {
        public Form_Calendar()
        {
            InitializeComponent();
        }
        private void Form_Calendar_Load(object sender, EventArgs e)
        {
            Reset();
            GetValueForTodayDate(1);
        }
        private void Reset()
        {
            lblTitle.Text = "PROJECT-1";
            btnProject1Calendar.Enabled = false;
            btnProject2Calendar.Enabled = true;
            btnProject3Calendar.Enabled = true;
            btnProject1Calendar.Text = "";
            btnProject2Calendar.Text = "PROJECT-2";
            btnProject3Calendar.Text = "PROJECT-3";
            lblProject1Calendar.Visible = true;
            lblProject2Calendar.Visible = false;
            lblProject3Calendar.Visible = false;
            btnProject1Calendar.BackColor = System.Drawing.SystemColors.Highlight;
            btnProject2Calendar.BackColor = System.Drawing.Color.Black;
            btnProject3Calendar.BackColor = System.Drawing.Color.Black;
            DateTime value = Convert.ToDateTime(Form_Main.dateToday);
            DateTimePicker1.Value = value;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextForm = new Form_Main();
            nextForm.ShowDialog();
        }
        private void btnProject1Calendar_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "PROJECT-1";
            btnProject1Calendar.Enabled = false;
            btnProject2Calendar.Enabled = true;
            btnProject3Calendar.Enabled = true;
            btnProject1Calendar.Text = "";
            btnProject2Calendar.Text = "PROJECT-2";
            btnProject3Calendar.Text = "PROJECT-3";
            lblProject1Calendar.Visible = true;
            lblProject2Calendar.Visible = false;
            lblProject3Calendar.Visible = false;
            btnProject1Calendar.BackColor = System.Drawing.SystemColors.Highlight;
            btnProject2Calendar.BackColor = System.Drawing.Color.Black;
            btnProject3Calendar.BackColor = System.Drawing.Color.Black;
            GetValueForTodayDate(1);
            DateTime value = Convert.ToDateTime(Form_Main.dateToday);
            DateTimePicker1.Value = value;
            this.ActiveControl = lblTitle;
        }
        private void btnProject2Calendar_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "PROJECT-2";
            btnProject1Calendar.Enabled = true;
            btnProject2Calendar.Enabled = false;
            btnProject3Calendar.Enabled = true;
            btnProject1Calendar.Text = "PROJECT-1";
            btnProject2Calendar.Text = "";
            btnProject3Calendar.Text = "PROJECT-3";
            lblProject1Calendar.Visible = false;
            lblProject2Calendar.Visible = true;
            lblProject3Calendar.Visible = false;
            btnProject1Calendar.BackColor = System.Drawing.Color.Black;
            btnProject2Calendar.BackColor = System.Drawing.SystemColors.Highlight;
            btnProject3Calendar.BackColor = System.Drawing.Color.Black;
            GetValueForTodayDate(2);
            DateTime value = Convert.ToDateTime(Form_Main.dateToday);
            DateTimePicker1.Value = value;
            this.ActiveControl = lblTitle;
        }
        private void btnProject3Calendar_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "PROJECT-3";
            btnProject1Calendar.Enabled = true;
            btnProject2Calendar.Enabled = true;
            btnProject3Calendar.Enabled = false;
            btnProject1Calendar.Text = "PROJECT-1";
            btnProject2Calendar.Text = "PROJECT-2";
            btnProject3Calendar.Text = "";
            lblProject1Calendar.Visible = false;
            lblProject2Calendar.Visible = false;
            lblProject3Calendar.Visible = true;
            btnProject1Calendar.BackColor = System.Drawing.Color.Black;
            btnProject2Calendar.BackColor = System.Drawing.Color.Black;
            btnProject3Calendar.BackColor = System.Drawing.SystemColors.Highlight;
            GetValueForTodayDate(3);
            DateTime value = Convert.ToDateTime(Form_Main.dateToday);
            DateTimePicker1.Value = value;
            this.ActiveControl = lblTitle;
        }
        private void GetValueForTodayDate(int param_Project)
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT DISTINCT [total_ID] FROM [tbl_records] WHERE date_ID=@date_ID AND project_ID=@project_ID", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", Form_Main.dateIDTodayGetter));
                Objects.cmd.Parameters.Add(new OleDbParameter("@project_ID", param_Project));
                int totalID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                Objects.cmd.Dispose();
                Objects.con.Close();

                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [total] FROM [tbl_totals] WHERE ID=@ID", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@ID", totalID));
                string totalValue = Objects.cmd.ExecuteScalar().ToString();
                lblTotalDay.Text = "TOTAL DAY: " + MakingComma(totalValue);
                Objects.cmd.Dispose();
                Objects.con.Close();
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
        private void Searching(int param_Project)
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [ID] FROM [tbl_date] WHERE date=@date", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@date", DateTimePicker1.Value));
                int dateID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                Objects.cmd.Dispose();
                Objects.con.Close();

                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE date_ID=@date_ID AND project_ID=@project_ID", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateID));
                Objects.cmd.Parameters.Add(new OleDbParameter("@project_ID", param_Project));
                int totalID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                Objects.cmd.Dispose();
                Objects.dr.Close();
                Objects.con.Close();

                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [total] FROM [tbl_totals] WHERE ID=@ID", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@ID", totalID));
                string totalValue = Objects.cmd.ExecuteScalar().ToString();
                lblTotalDay.Text = "TOTAL DAY: " + MakingComma(totalValue);
                Objects.cmd.Dispose();
                Objects.con.Close();
                this.ActiveControl = lblTitle;
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
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (btnProject1Calendar.Text == String.Empty)
            {
                Searching(1);
            }
            else if (btnProject2Calendar.Text == String.Empty)
            {
                Searching(2);
            }
            else if (btnProject3Calendar.Text == String.Empty)
            {
                Searching(3);
            }
            GetTheTotalOfMonth();
        }
        private void GetTheTotalOfMonth()
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [ID] FROM [tbl_date] WHERE [date]=[@date]", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@date", DateTimePicker1.Value));
                int dateID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                Objects.cmd.Dispose();
                Objects.con.Close();

                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_monthlytotal] WHERE [date_ID]=[@date_ID]", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateID));
                Objects.dr = Objects.cmd.ExecuteReader();

                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    lblTotalMonth.Text = "TOTAL MONTH: " + MakingComma(Convert.ToString(Objects.dr["total"]));
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();
                }
                else
                {
                    lblTotalMonth.Text = "TOTAL MONTH:";
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();
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
        private string MakingComma(string param_StringValue)
        {
            string commaString = "";
            if (param_StringValue.Length >= 4)
            {
                double patternFormat = Convert.ToDouble(param_StringValue);
                param_StringValue = patternFormat.ToString("#,##0");
                return commaString = param_StringValue;
            }
            else
            {
                return param_StringValue;
            }
        }
        private void btnPrintPreviewOfMonthlyTotal_Click(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitle;
            var nextForm = new Form_Print_MonthlyTotal();
            nextForm.ShowDialog();
        }
    }
}
