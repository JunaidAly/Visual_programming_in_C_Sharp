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
    public partial class Sign_Up : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junaid Ali\source\repos\Project\Project\DB.mdf;Integrated Security = True; Connect Timeout = 30";
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            if ( username.Text.Equals("") || password.Text.Equals(""))
            {
                MessageBox.Show("Fill Up Above form");
            }
            else
            {
                    int id = int.Parse(idtxt.Text);
                    string email = username.Text;
                    string con_password = password.Text;



                    string query = String.Format("INSERT INTO Login Values" +
                        "({0}, '{1}','{2}')",id, email, con_password);

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.ExecuteNonQuery();

                    idtxt.Text = "";

                    username.Text = "";

                    password.Text = "";

                    con.Close();
                
              
                
            }

            Login_Page login = new Login_Page();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Page login = new Login_Page();
            login.Show();
            this.Hide();
        }
    }
}
