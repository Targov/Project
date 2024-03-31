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
    public partial class Form2 : Form
    {
        Menu menu = new Menu();
        public SqlConnection connection = new SqlConnection();
        public Form2()
        {
            InitializeComponent();

        }
        private void Work_Load(object sender, EventArgs e)
        {

        }

        public bool IsFormVisible => this.Visible;
        public void button2_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = "Data Source=NIKOLAPC\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True";
            String querry = "INSERT INTO Tables (table_number) Values (1)";
            SqlCommand comand = new SqlCommand(querry, connection);
            connection.Open();
            comand.ExecuteNonQuery();
            connection.Close();
            menu.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnFisk_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        public void btnTable4_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        public void btnTable5_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        public void btnTable6_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        public void btnTable2_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            this.Hide();
            loginform.Show();
        }
    }
}
