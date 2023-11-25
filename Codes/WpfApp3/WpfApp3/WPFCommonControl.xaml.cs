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
    /// Interaction logic for WPFCommonControl.xaml
    /// </summary>
    public partial class WPFCommonControl : Window
    {
        public WPFCommonControl()
        {
            InitializeComponent();
        }

       

        

        private void cbComboadd_Click(object sender, RoutedEventArgs e)
        {
            cbcountry.Items.Add(addItems.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cbcountry.Items.RemoveAt(cbcountry.Items.IndexOf(cbcountry.SelectedItem));
        }

        private void additms_Click(object sender, RoutedEventArgs e)
        {
            lbitms.Items.Add(lbtxt.Text);
        }

        private void removeitems_Click(object sender, RoutedEventArgs e)
        {
            lbitms.Items.RemoveAt(lbitms.Items.IndexOf(lbitms.SelectedItem));
        }
    }
}
