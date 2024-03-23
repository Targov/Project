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
        Form2 tables = new Form2();
        Admin admin = new Admin();

        public Login()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=NIKOLAPC\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True";

            String username, userPassword;
            username = txtUsername.Text;
            userPassword = txtPassword.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    String querry = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(querry, connection);

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", userPassword);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (username == "Admin" && count > 0)
                    {
                        this.Hide();
                        admin.Show();
                    }
                    else if (count > 0)
                    {
                        tables.Show();
                        this.Hide();
                    }
                    else
                    { 
                        lblError.Visible = true;
                    }
                }
                catch
                {
             
                    lblError.Visible = true;
                }
                finally { connection.Close(); }
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        { 
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }

}
