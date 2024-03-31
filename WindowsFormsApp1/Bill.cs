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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Bill : Form
    {
        public SqlConnection connection = new SqlConnection();
        public Bill()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=NIKOLAPC\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True";
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            String querry = "select * from Menu2";
            SqlCommand comand = new SqlCommand(querry, connection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(comand); 
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
            double amount = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[3].Value =+ amount;
            }
            textBox1.Text = amount.ToString();
        }
    }
}
