using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Project
{
    public partial class Login_Page : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junaid Ali\source\repos\Project\Project\DB.mdf;Integrated Security = True; Connect Timeout = 30";
        public Login_Page()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up sign = new Sign_Up();
            sign.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection(connectionString);
         
            string query = "SELECT * FROM Login WHERE username='" + userTxt.Text.Trim() + "' and password='" + PassTxt.Text.Trim()+"'";
            SqlDataAdapter adp = new SqlDataAdapter(query, sql);
            DataTable data = new DataTable();
            adp.Fill(data);
            
            if (data.Rows.Count == 1)
            {
                Menu_Page menu = new Menu_Page();
                this.Hide();
                menu.Show();
                
            }
            else
            {
                MessageBox.Show(" Enter Valid username and password");
            }
            
        }
    }
}
