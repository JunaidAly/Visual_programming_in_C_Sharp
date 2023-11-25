using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Login_and_Registration_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter de = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM db_user WHERE username='" + textusername.Text + "'and password='" + textpassword.Text + "' ";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                new dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username and Password ", "login Failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textusername.Text = "";
                textpassword.Text = "";
                textusername.Focus();
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textusername.Text = "";
            textpassword.Text = "";
            textusername.Focus();
        }

        private void checkBoxshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxshowpassword.Checked)
            {
                textpassword.PasswordChar = '\0';
                
            }
            else
            {
                textpassword.PasswordChar = '•';
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frm_Login().Show();
            this.Hide();
        }
    }
    }

