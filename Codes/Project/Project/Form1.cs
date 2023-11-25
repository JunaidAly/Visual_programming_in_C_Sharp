using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splash_timer.Enabled = true;
            Splash_progressBar.Increment(5);
            if (Splash_progressBar.Value == 100)
            {
                splash_timer.Enabled = false;
                Login_Page main = new Login_Page();
                main.Show();
                this.Hide();
            }
        }

        private void Splash_progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
