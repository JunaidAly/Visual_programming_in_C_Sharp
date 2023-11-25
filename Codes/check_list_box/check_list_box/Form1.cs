using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_list_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
           foreach(string s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s);
            }

           for(int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedIndices[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
