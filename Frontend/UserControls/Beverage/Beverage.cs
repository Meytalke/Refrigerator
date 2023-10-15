using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refrigerator_FinalProj.Backend.Enums;
using Refrigerator_FinalProj.Backend.Model;

namespace Refrigerator_FinalProj.Frontend.UserControls
{
    public partial class Beverage : UserControl
    {
        ProductsManager p;

        public ProductsManager P { get => p; }
        public Beverage()
        {
            InitializeComponent();
            p = new ProductsManager();
            comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageType));
            comboBoxMilkTypeDairy.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorMilkType));
            comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageType));
            comboBoxNameBeverage.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
            string[] BeverageProducts = { "Cola","EnergyDrink","FruitPunch","Milk","Chocolate","Coffee"};
            AddProductImages(0, BeverageProducts);
            regularAddToTable();
        }
        private Image GetProductImage(string productName)
        {
            switch (productName)
            {
                case "Cola":
                    return Properties.Resources.Cola;
                case "EnergyDrink":
                    return Properties.Resources.EnergyDrink;
                case "FruitPunch":
                    return Properties.Resources.FruitPunch;
                case "Milk":
                    return Properties.Resources.Milk;
                case "Chocolate":
                    return Properties.Resources.Chocolate;
                case "Coffee":
                    return Properties.Resources.Coffee;
                default:
                    return null;
            }
        }
        private void AddProductImages(int imageCount, string[] productNames)
        {
            int x = 150;  // Horizontal position
            int y = 450;  // Vertical position

            foreach (string productName in productNames)
            {
                int productCount = p.CountOccurrences(productName);
                for (int i = 0; i < productCount; i++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = GetProductImage(productName);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(50, 100);

                    // Location decision for each product using switch
                    switch (productName)
                    {
                        case "Cola":
                            pictureBox.Location = new Point(x, y);
                            break;
                        case "EnergyDrink":
                            pictureBox.Location = new Point(x + 100, y);
                            break;
                        case "FruitPunch":
                            pictureBox.Location = new Point(x + 200, y);
                            break;
                        case "Milk":
                            pictureBox.Location = new Point(x + 300, y);
                            break;
                        case "Chocolate":
                            pictureBox.Location = new Point(x + 400, y);
                            break;
                        case "Coffee":
                            pictureBox.Location = new Point(x + 400, y);
                            break;
                        default:
                            break;
                    }

                    pictureBox.Cursor = Cursors.Hand;
                    pictureBox.MouseDown += MouseDown;
                    pictureBox.MouseMove += MouseMove;
                    pictureBox.MouseUp += MouseUp;
                    this.Controls.Add(pictureBox);
                }
            }
        }
        private void DisplayAllProductsInGrid(BindingList<Product> products)
        {
            dataGridViewBeverage.Rows.Clear();

            foreach (Product product in products)
            {
                if (product.Name == "Coffee" || product.Name == "Chocolate" || product.Name == "Milk" || product.Name == "Cola" || product.Name == "EnergyDrink" || product.Name == "FruitPunch")
                {
                    int row = dataGridViewBeverage.Rows.Add();
                    dataGridViewBeverage.Rows[row].Cells["Name"].Value = product.Name;
                    dataGridViewBeverage.Rows[row].Cells["Price"].Value = product.Price;
                    dataGridViewBeverage.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                    dataGridViewBeverage.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                    if (product is Coffee)
                    {
                        Coffee coffee = (Coffee)product;
                        dataGridViewBeverage.Rows[row].Cells["ID"].Value = coffee.Id;
                        dataGridViewBeverage.Rows[row].Cells["Liters"].Value = coffee.Liters;
                        dataGridViewBeverage.Rows[row].Cells["Brand"].Value = coffee.Brand;
                        dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = coffee.Flavor;
                        dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = coffee.IsCarbonated;
                        dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = coffee.MilkType;
                        dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = coffee.IsLactoseFree;
                        dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = coffee.IsVegan;
                        dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = coffee.IsAlmondMilkBeverage;
                        dataGridViewBeverage.Rows[row].Cells["Fat"].Value = coffee.FatPercentage;
                    }
                    else if (product is Chocolate)
                    {
                        Chocolate chocolate = (Chocolate)product;
                        dataGridViewBeverage.Rows[row].Cells["ID"].Value = chocolate.Id;
                        dataGridViewBeverage.Rows[row].Cells["Liters"].Value = chocolate.Liters;
                        dataGridViewBeverage.Rows[row].Cells["Brand"].Value = chocolate.Brand;
                        dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = chocolate.Flavor;
                        dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = chocolate.IsCarbonated;
                        dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = chocolate.MilkType;
                        dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = chocolate.IsLactoseFree;
                        dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = chocolate.IsVegan;
                        dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = chocolate.IsAlmondMilkBeverage;
                        dataGridViewBeverage.Rows[row].Cells["Fat"].Value = chocolate.FatPercentage;
                    }
                    else if (product is Milk)
                    {
                        Milk milk = (Milk)product;
                        dataGridViewBeverage.Rows[row].Cells["ID"].Value = milk.Id;
                        dataGridViewBeverage.Rows[row].Cells["Liters"].Value = milk.Liters;
                        dataGridViewBeverage.Rows[row].Cells["Brand"].Value = milk.Brand;
                        dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = milk.Flavor;
                        dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = milk.IsCarbonated;
                        dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = milk.MilkType;
                        dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = milk.IsLactoseFree;
                        dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = milk.IsVegan;
                        dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = milk.IsAlmondMilkBeverage;
                        dataGridViewBeverage.Rows[row].Cells["Fat"].Value = milk.FatPercentage;
                    }
                    else if (product is Cola)
                    {
                        Cola cola = (Cola)product;
                        dataGridViewBeverage.Rows[row].Cells["ID"].Value = cola.Id;
                        dataGridViewBeverage.Rows[row].Cells["Liters"].Value = cola.Liters;
                        dataGridViewBeverage.Rows[row].Cells["Brand"].Value = cola.Brand;
                        dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = cola.Flavor;
                        dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = cola.IsCarbonated;
                        dataGridViewBeverage.Rows[row].Cells["SugarContent"].Value = cola.SugarContent;
                        dataGridViewBeverage.Rows[row].Cells["IsDiet"].Value = cola.IsDiet;
                        dataGridViewBeverage.Rows[row].Cells["HasCaffeine"].Value = cola.HasCaffeine;
                    }
                    else if (product is EnergyDrink)
                    {
                        EnergyDrink energyDrink = (EnergyDrink)product;
                        dataGridViewBeverage.Rows[row].Cells["ID"].Value = energyDrink.Id;
                        dataGridViewBeverage.Rows[row].Cells["Liters"].Value = energyDrink.Liters;
                        dataGridViewBeverage.Rows[row].Cells["Brand"].Value = energyDrink.Brand;
                        dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = energyDrink.Flavor;
                        dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = energyDrink.IsCarbonated;
                        dataGridViewBeverage.Rows[row].Cells["SugarContent"].Value = energyDrink.SugarContent;
                        dataGridViewBeverage.Rows[row].Cells["IsDiet"].Value = energyDrink.IsDiet;
                        dataGridViewBeverage.Rows[row].Cells["CaffeineContent"].Value = energyDrink.CaffeineContent;
                    }
                    else if (product is FruitPunch)
                    {
                        FruitPunch fruitPunch = (FruitPunch)product;
                        dataGridViewBeverage.Rows[row].Cells["ID"].Value = fruitPunch.Id;
                        dataGridViewBeverage.Rows[row].Cells["Liters"].Value = fruitPunch.Liters;
                        dataGridViewBeverage.Rows[row].Cells["Brand"].Value = fruitPunch.Brand;
                        dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = fruitPunch.Flavor;
                        dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = fruitPunch.IsCarbonated;
                        dataGridViewBeverage.Rows[row].Cells["SugarContent"].Value = fruitPunch.SugarContent;
                        dataGridViewBeverage.Rows[row].Cells["IsDiet"].Value = fruitPunch.IsDiet;
                        dataGridViewBeverage.Rows[row].Cells["IsPulpFree"].Value = fruitPunch.IsPulpFree;
                        dataGridViewBeverage.Rows[row].Cells["FruitCombination"].Value = fruitPunch.FruitCombination;
                    }
                }
            }
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem.ToString() == "Choose")
            {
                BindingList<Product> products = p.GetProducts();
                DisplayAllProductsInGrid(products);
                VisibleandEnable(true, false);
                VisibleandEnableSweetenedBeverage(false, false);
                VisibleandEnableDairyBeverage(false, false);
                VisibleandEnableCola(false);
                VisibleandEnableEnergyDrink(false);
                VisibleandEnableFruitPunch(false);
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageType));
                comboBoxMilkTypeDairy.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorMilkType));
                buttonAdd.Enabled = false;
                buttonClear.Enabled = false;
            }
            if (comboBoxType.SelectedIndex == 1)
            {
                comboBoxNameBeverage.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                VisibleandEnable(true, false);
                comboBoxNameBeverage.Enabled = true;
                VisibleandEnableSweetenedBeverage(false, false);
                VisibleandEnableDairyBeverage(true, false);
                VisibleandEnableCola(false);
                VisibleandEnableEnergyDrink(false);
                VisibleandEnableFruitPunch(false);
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageDairyBrand));

            }
            if (comboBoxType.SelectedItem.ToString() == "Sweet")
            {
                VisibleandEnableSweetenedBeverage(true, false);
                VisibleandEnableDairyBeverage(false, false);
                VisibleandEnableCola(false);
                VisibleandEnableEnergyDrink(false);
                VisibleandEnableFruitPunch(false);
                comboBoxNameBeverage.Enabled = true;
                comboBoxNameBeverage.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameSweet));

                lblisDietSweet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblsugarContentSweet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            buttonAdd.Enabled = false;
            buttonClear.Enabled = false;
        }

        private void VisibleandEnable(bool i, bool j)
        {
            Control[] VisibleandEnableControls = { comboBoxNameBeverage, textBoxPrice, dateTimeBuyingDate, txtShelfLife, comboBoxBrand, comboBoxFlavor, txtLiters, chkIsCarbonated };
            foreach (Control control in VisibleandEnableControls)
            {
                control.Visible = i;
                control.Enabled = j;
            }

        }
        private void VisibleandEnableSweetenedBeverage(bool i, bool j)
        {
            Control[] SweetenedBeverageControls = { chkisDietSweet, lblisDietSweet, lblsugarContentSweet, txtsugarContentSweet };

            foreach (Control control in SweetenedBeverageControls)
            {
                control.Visible = i;
                control.Enabled = j;
            }

        }
        private void VisibleandEnableDairyBeverage(bool i, bool j)
        {
            Control[] DairyBeverageControls = { chkisAlmondMilkDairy, lblIsAlmondMilkDairy, chkisLactoseFreeDairy, lblisLactoseFreeDairy, chkisVeganDairy, lblisVeganDairy, comboBoxMilkTypeDairy, lblMilkTypeDairy, txtFatDairy, lblfatPercentageDairy };

            foreach (Control control in DairyBeverageControls)
            {
                control.Visible = i;
                control.Enabled = j;
            }
        }
        private void VisibleandEnableCola(bool i)
        {
            Control[] ColaControls = { chkhasCaffeineCola, lblhasCaffeineCola };

            foreach (Control control in ColaControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void VisibleandEnableEnergyDrink(bool i)
        {
            Control[] EnergyDrinkControls = { txtcaffeineContentEnergy, lblcaffeineContentEnergy };

            foreach (Control control in EnergyDrinkControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void VisibleandEnableFruitPunch(bool i)
        {
            Control[] FruitPunchControls = { chkisPulpFreeFruitPunch, comboBoxfruitCombinationFruitPunch, lblfruitCombinationFruitPunch, lblisPulpFreeFruitPunch };

            foreach (Control control in FruitPunchControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void ClearForm()
        {
            ComboBox[] comboBoxes = { comboBoxBrand, comboBoxFlavor, comboBoxfruitCombinationFruitPunch, comboBoxMilkTypeDairy };
            TextBox[] textBoxes = { txtcaffeineContentEnergy, txtFatDairy, txtLiters, txtShelfLife, txtsugarContentSweet ,textBoxPrice};
            DateTimePicker[] dateTimePickers = { dateTimeBuyingDate };
            CheckBox[] checkboxes = { chkhasCaffeineCola, chkisAlmondMilkDairy, chkIsCarbonated, chkisDietSweet, chkisLactoseFreeDairy, chkisPulpFreeFruitPunch, chkisVeganDairy };

            if (comboBoxBrand.SelectedIndex != 0)
            {
                comboBoxBrand.SelectedIndex = 0;
            }
            if (comboBoxFlavor.SelectedIndex != 0)
            {
                comboBoxFlavor.SelectedIndex = 0;
            }
            if (comboBoxMilkTypeDairy.SelectedIndex != 0)
            {
                comboBoxMilkTypeDairy.SelectedIndex = 0;
            }
            if (comboBoxNameBeverage.SelectedIndex != 0)
            {
                comboBoxNameBeverage.SelectedIndex = 0;
            }
            comboBoxType.SelectedIndex = 0;
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.ResetText();
            }

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }

            foreach (DateTimePicker dateTimePicker in dateTimePickers)
            {
                dateTimePicker.ResetText();
            }

            foreach (CheckBox checkbox in checkboxes)
            {
                checkbox.Checked = false;
            }

            VisibleandEnable(true, false);
            VisibleandEnableSweetenedBeverage(false, false);
            VisibleandEnableDairyBeverage(false, false);
            VisibleandEnableCola(false);
            VisibleandEnableEnergyDrink(false);
            VisibleandEnableFruitPunch(false);
        }
        private List<Product> GetFilteredProducts(string selectedProductName)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (Product product in P.GetProducts())
            {
                if (product.Name == selectedProductName)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }
        private void regularAddToTable()
        {

            dataGridViewBeverage.Columns.Add("ID", "ID");
            dataGridViewBeverage.Columns.Add("Name", "Name");
            dataGridViewBeverage.Columns.Add("Price", "Price");
            dataGridViewBeverage.Columns.Add("PurchaseDay", "Purchase Day");
            dataGridViewBeverage.Columns.Add("ShelfLife", "Shelf Life");
            dataGridViewBeverage.Columns.Add("Brand", "Brand");
            dataGridViewBeverage.Columns.Add("Flavor", "Flavor");
            dataGridViewBeverage.Columns.Add("Liters", "Liters");
            dataGridViewBeverage.Columns.Add("IsCarbonated", "IsCarbonated");
            dataGridViewBeverage.Columns.Add("MilkType", "Milk Type");
            dataGridViewBeverage.Columns.Add("IsLactoseFree", "Is Lactose Free");
            dataGridViewBeverage.Columns.Add("IsVegan", "Is Vegan");
            dataGridViewBeverage.Columns.Add("IsAlmond", "Is Almond");
            dataGridViewBeverage.Columns.Add("Fat", "Fat");
            dataGridViewBeverage.Columns.Add("SugarContent", "Sugar Content");
            dataGridViewBeverage.Columns.Add("IsDiet", "IsDiet");
            dataGridViewBeverage.Columns.Add("HasCaffeine", "Has Caffeine");
            dataGridViewBeverage.Columns.Add("CaffeineContent", "Caffeine Content");
            dataGridViewBeverage.Columns.Add("FruitCombination", "Fruit Combination");
            dataGridViewBeverage.Columns.Add("IsPulpFree", "Is Pulp Free");
        }
        private void DisplayProductsInGrid(List<Product> filteredProducts)
        {
            dataGridViewBeverage.Rows.Clear();

            foreach (Product product in filteredProducts)
            {
                int row = dataGridViewBeverage.Rows.Add();
                dataGridViewBeverage.Rows[row].Cells["Name"].Value = product.Name;
                dataGridViewBeverage.Rows[row].Cells["Price"].Value = product.Price;
                dataGridViewBeverage.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                dataGridViewBeverage.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                if (product is Coffee)
                {
                    Coffee coffee = (Coffee)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = coffee.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = coffee.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = coffee.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = coffee.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = coffee.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = coffee.MilkType;
                    dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = coffee.IsLactoseFree;
                    dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = coffee.IsVegan;
                    dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = coffee.IsAlmondMilkBeverage;
                    dataGridViewBeverage.Rows[row].Cells["Fat"].Value = coffee.FatPercentage;
                }
                else if (product is Chocolate)
                {
                    Chocolate chocolate = (Chocolate)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = chocolate.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = chocolate.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = chocolate.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = chocolate.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = chocolate.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = chocolate.MilkType;
                    dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = chocolate.IsLactoseFree;
                    dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = chocolate.IsVegan;
                    dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = chocolate.IsAlmondMilkBeverage;
                    dataGridViewBeverage.Rows[row].Cells["Fat"].Value = chocolate.FatPercentage;
                }
                else if (product is Milk)
                {
                    Milk milk = (Milk)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = milk.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = milk.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = milk.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = milk.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = milk.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = milk.MilkType;
                    dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = milk.IsLactoseFree;
                    dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = milk.IsVegan;
                    dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = milk.IsAlmondMilkBeverage;
                    dataGridViewBeverage.Rows[row].Cells["Fat"].Value = milk.FatPercentage;
                }
                else if (product is Cola)
                {
                    Cola cola = (Cola)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = cola.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = cola.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = cola.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = cola.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = cola.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["SugarContent"].Value = cola.SugarContent;
                    dataGridViewBeverage.Rows[row].Cells["IsDiet"].Value = cola.IsDiet;
                    dataGridViewBeverage.Rows[row].Cells["HasCaffeine"].Value = cola.HasCaffeine;
                }
                else if (product is EnergyDrink)
                {
                    EnergyDrink energyDrink = (EnergyDrink)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = energyDrink.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = energyDrink.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = energyDrink.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = energyDrink.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = energyDrink.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["SugarContent"].Value = energyDrink.SugarContent;
                    dataGridViewBeverage.Rows[row].Cells["IsDiet"].Value = energyDrink.IsDiet;
                    dataGridViewBeverage.Rows[row].Cells["CaffeineContent"].Value = energyDrink.CaffeineContent;
                }
                else if (product is FruitPunch)
                {
                    FruitPunch fruitPunch = (FruitPunch)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = fruitPunch.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = fruitPunch.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = fruitPunch.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = fruitPunch.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = fruitPunch.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["SugarContent"].Value = fruitPunch.SugarContent;
                    dataGridViewBeverage.Rows[row].Cells["IsDiet"].Value = fruitPunch.IsDiet;
                    dataGridViewBeverage.Rows[row].Cells["IsPulpFree"].Value = fruitPunch.IsPulpFree;
                    dataGridViewBeverage.Rows[row].Cells["FruitCombination"].Value = fruitPunch.FruitCombination;
                }
            }
        }
        private void comboBoxNameBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 1 && comboBoxNameBeverage.SelectedIndex == 0)
            {
                VisibleandEnable(true, false);
                VisibleandEnableSweetenedBeverage(false, false);
                VisibleandEnableDairyBeverage(false, false);
                VisibleandEnableCola(false);
                VisibleandEnableEnergyDrink(false);
                VisibleandEnableFruitPunch(false);
                buttonAdd.Enabled = false;
                buttonClear.Enabled = false;

            }
            else
            {
                buttonAdd.Enabled = true;
                buttonClear.Enabled = true;
            }

            if (comboBoxNameBeverage.SelectedItem.ToString() == "Milk" || comboBoxNameBeverage.SelectedItem.ToString() == "Chocolate" || comboBoxNameBeverage.SelectedItem.ToString() == "Coffee")
            {
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyButter));
                string selectedProduct = comboBoxNameBeverage.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableSweetenedBeverage(false, false);
                VisibleandEnableDairyBeverage(true, true);
                VisibleandEnableCola(false);
                VisibleandEnableEnergyDrink(false);
                VisibleandEnableFruitPunch(false);

                lblfatPercentageDairy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblIsAlmondMilkDairy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblisLactoseFreeDairy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblisVeganDairy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblMilkTypeDairy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                if (comboBoxNameBeverage.SelectedItem.ToString() == "Milk")
                {
                    comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorMilk));
                }
                else if (comboBoxNameBeverage.SelectedItem.ToString() == "Chocolate")
                {
                    comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorChocolate));

                }
                else if (comboBoxNameBeverage.SelectedItem.ToString() == "Coffee")
                {
                    comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorCoffee));

                }
                DisplayProductsInGrid(filteredProducts);
            }
            if (comboBoxNameBeverage.SelectedItem.ToString() == "Cola")
            {
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyButter));
                string selectedProduct = comboBoxNameBeverage.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableSweetenedBeverage(true, true);
                VisibleandEnableDairyBeverage(false, false);
                VisibleandEnableCola(true);
                VisibleandEnableEnergyDrink(false);
                VisibleandEnableFruitPunch(false);

                lblhasCaffeineCola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorCola));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eCola));
                DisplayProductsInGrid(filteredProducts);
            }
            if (comboBoxNameBeverage.SelectedItem.ToString() == "EnergyDrink")
            {
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyButter));
                string selectedProduct = comboBoxNameBeverage.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableSweetenedBeverage(true, true);
                VisibleandEnableDairyBeverage(false, false);
                VisibleandEnableCola(false);
                VisibleandEnableEnergyDrink(true);
                VisibleandEnableFruitPunch(false);

                lblcaffeineContentEnergy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorEnergyDrink));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eEnergyDrink));
                DisplayProductsInGrid(filteredProducts);
            }
            if (comboBoxNameBeverage.SelectedItem.ToString() == "FruitPunch")
            {
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyButter));
                string selectedProduct = comboBoxNameBeverage.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableSweetenedBeverage(true, true);
                VisibleandEnableDairyBeverage(false, false);
                VisibleandEnableCola(false);
                VisibleandEnableEnergyDrink(false);
                VisibleandEnableFruitPunch(true);

                lblfruitCombinationFruitPunch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblisPulpFreeFruitPunch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eFruitPunch));
                comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorFruitPunch));
                comboBoxfruitCombinationFruitPunch.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorFruitComb));
                DisplayProductsInGrid(filteredProducts);
            }

        }
        private bool validtion()
        {
            try
            {
                double price;
                if (double.TryParse(textBoxPrice.Text, out price))
                {
                    if (price <= 0)
                    {
                        throw new Exception("Invalid price value");
                    }
                }
                if (!Validator.ValidateValue(textBoxPrice.Text, typeof(double)))
                    throw new Exception("Invalid price value");
                if (!Validator.ValidateValue(dateTimeBuyingDate.Value, typeof(DateTime)))
                    throw new Exception("Invalid Buying date value");
                if (dateTimeBuyingDate.Value > DateTime.Today.AddDays(+1))
                {
                    throw new Exception("Invalid Buying date value");
                }
                if (!Validator.ValidateValue(txtShelfLife.Text, typeof(int)))
                    throw new Exception("Invalid shelf life value");
                int shelf;
                if (int.TryParse(txtShelfLife.Text, out shelf))
                {
                    if (shelf <= 0)
                    {
                        throw new Exception("Invalid shelf life value");
                    }
                }
                if (comboBoxBrand.SelectedIndex == 0)
                {
                    throw new Exception("Please choose Brand");
                }
                if (comboBoxFlavor.SelectedIndex == 0)
                {
                    throw new Exception("Please choose Flavor");
                }
                if (!Validator.ValidateValue(txtLiters.Text, typeof(double)))
                    throw new Exception("Invalid Liters value");
                double Liters;
                if (double.TryParse(txtLiters.Text, out Liters))
                {
                    if (Liters <= 0)
                    {
                        throw new Exception("Invalid Liters value");
                    }
                }
                if (comboBoxType.SelectedIndex == 1)
                {

                    if (comboBoxMilkTypeDairy.SelectedIndex == 0)
                    {
                        throw new Exception("Please choose Milk Type");
                    }

                    if (!Validator.ValidateValue(txtFatDairy.Text, typeof(double)))
                    {
                        throw new Exception("Invalid fat value");
                    }
                    double fat;
                    if (double.TryParse(txtFatDairy.Text, out fat))
                    {
                        if (fat <= 0 || fat > 100)
                        {
                            throw new Exception("Invalid fat value");
                        }
                    }
                }
                if (comboBoxType.SelectedIndex == 2)
                {
                    if (!Validator.ValidateValue(txtsugarContentSweet.Text, typeof(double)))
                    {
                        throw new Exception("Invalid sugar content value");
                    }
                    double sugar;
                    if (double.TryParse(txtsugarContentSweet.Text, out sugar))
                    {
                        if (sugar <= 0)
                        {
                            throw new Exception("Invalid sugar content value");
                        }
                    }
                    if (comboBoxNameBeverage.SelectedIndex == 2)
                    {
                        if (!Validator.ValidateValue(txtcaffeineContentEnergy.Text, typeof(double)))
                        {
                            throw new Exception("Invalid caffeine content value");
                        }
                        double caffeine;
                        if (double.TryParse(txtcaffeineContentEnergy.Text, out caffeine))
                        {
                            if (sugar <= 0 || sugar > 100)
                            {
                                throw new Exception("Invalid caffeine Content value");
                            }
                        }
                    }
                    if (comboBoxNameBeverage.SelectedIndex == 3)
                    {
                        if (comboBoxfruitCombinationFruitPunch.SelectedIndex == 0)
                        {
                            throw new Exception("Please choose fruit Combination");
                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private bool isDragging = false;
        private Point startPosition;
        private void MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPosition = e.Location;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox Beverage = (PictureBox)sender;
                Beverage.Left += e.X - startPosition.X;
                Beverage.Top += e.Y - startPosition.Y;
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void buttonAdd_Click_2(object sender, EventArgs e)
        {
            if (validtion())
            {
                int rowCount = dataGridViewBeverage.Rows.Count;

                string type = comboBoxType.Text;
                string name = comboBoxNameBeverage.Text;
                double price = double.Parse(textBoxPrice.Text);
                DateTime date = dateTimeBuyingDate.Value;
                int shelf = int.Parse(txtShelfLife.Text);
                string Brand = comboBoxBrand.Text;
                string Flavor = comboBoxFlavor.Text;

                double Liters = double.Parse(txtLiters.Text);
                bool IsCarbonated = chkIsCarbonated.Checked;


                switch (comboBoxNameBeverage.SelectedItem.ToString())
                {
                    case "Chocolate":
                        string milkType = comboBoxMilkTypeDairy.Text;
                        bool isLactoseFree = chkisLactoseFreeDairy.Checked;
                        bool isVagen = chkisVeganDairy.Checked;
                        bool isAlmondMilkBeverage = chkisAlmondMilkDairy.Checked;
                        double fatPercentage = double.Parse(txtFatDairy.Text);
                        Chocolate chocolate = null;
                        chocolate = new Chocolate(name, price, date, shelf, Liters, Brand, Flavor, IsCarbonated, milkType, isLactoseFree, isVagen, isAlmondMilkBeverage, fatPercentage);
                        p.AddProduct(chocolate);
                        int row = dataGridViewBeverage.Rows.Add();
                        dataGridViewBeverage.Rows[row].Cells["Name"].Value = chocolate.Name;
                        dataGridViewBeverage.Rows[row].Cells["Price"].Value = chocolate.Price;
                        dataGridViewBeverage.Rows[row].Cells["PurchaseDay"].Value = chocolate.PurchaseDay;
                        dataGridViewBeverage.Rows[row].Cells["ShelfLife"].Value = chocolate.ShelfLife;
                        dataGridViewBeverage.Rows[row].Cells["ID"].Value = chocolate.Id;
                        dataGridViewBeverage.Rows[row].Cells["Brand"].Value = chocolate.Brand;
                        dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = chocolate.Flavor;
                        dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = chocolate.MilkType;
                        dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = chocolate.IsLactoseFree;
                        dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = chocolate.IsVegan;
                        dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = chocolate.IsAlmondMilkBeverage;
                        dataGridViewBeverage.Rows[row].Cells["Fat"].Value = chocolate.FatPercentage;
                        PictureBox chocolateim = new PictureBox();
                        chocolateim.Image = Properties.Resources.Chocolate;
                        Image originalImage = chocolateim.Image;
                        Image resizedImage = new Bitmap(originalImage, new Size(50, 100));
                        chocolateim.Image = resizedImage;
                        chocolateim.SizeMode = PictureBoxSizeMode.AutoSize; // Automatically adjust image size into the picturebox
                        chocolateim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        chocolateim.Cursor = Cursors.Hand; //Change the mouse shape to a hand shape
                        chocolateim.MouseDown += MouseDown;
                        chocolateim.MouseMove += MouseMove;
                        chocolateim.MouseUp += MouseUp;
                        Controls.Add(chocolateim);
                        break;
                    case "Coffee":
                        string milkType1 = comboBoxMilkTypeDairy.Text;
                        bool isLactoseFree1 = chkisLactoseFreeDairy.Checked;
                        bool isVagen1 = chkisVeganDairy.Checked;
                        bool isAlmondMilkBeverage1 = chkisAlmondMilkDairy.Checked;
                        double fatPercentage1 = double.Parse(txtFatDairy.Text);
                        Coffee coffee = null;
                        coffee = new Coffee(name, price, date, shelf, Liters, Brand, Flavor, IsCarbonated, milkType1, isLactoseFree1, isVagen1, isAlmondMilkBeverage1, fatPercentage1);
                        p.AddProduct(coffee);
                        int row1 = dataGridViewBeverage.Rows.Add();
                        dataGridViewBeverage.Rows[row1].Cells["Name"].Value = coffee.Name;
                        dataGridViewBeverage.Rows[row1].Cells["Price"].Value = coffee.Price;
                        dataGridViewBeverage.Rows[row1].Cells["PurchaseDay"].Value = coffee.PurchaseDay;
                        dataGridViewBeverage.Rows[row1].Cells["ShelfLife"].Value = coffee.ShelfLife;
                        dataGridViewBeverage.Rows[row1].Cells["ID"].Value = coffee.Id;
                        dataGridViewBeverage.Rows[row1].Cells["Brand"].Value = coffee.Brand;
                        dataGridViewBeverage.Rows[row1].Cells["Flavor"].Value = coffee.Flavor;
                        dataGridViewBeverage.Rows[row1].Cells["MilkType"].Value = coffee.MilkType;
                        dataGridViewBeverage.Rows[row1].Cells["IsLactoseFree"].Value = coffee.IsLactoseFree;
                        dataGridViewBeverage.Rows[row1].Cells["IsVegan"].Value = coffee.IsVegan;
                        dataGridViewBeverage.Rows[row1].Cells["IsAlmond"].Value = coffee.IsAlmondMilkBeverage;
                        dataGridViewBeverage.Rows[row1].Cells["Fat"].Value = coffee.FatPercentage;
                        PictureBox coffeeim = new PictureBox();
                        coffeeim.Image = Properties.Resources.Coffee;
                        Image originalImage1 = coffeeim.Image;
                        Image resizedImage1 = new Bitmap(originalImage1, new Size(50, 100));
                        coffeeim.Image = resizedImage1;
                        coffeeim.SizeMode = PictureBoxSizeMode.AutoSize; //Automatically adjust image size into the picturebox
                        coffeeim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        coffeeim.Cursor = Cursors.Hand;//Change the mouse shape to a hand shape
                        coffeeim.MouseDown += MouseDown;
                        coffeeim.MouseMove += MouseMove;
                        coffeeim.MouseUp += MouseUp;
                        Controls.Add(coffeeim);
                        break;

                    case "Milk":
                        string milkType2 = comboBoxMilkTypeDairy.Text;
                        bool isLactoseFree2 = chkisLactoseFreeDairy.Checked;
                        bool isVagen2 = chkisVeganDairy.Checked;
                        bool isAlmondMilkBeverage2 = chkisAlmondMilkDairy.Checked;
                        double fatPercentage2 = double.Parse(txtFatDairy.Text);
                        Milk milk = null;
                        milk = new Milk(name, price, date, shelf, Liters, Brand, Flavor, IsCarbonated, milkType2, isLactoseFree2, isVagen2, isAlmondMilkBeverage2, fatPercentage2);
                        p.AddProduct(milk);
                        int row2 = dataGridViewBeverage.Rows.Add();
                        dataGridViewBeverage.Rows[row2].Cells["Name"].Value = milk.Name;
                        dataGridViewBeverage.Rows[row2].Cells["Price"].Value = milk.Price;
                        dataGridViewBeverage.Rows[row2].Cells["PurchaseDay"].Value = milk.PurchaseDay;
                        dataGridViewBeverage.Rows[row2].Cells["ShelfLife"].Value = milk.ShelfLife;
                        dataGridViewBeverage.Rows[row2].Cells["ID"].Value = milk.Id;
                        dataGridViewBeverage.Rows[row2].Cells["Brand"].Value = milk.Brand;
                        dataGridViewBeverage.Rows[row2].Cells["Flavor"].Value = milk.Flavor;
                        dataGridViewBeverage.Rows[row2].Cells["MilkType"].Value = milk.MilkType;
                        dataGridViewBeverage.Rows[row2].Cells["IsLactoseFree"].Value = milk.IsLactoseFree;
                        dataGridViewBeverage.Rows[row2].Cells["IsVegan"].Value = milk.IsVegan;
                        dataGridViewBeverage.Rows[row2].Cells["IsAlmond"].Value = milk.IsAlmondMilkBeverage;
                        dataGridViewBeverage.Rows[row2].Cells["Fat"].Value = milk.FatPercentage;
                        PictureBox milkim = new PictureBox();
                        milkim.Image = Properties.Resources.Milk;
                        Image originalImage2 = milkim.Image;
                        Image resizedImage2 = new Bitmap(originalImage2, new Size(50, 100));
                        milkim.Image = resizedImage2;
                        milkim.SizeMode = PictureBoxSizeMode.AutoSize; // Automatically adjust image size into the picturebox
                        milkim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        milkim.Cursor = Cursors.Hand; //Change the mouse shape to a hand shape
                        milkim.MouseDown += MouseDown;
                        milkim.MouseMove += MouseMove;
                        milkim.MouseUp += MouseUp;
                        Controls.Add(milkim);
                        break;
                    case "Cola":

                        double sugarContent= double.Parse(txtsugarContentSweet.Text);
                        bool isDiet = chkisDietSweet.Checked;
                        bool hasCaffeine = chkhasCaffeineCola.Checked;


                        Cola cola = null;
                        cola = new Cola(name, price, date, shelf, Liters, Brand, Flavor, IsCarbonated, sugarContent, isDiet, hasCaffeine);
                        p.AddProduct(cola);
                        int row3 = dataGridViewBeverage.Rows.Add();

                        dataGridViewBeverage.Rows[row3].Cells["Name"].Value = cola.Name;
                        dataGridViewBeverage.Rows[row3].Cells["Price"].Value = cola.Price;
                        dataGridViewBeverage.Rows[row3].Cells["PurchaseDay"].Value = cola.PurchaseDay;
                        dataGridViewBeverage.Rows[row3].Cells["ShelfLife"].Value = cola.ShelfLife;
                        dataGridViewBeverage.Rows[row3].Cells["ID"].Value = cola.Id;
                        dataGridViewBeverage.Rows[row3].Cells["Brand"].Value = cola.Brand;
                        dataGridViewBeverage.Rows[row3].Cells["Flavor"].Value = cola.Flavor;
                        dataGridViewBeverage.Rows[row3].Cells["SugarContent"].Value = cola.SugarContent;
                        dataGridViewBeverage.Rows[row3].Cells["IsDiet"].Value = cola.IsDiet;
                        dataGridViewBeverage.Rows[row3].Cells["HasCaffeine"].Value = cola.HasCaffeine;
                        PictureBox colaim = new PictureBox();
                        colaim.Image = Properties.Resources.Cola;
                        Image originalImage3 = colaim.Image;
                        Image resizedImage3 = new Bitmap(originalImage3, new Size(50, 100));
                        colaim.Image = resizedImage3;
                        colaim.SizeMode = PictureBoxSizeMode.AutoSize; // Automatically adjust image size into the picturebox
                        colaim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        colaim.Cursor = Cursors.Hand; //Change the mouse shape to a hand shape
                        colaim.MouseDown += MouseDown;
                        colaim.MouseMove += MouseMove;
                        colaim.MouseUp += MouseUp;
                        Controls.Add(colaim);
                        break;
                    case "EnergyDrink":
                        double sugarContent1 = double.Parse(txtsugarContentSweet.Text);
                        bool isDiet1 = chkisDietSweet.Checked;
                        double caffeineContent = double.Parse(txtcaffeineContentEnergy.Text);


                        EnergyDrink energyDrink = null;
                        energyDrink = new EnergyDrink(name, price, date, shelf, Liters, Brand, Flavor, IsCarbonated, sugarContent1, isDiet1, caffeineContent);
                        p.AddProduct(energyDrink);
                        int row4 = dataGridViewBeverage.Rows.Add();

                        dataGridViewBeverage.Rows[row4].Cells["Name"].Value = energyDrink.Name;
                        dataGridViewBeverage.Rows[row4].Cells["Price"].Value = energyDrink.Price;
                        dataGridViewBeverage.Rows[row4].Cells["PurchaseDay"].Value = energyDrink.PurchaseDay;
                        dataGridViewBeverage.Rows[row4].Cells["ShelfLife"].Value = energyDrink.ShelfLife;
                        dataGridViewBeverage.Rows[row4].Cells["ID"].Value = energyDrink.Id;
                        dataGridViewBeverage.Rows[row4].Cells["Brand"].Value = energyDrink.Brand;
                        dataGridViewBeverage.Rows[row4].Cells["Flavor"].Value = energyDrink.Flavor;
                        dataGridViewBeverage.Rows[row4].Cells["SugarContent"].Value = energyDrink.SugarContent;
                        dataGridViewBeverage.Rows[row4].Cells["IsDiet"].Value = energyDrink.IsDiet;
                        dataGridViewBeverage.Rows[row4].Cells["CaffeineContent"].Value = energyDrink.CaffeineContent;
                        PictureBox energyDrinkim = new PictureBox();
                        energyDrinkim.Image = Properties.Resources.EnergyDrink;
                        Image originalImage4 = energyDrinkim.Image;
                        Image resizedImage4 = new Bitmap(originalImage4, new Size(50, 100));
                        energyDrinkim.Image = resizedImage4;
                        energyDrinkim.SizeMode = PictureBoxSizeMode.AutoSize;// Automatically adjust image size into the picturebox
                        energyDrinkim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        energyDrinkim.Cursor = Cursors.Hand; //Change the mouse shape to a hand shape
                        energyDrinkim.MouseDown += MouseDown;
                        energyDrinkim.MouseMove += MouseMove;
                        energyDrinkim.MouseUp += MouseUp;
                        Controls.Add(energyDrinkim);
                        break;
                    case "FruitPunch":
                        double sugarContent2 = double.Parse(txtsugarContentSweet.Text);
                        bool isDiet2 = chkisDietSweet.Checked;
                        bool IsPulpFree = chkisPulpFreeFruitPunch.Checked;
                        string FruitCombination = comboBoxfruitCombinationFruitPunch.Text;

                        FruitPunch fruitPunch = null;
                        fruitPunch = new FruitPunch(name, price, date, shelf, Liters, Brand, Flavor, IsCarbonated, sugarContent2, isDiet2, FruitCombination, IsPulpFree);
                        p.AddProduct(fruitPunch);
                        int row5 = dataGridViewBeverage.Rows.Add();

                        dataGridViewBeverage.Rows[row5].Cells["Name"].Value = fruitPunch.Name;
                        dataGridViewBeverage.Rows[row5].Cells["Price"].Value = fruitPunch.Price;
                        dataGridViewBeverage.Rows[row5].Cells["PurchaseDay"].Value = fruitPunch.PurchaseDay;
                        dataGridViewBeverage.Rows[row5].Cells["ShelfLife"].Value = fruitPunch.ShelfLife;
                        dataGridViewBeverage.Rows[row5].Cells["ID"].Value = fruitPunch.Id;
                        dataGridViewBeverage.Rows[row5].Cells["Brand"].Value = fruitPunch.Brand;
                        dataGridViewBeverage.Rows[row5].Cells["Flavor"].Value = fruitPunch.Flavor;
                        dataGridViewBeverage.Rows[row5].Cells["SugarContent"].Value = fruitPunch.SugarContent;
                        dataGridViewBeverage.Rows[row5].Cells["IsDiet"].Value = fruitPunch.IsDiet;
                        dataGridViewBeverage.Rows[row5].Cells["FruitCombination"].Value = fruitPunch.FruitCombination;
                        dataGridViewBeverage.Rows[row5].Cells["IsPulpFree"].Value = fruitPunch.IsPulpFree;

                        PictureBox fruitPunchim = new PictureBox();
                        fruitPunchim.Image = Properties.Resources.FruitPunch;
                        Image originalImage5 = fruitPunchim.Image;
                        Image resizedImage5 = new Bitmap(originalImage5, new Size(50, 100));
                        fruitPunchim.Image = resizedImage5;
                        fruitPunchim.SizeMode = PictureBoxSizeMode.AutoSize; // Automatically adjust image size into the picturebox
                        fruitPunchim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        fruitPunchim.Cursor = Cursors.Hand; //Change the mouse shape to a hand shape
                        fruitPunchim.MouseDown += MouseDown;
                        fruitPunchim.MouseMove += MouseMove;
                        fruitPunchim.MouseUp += MouseUp;
                        Controls.Add(fruitPunchim);
                        break;
                }
                MessageBox.Show("The product has been successfully Added");
                ClearForm();
            }
        }
        private string ShowInputDialog(string title, string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label promptLabel = new Label() { Left = 50, Top = 20, Text = prompt };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmButton = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmButton.Click += (sender, e) => { promptForm.Close(); };
            promptForm.Controls.Add(promptLabel);
            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(confirmButton);
            promptForm.AcceptButton = confirmButton;

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string idInput = ShowInputDialog("Remove", "Enter ID:");
            if (string.IsNullOrEmpty(idInput))
            {
                MessageBox.Show("Please enter ID");
                return;
            }

            if (!int.TryParse(idInput, out int idToRemove))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            bool isIdExists = p.GetProducts().Any(product => product.Id == idToRemove);
            if (!isIdExists)
            {
                MessageBox.Show("The ID does not exist");
                return;
            }

            int rowIndex = -1;
            
            foreach (DataGridViewRow row in dataGridViewBeverage.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == idToRemove.ToString())
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                dataGridViewBeverage.Rows.RemoveAt(rowIndex);
                p.RemoveProductById(idToRemove);
                MessageBox.Show("The product has been successfully deleted");
            }
        }

        private void btnPrintInfo_Click(object sender, EventArgs e)
        {
            string idInput = ShowInputDialog("Print Info", "Enter ID:");
            if (string.IsNullOrEmpty(idInput))
            {
                MessageBox.Show("Please enter ID");
                return;
            }

            if (!int.TryParse(idInput, out int idToPrint))
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            bool isIdExists = p.GetProducts().Any(product => product.Id == idToPrint);
            if (!isIdExists)
            {
                MessageBox.Show("The ID does not exist");
                return;
            }

            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridViewBeverage.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == idToPrint.ToString())
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                p.DisplayPrintFunc(idToPrint);
            }
        }
        private void DisplayIDInGrid(Product product, int ID)
        {
            dataGridViewBeverage.Rows.Clear();

            if (product.Id == ID)
            {

                int row = dataGridViewBeverage.Rows.Add();
                dataGridViewBeverage.Rows[row].Cells["Name"].Value = product.Name;
                dataGridViewBeverage.Rows[row].Cells["Price"].Value = product.Price;
                dataGridViewBeverage.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                dataGridViewBeverage.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                if (product is Coffee)
                {
                    Coffee coffee = (Coffee)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = coffee.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = coffee.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = coffee.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = coffee.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = coffee.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = coffee.MilkType;
                    dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = coffee.IsLactoseFree;
                    dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = coffee.IsVegan;
                    dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = coffee.IsAlmondMilkBeverage;
                    dataGridViewBeverage.Rows[row].Cells["Fat"].Value = coffee.FatPercentage;
                }
                else if (product is Chocolate)
                {
                    Chocolate chocolate = (Chocolate)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = chocolate.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = chocolate.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = chocolate.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = chocolate.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = chocolate.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = chocolate.MilkType;
                    dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = chocolate.IsLactoseFree;
                    dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = chocolate.IsVegan;
                    dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = chocolate.IsAlmondMilkBeverage;
                    dataGridViewBeverage.Rows[row].Cells["Fat"].Value = chocolate.FatPercentage;
                }
                else if (product is Milk)
                {
                    Milk milk = (Milk)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = milk.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = milk.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = milk.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = milk.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = milk.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["MilkType"].Value = milk.MilkType;
                    dataGridViewBeverage.Rows[row].Cells["IsLactoseFree"].Value = milk.IsLactoseFree;
                    dataGridViewBeverage.Rows[row].Cells["IsVegan"].Value = milk.IsVegan;
                    dataGridViewBeverage.Rows[row].Cells["IsAlmond"].Value = milk.IsAlmondMilkBeverage;
                    dataGridViewBeverage.Rows[row].Cells["Fat"].Value = milk.FatPercentage;
                }
                else if (product is Cola)
                {
                    Cola cola = (Cola)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = cola.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = cola.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = cola.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = cola.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = cola.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["SugarContent"].Value = cola.SugarContent;
                    dataGridViewBeverage.Rows[row].Cells["IsDiet"].Value = cola.IsDiet;
                    dataGridViewBeverage.Rows[row].Cells["HasCaffeine"].Value = cola.HasCaffeine;
                }
                else if (product is EnergyDrink)
                {
                    EnergyDrink energyDrink = (EnergyDrink)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = energyDrink.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = energyDrink.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = energyDrink.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = energyDrink.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = energyDrink.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["SugarContent"].Value = energyDrink.SugarContent;
                    dataGridViewBeverage.Rows[row].Cells["IsDiet"].Value = energyDrink.IsDiet;
                    dataGridViewBeverage.Rows[row].Cells["CaffeineContent"].Value = energyDrink.CaffeineContent;
                }
                else if (product is FruitPunch)
                {
                    FruitPunch fruitPunch = (FruitPunch)product;
                    dataGridViewBeverage.Rows[row].Cells["ID"].Value = fruitPunch.Id;
                    dataGridViewBeverage.Rows[row].Cells["Liters"].Value = fruitPunch.Liters;
                    dataGridViewBeverage.Rows[row].Cells["Brand"].Value = fruitPunch.Brand;
                    dataGridViewBeverage.Rows[row].Cells["Flavor"].Value = fruitPunch.Flavor;
                    dataGridViewBeverage.Rows[row].Cells["IsCarbonated"].Value = fruitPunch.IsCarbonated;
                    dataGridViewBeverage.Rows[row].Cells["SugarContent"].Value = fruitPunch.SugarContent;
                    dataGridViewBeverage.Rows[row].Cells["IsDiet"].Value = fruitPunch.IsDiet;
                    dataGridViewBeverage.Rows[row].Cells["IsPulpFree"].Value = fruitPunch.IsPulpFree;
                    dataGridViewBeverage.Rows[row].Cells["FruitCombination"].Value = fruitPunch.FruitCombination;
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Visible = true;
            btnUpdate.Enabled = true;
            btnUpdate.Visible = true;
            btnRemove.Enabled = false;
            buttonClear.Enabled = false;
            buttonAdd.Enabled = false;
            string idInput = ShowInputDialog("Update", "Enter ID:");
            txtID.Text = idInput;
            if (string.IsNullOrEmpty(idInput))
            {

                MessageBox.Show("Please enter ID");
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageDairyBrand));
                comboBoxNameBeverage.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorChocolate));
                comboBoxType.Enabled = true;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                btnRemove.Enabled = true;
                buttonClear.Enabled = true;
                buttonAdd.Enabled = true;

                txtID.Visible = false;
                ClearForm();
                return;
            }
            if (!int.TryParse(idInput, out int idToUpdate))
            {
                MessageBox.Show("Invalid ID");
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageDairyBrand));
                comboBoxNameBeverage.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorChocolate));
                comboBoxType.Enabled = true;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                btnRemove.Enabled = true;
                buttonClear.Enabled = true;
                buttonAdd.Enabled = true;
                txtID.Visible = false;
                ClearForm();
                return;
            }
            // Get the list of products
            BindingList<Product> products = p.GetProducts();

            // Find the product to update
            Product productToUpdate = products.FirstOrDefault(product => product.Id == idToUpdate);
            DisplayIDInGrid(productToUpdate, idToUpdate);
            if (productToUpdate == null)
            {
                MessageBox.Show("The ID does not exist");
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageDairyBrand));
                comboBoxNameBeverage.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorChocolate));
                comboBoxType.Enabled = true;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                btnRemove.Enabled = true;
                buttonClear.Enabled = true;
                buttonAdd.Enabled = true;
                buttonClear.Enabled = true;
                txtID.Visible = false;
                ClearForm();
                return;
            }
            if (productToUpdate.Name == "Milk")
            {
                comboBoxType.SelectedIndex = 1;
                comboBoxNameBeverage.SelectedIndex = 1;
            }
            else if (productToUpdate.Name == "Chocolate")
            {
                comboBoxType.SelectedIndex = 1;
                comboBoxNameBeverage.SelectedIndex = 2;
            }
            else if (productToUpdate.Name == "Coffee")
            {
                comboBoxType.SelectedIndex = 1;
                comboBoxNameBeverage.SelectedIndex = 3;
            }
            else if (productToUpdate.Name == "Cola")
            {
                comboBoxType.SelectedIndex = 2;
                comboBoxNameBeverage.SelectedIndex = 1;
            }
            else if (productToUpdate.Name == "EnergyDrink")
            {
                comboBoxType.SelectedIndex = 2;
                comboBoxNameBeverage.SelectedIndex = 2;
            }
            else if (productToUpdate.Name == "FruitPunch")
            {
                comboBoxType.SelectedIndex = 2;
                comboBoxNameBeverage.SelectedIndex = 3;
            }
            comboBoxType.Enabled = false;
            comboBoxNameBeverage.Enabled = false;

            //Update the fields based on the selected product type
            switch (productToUpdate)
            {
                case Milk milk:
                    comboBoxBrand.SelectedItem = milk.Brand;
                    comboBoxFlavor.SelectedItem = milk.Flavor;
                    txtLiters.Text = milk.Liters.ToString();
                    chkIsCarbonated.Checked = milk.IsCarbonated;
                    comboBoxMilkTypeDairy.SelectedItem = milk.MilkType;
                    chkisLactoseFreeDairy.Checked = milk.IsLactoseFree;
                    chkisVeganDairy.Checked = milk.IsVegan;
                    chkisAlmondMilkDairy.Checked = milk.IsAlmondMilkBeverage;
                    txtFatDairy.Text = milk.FatPercentage.ToString();

                    break;
                case Chocolate chocolate:
                    comboBoxBrand.SelectedItem = chocolate.Brand;
                    comboBoxFlavor.SelectedItem = chocolate.Flavor;
                    txtLiters.Text = chocolate.Liters.ToString();
                    chkIsCarbonated.Checked = chocolate.IsCarbonated;
                    comboBoxMilkTypeDairy.SelectedItem = chocolate.MilkType;
                    chkisLactoseFreeDairy.Checked = chocolate.IsLactoseFree;
                    chkisVeganDairy.Checked = chocolate.IsVegan;
                    chkisAlmondMilkDairy.Checked = chocolate.IsAlmondMilkBeverage;
                    txtFatDairy.Text = chocolate.FatPercentage.ToString();
                    break;
                case Coffee coffee:
                    comboBoxBrand.SelectedItem = coffee.Brand;
                    comboBoxFlavor.SelectedItem = coffee.Flavor;
                    txtLiters.Text = coffee.Liters.ToString();
                    chkIsCarbonated.Checked = coffee.IsCarbonated;
                    comboBoxMilkTypeDairy.SelectedItem = coffee.MilkType;
                    chkisLactoseFreeDairy.Checked = coffee.IsLactoseFree;
                    chkisVeganDairy.Checked = coffee.IsVegan;
                    chkisAlmondMilkDairy.Checked = coffee.IsAlmondMilkBeverage;
                    txtFatDairy.Text = coffee.FatPercentage.ToString();
                    break;
                case Cola cola:
                    comboBoxBrand.SelectedItem = cola.Brand;
                    comboBoxFlavor.SelectedItem = cola.Flavor;
                    txtLiters.Text = cola.Liters.ToString();
                    chkIsCarbonated.Checked = cola.IsCarbonated;
                    chkisDietSweet.Checked =cola.IsDiet;
                    txtsugarContentSweet.Text = cola.SugarContent.ToString();
                    chkhasCaffeineCola.Checked = cola.HasCaffeine;
                    break;
                case EnergyDrink energyDrink:
                    comboBoxBrand.SelectedItem = energyDrink.Brand;
                    comboBoxFlavor.SelectedItem = energyDrink.Flavor;
                    txtLiters.Text = energyDrink.Liters.ToString();
                    chkIsCarbonated.Checked = energyDrink.IsCarbonated;
                    chkisDietSweet.Checked = energyDrink.IsDiet;
                    txtsugarContentSweet.Text = energyDrink.SugarContent.ToString();
                    txtcaffeineContentEnergy.Text = energyDrink.CaffeineContent.ToString();
                    break;
                case FruitPunch fruitPunch:
                    comboBoxBrand.SelectedItem = fruitPunch.Brand;
                    comboBoxFlavor.SelectedItem = fruitPunch.Flavor;
                    txtLiters.Text = fruitPunch.Liters.ToString();
                    chkIsCarbonated.Checked = fruitPunch.IsCarbonated;
                    chkisDietSweet.Checked = fruitPunch.IsDiet;
                    txtsugarContentSweet.Text = fruitPunch.SugarContent.ToString();
                    chkisPulpFreeFruitPunch.Checked = fruitPunch.IsPulpFree;
                    comboBoxfruitCombinationFruitPunch.Text = fruitPunch.FruitCombination;
                    break;
                default:
                    // Handle default case
                    break;
            }

            // Update other fields
            MessageBox.Show("When you finish- click on update");
            buttonAdd.Enabled = false;
            buttonClear.Enabled = false;
            textBoxPrice.Text = productToUpdate.Price.ToString();
            dateTimeBuyingDate.Value = productToUpdate.PurchaseDay;
            txtShelfLife.Text = productToUpdate.ShelfLife.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            int i = Update();

            if (i == 1)
            {
                btnRemove.Enabled = true;
                buttonClear.Enabled = true;
                buttonClear.Enabled = true;
                buttonAdd.Enabled = true;
                txtID.Visible = false;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageDairyBrand));
                comboBoxNameBeverage.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorChocolate));
                comboBoxType.Enabled = true;
                comboBoxType.SelectedItem = "Choose";
                ClearForm();
            }
        }

        private int Update()
        {
            string idInput = txtID.Text;
            int id;

            try
            {
                id = int.Parse(idInput);
            }
            catch (FormatException)
            {
                // If the ID type is not an integer - handle the case of an error here
                MessageBox.Show("Invalid ID");
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageDairyBrand));
                comboBoxNameBeverage.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxFlavor.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorChocolate));
                comboBoxType.Enabled = true;
                buttonAdd.Text = "Add";
                ClearForm();
                return 0;
            }
            BindingList<Product> products = p.GetProducts();

            Product productToUpdate = products.FirstOrDefault(product => product.Id == id);
            DisplayIDInGrid(productToUpdate, id);

            if (validtion())
            {
                string type = comboBoxType.Text;
                string name = comboBoxNameBeverage.Text;
                double price = double.Parse(textBoxPrice.Text);
                DateTime date = dateTimeBuyingDate.Value;
                int shelf = int.Parse(txtShelfLife.Text);
                string Brand = comboBoxBrand.Text;
                string flavor = comboBoxFlavor.Text;
                double liters= double.Parse(txtLiters.Text);
                bool IsCarbonated = chkIsCarbonated.Checked;

                productToUpdate.Price = price;
                productToUpdate.PurchaseDay = date;
                productToUpdate.ShelfLife = shelf;

                if (comboBoxNameBeverage.SelectedItem.ToString() == "Milk")
                {
                    string milkType = comboBoxMilkTypeDairy.Text;
                    bool isLactoseFreeDairy = chkisLactoseFreeDairy.Checked;
                    bool isVeganDairy = chkisVeganDairy.Checked;
                    bool isAlmondMilkDairy = chkisAlmondMilkDairy.Checked;
                    double fat = double.Parse(txtFatDairy.Text);

                    Milk milk = productToUpdate as Milk;
                    milk.Brand = Brand;
                    milk.Flavor = flavor;
                    milk.Liters = liters;
                    milk.IsCarbonated = IsCarbonated;
                    milk.MilkType = milkType;
                    milk.IsLactoseFree = isLactoseFreeDairy;
                    milk.IsVegan = isVeganDairy;
                    milk.IsAlmondMilkBeverage = isAlmondMilkDairy;
                    milk.FatPercentage = fat;

                }
                else if (comboBoxNameBeverage.SelectedItem.ToString() == "Chocolate")
                {
                    string milkType = comboBoxMilkTypeDairy.Text;
                    bool isLactoseFreeDairy = chkisLactoseFreeDairy.Checked;
                    bool isVeganDairy = chkisVeganDairy.Checked;
                    bool isAlmondMilkDairy = chkisAlmondMilkDairy.Checked;
                    double fat = double.Parse(txtFatDairy.Text);

                    Chocolate chocolate = productToUpdate as Chocolate;
                    chocolate.Brand = Brand;
                    chocolate.Flavor = flavor;
                    chocolate.Liters = liters;
                    chocolate.IsCarbonated = IsCarbonated;
                    chocolate.MilkType = milkType;
                    chocolate.IsLactoseFree = isLactoseFreeDairy;
                    chocolate.IsVegan = isVeganDairy;
                    chocolate.IsAlmondMilkBeverage = isAlmondMilkDairy;
                    chocolate.FatPercentage = fat;
                }
                else if (comboBoxNameBeverage.SelectedItem.ToString() == "Coffee")
                {
                    string milkType = comboBoxMilkTypeDairy.Text;
                    bool isLactoseFreeDairy = chkisLactoseFreeDairy.Checked;
                    bool isVeganDairy = chkisVeganDairy.Checked;
                    bool isAlmondMilkDairy = chkisAlmondMilkDairy.Checked;
                    double fat = double.Parse(txtFatDairy.Text);

                    Coffee coffee = productToUpdate as Coffee;
                    coffee.Brand = Brand;
                    coffee.Flavor = flavor;
                    coffee.Liters = liters;
                    coffee.IsCarbonated = IsCarbonated;
                    coffee.MilkType = milkType;
                    coffee.IsLactoseFree = isLactoseFreeDairy;
                    coffee.IsVegan = isVeganDairy;
                    coffee.IsAlmondMilkBeverage = isAlmondMilkDairy;
                    coffee.FatPercentage = fat;
                }
                else if (comboBoxNameBeverage.SelectedItem.ToString() == "Cola")
                {
                    bool isDiet = chkisDietSweet.Checked;
                    double sugarContent = double.Parse(txtsugarContentSweet.Text);
                    bool hasCaffeine = chkhasCaffeineCola.Checked;

                    Cola cola = productToUpdate as Cola;

                    cola.Brand = Brand;
                    cola.Flavor = flavor;
                    cola.Liters = liters;
                    cola.IsCarbonated = IsCarbonated;
                    cola.IsDiet = isDiet;
                    cola.SugarContent = sugarContent;
                    cola.HasCaffeine = hasCaffeine;
                }
                else if (comboBoxNameBeverage.SelectedItem.ToString() == "EnergyDrink")
                {
                    bool isDiet = chkisDietSweet.Checked;
                    double sugarContent = double.Parse(txtsugarContentSweet.Text);
                    double caffeineContent = double.Parse(txtcaffeineContentEnergy.Text);

                    EnergyDrink energyDrink = productToUpdate as EnergyDrink;

                    energyDrink.Brand = Brand;
                    energyDrink.Flavor = flavor;
                    energyDrink.Liters = liters;
                    energyDrink.IsCarbonated = IsCarbonated;
                    energyDrink.IsDiet = isDiet;
                    energyDrink.SugarContent = sugarContent;
                    energyDrink.CaffeineContent = caffeineContent;
                }
                else if (comboBoxNameBeverage.SelectedItem.ToString() == "FruitPunch")
                {
                    bool isDiet = chkisDietSweet.Checked;
                    double sugarContent = double.Parse(txtsugarContentSweet.Text);
                    bool isPulpFree = chkisPulpFreeFruitPunch.Checked;
                    string FruitCombination = comboBoxfruitCombinationFruitPunch.Text;

                    FruitPunch fruitPunch = productToUpdate as FruitPunch;

                    fruitPunch.Brand = Brand;
                    fruitPunch.Flavor = flavor;
                    fruitPunch.Liters = liters;
                    fruitPunch.IsCarbonated = IsCarbonated;
                    fruitPunch.IsDiet = isDiet;
                    fruitPunch.SugarContent = sugarContent;
                    fruitPunch.IsPulpFree =  isPulpFree;
                    fruitPunch.FruitCombination = FruitCombination;
                }
                MessageBox.Show("The product has been successfully updated");
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
