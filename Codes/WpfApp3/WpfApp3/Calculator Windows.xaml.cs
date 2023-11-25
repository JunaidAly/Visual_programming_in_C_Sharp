using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Calculator_Windows.xaml
    /// </summary>
    public partial class Calculator_Windows : Window
    {
        public Calculator_Windows()
        {
            InitializeComponent();
        }

        private void Btn_operation(object sender, RoutedEventArgs e)
        {
            Button operation;
            operation = (Button)sender;
            if (sender is Button)
            {
                if (operation == AddOperation)
                {


                    int firstnumber = Convert.ToInt32(txtFirst.Text);
                    int secondnumber = Convert.ToInt32(txtsecond.Text);
                    int result = firstnumber + secondnumber;
                    MessageBox.Show("Result is " + result);
                }
                else if (operation == mulOperation)
                {
                    int firstnumber = Convert.ToInt32(txtFirst.Text);
                    int secondnumber = Convert.ToInt32(txtsecond.Text);
                    int result = firstnumber * secondnumber;
                    MessageBox.Show("Result is " + result);
                }
                else if (operation == subOperation)
                {
                    int firstnumber = Convert.ToInt32(txtFirst.Text);
                    int secondnumber = Convert.ToInt32(txtsecond.Text);
                    int result = firstnumber - secondnumber;
                    MessageBox.Show("Result is " + result);
                }
                else if (operation == divOperation)
                {
                    int firstnumber = Convert.ToInt32(txtFirst.Text);
                    int secondnumber = Convert.ToInt32(txtsecond.Text);
                    float result = firstnumber / secondnumber;
                    MessageBox.Show("Result is " + result);
                }
            }
        }  
    }
}
