﻿using System;
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
    public partial class Form2 : Form
    {
        Menu menu = new Menu();
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
    }
}
