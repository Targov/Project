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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
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
            radioButton1.ForeColor = System.Drawing.Color.DarkBlue;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton7.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton8.ForeColor = System.Drawing.Color.RosyBrown;

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Капучино");
            comboBox1.Items.Add("Виенско кафе");
            comboBox1.Items.Add("Макиато");
            comboBox1.Items.Add("Мляко с Nescafe");
            comboBox1.Items.Add("Мляко с какао");
            comboBox1.Items.Add("Топъл шоколад");
            comboBox1.Items.Add("Топъл шоколад с сироп");
            comboBox1.Items.Add("Чай 500мл");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.DarkBlue;
            radioButton3.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton7.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton8.ForeColor = System.Drawing.Color.RosyBrown;

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Фрапе");
            comboBox1.Items.Add("Кафе със сладолед");
            comboBox1.Items.Add("Матча лате");
            comboBox1.Items.Add("Студено лате");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.DarkBlue;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton7.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton8.ForeColor = System.Drawing.Color.RosyBrown;

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Кола");
            comboBox1.Items.Add("Фанта");
            comboBox1.Items.Add("Спрайт");
            comboBox1.Items.Add("Швепс");
            comboBox1.Items.Add("Сок капи");
            comboBox1.Items.Add("Студен чай");
            comboBox1.Items.Add("Минерална вода");
            comboBox1.Items.Add("Ред Бул");
            comboBox1.Items.Add("Лимонада");
            comboBox1.Items.Add("Кана с лимонада");
            comboBox1.Items.Add("Фреш");

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton6.ForeColor = System.Drawing.Color.DarkBlue;
            radioButton7.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton8.ForeColor = System.Drawing.Color.RosyBrown;

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Мляко");
            comboBox1.Items.Add("Мед");
            comboBox1.Items.Add("Сметана");
            comboBox1.Items.Add("Ядки");
            comboBox1.Items.Add("Луканка");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.DarkBlue;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton7.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton8.ForeColor = System.Drawing.Color.RosyBrown;

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Ракия");
            comboBox1.Items.Add("Водка");
            comboBox1.Items.Add("Джин");
            comboBox1.Items.Add("Узо");
            comboBox1.Items.Add("Перно");
            comboBox1.Items.Add("Бренди");
            comboBox1.Items.Add("Коняк");
            comboBox1.Items.Add("Ром");
            comboBox1.Items.Add("Текила");
            comboBox1.Items.Add("Уиски");
            comboBox1.Items.Add("Жива бира");
            comboBox1.Items.Add("Шуменско наливна");
            comboBox1.Items.Add("Бира бутилка");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton7.ForeColor = System.Drawing.Color.DarkBlue;
            radioButton8.ForeColor = System.Drawing.Color.RosyBrown;

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Пилешки хапки");
            comboBox1.Items.Add("Принцеси");
            comboBox1.Items.Add("Пица");
            comboBox1.Items.Add("Пържени картофи");
            comboBox1.Items.Add("Пържени картофи със сирене");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton4.ForeColor = System.Drawing.Color.DarkBlue;
            radioButton5.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton7.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton8.ForeColor = System.Drawing.Color.RosyBrown;

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Синя лагуна");
            comboBox1.Items.Add("Мохито");
            comboBox1.Items.Add("Маргарита");

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton3.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton4.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton5.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton6.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton7.ForeColor = System.Drawing.Color.RosyBrown;
            radioButton8.ForeColor = System.Drawing.Color.DarkBlue;

            comboBox1.Items.Clear();

            comboBox1.Items.Add("Крем брюле");
            comboBox1.Items.Add("Шоколадово суфле");
            comboBox1.Items.Add("Биксвитена торта");
            comboBox1.Items.Add("Чийзкейк");
            comboBox1.Items.Add("Сладолед");
            comboBox1.Items.Add("Мелба");
            comboBox1.Items.Add("Шоколадова торта");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Капучино")
                {
                        textBox1.Text = "4,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Виенско кафе")
                {
                    textBox1.Text = "4,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Макиато")
                {
                    textBox1.Text = "4,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Мляко с Nescafe")
                {
                    textBox1.Text = "3,50";
                }
                else if (comboBox1.SelectedItem.ToString() == "Мляко с какао")
                {
                    textBox1.Text = "3,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Топъл шоколад")
                {
                    textBox1.Text = "3,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Топъл шоколад с сироп")
                {
                    textBox1.Text = "3,50";
                }
                else
                {
                    textBox1.Text = "4,00";
                }
            }


            if (radioButton2.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Фрапе")
                {
                    textBox1.Text = "4,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Кафе със сладолед")
                {
                    textBox1.Text = "4,50";
                }
                else if (comboBox1.SelectedItem.ToString() == "Матча лате")
                {
                    textBox1.Text = "6,00";
                }
                else
                {
                    textBox1.Text = "5,50";
                } 
            }


            if (radioButton3.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Фреш")
                {
                    textBox1.Text = "4,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Минерална вода")
                {
                    textBox1.Text = "3,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Ред Бул")
                {
                    textBox1.Text = "5,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Лимонада")
                {
                    textBox1.Text = "4,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Кана с лимонада")
                {
                    textBox1.Text = "10,50";
                }
                else
                {
                    textBox1.Text = "2,50";
                }
            }


            if (radioButton4.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Синя лагуна")
                {
                    textBox1.Text = "8,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Мохито")
                {
                    textBox1.Text = "9,00";
                }
                else
                {
                    textBox1.Text = "8,50";
                }
            }


            if (radioButton5.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Ракия")
                {
                    textBox1.Text = "5,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Водка")
                {
                    textBox1.Text = "4,50";
                }
                else if (comboBox1.SelectedItem.ToString() == "Джин")
                {
                    textBox1.Text = "7,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Узо")
                {
                    textBox1.Text = "5,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Перно")
                {
                    textBox1.Text = "5,50";
                }
                else if (comboBox1.SelectedItem.ToString() == "Бренди")
                {
                    textBox1.Text = "4,50";
                }
                else if (comboBox1.SelectedItem.ToString() == "Коняк")
                {
                    textBox1.Text = "7,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Ром")
                {
                    textBox1.Text = "6,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Текила")
                {
                    textBox1.Text = "4,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Уиски")
                {
                    textBox1.Text = "7,50";
                }
                else if (comboBox1.SelectedItem.ToString() == "Жива бира")
                {
                    textBox1.Text = "3.00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Шуменско наливна")
                {
                    textBox1.Text = "3,00";
                }
                else
                {
                    textBox1.Text = "4,00";
                }
            }


            if (radioButton6.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Мляко")
                {
                    textBox1.Text = "1,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Мед")
                {
                    textBox1.Text = "0,50";
                }
                else if (comboBox1.SelectedItem.ToString() == "Сметана")
                {
                    textBox1.Text = "0,80";
                }
                else if (comboBox1.SelectedItem.ToString() == "Ядки")
                {
                    textBox1.Text = "6,50";
                }
                else
                {
                    textBox1.Text = "6,00";
                }
            }


            if (radioButton7.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Пилешки хапки")
                {
                    textBox1.Text = "10,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Принцеси")
                {
                    textBox1.Text = "7,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Пица")
                {
                    textBox1.Text = "11.00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Пържени картофи")
                {
                    textBox1.Text = "5,50";
                }
                else
                {
                    textBox1.Text = "6,50";
                }
            }


            if (radioButton8.Checked)
            {
                if (comboBox1.SelectedItem.ToString() == "Крем брюле")
                {
                    textBox1.Text = "6,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Шоколадово суфле")
                {
                    textBox1.Text = "5,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Биксвитена торта")
                {
                    textBox1.Text = "6,50";
                }
                else if (comboBox1.SelectedItem.ToString() == "Чийзкейк")
                {
                    textBox1.Text = "4,50";
                }
                else if (comboBox1.SelectedItem.ToString() == "Сладолед")
                {
                    textBox1.Text = "2,00";
                }
                else if (comboBox1.SelectedItem.ToString() == "Мелба")
                {
                    textBox1.Text = "6,00";
                }
                else
                {
                    textBox1.Text = "8,00";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox3.Text = (Convert.ToInt64(textBox2.Text) * Convert.ToInt64(textBox3.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text);
            textBox4.Text = (Convert.ToInt16(textBox4) + Convert.ToInt16(textBox3)).ToString();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        textBox4.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(dataGridView1.Rows[i].Cells[4].Value)).ToString();
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length > 0)
            {
                textBox6.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(textBox5.Text)).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
