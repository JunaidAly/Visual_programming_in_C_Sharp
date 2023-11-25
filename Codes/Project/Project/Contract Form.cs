using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Contract_Form : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junaid Ali\source\repos\Project\Project\DB.mdf;Integrated Security = True; Connect Timeout = 30";
        public Contract_Form()
        {
            InitializeComponent();
        }

        private void Btn_save_Click(object sender, EventArgs e)

        {
            
            SqlConnection con = new SqlConnection(connectionString);
            if (fullnametxt.Text.Equals("") || compnametxt.Text.Equals("") || Contratortxt.Text.Equals("") || Labourtxt.Text.Equals("") || recenttxt.Text.Equals("") || Workingtxt.Text.Equals("") || PECtxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Up Above form");
            }
            else
            {
                int contractorcode = int.Parse(Contratortxt.Text);
                string fullname = fullnametxt.Text;
                string comname = compnametxt.Text;
                string contractcategory = contractorcat.Text;
                string labourforce = Labourtxt.Text;
                string recentproject = recenttxt.Text;
                string workingexp = Workingtxt.Text;
                string pec = PECtxt.Text;



                string query = String.Format("INSERT INTO Details Values" +
                    "({0}, '{1}','{2}','{3}','{4}','{5}','{6}','{7}')", contractorcode, fullname, comname, contractcategory, labourforce, recentproject, workingexp, pec);

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                Contratortxt.Text = "";

                fullnametxt.Text = "";

                compnametxt.Text = "";

                contractorcat.Text = "";

                Labourtxt.Text = "";

                recenttxt.Text = "";

                Workingtxt.Text = "";

                PECtxt.Text = "";

                con.Close();

            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Menu_Page menu = new Menu_Page();
            menu.Show();
            this.Close();
        }
    }
}

