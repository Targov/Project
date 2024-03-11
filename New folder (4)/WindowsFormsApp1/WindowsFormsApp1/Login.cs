using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        
        
       
        Form2 work = new Form2();
        Admin adminForm = new Admin();
        public Login()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            // Check the login credentials or condition for determining the user type
            if (true) // normal hashed MD5 login
            {
                work.Show();               
                this.Hide();
            }
            else if (false) // implement Admin login
            {
                adminForm.Show();
                this.Hide();
            }
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
    }

}
