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

namespace Refrigerator_FinalProj.Frontend.UserControls.Fruit
{
    public partial class Fruit : UserControl
    {
        ProductsManager p;

        public ProductsManager P { get => p; }
        public Fruit()
        {
            InitializeComponent();
            p = new ProductsManager();
            comboBoxType.DataSource = Enum.GetValues(typeof(eFruitType));
            comboBoxColors.DataSource = Enum.GetValues(typeof(eColors));
            comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
            comboBoxVarietyApple.DataSource = Enum.GetValues(typeof(Enums_Collections.eVarietyApple));
            comboBoxTaste.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageFlavorFruitPunch));
            string[] FruitProducts = { "Apple","Banana","Grapes", "Orange", "Peach" };
            AddProductImages(0, FruitProducts);
            regularAddToTable();
        }
        private Image GetProductImage(string productName)
        {
            switch (productName)
            {
                case "Apple":
                    return Properties.Resources.Apple;
                case "Banana":
                    return Properties.Resources.Banana;
                case "Grapes":
                    return Properties.Resources.Grapes;
                case "Orange":
                    return Properties.Resources.Orangejpg;
                case "Peach":
                    return Properties.Resources.Peach;
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
                    pictureBox.Size = new Size(100, 50);

                    // החלטת המיקום עבור כל מוצר באמצעות switch
                    switch (productName)
                    {
                        case "Apple":
                            pictureBox.Location = new Point(x, y);
                            break;
                        case "Banana":
                            pictureBox.Location = new Point(x + 100, y);
                            break;
                        case "Grapes":
                            pictureBox.Location = new Point(x + 200, y);
                            break;
                        case "Orange":
                            pictureBox.Location = new Point(x + 300, y);
                            break;
                        case "Peach":
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
        private void ClearForm()
        {
            ComboBox[] comboBoxes = { comboBoxType, comboBoxColors, comboBoxSize, comboBoxVarietyApple };
            TextBox[] textBoxes = { textBoxPrice, txtShelfLife, txtWeight };
            DateTimePicker[] dateTimePickers = { dateTimeBuyingDate };
            CheckBox[] checkboxes = { chkhasSeedsApple, chkIsRipeBanana, chkhasSeedsBanana, chkisGreenGrapes, chkhasSeedsGrapes, chkisOrange, chkHasSeedsOrange, chkhasSeedsPeach, chkIsRipePeach };

            for (int i = 0; i < checkedListVitamins.Items.Count; i++)
            {
                checkedListVitamins.SetItemChecked(i, false);
            }

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
            VisibleandEnableApple(false);
            VisibleandEnableBanana(false);
            VisibleandEnableGrapes(false);
            VisibleandEnableOrange(false);
            VisibleandEnablePeach(false);
            comboBoxType.SelectedIndex = 0;
            comboBoxColors.SelectedIndex = 0;
            comboBoxSize.SelectedIndex = 0;
            comboBoxVarietyApple.SelectedIndex = 0;
            comboBoxTaste.SelectedIndex = 0;
        }

        private void VisibleandEnable(bool i, bool j)
        {
            Control[] VisibleandEnableControls = { textBoxPrice, dateTimeBuyingDate, txtShelfLife, txtWeight, comboBoxColors, comboBoxSize, comboBoxSize, comboBoxTaste, checkedListVitamins };

            foreach (Control control in VisibleandEnableControls)
            {
                control.Visible = i;
                control.Enabled = j;
            }
        }
        private void VisibleandEnableApple(bool i)
        {
            Control[] AppleControls = { chkhasSeedsApple, comboBoxVarietyApple, lblhasSeedsApple, lblIsVarietyApple };

            foreach (Control control in AppleControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableBanana(bool i)
        {
            Control[] BananaControls = { chkhasSeedsBanana, chkIsRipeBanana, lblisRipeBanana, lbllblhasSeedsBanana };

            foreach (Control control in BananaControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableGrapes(bool i)
        {
            Control[] GrapesControls = { chkhasSeedsGrapes, chkisGreenGrapes, lblisGreenGrapes, lbllblhasSeedsGrapes };

            foreach (Control control in GrapesControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableOrange(bool i)
        {
            Control[] OrangeControls = { chkHasSeedsOrange, chkisOrange, lblHasSeedsOrange, lblisOrange };

            foreach (Control control in OrangeControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnablePeach(bool i)
        {
            Control[] PeachControls = { chkhasSeedsPeach, chkIsRipePeach, lblisRipePeach, lbllblhasSeedsPeach };

            foreach (Control control in PeachControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void regularAddToTable()
        {

            dataGridViewFruit.Columns.Add("ID", "ID");
            dataGridViewFruit.Columns.Add("Name", "Name");
            dataGridViewFruit.Columns.Add("Price", "Price");
            dataGridViewFruit.Columns.Add("PurchaseDay", "Purchase Day");
            dataGridViewFruit.Columns.Add("ShelfLife", "Shelf Life");
            dataGridViewFruit.Columns.Add("Color", "Color");
            dataGridViewFruit.Columns.Add("Size", "Size");
            dataGridViewFruit.Columns.Add("Weight", "Weight");
            dataGridViewFruit.Columns.Add("Taste", "Taste");
            dataGridViewFruit.Columns.Add("Vitamins", "Vitamins");
            dataGridViewFruit.Columns.Add("Variety", "Variety");
            dataGridViewFruit.Columns.Add("HasSeeds", "Has Seeds");
            dataGridViewFruit.Columns.Add("IsRipe", "Is Ripe");
            dataGridViewFruit.Columns.Add("IsGreen", "Is Green");
            dataGridViewFruit.Columns.Add("IsOrange", "Is Orange");
        }
        private void DisplayAllProductsInGrid(BindingList<Product> products)
        {
            dataGridViewFruit.Rows.Clear();

            foreach (Product product in products)
            {
                if (product.Name == "Apple" || product.Name == "Banana" || product.Name == "Grapes" || product.Name == "Orange" || product.Name == "Peach")
                {
                    int row = dataGridViewFruit.Rows.Add();
                    dataGridViewFruit.Rows[row].Cells["Name"].Value = product.Name;
                    dataGridViewFruit.Rows[row].Cells["Price"].Value = product.Price;
                    dataGridViewFruit.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                    dataGridViewFruit.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                    if (product is Apple)
                    {
                        Apple apple = (Apple)product;
                        dataGridViewFruit.Rows[row].Cells["ID"].Value = apple.Id;
                        dataGridViewFruit.Rows[row].Cells["Color"].Value = apple.Color;
                        dataGridViewFruit.Rows[row].Cells["Size"].Value = apple.Size;
                        dataGridViewFruit.Rows[row].Cells["Weight"].Value = apple.Weight;
                        dataGridViewFruit.Rows[row].Cells["Taste"].Value = apple.Taste;
                        dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", apple.Vitamins);
                        dataGridViewFruit.Rows[row].Cells["Variety"].Value = apple.Variety;
                        dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = apple.HasSeeds;
                    }
                    else if (product is Banana)
                    {
                        Banana banana = (Banana)product;
                        dataGridViewFruit.Rows[row].Cells["ID"].Value = banana.Id;
                        dataGridViewFruit.Rows[row].Cells["Color"].Value = banana.Color;
                        dataGridViewFruit.Rows[row].Cells["Size"].Value = banana.Size;
                        dataGridViewFruit.Rows[row].Cells["Weight"].Value = banana.Weight;
                        dataGridViewFruit.Rows[row].Cells["Taste"].Value = banana.Taste;
                        dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", banana.Vitamins);
                        dataGridViewFruit.Rows[row].Cells["IsRipe"].Value = banana.IsRipe;
                        dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = banana.HasSeeds;
                    }
                    else if (product is Grapes)
                    {
                        Grapes grapes = (Grapes)product;
                        dataGridViewFruit.Rows[row].Cells["ID"].Value = grapes.Id;
                        dataGridViewFruit.Rows[row].Cells["Color"].Value = grapes.Color;
                        dataGridViewFruit.Rows[row].Cells["Size"].Value = grapes.Size;
                        dataGridViewFruit.Rows[row].Cells["Taste"].Value = grapes.Taste;
                        dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", grapes.Vitamins);
                        dataGridViewFruit.Rows[row].Cells["Weight"].Value = grapes.Weight;
                        dataGridViewFruit.Rows[row].Cells["IsGreen"].Value = grapes.IsGreen;
                        dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = grapes.HasSeeds;
                    }
                    else if (product is Orange)
                    {
                        Orange orange = (Orange)product;
                        dataGridViewFruit.Rows[row].Cells["ID"].Value = orange.Id;
                        dataGridViewFruit.Rows[row].Cells["Color"].Value = orange.Color;
                        dataGridViewFruit.Rows[row].Cells["Size"].Value = orange.Size;
                        dataGridViewFruit.Rows[row].Cells["Taste"].Value = orange.Taste;
                        dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", orange.Vitamins);
                        dataGridViewFruit.Rows[row].Cells["Weight"].Value = orange.Weight;
                        dataGridViewFruit.Rows[row].Cells["IsOrange"].Value = orange.IsOrange;
                        dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = orange.HasSeeds;
                    }
                    else if (product is Peach)
                    {
                        Peach peach = (Peach)product;
                        dataGridViewFruit.Rows[row].Cells["ID"].Value = peach.Id;
                        dataGridViewFruit.Rows[row].Cells["Color"].Value = peach.Color;
                        dataGridViewFruit.Rows[row].Cells["Size"].Value = peach.Size;
                        dataGridViewFruit.Rows[row].Cells["Taste"].Value = peach.Taste;
                        dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", peach.Vitamins);
                        dataGridViewFruit.Rows[row].Cells["Weight"].Value = peach.Weight;
                        dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = peach.HasSeeds;
                        dataGridViewFruit.Rows[row].Cells["IsRipe"].Value = peach.IsRipe;
                    }
                }
            }
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
        private void DisplayProductsInGrid(List<Product> filteredProducts)
        {
            dataGridViewFruit.Rows.Clear();

            foreach (Product product in filteredProducts)
            {
                int row = dataGridViewFruit.Rows.Add();
                dataGridViewFruit.Rows[row].Cells["Name"].Value = product.Name;
                dataGridViewFruit.Rows[row].Cells["Price"].Value = product.Price;
                dataGridViewFruit.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                dataGridViewFruit.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                if (product is Apple)
                {
                    Apple apple = (Apple)product;
                    dataGridViewFruit.Rows[row].Cells["ID"].Value = apple.Id;
                    dataGridViewFruit.Rows[row].Cells["Color"].Value = apple.Color;
                    dataGridViewFruit.Rows[row].Cells["Size"].Value = apple.Size;
                    dataGridViewFruit.Rows[row].Cells["Taste"].Value = apple.Taste;
                    dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", apple.Vitamins);
                    dataGridViewFruit.Rows[row].Cells["Weight"].Value = apple.Weight;
                    dataGridViewFruit.Rows[row].Cells["Variety"].Value = apple.Variety;
                    dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = apple.HasSeeds;
                }
                else if (product is Banana)
                {
                    Banana banana = (Banana)product;
                    dataGridViewFruit.Rows[row].Cells["ID"].Value = banana.Id;
                    dataGridViewFruit.Rows[row].Cells["Color"].Value = banana.Color;
                    dataGridViewFruit.Rows[row].Cells["Size"].Value = banana.Size;
                    dataGridViewFruit.Rows[row].Cells["Taste"].Value = banana.Taste;
                    dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", banana.Vitamins);
                    dataGridViewFruit.Rows[row].Cells["Weight"].Value = banana.Weight;
                    dataGridViewFruit.Rows[row].Cells["IsRipe"].Value = banana.IsRipe;
                    dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = banana.HasSeeds;
                }
                else if (product is Grapes)
                {
                    Grapes grapes = (Grapes)product;
                    dataGridViewFruit.Rows[row].Cells["ID"].Value = grapes.Id;
                    dataGridViewFruit.Rows[row].Cells["Color"].Value = grapes.Color;
                    dataGridViewFruit.Rows[row].Cells["Size"].Value = grapes.Size;
                    dataGridViewFruit.Rows[row].Cells["Taste"].Value = grapes.Taste;
                    dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", grapes.Vitamins);
                    dataGridViewFruit.Rows[row].Cells["Weight"].Value = grapes.Weight;
                    dataGridViewFruit.Rows[row].Cells["IsGreen"].Value = grapes.IsGreen;
                    dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = grapes.HasSeeds;
                }
                else if (product is Orange)
                {
                    Orange orange = (Orange)product;
                    dataGridViewFruit.Rows[row].Cells["ID"].Value = orange.Id;
                    dataGridViewFruit.Rows[row].Cells["Color"].Value = orange.Color;
                    dataGridViewFruit.Rows[row].Cells["Size"].Value = orange.Size;
                    dataGridViewFruit.Rows[row].Cells["Taste"].Value = orange.Taste;
                    dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", orange.Vitamins);
                    dataGridViewFruit.Rows[row].Cells["Weight"].Value = orange.Weight;
                    dataGridViewFruit.Rows[row].Cells["IsOrange"].Value = orange.IsOrange;
                    dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = orange.HasSeeds;
                }
                else if (product is Peach)
                {
                    Peach peach = (Peach)product;
                    dataGridViewFruit.Rows[row].Cells["ID"].Value = peach.Id;
                    dataGridViewFruit.Rows[row].Cells["Color"].Value = peach.Color;
                    dataGridViewFruit.Rows[row].Cells["Size"].Value = peach.Size;
                    dataGridViewFruit.Rows[row].Cells["Taste"].Value = peach.Taste;
                    dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", peach.Vitamins);
                    dataGridViewFruit.Rows[row].Cells["Weight"].Value = peach.Weight;
                    dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = peach.HasSeeds;
                    dataGridViewFruit.Rows[row].Cells["IsRipe"].Value = peach.IsRipe;
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
                VisibleandEnableApple(false);
                VisibleandEnableBanana(false);
                VisibleandEnableGrapes(false);
                VisibleandEnableOrange(false);
                VisibleandEnablePeach(false);
                buttonAdd.Enabled = false;
                buttonClear.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
                buttonClear.Enabled = true;
            }
            if (comboBoxType.SelectedItem.ToString() == "Apple")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableApple(true);
                VisibleandEnableBanana(false);
                VisibleandEnableGrapes(false);
                VisibleandEnableOrange(false);
                VisibleandEnablePeach(false);

                lblhasSeedsApple.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblIsVarietyApple.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }
            if (comboBoxType.SelectedItem.ToString() == "Banana")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableBanana(true);
                VisibleandEnableApple(false);
                VisibleandEnableGrapes(false);
                VisibleandEnableOrange(false);
                VisibleandEnablePeach(false);

                lblisRipeBanana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lbllblhasSeedsBanana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);

            }
            if (comboBoxType.SelectedItem.ToString() == "Grapes")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableGrapes(true);
                VisibleandEnableApple(false);
                VisibleandEnableBanana(false);
                VisibleandEnableOrange(false);
                VisibleandEnablePeach(false);

                lblisGreenGrapes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lbllblhasSeedsGrapes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }
            if (comboBoxType.SelectedItem.ToString() == "Orange")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableOrange(true);
                VisibleandEnableApple(false);
                VisibleandEnableBanana(false);
                VisibleandEnableGrapes(false);
                VisibleandEnablePeach(false);

                lblHasSeedsOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblisOrange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }
            if (comboBoxType.SelectedItem.ToString() == "Peach")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnablePeach(true);
                VisibleandEnableApple(false);
                VisibleandEnableBanana(false);
                VisibleandEnableGrapes(false);
                VisibleandEnableOrange(false);

                lblisRipePeach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lbllblhasSeedsPeach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
                if(dateTimeBuyingDate.Value > DateTime.Today.AddDays(+1))
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

                
                if (comboBoxColors.SelectedIndex == 0)
                {
                    throw new Exception("Please choose Color");
                }
                if (comboBoxSize.SelectedIndex == 0)
                {
                    throw new Exception("Please choose Size");
                }
                if (!Validator.ValidateValue(txtWeight.Text, typeof(double)))
                    throw new Exception("Invalid weight value");
                int weight;
                if (int.TryParse(txtWeight.Text, out weight))
                {
                    if (weight <= 0)
                    {
                        throw new Exception("Invalid weight value");
                    }
                }
                if (comboBoxTaste.SelectedIndex == 0)
                {
                    throw new Exception("Please choose Taste");
                }

                if ((comboBoxType.SelectedIndex == 0 || comboBoxType.SelectedIndex == 1) && comboBoxVarietyApple.SelectedIndex == 0)
                {
                    throw new Exception("Please choose Variety");
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
                PictureBox Fruit = (PictureBox)sender;
                Fruit.Left += e.X - startPosition.X;
                Fruit.Top += e.Y - startPosition.Y;
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (validtion())
            {
                int rowCount = dataGridViewFruit.Rows.Count;
                string type = comboBoxType.Text;
                double price = double.Parse(textBoxPrice.Text);
                DateTime date = dateTimeBuyingDate.Value;
                int shelf = int.Parse(txtShelfLife.Text);
                string color = comboBoxColors.Text;
                string size = comboBoxSize.Text;
                double weight = double.Parse(txtWeight.Text);
                string taste = comboBoxTaste.Text;
                List<string> vitamins = new List<string>();
                foreach (var item in checkedListVitamins.CheckedItems)
                {
                    string vitamin = item.ToString();
                    vitamins.Add(vitamin);
                }
                bool hasSeedsApple = chkhasSeedsApple.Checked;
                string VarietyApple = comboBoxVarietyApple.Text;
                bool hasSeedsBanana = chkhasSeedsBanana.Checked;
                bool IsRipeBanana = chkIsRipeBanana.Checked;
                bool SeedsGrapes = chkhasSeedsGrapes.Checked;
                bool isGreenGrapes = chkisGreenGrapes.Checked;
                bool HasSeedsOrange = chkHasSeedsOrange.Checked;
                bool isOrange = chkisOrange.Checked;
                bool hasSeedsPeach = chkhasSeedsPeach.Checked;
                bool IsRipePeach = chkIsRipePeach.Checked;

                switch (comboBoxType.SelectedItem.ToString())
                {
                    case "Apple":
                        Apple apple = null;
                        apple = new Apple(type, price, date, shelf, weight, size, color, vitamins.ToArray(), taste, VarietyApple, hasSeedsApple);
                        p.AddProduct(apple);
                        int row = dataGridViewFruit.Rows.Add();

                        dataGridViewFruit.Rows[row].Cells["Name"].Value = apple.Name;
                        dataGridViewFruit.Rows[row].Cells["Price"].Value = apple.Price;
                        dataGridViewFruit.Rows[row].Cells["PurchaseDay"].Value = apple.PurchaseDay;
                        dataGridViewFruit.Rows[row].Cells["ShelfLife"].Value = apple.ShelfLife;
                        dataGridViewFruit.Rows[row].Cells["ID"].Value = apple.Id;
                        dataGridViewFruit.Rows[row].Cells["Color"].Value = apple.Color;
                        dataGridViewFruit.Rows[row].Cells["Size"].Value = apple.Size;
                        dataGridViewFruit.Rows[row].Cells["Weight"].Value = apple.Weight;
                        dataGridViewFruit.Rows[row].Cells["Taste"].Value = apple.Taste;
                        dataGridViewFruit.Rows[row].Cells["Vitamins"].Value = string.Join(", ", apple.Vitamins);
                        dataGridViewFruit.Rows[row].Cells["Variety"].Value = apple.Variety;
                        dataGridViewFruit.Rows[row].Cells["HasSeeds"].Value = apple.HasSeeds;
                        PictureBox appleim = new PictureBox();
                        appleim.Image = Properties.Resources.Apple;
                        Image originalImage = appleim.Image;
                        Image resizedImage = new Bitmap(originalImage, new Size(100, 100));
                        appleim.Image = resizedImage;
                        appleim.SizeMode = PictureBoxSizeMode.AutoSize; // Automatically adjust image size into the picturebox
                        appleim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        appleim.Cursor = Cursors.Hand; //Change the mouse shape to a hand shape
                        appleim.MouseDown += MouseDown;
                        appleim.MouseMove += MouseMove;
                        appleim.MouseUp += MouseUp;
                        Controls.Add(appleim);
                        break;
                    case "Banana":
                        Banana banana = null;
                        banana = new Banana(type, price, date, shelf, weight, size, color, vitamins.ToArray(), taste, IsRipeBanana, hasSeedsBanana);
                        p.AddProduct(banana);

                        int row1 = dataGridViewFruit.Rows.Add();
                        dataGridViewFruit.Rows[row1].Cells["Name"].Value = banana.Name;
                        dataGridViewFruit.Rows[row1].Cells["Price"].Value = banana.Price;
                        dataGridViewFruit.Rows[row1].Cells["PurchaseDay"].Value = banana.PurchaseDay;
                        dataGridViewFruit.Rows[row1].Cells["ShelfLife"].Value = banana.ShelfLife;
                        dataGridViewFruit.Rows[row1].Cells["ID"].Value = banana.Id;
                        dataGridViewFruit.Rows[row1].Cells["Color"].Value = banana.Color;
                        dataGridViewFruit.Rows[row1].Cells["Size"].Value = banana.Size;
                        dataGridViewFruit.Rows[row1].Cells["Weight"].Value = banana.Weight;
                        dataGridViewFruit.Rows[row1].Cells["Taste"].Value = banana.Taste;
                        dataGridViewFruit.Rows[row1].Cells["Vitamins"].Value = string.Join(", ", banana.Vitamins);
                        dataGridViewFruit.Rows[row1].Cells["HasSeeds"].Value = banana.HasSeeds;
                        dataGridViewFruit.Rows[row1].Cells["IsRipe"].Value = banana.IsRipe;
                        PictureBox bananaim = new PictureBox();
                        bananaim.Image = Properties.Resources.Banana;
                        Image originalImage2 = bananaim.Image;
                        Image resizedImage2 = new Bitmap(originalImage2, new Size(100, 50));
                        bananaim.Image = resizedImage2;
                        bananaim.SizeMode = PictureBoxSizeMode.AutoSize;
                        bananaim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        bananaim.Cursor = Cursors.Hand;
                        bananaim.MouseDown += MouseDown;
                        bananaim.MouseMove += MouseMove;
                        bananaim.MouseUp += MouseUp;
                        Controls.Add(bananaim);
                        break;
                    case "Grapes":
                        Grapes grapes = null;
                        grapes = new Grapes(type, price, date, shelf, weight, size, color, vitamins.ToArray(), taste, isGreenGrapes, SeedsGrapes);
                        p.AddProduct(grapes);

                        int row2 = dataGridViewFruit.Rows.Add();
                        dataGridViewFruit.Rows[row2].Cells["Name"].Value = grapes.Name;
                        dataGridViewFruit.Rows[row2].Cells["Price"].Value = grapes.Price;
                        dataGridViewFruit.Rows[row2].Cells["PurchaseDay"].Value = grapes.PurchaseDay;
                        dataGridViewFruit.Rows[row2].Cells["ShelfLife"].Value = grapes.ShelfLife;
                        dataGridViewFruit.Rows[row2].Cells["ID"].Value = grapes.Id;
                        dataGridViewFruit.Rows[row2].Cells["Color"].Value = grapes.Color;
                        dataGridViewFruit.Rows[row2].Cells["Size"].Value = grapes.Size;
                        dataGridViewFruit.Rows[row2].Cells["Weight"].Value = grapes.Weight;
                        dataGridViewFruit.Rows[row2].Cells["Taste"].Value = grapes.Taste;
                        dataGridViewFruit.Rows[row2].Cells["Vitamins"].Value = string.Join(", ", grapes.Vitamins);
                        dataGridViewFruit.Rows[row2].Cells["IsGreen"].Value = grapes.IsGreen;
                        dataGridViewFruit.Rows[row2].Cells["HasSeeds"].Value = grapes.HasSeeds;
                        PictureBox grapesim = new PictureBox();
                        grapesim.Image = Properties.Resources.Grapes;
                        Image originalImage3 = grapesim.Image;
                        Image resizedImage3 = new Bitmap(originalImage3, new Size(100, 100));
                        grapesim.Image = resizedImage3;
                        grapesim.SizeMode = PictureBoxSizeMode.AutoSize;
                        grapesim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        grapesim.Cursor = Cursors.Hand;
                        grapesim.MouseDown += MouseDown;
                        grapesim.MouseMove += MouseMove;
                        grapesim.MouseUp += MouseUp;
                        Controls.Add(grapesim);
                        break;
                    case "Orange":
                        Orange orange = null;
                        orange = new Orange(type, price, date, shelf, weight, size, color, vitamins.ToArray(), taste, isOrange, HasSeedsOrange);
                        p.AddProduct(orange);

                        int row3 = dataGridViewFruit.Rows.Add();
                        dataGridViewFruit.Rows[row3].Cells["Name"].Value = orange.Name;
                        dataGridViewFruit.Rows[row3].Cells["Price"].Value = orange.Price;
                        dataGridViewFruit.Rows[row3].Cells["PurchaseDay"].Value = orange.PurchaseDay;
                        dataGridViewFruit.Rows[row3].Cells["ShelfLife"].Value = orange.ShelfLife;
                        dataGridViewFruit.Rows[row3].Cells["ID"].Value = orange.Id;
                        dataGridViewFruit.Rows[row3].Cells["Color"].Value = orange.Color;
                        dataGridViewFruit.Rows[row3].Cells["Size"].Value = orange.Size;
                        dataGridViewFruit.Rows[row3].Cells["Weight"].Value = orange.Weight;
                        dataGridViewFruit.Rows[row3].Cells["Taste"].Value = orange.Taste;
                        dataGridViewFruit.Rows[row3].Cells["Vitamins"].Value = string.Join(", ", orange.Vitamins);
                        dataGridViewFruit.Rows[row3].Cells["IsOrange"].Value = orange.IsOrange;
                        dataGridViewFruit.Rows[row3].Cells["HasSeeds"].Value = orange.HasSeeds;
                        PictureBox orangeim = new PictureBox();
                        orangeim.Image = Properties.Resources.Orangejpg;
                        Image originalImage4 = orangeim.Image;
                        Image resizedImage4 = new Bitmap(originalImage4, new Size(75, 75));
                        orangeim.Image = resizedImage4;
                        orangeim.SizeMode = PictureBoxSizeMode.AutoSize;
                        orangeim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        orangeim.Cursor = Cursors.Hand;
                        orangeim.MouseDown += MouseDown;
                        orangeim.MouseMove += MouseMove;
                        orangeim.MouseUp += MouseUp;
                        Controls.Add(orangeim);
                        break;
                    case "Peach":
                        Peach peach = null;
                        peach = new Peach(type, price, date, shelf, weight, size, color, vitamins.ToArray(), taste, IsRipePeach, hasSeedsPeach);
                        p.AddProduct(peach);

                        int row4 = dataGridViewFruit.Rows.Add();
                        dataGridViewFruit.Rows[row4].Cells["Name"].Value = peach.Name;
                        dataGridViewFruit.Rows[row4].Cells["Price"].Value = peach.Price;
                        dataGridViewFruit.Rows[row4].Cells["PurchaseDay"].Value = peach.PurchaseDay;
                        dataGridViewFruit.Rows[row4].Cells["ShelfLife"].Value = peach.ShelfLife;
                        dataGridViewFruit.Rows[row4].Cells["ID"].Value = peach.Id;
                        dataGridViewFruit.Rows[row4].Cells["Color"].Value = peach.Color;
                        dataGridViewFruit.Rows[row4].Cells["Size"].Value = peach.Size;
                        dataGridViewFruit.Rows[row4].Cells["Weight"].Value = peach.Weight;
                        dataGridViewFruit.Rows[row4].Cells["Taste"].Value = peach.Taste;
                        dataGridViewFruit.Rows[row4].Cells["Vitamins"].Value = string.Join(", ", peach.Vitamins);
                        dataGridViewFruit.Rows[row4].Cells["IsRipe"].Value = peach.IsRipe;
                        dataGridViewFruit.Rows[row4].Cells["HasSeeds"].Value = peach.HasSeeds;
                        PictureBox peachim = new PictureBox();
                        peachim.Image = Properties.Resources.Peach;
                        Image originalImage5 = peachim.Image;
                        Image resizedImage5 = new Bitmap(originalImage5, new Size(100, 50));
                        peachim.Image = resizedImage5;
                        peachim.SizeMode = PictureBoxSizeMode.AutoSize;
                        peachim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        peachim.Cursor = Cursors.Hand;
                        peachim.MouseDown += MouseDown;
                        peachim.MouseMove += MouseMove;
                        peachim.MouseUp += MouseUp;
                        Controls.Add(peachim);
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
            foreach (DataGridViewRow row in dataGridViewFruit.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == idToRemove.ToString())
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                dataGridViewFruit.Rows.RemoveAt(rowIndex);
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
            foreach (DataGridViewRow row in dataGridViewFruit.Rows)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Visible = true;
            btnUpdate.Enabled = true;
            btnUpdate.Visible = true;
            btnRemove.Enabled = false;
            buttonClear.Enabled = false;
            string idInput = ShowInputDialog("Update", "Enter ID:");
            txtID.Text = idInput;
            if (string.IsNullOrEmpty(idInput))
            {
                MessageBox.Show("Please enter ID");
                comboBoxType.DataSource = Enum.GetValues(typeof(eVegetableType));
                comboBoxColors.DataSource = Enum.GetValues(typeof(Enums_Collections.eColors));
                comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
                comboBoxType.Enabled = true;
                btnRemove.Enabled = true;
                buttonClear.Enabled = true;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                txtID.Visible = false;
                ClearForm();
                return;
            }

            if (!int.TryParse(idInput, out int idToUpdate))
            {
                MessageBox.Show("Invalid ID");
                comboBoxType.DataSource = Enum.GetValues(typeof(eVegetableType));
                comboBoxColors.DataSource = Enum.GetValues(typeof(Enums_Collections.eColors));
                comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
                comboBoxType.Enabled = true;
                btnRemove.Enabled = true;
                buttonClear.Enabled = true;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                txtID.Visible = false;
                ClearForm();
                return;
            }

            // Get the list of products
            BindingList<Product> products = p.GetProducts();

            // Find the product to update
            Product productToUpdate = products.FirstOrDefault(product => product.Id == idToUpdate);
            //DisplayIDInGrid(productToUpdate, idToUpdate);
            if (productToUpdate == null)
            {
                MessageBox.Show("The ID does not exist");
                comboBoxType.DataSource = Enum.GetValues(typeof(eVegetableType));
                comboBoxColors.DataSource = Enum.GetValues(typeof(Enums_Collections.eColors));
                comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
                comboBoxType.Enabled = true;
                btnRemove.Enabled = true;
                buttonClear.Enabled = true;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                txtID.Visible = false;
                ClearForm();
                return;
            }
            if (productToUpdate.Name == "Apple")
            {
                comboBoxType.SelectedIndex = 1;
            }
            else if (productToUpdate.Name == "Banana")
            {
                comboBoxType.SelectedIndex = 2;
            }
            else if (productToUpdate.Name == "Grapes")
            {
                comboBoxType.SelectedIndex = 3;
            }
            else if (productToUpdate.Name == "Orange")
            {
                comboBoxType.SelectedIndex = 4;
            }
            else if (productToUpdate.Name == "Peach")
            {
                comboBoxType.SelectedIndex = 5;
            }
            comboBoxType.Enabled = false;

            // Update the fields based on the selected product type
            switch (productToUpdate)
            {
                case Apple apple:
                    comboBoxTaste.SelectedItem = apple.Taste;
                    comboBoxVarietyApple.SelectedItem = apple.Variety;
                    chkhasSeedsApple.Checked =apple.HasSeeds;
                    break;
                case Banana banana:
                    comboBoxTaste.SelectedItem = banana.Taste;
                    chkhasSeedsBanana.Checked = banana.HasSeeds;
                    chkIsRipeBanana.Checked = banana.IsRipe;
                    break;
                case Grapes grapes:
                    comboBoxTaste.SelectedItem = grapes.Taste;
                    chkhasSeedsGrapes.Checked = grapes.HasSeeds;
                    chkisGreenGrapes.Checked = grapes.IsGreen;
                    break;
                case Orange orange:
                    comboBoxTaste.SelectedItem = orange.Taste;
                    chkisOrange.Checked = orange.IsOrange;
                    chkHasSeedsOrange.Checked = orange.HasSeeds;
                    break;
                case Peach peach:
                    comboBoxTaste.SelectedItem = peach.Taste;
                    chkhasSeedsPeach.Checked = peach.HasSeeds;
                    chkIsRipePeach.Checked = peach.IsRipe;
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
            txtWeight.Text = productToUpdate.Weight.ToString();
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
                comboBoxType.DataSource = Enum.GetValues(typeof(eVegetableType));
                comboBoxColors.DataSource = Enum.GetValues(typeof(Enums_Collections.eColors));
                comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
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
                comboBoxType.DataSource = Enum.GetValues(typeof(eVegetableType));
                comboBoxColors.DataSource = Enum.GetValues(typeof(Enums_Collections.eColors));
                comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
                comboBoxType.Enabled = true;
                buttonAdd.Text = "Add";
                ClearForm();
                return 0;
            }
            BindingList<Product> products = p.GetProducts();

            Product productToUpdate = products.FirstOrDefault(product => product.Id == id);

            if (validtion())
            {
                string type = comboBoxType.Text;
                double price = double.Parse(textBoxPrice.Text);
                DateTime date = dateTimeBuyingDate.Value;
                int shelf = int.Parse(txtShelfLife.Text);
                string color = comboBoxColors.Text;
                string size = comboBoxSize.Text;
                double weight = double.Parse(txtWeight.Text);
                string taste = comboBoxTaste.Text;
                List<string> vitamins = new List<string>();
                foreach (var item in checkedListVitamins.CheckedItems)
                {
                    string vitamin = item.ToString();
                    vitamins.Add(vitamin);
                }
                bool hasSeedsApple = chkhasSeedsApple.Checked;
                string VarietyApple = comboBoxVarietyApple.Text;
                bool hasSeedsBanana = chkhasSeedsBanana.Checked;
                bool IsRipeBanana = chkIsRipeBanana.Checked;
                bool SeedsGrapes = chkhasSeedsGrapes.Checked;
                bool isGreenGrapes = chkisGreenGrapes.Checked;
                bool HasSeedsOrange = chkHasSeedsOrange.Checked;
                bool isOrange = chkisOrange.Checked;
                bool hasSeedsPeach = chkhasSeedsPeach.Checked;
                bool IsRipePeach = chkIsRipePeach.Checked;

                productToUpdate.Price = price;
                productToUpdate.PurchaseDay = date;
                productToUpdate.ShelfLife = shelf;
                productToUpdate.Color = color;
                productToUpdate.Size = size;
                productToUpdate.Weight = weight;


                if (comboBoxType.SelectedItem.ToString() == "Apple")
                {
                    Apple apple = productToUpdate as Apple;
                    apple.Taste = taste;
                    apple.HasSeeds = hasSeedsApple;
                    apple.Variety = VarietyApple;

                    if (apple != null)
                    {
                        apple.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
                    }
                }
                else if (comboBoxType.SelectedItem.ToString() == "Banana")
                {
                    Banana banana = productToUpdate as Banana;
                    banana.Taste = taste;
                    banana.HasSeeds = hasSeedsApple;
                    banana.IsRipe = IsRipeBanana;

                    if (banana != null)
                    {
                        banana.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
                    }
                }
                else if (comboBoxType.SelectedItem.ToString() == "Grapes")
                {
                    Grapes grapes = productToUpdate as Grapes;
                    grapes.Taste = taste;
                    grapes.HasSeeds = hasSeedsApple;
                    grapes.IsGreen = isGreenGrapes;

                    if (grapes != null)
                    {
                        grapes.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
                    }
                }
                else if (comboBoxType.SelectedItem.ToString() == "Orange")
                {
                    Orange orange = productToUpdate as Orange;
                    orange.Taste = taste;
                    orange.HasSeeds = hasSeedsApple;
                    orange.IsOrange = isOrange;

                    if (orange != null)
                    {
                        orange.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
                    }
                }
                else if (comboBoxType.SelectedItem.ToString() == "Peach")
                {
                    Peach peach = productToUpdate as Peach;
                    peach.Taste = taste;
                    peach.HasSeeds = hasSeedsApple;
                    peach.IsRipe = IsRipePeach;

                    if (peach != null)
                    {
                        peach.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
                    }
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
