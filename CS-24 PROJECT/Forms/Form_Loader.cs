using System;
using System.Windows.Forms;
namespace CS_24_PROJECT.Forms
{
    public partial class Form_Loader : Form
    {
        private double x;
        public Form_Loader()
        {
            InitializeComponent();
        }
        private void Form_Loader_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 0.5;
            if (x == 30)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Hide();
                Form_Login nextForm = new Form_Login();
                nextForm.ShowDialog();
            }
        }
    }
}
