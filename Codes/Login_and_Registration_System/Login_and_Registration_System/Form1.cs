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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
           
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter de = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            if(textusername.Text==""&& textpassword.Text == "" && textconfirmPassword.Text == "")
            {
                MessageBox.Show("User name and Password fields are empty", "Registration Failed !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textpassword.Text == textconfirmPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO db_user VALUES('" + textusername.Text + "','" + textpassword.Text + "',')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQueryAsync();
                con.Close();
                textusername.Text = "";
                textpassword.Text = "";
                textconfirmPassword.Text = "";
                MessageBox.Show("You Account Has Been Created", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Password does not match ,Please Re-Enter", "Registration Failed, MessageBoxIcon.Error");
                textpassword.Text = "";
                textconfirmPassword.Text = "";
                textpassword.Focus();
            }
        }

        private void checkBoxshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxshowpassword.Checked){
                textpassword.PasswordChar = '\0';
                textconfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textpassword.PasswordChar = '•';
                textconfirmPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textusername.Text = "";
            textpassword.Text = "";
            textconfirmPassword.Text = "";
            textusername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frm_Login().Show();
            this.Hide();
        }
    }
}
