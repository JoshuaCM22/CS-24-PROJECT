using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        public static string accountName;
        public static string dateToday = DateTime.Now.ToString("dd/MM/yyyy");
        public static int accountIDGetter;
        private void Form_Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDateAndDayToday.Text = DateTime.Now.ToString("MMMM dd, yyyy") + " / " + DateTime.Now.DayOfWeek.ToString();
            lblTimeNow.Text = DateTime.Now.ToLongTimeString();
            this.ActiveControl = lblTitle;
            CheckDatabaseForDateToday();
            GetValuesForAllProjects();
            TextBox[] TextBoxes = { txtTotalProject1, txtTotalProject2, txtTotalProject3 };
            CheckValueIfZeros(TextBoxes);
            lblAccountName.Text += accountName;
        }
        private void CheckValueIfZeros(params TextBox[] param_TextBoxName)
        {
            for (int x = 0; x < 3; x++)
            {
                if (param_TextBoxName[x].Text == "0.0000")
                {
                    param_TextBoxName[x].Text = "0";
                }
            }
        }
        int dateIDGetter, monthTotal;
        private void CheckingAndComputingMonthyTotal()
        {
            try
            {
                int yearToday = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                for (int year = 2018; year <= yearToday; year++)
                {
                    // Check for January 31
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "31/01/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 31 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for February 29
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "29/02/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 29 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    else
                    {
                        Objects.cmd.Dispose();
                        Objects.dr.Close();
                        Objects.con.Close();

                        // Check for February 28
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date", "28/02/" + year));
                        Objects.dr = Objects.cmd.ExecuteReader();
                        if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value && year != 2020)
                        {
                            dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                            Objects.con.Close();
                            Objects.dr.Close();
                            // Get the total ID
                            Objects.con.Open();
                            Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                            Objects.cmd.CommandType = CommandType.Text;
                            Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                            int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                            Objects.con.Close();
                            Objects.dr.Close();
                            // Compute the sum
                            Objects.con.Open();
                            Objects.cmd = new OleDbCommand("SELECT [total] * 28 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                            Objects.cmd.CommandType = CommandType.Text;
                            Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                            monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                            Objects.con.Close();
                            Objects.dr.Close();
                            InsertingOrUpdating();
                        }
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for March 31
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "31/03/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 31 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for April 30
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "30/04/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 30 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for May 31
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "31/05/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 31 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for June 30
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "30/06/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 30 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for July 31
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "31/07/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 31 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for August 31
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "31/08/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 31 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for September 30
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "30/09/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 30 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for October 31
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "31/10/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 31 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for November 30
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "30/11/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 30 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();

                    // Check for December 31
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date", "31/12/" + year));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        dateIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Get the total ID
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [date_ID]=@date_ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                        int total_ID = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        // Compute the sum
                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("SELECT [total] * 31 FROM [tbl_totals] WHERE [ID]=@ID", Objects.con);
                        Objects.cmd.CommandType = CommandType.Text;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@ID", total_ID));
                        monthTotal = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                        Objects.con.Close();
                        Objects.dr.Close();
                        InsertingOrUpdating();
                    }
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
        private void InsertingOrUpdating()
        {
            try
            {
                // Check the ID of column called date of tbl_date in tbl_monthlytotal 
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_monthlytotal] WHERE [date_ID]=@date_ID", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                Objects.dr = Objects.cmd.ExecuteReader();
                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    int monthlyTotalIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                    Objects.con.Close();
                    Objects.dr.Close();

                    // Update the total in tbl_monthlytotal
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("UPDATE [tbl_monthlytotal] SET [total] = [@total] WHERE [ID] = [@ID]", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@total", monthTotal));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@ID", monthlyTotalIDGetter));
                    Objects.cmd.ExecuteNonQuery();
                    Objects.con.Close();
                }
                else
                {
                    Objects.con.Close();
                    Objects.dr.Close();
                    // Insert to the total in tbl_monthlytotal
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("INSERT INTO [tbl_monthlytotal] ([date_ID], [total]) VALUES ([@date_ID], [@total]) ", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDGetter));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@total", monthTotal));
                    Objects.cmd.ExecuteNonQuery();
                    Objects.cmd.Dispose();
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
        public static int dateIDTodayGetter;
        private void CheckDatabaseForDateToday()
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_date] WHERE [date]=@date", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@date", dateToday));
                Objects.dr = Objects.cmd.ExecuteReader();
                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    dateIDTodayGetter = Convert.ToInt32(Objects.dr["ID"]);
                    Objects.con.Close();
                    Objects.dr.Close();
                }
                else
                {
                    Objects.con.Close();
                    Objects.dr.Close();
                    IncrementingIDForDate();
                    InsertingNewDate();
                    InsertingNewRow();
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
        private static int autoIncrementIDForDate;
        private void IncrementingIDForDate()
        {
            Objects.con.Open();
            Objects.cmd = new OleDbCommand("SELECT (MAX(ID) + 1) FROM [tbl_date]", Objects.con);
            autoIncrementIDForDate = Convert.ToInt32(Objects.cmd.ExecuteScalar());
            Objects.cmd.Dispose();
            Objects.con.Close();
        }
        private void InsertingNewDate()
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("spInsertNewDate", Objects.con);
                Objects.cmd.CommandType = CommandType.StoredProcedure;
                Objects.cmd.Parameters.Add(new OleDbParameter("@ID", autoIncrementIDForDate));
                Objects.cmd.Parameters.Add(new OleDbParameter("@date", dateToday));
                Objects.cmd.ExecuteNonQuery();
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
        private int valueForProject = 1;
        private void InsertingNewRow()
        {
            int startingNumber = 1;
            int targetNumber = 3;
            while (startingNumber <= targetNumber)
            {
                ForloopMethod();
                valueForProject = valueForProject + 1;
                startingNumber++;
            }
        }
        private void ForloopMethod()
        {
            for (int a = 1; a <= 3; a++)
            {
                try
                {
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT MAX(ID) FROM [tbl_records] WHERE project_ID=@project_ID", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@project_ID", a));
                    int lastID = Convert.ToInt32(Objects.cmd.ExecuteScalar().ToString());
                    Objects.cmd.Dispose();
                    Objects.con.Close();

                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_records] WHERE ID=@ID", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@ID", lastID));
                    Objects.dr = Objects.cmd.ExecuteReader();
                    int totalID, subtotalID;
                    if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                    {
                        totalID = Convert.ToInt32(Objects.dr["total_ID"]);
                        subtotalID = Convert.ToInt32(Objects.dr["sub_total_ID"]);
                        Objects.cmd.Dispose();
                        Objects.dr.Close();
                        Objects.con.Close();

                        int valueForDate = autoIncrementIDForDate;

                        Objects.con.Open();
                        Objects.cmd = new OleDbCommand("spInsertNewRow", Objects.con);
                        Objects.cmd.CommandType = CommandType.StoredProcedure;
                        Objects.cmd.Parameters.Add(new OleDbParameter("@user_ID", a));
                        Objects.cmd.Parameters.Add(new OleDbParameter("@sub_total", subtotalID));
                        Objects.cmd.Parameters.Add(new OleDbParameter("@project_ID", valueForProject));
                        Objects.cmd.Parameters.Add(new OleDbParameter("@total", totalID));
                        Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", valueForDate));
                        Objects.cmd.Parameters.Add(new OleDbParameter("@account_ID", accountIDGetter));
                        Objects.cmd.ExecuteNonQuery();
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
        }
        private string totalIDValue1, totalIDValue2, totalIDValue3;
        private void GetValuesForAllProjects()
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [project_ID]=[@project_ID] AND [date_ID]=[@date_ID]", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@project_ID", 1));
                Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDTodayGetter));
                totalIDValue1 = Objects.cmd.ExecuteScalar().ToString();
                Objects.con.Close();

                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [total] FROM [tbl_totals] WHERE [ID]=[@ID]", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@ID", totalIDValue1));
                txtTotalProject1.Text = Objects.cmd.ExecuteScalar().ToString();
                Objects.con.Close();

                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [project_ID]=[@project_ID] AND [date_ID]=[@date_ID]", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@project_ID", 2));
                Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDTodayGetter));
                totalIDValue2 = Objects.cmd.ExecuteScalar().ToString();
                Objects.con.Close();

                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [total] FROM [tbl_totals] WHERE [ID]=[@ID]", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@ID", totalIDValue2));
                txtTotalProject2.Text = Objects.cmd.ExecuteScalar().ToString();
                Objects.con.Close();

                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [total_ID] FROM [tbl_records] WHERE [project_ID]=[@project_ID] AND [date_ID]=[@date_ID]", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@project_ID", 3));
                Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDTodayGetter));
                totalIDValue3 = Objects.cmd.ExecuteScalar().ToString();
                Objects.con.Close();

                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT [total] FROM [tbl_totals] WHERE [ID]=[@ID]", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@ID", totalIDValue3));
                txtTotalProject3.Text = Objects.cmd.ExecuteScalar().ToString();
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

        private void GetPreviousValuesForAllProjects() 
        {
        
        
        
        }
        private void btnProject1_Click(object sender, EventArgs e)
        {
            Form_Project1.totalValue = txtTotalProject1.Text;
            this.Hide();
            var nextForm = new Form_Project1();
            nextForm.ShowDialog();
        }
        private void btnProject2_Click(object sender, EventArgs e)
        {
            Form_Project2.totalValue = txtTotalProject2.Text;
            this.Hide();
            var nextForm = new Form_Project2();
            nextForm.ShowDialog();
        }
        private void btnProject3_Click(object sender, EventArgs e)
        {
            Form_Project3.totalValue = txtTotalProject3.Text;
            this.Hide();
            var nextForm = new Form_Project3();
            nextForm.ShowDialog();
        }
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitle;
            CheckingAndComputingMonthyTotal();
            this.Hide();
            var nextForm = new Form_Calendar();
            nextForm.ShowDialog();
        }
        private int total_IDGetter;
        private void Checktbl_totals(string param_StringValue)
        {
            try
            {
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_totals] WHERE [total]=@total", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@total", param_StringValue));
                Objects.dr = Objects.cmd.ExecuteReader();
                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    total_IDGetter = Convert.ToInt32(Objects.dr["ID"]);
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();
                }
                else
                {
                    Objects.con.Close();
                    Objects.dr.Close();

                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT (MAX(ID) + 1) FROM [tbl_totals]", Objects.con);
                    int lastIDValue = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                    Objects.cmd.Dispose();
                    Objects.con.Close();

                    // Insert new total in tbl_totals
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("INSERT INTO [tbl_totals] ([ID], [total]) VALUES ([@ID], [@total]) ", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@ID", lastIDValue));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@total", param_StringValue));
                    Objects.cmd.ExecuteNonQuery();
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();
                    total_IDGetter = lastIDValue;
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
        private int sub_totalsIDGetter;
        private void Checktbl_sub_totals(string param_StringValue)
        {
            try
            {
                int valueForTotal = Convert.ToInt32(param_StringValue);
                double valueForThreeUsers = Convert.ToDouble(valueForTotal) / 3;
                Objects.con.Open();
                Objects.cmd = new OleDbCommand("SELECT * FROM [tbl_sub_totals] WHERE [sub_total]=[@sub_total]", Objects.con);
                Objects.cmd.CommandType = CommandType.Text;
                Objects.cmd.Parameters.Add(new OleDbParameter("@sub_total", valueForThreeUsers));
                Objects.dr = Objects.cmd.ExecuteReader();
                if (Objects.dr.Read() && Objects.dr.GetValue(0) != DBNull.Value)
                {
                    sub_totalsIDGetter = Convert.ToInt32(Objects.dr["ID"]);
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();
                }
                else
                {
                    Objects.con.Close();
                    Objects.dr.Close();

                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("SELECT (MAX(ID) + 1) FROM [tbl_sub_totals]", Objects.con);
                    int lastIDValue = Convert.ToInt32(Objects.cmd.ExecuteScalar());
                    Objects.cmd.Dispose();
                    Objects.con.Close();

                    // Insert new total in tbl_sub_totals
                    Objects.con.Open();
                    Objects.cmd = new OleDbCommand("INSERT INTO [tbl_sub_totals] ([ID], [sub_total]) VALUES ([@ID], [@sub_total]) ", Objects.con);
                    Objects.cmd.CommandType = CommandType.Text;
                    Objects.cmd.Parameters.Add(new OleDbParameter("@ID", lastIDValue));
                    Objects.cmd.Parameters.Add(new OleDbParameter("@sub_total", valueForThreeUsers));
                    Objects.cmd.ExecuteNonQuery();
                    Objects.cmd.Dispose();
                    Objects.dr.Close();
                    Objects.con.Close();
                    sub_totalsIDGetter = lastIDValue;
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
        private void Updatingtbl_records(int param_ProjectID)
        {
            Objects.con.Open();
            Objects.cmd = new OleDbCommand("UPDATE [tbl_records] SET [sub_total_ID]=[@sub_total_ID], [total_ID]=[@total_ID], [account_ID]=[@account_ID] WHERE [project_ID]=[@project_ID] AND [date_ID]=[@date_ID]", Objects.con);
            Objects.cmd.CommandType = CommandType.Text;
            Objects.cmd.Parameters.Add(new OleDbParameter("@sub_total_ID", sub_totalsIDGetter));
            Objects.cmd.Parameters.Add(new OleDbParameter("@total_ID", total_IDGetter));
            Objects.cmd.Parameters.Add(new OleDbParameter("@account_ID", accountIDGetter));
            Objects.cmd.Parameters.Add(new OleDbParameter("@project_ID", param_ProjectID));
            Objects.cmd.Parameters.Add(new OleDbParameter("@date_ID", dateIDTodayGetter));
            Objects.cmd.ExecuteNonQuery();
            Objects.con.Close();
        }
        private string project1Value, project2Value, project3Value;
        private void txtTotalProject1_Leave(object sender, EventArgs e)
        {
            if (txtTotalProject1.Text == "")
            {
                txtTotalProject1.Text = "0";
                this.ActiveControl = txtTotalProject1;
            }
            project1Value = txtTotalProject1.Text;
            Checktbl_totals(RemovingComma(project1Value));
            Checktbl_sub_totals(RemovingComma(project1Value));
            Updatingtbl_records(1);
        }
        private void txtTotalProject2_Leave(object sender, EventArgs e)
        {
            if (txtTotalProject2.Text == "")
            {
                txtTotalProject2.Text = "0";
                this.ActiveControl = txtTotalProject2;
            }
            project2Value = txtTotalProject2.Text;
            Checktbl_totals(RemovingComma(project2Value));
            Checktbl_sub_totals(RemovingComma(project2Value));
            Updatingtbl_records(2);
        }
        private void txtTotalProject3_Leave(object sender, EventArgs e)
        {
            if (txtTotalProject3.Text == "")
            {
                txtTotalProject3.Text = "0";
                this.ActiveControl = txtTotalProject3;
            }
            project3Value = txtTotalProject3.Text;
            Checktbl_totals(RemovingComma(project3Value));
            Checktbl_sub_totals(RemovingComma(project3Value));
            Updatingtbl_records(3);
        }
        private void txtTotalProject1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtTotalProject2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtTotalProject3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToLongTimeString();
            lblDateAndDayToday.Text = DateTime.Now.ToString("MMMM dd, yyyy") + " / " + DateTime.Now.DayOfWeek.ToString();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log-out?", "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                accountName = string.Empty;
                var nextForm = new Form_Login();
                nextForm.ShowDialog();
            }
            this.ActiveControl = lblTitle;
        }
        private void btnCreateAnotherAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextForm = new Form_CreateAnotherAccount();
            nextForm.ShowDialog();
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextForm = new Form_ChangePassword();
            nextForm.ShowDialog();
        }
        private void MakingComma(TextBox param_TextBoxName)
        {
            if (param_TextBoxName.Text.Length >= 4)
            {
                double patternFormat = Convert.ToDouble(param_TextBoxName.Text);
                if (!param_TextBoxName.Text.Contains("."))
                {
                    param_TextBoxName.Text = patternFormat.ToString("#,##0");
                    param_TextBoxName.SelectionStart = param_TextBoxName.Text.Length;
                }
            }
        }
        private string RemovingComma(string param_StringVariable)
        {
            string removedString = "";
            if (param_StringVariable.Contains(","))
            {
                removedString = param_StringVariable.Replace(",", "");
                return removedString;
            }
            else
            {
                return removedString = param_StringVariable;
            }
        }
        private void txtTotalProject1_TextChanged(object sender, EventArgs e)
        {
            MakingComma(txtTotalProject1);
        }
        private void txtTotalProject2_TextChanged(object sender, EventArgs e)
        {
            MakingComma(txtTotalProject2);
        }
        private void txtTotalProject3_TextChanged(object sender, EventArgs e)
        {
            MakingComma(txtTotalProject3);
        }
    }
}
