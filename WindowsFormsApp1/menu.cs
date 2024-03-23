using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public SqlConnection connection = new SqlConnection();
        public Menu()
        {
            InitializeComponent();
            connection.ConnectionString = "Data Source=NIKOLAPC\\SQLEXPRESS;Initial Catalog=LoginDB;Integrated Security=True";
        }

        private void капучино400ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void топлиНапиткиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbHotDrinks.ForeColor = System.Drawing.Color.DarkBlue;
            rbColdDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbSoda.ForeColor = System.Drawing.Color.RosyBrown;
            rbCocktail.ForeColor = System.Drawing.Color.RosyBrown;
            rbAlcohol.ForeColor = System.Drawing.Color.RosyBrown;
            rbExtras.ForeColor = System.Drawing.Color.RosyBrown;
            rbHotDishes.ForeColor = System.Drawing.Color.RosyBrown;
            rbDesert.ForeColor = System.Drawing.Color.RosyBrown;

            cbChoose.Items.Clear();

            cbChoose.Items.Add("Капучино");
            cbChoose.Items.Add("Виенско кафе");
            cbChoose.Items.Add("Макиато");
            cbChoose.Items.Add("Мляко с Nescafe");
            cbChoose.Items.Add("Мляко с какао");
            cbChoose.Items.Add("Топъл шоколад");
            cbChoose.Items.Add("Топъл шоколад с сироп");
            cbChoose.Items.Add("Чай 500мл");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rbHotDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbColdDrinks.ForeColor = System.Drawing.Color.DarkBlue;
            rbSoda.ForeColor = System.Drawing.Color.RosyBrown;
            rbCocktail.ForeColor = System.Drawing.Color.RosyBrown;
            rbAlcohol.ForeColor = System.Drawing.Color.RosyBrown;
            rbExtras.ForeColor = System.Drawing.Color.RosyBrown;
            rbHotDishes.ForeColor = System.Drawing.Color.RosyBrown;
            rbDesert.ForeColor = System.Drawing.Color.RosyBrown;

            cbChoose.Items.Clear();

            cbChoose.Items.Add("Фрапе");
            cbChoose.Items.Add("Кафе със сладолед");
            cbChoose.Items.Add("Матча лате");
            cbChoose.Items.Add("Студено лате");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rbHotDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbColdDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbSoda.ForeColor = System.Drawing.Color.DarkBlue;
            rbCocktail.ForeColor = System.Drawing.Color.RosyBrown;
            rbAlcohol.ForeColor = System.Drawing.Color.RosyBrown;
            rbExtras.ForeColor = System.Drawing.Color.RosyBrown;
            rbHotDishes.ForeColor = System.Drawing.Color.RosyBrown;
            rbDesert.ForeColor = System.Drawing.Color.RosyBrown;

            cbChoose.Items.Clear();

            cbChoose.Items.Add("Кола");
            cbChoose.Items.Add("Фанта");
            cbChoose.Items.Add("Спрайт");
            cbChoose.Items.Add("Швепс");
            cbChoose.Items.Add("Сок капи");
            cbChoose.Items.Add("Студен чай");
            cbChoose.Items.Add("Минерална вода");
            cbChoose.Items.Add("Ред Бул");
            cbChoose.Items.Add("Лимонада");
            cbChoose.Items.Add("Кана с лимонада");
            cbChoose.Items.Add("Фреш");

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            rbHotDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbColdDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbSoda.ForeColor = System.Drawing.Color.RosyBrown;
            rbCocktail.ForeColor = System.Drawing.Color.RosyBrown;
            rbAlcohol.ForeColor = System.Drawing.Color.RosyBrown;
            rbExtras.ForeColor = System.Drawing.Color.DarkBlue;
            rbHotDishes.ForeColor = System.Drawing.Color.RosyBrown;
            rbDesert.ForeColor = System.Drawing.Color.RosyBrown;

            cbChoose.Items.Clear();

            cbChoose.Items.Add("Мляко");
            cbChoose.Items.Add("Мед");
            cbChoose.Items.Add("Сметана");
            cbChoose.Items.Add("Ядки");
            cbChoose.Items.Add("Луканка");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            rbHotDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbColdDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbSoda.ForeColor = System.Drawing.Color.RosyBrown;
            rbCocktail.ForeColor = System.Drawing.Color.RosyBrown;
            rbAlcohol.ForeColor = System.Drawing.Color.DarkBlue;
            rbExtras.ForeColor = System.Drawing.Color.RosyBrown;
            rbHotDishes.ForeColor = System.Drawing.Color.RosyBrown;
            rbDesert.ForeColor = System.Drawing.Color.RosyBrown;

            cbChoose.Items.Clear();

            cbChoose.Items.Add("Ракия");
            cbChoose.Items.Add("Водка");
            cbChoose.Items.Add("Джин");
            cbChoose.Items.Add("Узо");
            cbChoose.Items.Add("Перно");
            cbChoose.Items.Add("Бренди");
            cbChoose.Items.Add("Коняк");
            cbChoose.Items.Add("Ром");
            cbChoose.Items.Add("Текила");
            cbChoose.Items.Add("Уиски");
            cbChoose.Items.Add("Жива бира");
            cbChoose.Items.Add("Шуменско наливна");
            cbChoose.Items.Add("Бира бутилка");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            rbHotDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbColdDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbSoda.ForeColor = System.Drawing.Color.RosyBrown;
            rbCocktail.ForeColor = System.Drawing.Color.RosyBrown;
            rbAlcohol.ForeColor = System.Drawing.Color.RosyBrown;
            rbExtras.ForeColor = System.Drawing.Color.RosyBrown;
            rbHotDishes.ForeColor = System.Drawing.Color.DarkBlue;
            rbDesert.ForeColor = System.Drawing.Color.RosyBrown;

            cbChoose.Items.Clear();

            cbChoose.Items.Add("Пилешки хапки");
            cbChoose.Items.Add("Принцеси");
            cbChoose.Items.Add("Пица");
            cbChoose.Items.Add("Пържени картофи");
            cbChoose.Items.Add("Пържени картофи със сирене");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            rbHotDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbColdDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbSoda.ForeColor = System.Drawing.Color.RosyBrown;
            rbCocktail.ForeColor = System.Drawing.Color.DarkBlue;
            rbAlcohol.ForeColor = System.Drawing.Color.RosyBrown;
            rbExtras.ForeColor = System.Drawing.Color.RosyBrown;
            rbHotDishes.ForeColor = System.Drawing.Color.RosyBrown;
            rbDesert.ForeColor = System.Drawing.Color.RosyBrown;

            cbChoose.Items.Clear();

            cbChoose.Items.Add("Синя лагуна");
            cbChoose.Items.Add("Мохито");
            cbChoose.Items.Add("Маргарита");

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            rbHotDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbColdDrinks.ForeColor = System.Drawing.Color.RosyBrown;
            rbSoda.ForeColor = System.Drawing.Color.RosyBrown;
            rbCocktail.ForeColor = System.Drawing.Color.RosyBrown;
            rbAlcohol.ForeColor = System.Drawing.Color.RosyBrown;
            rbExtras.ForeColor = System.Drawing.Color.RosyBrown;
            rbHotDishes.ForeColor = System.Drawing.Color.RosyBrown;
            rbDesert.ForeColor = System.Drawing.Color.DarkBlue;

            cbChoose.Items.Clear();

            cbChoose.Items.Add("Крем брюле");
            cbChoose.Items.Add("Шоколадово суфле");
            cbChoose.Items.Add("Биксвитена торта");
            cbChoose.Items.Add("Чийзкейк");
            cbChoose.Items.Add("Сладолед");
            cbChoose.Items.Add("Мелба");
            cbChoose.Items.Add("Шоколадова торта");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbHotDrinks.Checked)
            {
                if (cbChoose.SelectedItem.ToString() == "Капучино")
                {
                        txtPrice.Text = "4,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Виенско кафе")
                {
                    txtPrice.Text = "4,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Макиато")
                {
                    txtPrice.Text = "4,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Мляко с Nescafe")
                {
                    txtPrice.Text = "3,50";
                }
                else if (cbChoose.SelectedItem.ToString() == "Мляко с какао")
                {
                    txtPrice.Text = "3,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Топъл шоколад")
                {
                    txtPrice.Text = "3,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Топъл шоколад с сироп")
                {
                    txtPrice.Text = "3,50";
                }
                else
                {
                    txtPrice.Text = "4,00";
                }
            }


            if (rbColdDrinks.Checked)
            {
                if (cbChoose.SelectedItem.ToString() == "Фрапе")
                {
                    txtPrice.Text = "4,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Кафе със сладолед")
                {
                    txtPrice.Text = "4,50";
                }
                else if (cbChoose.SelectedItem.ToString() == "Матча лате")
                {
                    txtPrice.Text = "6,00";
                }
                else
                {
                    txtPrice.Text = "5,50";
                } 
            }


            if (rbSoda.Checked)
            {
                if (cbChoose.SelectedItem.ToString() == "Фреш")
                {
                    txtPrice.Text = "4,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Минерална вода")
                {
                    txtPrice.Text = "3,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Ред Бул")
                {
                    txtPrice.Text = "5,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Лимонада")
                {
                    txtPrice.Text = "4,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Кана с лимонада")
                {
                    txtPrice.Text = "10,50";
                }
                else
                {
                    txtPrice.Text = "2,50";
                }
            }


            if (rbCocktail.Checked)
            {
                if (cbChoose.SelectedItem.ToString() == "Синя лагуна")
                {
                    txtPrice.Text = "8,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Мохито")
                {
                    txtPrice.Text = "9,00";
                }
                else
                {
                    txtPrice.Text = "8,50";
                }
            }


            if (rbAlcohol.Checked)
            {
                if (cbChoose.SelectedItem.ToString() == "Ракия")
                {
                    txtPrice.Text = "5,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Водка")
                {
                    txtPrice.Text = "4,50";
                }
                else if (cbChoose.SelectedItem.ToString() == "Джин")
                {
                    txtPrice.Text = "7,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Узо")
                {
                    txtPrice.Text = "5,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Перно")
                {
                    txtPrice.Text = "5,50";
                }
                else if (cbChoose.SelectedItem.ToString() == "Бренди")
                {
                    txtPrice.Text = "4,50";
                }
                else if (cbChoose.SelectedItem.ToString() == "Коняк")
                {
                    txtPrice.Text = "7,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Ром")
                {
                    txtPrice.Text = "6,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Текила")
                {
                    txtPrice.Text = "4,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Уиски")
                {
                    txtPrice.Text = "7,50";
                }
                else if (cbChoose.SelectedItem.ToString() == "Жива бира")
                {
                    txtPrice.Text = "3.00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Шуменско наливна")
                {
                    txtPrice.Text = "3,00";
                }
                else
                {
                    txtPrice.Text = "4,00";
                }
            }


            if (rbExtras.Checked)
            {
                if (cbChoose.SelectedItem.ToString() == "Мляко")
                {
                    txtPrice.Text = "1,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Мед")
                {
                    txtPrice.Text = "0,50";
                }
                else if (cbChoose.SelectedItem.ToString() == "Сметана")
                {
                    txtPrice.Text = "0,80";
                }
                else if (cbChoose.SelectedItem.ToString() == "Ядки")
                {
                    txtPrice.Text = "6,50";
                }
                else
                {
                    txtPrice.Text = "6,00";
                }
            }


            if (rbHotDishes.Checked)
            {
                if (cbChoose.SelectedItem.ToString() == "Пилешки хапки")
                {
                    txtPrice.Text = "10,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Принцеси")
                {
                    txtPrice.Text = "7,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Пица")
                {
                    txtPrice.Text = "11.00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Пържени картофи")
                {
                    txtPrice.Text = "5,50";
                }
                else
                {
                    txtPrice.Text = "6,50";
                }
            }
            if (rbDesert.Checked)
            {
                if (cbChoose.SelectedItem.ToString() == "Крем брюле")
                {
                    txtPrice.Text = "6,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Шоколадово суфле")
                {
                    txtPrice.Text = "5,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Биксвитена торта")
                {
                    txtPrice.Text = "6,50";
                }
                else if (cbChoose.SelectedItem.ToString() == "Чийзкейк")
                {
                    txtPrice.Text = "4,50";
                }
                else if (cbChoose.SelectedItem.ToString() == "Сладолед")
                {
                    txtPrice.Text = "2,00";
                }
                else if (cbChoose.SelectedItem.ToString() == "Мелба")
                {
                    txtPrice.Text = "6,00";
                }
                else
                {
                    txtPrice.Text = "8,00";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text.Length > 0)
            {
                txtTotal.Text = (Convert.ToDouble(txtCount.Text) * Convert.ToDouble(txtPrice.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCount.Text == "")
            {
                txtCount.Text = "1";
            }
            dgBill.Rows.Add(cbChoose.Text, txtPrice.Text, txtCount.Text, txtTotal.Text, dtpData.Text);
            if (txtTotalOfBill.Text == "")
            {
                txtTotalOfBill.Text = (Convert.ToDouble(txtTotal.Text)).ToString();
                txtPrice.Text = "";
                txtCount.Text = "";
                txtTotal.Text = "";
                cbChoose.Text = "";
            }
            else
            {
                txtTotalOfBill.Text = (Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtTotalOfBill.Text)).ToString();
                txtPrice.Text = "";
                txtCount.Text = "";
                txtTotal.Text = "";
                cbChoose.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgBill.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgBill.Rows.Count; i++)
                {
                    if (dgBill.Rows[i].Selected)
                    {
                        txtTotalOfBill.Text = (Convert.ToDouble(txtTotalOfBill.Text) - Convert.ToDouble(dgBill.Rows[i].Cells[3].Value)).ToString();
                        dgBill.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (txtPayAmount.Text.Length > 0)
            {
                txtChange.Text = ((Convert.ToDouble(txtTotalOfBill.Text) - Convert.ToDouble(txtPayAmount.Text)) * -1).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgBill.Rows.Count; i++)
            {
                String querry = "INSERT INTO Menu (product_name, price, count, total, data) Values ('" + dgBill.Rows[i].Cells[0].Value + "','" + dgBill.Rows[i].Cells[1].Value + "','" + dgBill.Rows[i].Cells[2].Value + "','" + dgBill.Rows[i].Cells[3].Value + "','" + dgBill.Rows[i].Cells[4].Value + "')";
                SqlCommand comand = new SqlCommand(querry, connection);     
                connection.Open();
                comand.ExecuteNonQuery();
                connection.Close();
            }   
            dgBill.Rows.Clear();
            txtTotalOfBill.Text = "";
            txtPayAmount.Text = "";
            txtChange.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill bill = new Bill();
            bill.Show();
        }
    }
}
