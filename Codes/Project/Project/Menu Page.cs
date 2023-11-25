using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Menu_Page : Form
    {
        public Menu_Page()
        {
            InitializeComponent();
        }

        private void Btn_apply_Click(object sender, EventArgs e)
        {
            Contract_Form form = new Contract_Form();
            form.Show();
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            show_data show = new show_data();
            show.Show();
            this.Close();
        }
    }
}
