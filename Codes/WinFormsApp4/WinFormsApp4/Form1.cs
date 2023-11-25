using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junaid Ali\source\repos\WinFormsApp4\WinFormsApp4\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            String query = "insert into student values(1,'Junaid','cs')";
            SqlCommand command = new SqlCommand(query,connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            String query = "select * from student";
            SqlCommand sqladapter = new SqlCommand(query, connection);
            SqlDataAdapter sqlData = new SqlDataAdapter(sqladapter);
            connection.Close();
            System.Data.DataTable dt = new System.Data.DataTable();
            sqlData.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
