using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JunaidPractice
{
    public partial class combo_box : Form
    {
        public combo_box()
        {
            InitializeComponent();
        }

        private void combo_box_Load(object sender, EventArgs e)
        {
            string[] names = { "Tamil Nadu", "Kerala", "Telugana", "Andhara", "New Delhi"};
            foreach(string name in names)
            {
                comboBox1.Items.Add(name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if(comboBox1.SelectedIndex.ToString()== "Tamil Nadu")
            {
                comboBox2.Items.Add("Chennai");
                comboBox2.Items.Add("Trichy");
                comboBox2.Items.Add("Pondi");
                comboBox2.Items.Add("Madurai");
                comboBox2.Items.Add("Kanchipur");
            }
            if (comboBox1.SelectedIndex.ToString() == "Kerala")
            {
                comboBox2.Items.Add("Kolam");
                comboBox2.Items.Add("Cochin");
                comboBox2.Items.Add("Thiruvandhapuram");
            }
        }
    }
}
