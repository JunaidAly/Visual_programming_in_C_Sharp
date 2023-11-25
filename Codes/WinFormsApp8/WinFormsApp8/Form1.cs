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
namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junaid Ali\source\repos\Project\Project\DB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {

        }
    }
}
