using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JunaidPractice
{
    public partial class checkbox : Form
    {
        public checkbox()
        {
            InitializeComponent();
        }

        private void Btn_Buy_Click(object sender, EventArgs e)
        {
            string items = string.Empty;
            if (checkBox1.Checked)
            {
                items += "\nPen";
            }
            if (checkBox2.Checked)
            {
                items += "\nPencil";
            }
            if (checkBox3.Checked)
            {
                items += "\nShepener";
            }

            MessageBox.Show("You have bought :"+items);
        }

        private void Btn_click_Click(object sender, EventArgs e)
        {
            string Gender;
            if (radioButton1.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            MessageBox.Show(Gender.ToString());
        }
    }
}
