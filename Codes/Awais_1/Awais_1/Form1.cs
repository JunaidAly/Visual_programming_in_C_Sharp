using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awais_1
{
    public partial class Form1 : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junaid Ali\source\repos\Awais_1\Awais_1\dbo.mdf;Integrated Security=True";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            if (idBox.Text.Equals("") || nameBox.Text.Equals("") || deptBox.Text.Equals(""))
            {
                errorMsg.Visible = true;
            } else
            {
                errorMsg.Visible = false;

                try
                {
                    int id = int.Parse(idBox.Text);
                    string name = nameBox.Text;
                    string dept = deptBox.Text;

                    string query = String.Format("INSERT INTO dbo.students Values" +
                        "({0}, '{1}', '{2}')", id, name, dept);

                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    idBox.Text = "";
                    nameBox.Text = "";
                    deptBox.Text = "";

                    con.Close();

                }
                catch (Exception) { }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            string query = "SELECT * FROM dbo.students";

         
            SqlCommand cmdAdapter = new SqlCommand(query, con);
          
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAdapter);

          

            System.Data.DataTable dt = new System.Data.DataTable();

            
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void buttonpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            int editid = Convert.ToInt32(idBox.Text);
            
        }
    }
}
