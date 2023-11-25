using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JunaidPractice
{
    public partial class Save_File_Dialog : Form
    {
        public Save_File_Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter stream = new StreamWriter(file);
                stream.Write(richTextBox1.Text);
                stream.Close();
                MessageBox.Show("File Successfully Saved");
            }
        }
    }
}
