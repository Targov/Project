﻿using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonNewEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.Show();
        }
    }
}
