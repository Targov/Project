using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;
namespace WindowsFormsApp1.Tests
{
    [TestClass]
    public class Form2Tests
    {
        [TestMethod]
        public void Button2Click_ShowMenuForm_HideCurrentForm()
        {

            Form2 form2 = new Form2();
            Menu menu = new Menu();


            form2.button2_Click(null, EventArgs.Empty);


            Assert.IsFalse(form2.IsFormVisible);
            Assert.IsTrue(menu.IsMenuVisible);
        }
        public void BtnFiskClick_ShowMenuForm_HideCurrentForm()
        {

            Form2 form2 = new Form2();
            Menu menu = new Menu();
            bool form2VisibleBeforeClick = form2.IsFormVisible;
            bool menuVisibleBeforeClick = menu.IsMenuVisible;


            form2.btnFisk_Click(null, EventArgs.Empty);


            Assert.IsFalse(form2VisibleBeforeClick);
            Assert.IsTrue(menu.IsMenuVisible);
        }
        public void BtnTable4Click_ShowMenuForm_HideCurrentForm()
        {
      
            Form2 form2 = new Form2();
            Menu menu = new Menu();
            bool form2VisibleBeforeClick = form2.IsFormVisible;
            bool menuVisibleBeforeClick = menu.IsMenuVisible;

           
            form2.btnTable4_Click(null, EventArgs.Empty);

            
            Assert.IsFalse(form2VisibleBeforeClick);
            Assert.IsTrue(menu.IsMenuVisible); 
        }

        [TestMethod]
        public void BtnTable5Click_ShowMenuForm_HideCurrentForm()
        {
          
            Form2 form2 = new Form2();
            Menu menu = new Menu();
            bool form2VisibleBeforeClick = form2.IsFormVisible;
            bool menuVisibleBeforeClick = menu.IsMenuVisible;

       
            form2.btnTable5_Click(null, EventArgs.Empty);

    
            Assert.IsFalse(form2VisibleBeforeClick);
            Assert.IsTrue(menu.IsMenuVisible); 
        }

        [TestMethod]
        public void BtnTable6Click_ShowMenuForm_HideCurrentForm()
        {

            Form2 form2 = new Form2();
            Menu menu = new Menu();
            bool form2VisibleBeforeClick = form2.IsFormVisible;
            bool menuVisibleBeforeClick = menu.IsMenuVisible;

           
            form2.btnTable6_Click(null, EventArgs.Empty);

           
            Assert.IsFalse(form2VisibleBeforeClick); 
            Assert.IsTrue(menu.IsMenuVisible);
        }

       


    }
    [TestClass]
    public class MenuTests
    {
        private Menu menu;

        [TestInitialize]
        public void Setup()
        {
            menu = new Menu();
        }

        [TestMethod]
        public void TestDatabaseConnection()
        {
            Assert.IsNotNull(menu.connection);
            Assert.IsFalse(string.IsNullOrEmpty(menu.connection.ConnectionString));
        }

        [TestMethod]
        public void TestMenuVisibility()
        {
            Assert.IsTrue(menu.IsMenuVisible);
        }

        [TestMethod]
        public void TestRadioButtonInteraction()
        {
            menu.RbHotDrinks.Checked = true;
            Assert.IsTrue(menu.CbChoose.Items.Contains("Капучино"));
            Assert.IsFalse(menu.CbChoose.Items.Contains("Фрапе"));
        }

        [TestMethod]
        public void TestComboBoxSelection()
        {
            menu.RbHotDrinks.Checked = true;
            menu.CbChoose.SelectedIndex = 0; // Selecting the first item
            Assert.AreEqual("4,00", menu.TxtPrice.Text);
        }

        [TestMethod]
        public void TestAddingItemsToBill()
        {
            menu.RbHotDrinks.Checked = true;
            menu.CbChoose.SelectedIndex = 0; 
            menu.TxtCount.Text = "2"; 
            menu.button1_Click(null, null);
            Assert.AreEqual(1, menu.DgBill.Rows.Count); 
            Assert.AreEqual("8,00", menu.TxtTotalOfBill.Text); 

        }


        [TestMethod]
        public void RadioButtonHotDrinksChecked_ChooseComboBoxItem_CorrectPriceDisplayed()
        {
            Menu menu = new Menu();
            menu.RbHotDrinks.Checked = true;
            menu.CbChoose.SelectedIndex = 0;
            Assert.AreEqual("4,00", menu.TxtPrice.Text);
        }

        [TestMethod]
        public void RadioButtonColdDrinksChecked_ChooseComboBoxItem_CorrectPriceDisplayed()
        {
            Menu menu = new Menu();
            menu.RbColdDrinks.Checked = true;
            menu.CbChoose.SelectedIndex = 0;
            Assert.AreEqual("4,00", menu.TxtPrice.Text);
        }

        [TestMethod]
        public void RadioButtonSodaChecked_ChooseComboBoxItem_CorrectPriceDisplayed()
        {
            Menu menu = new Menu();
            menu.RbSoda.Checked = true;
            menu.CbChoose.SelectedIndex = 0;
            Assert.AreEqual("4,00", menu.TxtPrice.Text);
        }

        [TestMethod]
        public void ButtonAddToBill_Click_AddsItemToBill()
        {
            Menu menu = new Menu();
            menu.CbChoose.Items.Add("Test Item");
            menu.TxtPrice.Text = "5,00";
            menu.TxtCount.Text = "2";
            menu.button1_Click(null, EventArgs.Empty);
            Assert.AreEqual(1, menu.DgBill.Rows.Count);
            Assert.AreEqual("Test Item", menu.DgBill.Rows[0].Cells[0].Value);
            Assert.AreEqual("5,00", menu.DgBill.Rows[0].Cells[1].Value);
            Assert.AreEqual("2", menu.DgBill.Rows[0].Cells[2].Value);
            Assert.AreEqual("10,00", menu.DgBill.Rows[0].Cells[3].Value);
        }
        [TestMethod]
        public void TestComboBoxItems()
        {
            Menu menu = new Menu();
            menu.CbChoose.Items.Add("Item 1");
            menu.CbChoose.Items.Add("Item 2");
            Assert.AreEqual(2, menu.CbChoose.Items.Count);

            menu.CbChoose.Items.Clear();
            Assert.AreEqual(0, menu.CbChoose.Items.Count);
        }

        [TestMethod]
        public void TestDataGridViewRows()
        {
            Menu menu = new Menu();
            menu.DgBill.Rows.Add("Product 1", "Price 1", "Count 1", "Total 1", "Date 1");
            menu.DgBill.Rows.Add("Product 2", "Price 2", "Count 2", "Total 2", "Date 2");
            Assert.AreEqual(2, menu.DgBill.Rows.Count);

            menu.DgBill.Rows.RemoveAt(0);
            Assert.AreEqual(1, menu.DgBill.Rows.Count);
        }

        [TestMethod]
        public void TestButtonVisibility()
        {
            Menu menu = new Menu();
            Assert.IsNotNull(menu.BtnAdd); 
            Assert.IsFalse(menu.BtnAdd.Enabled); 
        }

    }


}