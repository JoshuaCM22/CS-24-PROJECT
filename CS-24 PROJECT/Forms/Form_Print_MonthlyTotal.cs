using System;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_Print_MonthlyTotal : Form
    {
        public Form_Print_MonthlyTotal()
        {
            InitializeComponent();
        }
        private void Form_Print_MonthlyTotal_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }
    }
}
