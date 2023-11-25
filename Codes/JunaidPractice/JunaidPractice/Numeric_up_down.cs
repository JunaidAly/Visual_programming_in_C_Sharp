using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JunaidPractice
{
    public partial class Numeric_up_down : Form
    {
        public Numeric_up_down()
        {
            InitializeComponent();
        }

        private void Btn_calculation_Click(object sender, EventArgs e)
        {
            decimal price = numericUpDownPrice.Value;
            int quantity = (int)numericUpDownQuantity.Value;
            decimal Total;
            Total = price * quantity;
            MessageBox.Show(string.Format("Price of the product is {0:c}", Total));
        }
    }
}
