using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddNewEmployee : Form
    {
        public SqlConnection connection = new SqlConnection();
        public AddNewEmployee()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=NIKOLAPC\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String querry = "INSERT INTO Menu Values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlCommand comand = new SqlCommand(querry, connection);
            connection.Open();
            comand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
