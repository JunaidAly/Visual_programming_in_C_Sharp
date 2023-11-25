using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace JunaidPractice
{
    public partial class Folder_browser_dialog : Form
    {
        public Folder_browser_dialog()
        {
            InitializeComponent();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folder.SelectedPath;
            }
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(string.Empty))
            {
                if (Directory.GetFiles(textBox1.Text).Length > 0)
                {
                    foreach(string files in Directory.GetFiles(textBox1.Text))
                    {
                        listBox1.Items.Add(files);
                    }
                }
                else
                {
                    listBox1.Items.Add(string.Format("No file found at location {0}", textBox1.Text));
                }
            }
        }
    }
}
