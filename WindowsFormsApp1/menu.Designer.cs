namespace WindowsFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbHotDrinks = new System.Windows.Forms.RadioButton();
            this.rbColdDrinks = new System.Windows.Forms.RadioButton();
            this.rbSoda = new System.Windows.Forms.RadioButton();
            this.rbCocktail = new System.Windows.Forms.RadioButton();
            this.rbAlcohol = new System.Windows.Forms.RadioButton();
            this.rbExtras = new System.Windows.Forms.RadioButton();
            this.rbHotDishes = new System.Windows.Forms.RadioButton();
            this.rbDesert = new System.Windows.Forms.RadioButton();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveInDB = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblTotalOfBill = new System.Windows.Forms.Label();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtTotalOfBill = new System.Windows.Forms.TextBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).BeginInit();
            this.SuspendLayout();
            // 
            // rbHotDrinks
            // 
            this.rbHotDrinks.AutoSize = true;
            this.rbHotDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHotDrinks.Location = new System.Drawing.Point(50, 106);
            this.rbHotDrinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHotDrinks.Name = "rbHotDrinks";
            this.rbHotDrinks.Size = new System.Drawing.Size(212, 33);
            this.rbHotDrinks.TabIndex = 3;
            this.rbHotDrinks.TabStop = true;
            this.rbHotDrinks.Text = "Топли напитки";
            this.rbHotDrinks.UseVisualStyleBackColor = true;
            this.rbHotDrinks.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbColdDrinks
            // 
            this.rbColdDrinks.AutoSize = true;
            this.rbColdDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbColdDrinks.Location = new System.Drawing.Point(286, 106);
            this.rbColdDrinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbColdDrinks.Name = "rbColdDrinks";
            this.rbColdDrinks.Size = new System.Drawing.Size(235, 33);
            this.rbColdDrinks.TabIndex = 4;
            this.rbColdDrinks.TabStop = true;
            this.rbColdDrinks.Text = "Студени напитки";
            this.rbColdDrinks.UseVisualStyleBackColor = true;
            this.rbColdDrinks.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbSoda
            // 
            this.rbSoda.AutoSize = true;
            this.rbSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSoda.Location = new System.Drawing.Point(50, 148);
            this.rbSoda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSoda.Name = "rbSoda";
            this.rbSoda.Size = new System.Drawing.Size(303, 33);
            this.rbSoda.TabIndex = 5;
            this.rbSoda.TabStop = true;
            this.rbSoda.Text = "Безалкохолни напитки";
            this.rbSoda.UseVisualStyleBackColor = true;
            this.rbSoda.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbCocktail
            // 
            this.rbCocktail.AutoSize = true;
            this.rbCocktail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCocktail.Location = new System.Drawing.Point(50, 232);
            this.rbCocktail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCocktail.Name = "rbCocktail";
            this.rbCocktail.Size = new System.Drawing.Size(147, 33);
            this.rbCocktail.TabIndex = 6;
            this.rbCocktail.TabStop = true;
            this.rbCocktail.Text = "Коктейли";
            this.rbCocktail.UseVisualStyleBackColor = true;
            this.rbCocktail.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbAlcohol
            // 
            this.rbAlcohol.AutoSize = true;
            this.rbAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlcohol.Location = new System.Drawing.Point(50, 190);
            this.rbAlcohol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAlcohol.Name = "rbAlcohol";
            this.rbAlcohol.Size = new System.Drawing.Size(130, 33);
            this.rbAlcohol.TabIndex = 7;
            this.rbAlcohol.TabStop = true;
            this.rbAlcohol.Text = "Алкохол";
            this.rbAlcohol.UseVisualStyleBackColor = true;
            this.rbAlcohol.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbExtras
            // 
            this.rbExtras.AutoSize = true;
            this.rbExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExtras.Location = new System.Drawing.Point(408, 148);
            this.rbExtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbExtras.Name = "rbExtras";
            this.rbExtras.Size = new System.Drawing.Size(115, 33);
            this.rbExtras.TabIndex = 8;
            this.rbExtras.TabStop = true;
            this.rbExtras.Text = "Екстри";
            this.rbExtras.UseVisualStyleBackColor = true;
            this.rbExtras.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rbHotDishes
            // 
            this.rbHotDishes.AutoSize = true;
            this.rbHotDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHotDishes.Location = new System.Drawing.Point(345, 190);
            this.rbHotDishes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbHotDishes.Name = "rbHotDishes";
            this.rbHotDishes.Size = new System.Drawing.Size(182, 33);
            this.rbHotDishes.TabIndex = 9;
            this.rbHotDishes.TabStop = true;
            this.rbHotDishes.Text = "Топли ястия";
            this.rbHotDishes.UseVisualStyleBackColor = true;
            this.rbHotDishes.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // rbDesert
            // 
            this.rbDesert.AutoSize = true;
            this.rbDesert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDesert.Location = new System.Drawing.Point(389, 232);
            this.rbDesert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDesert.Name = "rbDesert";
            this.rbDesert.Size = new System.Drawing.Size(131, 33);
            this.rbDesert.TabIndex = 10;
            this.rbDesert.TabStop = true;
            this.rbDesert.Text = "Десерти";
            this.rbDesert.UseVisualStyleBackColor = true;
            this.rbDesert.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(45, 310);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(101, 29);
            this.lblSelect.TabIndex = 11;
            this.lblSelect.Text = "Избери";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(45, 376);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(72, 29);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Цена";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(45, 451);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(71, 29);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "Брой";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(45, 521);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 29);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Обща сума";
            // 
            // cbChoose
            // 
            this.cbChoose.BackColor = System.Drawing.Color.PapayaWhip;
            this.cbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Location = new System.Drawing.Point(200, 307);
            this.cbChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(329, 37);
            this.cbChoose.TabIndex = 15;
            this.cbChoose.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(200, 372);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 34);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(200, 443);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(160, 34);
            this.txtCount.TabIndex = 17;
            this.txtCount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(200, 517);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(160, 34);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(92, 623);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 50);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(308, 623);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(173, 50);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Премахни";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgBill
            // 
            this.dgBill.AllowUserToAddRows = false;
            this.dgBill.AllowUserToDeleteRows = false;
            this.dgBill.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgBill.Location = new System.Drawing.Point(561, 48);
            this.dgBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgBill.Name = "dgBill";
            this.dgBill.ReadOnly = true;
            this.dgBill.RowHeadersWidth = 51;
            this.dgBill.Size = new System.Drawing.Size(888, 532);
            this.dgBill.TabIndex = 21;
            this.dgBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Продукти";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цени";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Брои";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Общо";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(633, 599);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 50);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Изчисти";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSaveInDB
            // 
            this.btnSaveInDB.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSaveInDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveInDB.Location = new System.Drawing.Point(848, 599);
            this.btnSaveInDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveInDB.Name = "btnSaveInDB";
            this.btnSaveInDB.Size = new System.Drawing.Size(173, 50);
            this.btnSaveInDB.TabIndex = 23;
            this.btnSaveInDB.Text = "Запази";
            this.btnSaveInDB.UseVisualStyleBackColor = false;
            this.btnSaveInDB.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtpData
            // 
            this.dtpData.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(1233, 14);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(161, 26);
            this.dtpData.TabIndex = 24;
            this.dtpData.Value = new System.DateTime(2024, 3, 23, 0, 0, 0, 0);
            this.dtpData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblTotalOfBill
            // 
            this.lblTotalOfBill.AutoSize = true;
            this.lblTotalOfBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOfBill.Location = new System.Drawing.Point(1045, 612);
            this.lblTotalOfBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalOfBill.Name = "lblTotalOfBill";
            this.lblTotalOfBill.Size = new System.Drawing.Size(139, 29);
            this.lblTotalOfBill.TabIndex = 25;
            this.lblTotalOfBill.Text = "Обща сума";
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayAmount.Location = new System.Drawing.Point(1045, 670);
            this.lblPayAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(172, 29);
            this.lblPayAmount.TabIndex = 26;
            this.lblPayAmount.Text = "Платена сума";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(1045, 721);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(81, 29);
            this.lblChange.TabIndex = 27;
            this.lblChange.Text = "Ресто";
            // 
            // txtTotalOfBill
            // 
            this.txtTotalOfBill.Enabled = false;
            this.txtTotalOfBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOfBill.Location = new System.Drawing.Point(1233, 606);
            this.txtTotalOfBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalOfBill.Name = "txtTotalOfBill";
            this.txtTotalOfBill.Size = new System.Drawing.Size(215, 34);
            this.txtTotalOfBill.TabIndex = 28;
            this.txtTotalOfBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalOfBill.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayAmount.Location = new System.Drawing.Point(1233, 666);
            this.txtPayAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(215, 34);
            this.txtPayAmount.TabIndex = 29;
            this.txtPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPayAmount.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(1233, 718);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(215, 34);
            this.txtChange.TabIndex = 30;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChange.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(633, 672);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(388, 46);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Принтирай";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 40);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtPayAmount);
            this.Controls.Add(this.txtTotalOfBill);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblPayAmount);
            this.Controls.Add(this.lblTotalOfBill);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnSaveInDB);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgBill);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbChoose);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.rbDesert);
            this.Controls.Add(this.rbHotDishes);
            this.Controls.Add(this.rbExtras);
            this.Controls.Add(this.rbAlcohol);
            this.Controls.Add(this.rbCocktail);
            this.Controls.Add(this.rbSoda);
            this.Controls.Add(this.rbColdDrinks);
            this.Controls.Add(this.rbHotDrinks);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbHotDrinks;
        private System.Windows.Forms.RadioButton rbColdDrinks;
        private System.Windows.Forms.RadioButton rbSoda;
        private System.Windows.Forms.RadioButton rbCocktail;
        private System.Windows.Forms.RadioButton rbAlcohol;
        private System.Windows.Forms.RadioButton rbExtras;
        private System.Windows.Forms.RadioButton rbHotDishes;
        private System.Windows.Forms.RadioButton rbDesert;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cbChoose;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgBill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveInDB;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblTotalOfBill;
        private System.Windows.Forms.Label lblPayAmount;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtTotalOfBill;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
    }
}