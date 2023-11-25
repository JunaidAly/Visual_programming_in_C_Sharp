using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button b1 = new Button();
            b1.Text = "Ok";
            b1.Location = new Point(40, 40);
            b1.Size = new Size(30,30);
            this.Controls.Add(b1);
            b1.Click += new EventHandler(b1_clicked);

            Label lb = new Label();
            lb.Text = "Enter Your Name";
            lb.Size = new Size(100, 40);
            lb.Location = new Point(60, 70);
            this.Controls.Add(lb);

            TextBox text = new TextBox();
            text.Text = "Type your name";
            text.Size = new Size(200,200);
            text.Location = new Point(180, 65);
            this.Controls.Add(text);

            b1.Click += new EventHandler(b1_clicked);
           

        }

        private void B1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void b1_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
           
        
        }

    }
}
