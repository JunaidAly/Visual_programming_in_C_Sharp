using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_to_Sql
{

    public partial class Linq_form : Form
    {
        string conString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Junaid Ali\Documents\LinqDB.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection sql;
        public Linq_form()
        {
            InitializeComponent();
            sql = new SqlConnection(conString);
        }

   

        private void Btn_save_data_Click(object sender, EventArgs e)
        {
            studentclassesDataContext dc = new studentclassesDataContext(sql);
            Student st = new Student();
            st.Id = 4;
            st.Name = "Ali";
            st.@class = "11th";
            st.Address = "Karachi";
            dc.Student.insertonsubmitted(st);
            dc.sumittedchanges();
            var result = from i in dc.GetTable<Student>()
                         select i;
            dataGridView1.DataSource = result;

        }

        private void Linq_form_Load(object sender, EventArgs e)
        {
            studentclassesDataContext dc = new studentclassesDataContext(sql);
            var result = from i in dc.GetTable<Student>()
                         select i;
            dataGridView1.DataSource = result;
        }
    }
}
