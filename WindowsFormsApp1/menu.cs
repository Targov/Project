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

            comboBox1.Items.Add("Кола 250 мл.");
            comboBox1.Items.Add("Фанта 250 мл");
            comboBox1.Items.Add("Спрайт 250 мл.");
            comboBox1.Items.Add("Швепс 250 мл.");
            comboBox1.Items.Add("Сок капи 250 мл.");
            comboBox1.Items.Add("Студен чай 250 мл.");
            comboBox1.Items.Add("Минерална вода 500мл.");
            comboBox1.Items.Add("Ред Бул 250 мл.");
            comboBox1.Items.Add("Лимонада 300 мл.");
            comboBox1.Items.Add("Кана с лимонада 1л.");
            comboBox1.Items.Add("Фреш 250 мл.");

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
    }
}
