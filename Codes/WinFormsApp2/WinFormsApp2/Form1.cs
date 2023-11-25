using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junaid Ali\source\repos\WinFormsApp2\WinFormsApp2\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonclickintdata_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO student VALUES (2,'Ali','COMSATS')";
            SqlCommand command = new SqlCommand(query,connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection connection = new SqlConnection(connectionString);
             connection.Open();
             string query = "SELECT * FROM student";
             SqlCommand command = new SqlCommand(query,connection);
            

        }


       
    }
}
