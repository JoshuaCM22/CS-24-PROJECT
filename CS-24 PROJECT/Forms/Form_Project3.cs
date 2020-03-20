using System;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_Project3 : Form
    {
        public Form_Project3()
        {
            InitializeComponent();
        }
        public static string totalValue;
        private void Form_Project3_Load(object sender, EventArgs e)
        {
            GetAllValues();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var nextForm = new Form_Main();
            nextForm.ShowDialog();
        }
        private void GetAllValues()
        {
            try
            {
                txtTotal.Text = totalValue;
                int valueForTotal = Convert.ToInt32(RemovingComma(totalValue));
                double valueForThreeUsers = Convert.ToDouble(valueForTotal) / 3;
                txtUser1.Text = Convert.ToString(valueForThreeUsers);
                txtUser2.Text = Convert.ToString(valueForThreeUsers);
                txtUser3.Text = Convert.ToString(valueForThreeUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
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
    }
}
