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
    public partial class Receipt : Form
    {
        public SqlConnection connection = new SqlConnection();
        public Receipt()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=NIKOLAPC\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True";
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                String querry = "select * from Receipt";
                SqlCommand command = new SqlCommand(querry, connection);
                SqlDataAdapter dt = new SqlDataAdapter(command);
                DataTable receipe = new DataTable();
                dt.Fill( receipe );
                dataGridView1.DataSource = receipe;
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            double amount = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                amount = amount + Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            textBox2.Text = amount.ToString();
        }
    }
}
