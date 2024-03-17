using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;


namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        SqlConnection connection = new SqlConnection(@"(localdb)\MSSQLLocalDB");
        Form2 tables = new Form2();
       
      
        public Login()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            String username, userPassword;
            username = textBox1.Text;
            userPassword = textBox2.Text;
            try
            {
                String querry = "SELECT * FROM Users WHERE usernsme = '"+textBox1.Text+"' AND password = '"+textBox2.Text+"'";
                SqlCommand command = new SqlCommand(querry, connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", userPassword);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count == 1)
                {
                    tables.Show();
                    this.Hide();
                }
                else { label2.Visible = true; }
            }
            catch
            {
                label2.Visible = true;
            }
            finally { connection.Close(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        { 
        }
    }

}
