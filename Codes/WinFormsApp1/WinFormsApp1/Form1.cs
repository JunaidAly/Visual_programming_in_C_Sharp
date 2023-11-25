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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = "";
        public Form1()
        {
            InitializeComponent();
        }

        public SqlCommand SqlCommand { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.Open();

            SqlCommand = new SqlCommand("INSERT INTO student values('Hassan')");

            string query = "INSERT INTO stidents VALUES(1,'Junaid','ali','yaseen')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Close();

        }
    }
}
