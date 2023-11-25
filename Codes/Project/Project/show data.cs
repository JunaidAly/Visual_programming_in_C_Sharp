using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class show_data : Form
    {
        string connectionString = @"";
        public show_data()
        {
            InitializeComponent();
        }

        private void Btn_show_data_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string query = "SELECT * FROM Details";


            SqlCommand cmdAdapter = new SqlCommand(query, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmdAdapter);



            System.Data.DataTable dt = new System.Data.DataTable();


            adapter.Fill(dt);

          dataGridView1.DataSource = dt;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Menu_Page page = new Menu_Page();
            page.Show();
            this.Close();
        }
    }
}
