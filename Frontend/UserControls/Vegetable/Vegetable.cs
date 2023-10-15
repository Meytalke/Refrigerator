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
using Microsoft.VisualBasic;


using Refrigerator_FinalProj.Frontend;

namespace Refrigerator_FinalProj.Frontend.UserControls.Vegetable
{
    public partial class Vegetable : UserControl
    {
        ProductsManager p;

        public ProductsManager P { get => p; }

        public Vegetable()
        {
            InitializeComponent();
            p = new ProductsManager();
            comboBoxType.DataSource = Enum.GetValues(typeof(eVegetableType));
            comboBoxColors.DataSource = Enum.GetValues(typeof(Enums_Collections.eColors));
            comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
            string[] vegetableProducts = { "Tomato", "Cucumber", "Pepper", "Lettuce", "Carrot" };
            AddProductImages(0, vegetableProducts);
            regularAddToTable();
            ClearForm();
        }
        private Image GetProductImage(string productName)
        {
            switch (productName)
            {
                case "Tomato":
                    return Properties.Resources.tom;
                case "Cucumber":
                    return Properties.Resources.Cumem;
                case "Pepper":
                    return Properties.Resources.pep;
                case "Lettuce":
                    return Properties.Resources.lettuce1;
                case "Carrot":
                    return Properties.Resources.Carrotjpg;
                default:
                    return null;
            }
        }
        private void AddProductImages(int imageCount, string[] productNames)
        {
            int x = 150; //Horizontal position
            int y = 450;  //Vertical position

            foreach (string productName in productNames)
            {
                int productCount = p.CountOccurrences(productName);
                for (int i = 0; i < productCount; i++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = GetProductImage(productName);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(100, 70);

                    //Location decision for each product using switch
                    switch (productName)
                    {
                        case "Tomato":
                            pictureBox.Location = new Point(x, y);
                            break;
                        case "Cucumber":
                            pictureBox.Location = new Point(x + 100, y);
                            break;
                        case "Pepper":
                            pictureBox.Location = new Point(x + 200, y);
                            break;
                        case "Lettuce":
                            pictureBox.Location = new Point(x + 300, y);
                            break;
                        case "Carrot":
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
            private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            ComboBox[] comboBoxes = { comboBoxType, comboBoxColors, comboBoxSize };
            TextBox[] textBoxes = { textBoxPrice, txtShelfLife, txtWeight };
            DateTimePicker[] dateTimePickers = { dateTimeBuyingDate };
            CheckBox[] checkboxes = { chkBoxIsOrganic, chkIsRedTomato, chk_IsCherryTomato, chk_IsGreenCucumber, _IsCrunchyCucumber, chkIsRedPepper, chkIsSpicyPepper, chkIsCrispyLettuce, chkIsGreenLettuce, chk_IsOrangeCarrot, chk_IsSweetCarrot };

            foreach (ComboBox comboBox in comboBoxes)
                comboBox.ResetText();
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

            for (int i = 0; i < checkedListVitamins.Items.Count; i++)
            {
                checkedListVitamins.SetItemChecked(i, false);
            }

            VisibleandEnable(true, false);
            VisibleandEnableCarrot(false);
            VisibleandEnableCucumber(false);
            VisibleandEnablePepper(false);
            VisibleandEnableLettuce(false);
            VisibleandEnableTomato(false);
            comboBoxType.SelectedIndex = 0;
            comboBoxColors.SelectedIndex = 0;
            comboBoxSize.SelectedIndex = 0;
        }
        private void VisibleandEnable(bool i, bool j)
        {
            Control[] VisibleandEnableControls = { textBoxPrice, dateTimeBuyingDate, txtShelfLife, txtWeight, chkBoxIsOrganic, comboBoxColors, comboBoxSize, comboBoxSize, checkedListVitamins };

            foreach (Control control in VisibleandEnableControls)
            {
                control.Visible = i;
                control.Enabled = j;
            }
        }
        private void VisibleandEnableTomato(bool i)
        {
            Control[] tomatoControls = { lblIsRedTomato, chk_IsCherryTomato, lbl_IsCherryTomato, chkIsRedTomato };

            foreach (Control control in tomatoControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void VisibleandEnableCucumber(bool i)
        {
            Control[] CucumberControls = { lblIsGreenCucumber, chk_IsGreenCucumber, lbl_IsCrunchyCucumber, _IsCrunchyCucumber };

            foreach (Control control in CucumberControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void VisibleandEnablePepper(bool i)
        {
            Control[] PepperControls = { lbl_IsRedPepper, chkIsRedPepper, lblIsSpicyPepper, chkIsSpicyPepper };

            foreach (Control control in PepperControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void VisibleandEnableLettuce(bool i)
        {
            Control[] LettuceControls = { lblIsGreenLettuce, chkIsGreenLettuce, lblIsCrispyLettuce, chkIsCrispyLettuce };

            foreach (Control control in LettuceControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void VisibleandEnableCarrot(bool i)
        {
            Control[] CarrotControls = { chk_IsOrangeCarrot, chk_IsSweetCarrot, lbl_IsOrangeCarrot, lbl_IsSweetCarrot };

            foreach (Control control in CarrotControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }

        }

        private void regularAddToTable()
        {

            dataGridViewVegetable.Columns.Add("ID", "ID");
            dataGridViewVegetable.Columns.Add("Name", "Name");
            dataGridViewVegetable.Columns.Add("Price", "Price");
            dataGridViewVegetable.Columns.Add("PurchaseDay", "Purchase Day");
            dataGridViewVegetable.Columns.Add("ShelfLife", "Shelf Life");
            dataGridViewVegetable.Columns.Add("IsOrganic", "Is Organic");
            dataGridViewVegetable.Columns.Add("Color", "Color");
            dataGridViewVegetable.Columns.Add("Size", "Size");
            dataGridViewVegetable.Columns.Add("Weight", "Weight");
            dataGridViewVegetable.Columns.Add("Vitamins", "Vitamins");
            dataGridViewVegetable.Columns.Add("IsRed", "Is Red");
            dataGridViewVegetable.Columns.Add("IsCherry", "Is Cherry");
            dataGridViewVegetable.Columns.Add("IsGreen", "Is Green");
            dataGridViewVegetable.Columns.Add("IsCrunchy", "Is Crunchy");
            dataGridViewVegetable.Columns.Add("IsSpicy", "Is Spicy");
            dataGridViewVegetable.Columns.Add("IsCrispy", "Is Crispy");
            dataGridViewVegetable.Columns.Add("IsOrange", "Is Orange");
            dataGridViewVegetable.Columns.Add("IsSweet", "Is Sweet");
        }
        private void VisToColumns(bool i)
        {
            buttonAdd.Enabled = false;
            buttonClear.Enabled = false;
            string[] columnNames = {
                                   "IsRedTomato",
                                   "IsCherryTomato",
                                   "IsGreenCucumber",
                                   "IsCrunchyCucumber",
                                   "IsRedPepper",
                                   "IsSpicyPepper",
                                   "IsGreenLettuce",
                                   "IsCrispyLettuce",
                                   "IsOrangeCarrot",
                                   "IsSweetCarrot"
            };
            foreach (string columnName in columnNames)
            {
                if (dataGridViewVegetable.Columns.Contains(columnName))
                {
                    dataGridViewVegetable.Columns[columnName].Visible = i;
                }
            }
        }
        private void UpdateLastTwoColumns(string newText1, string newText2, string newColumnName1, string newColumnName2)
        {
            int rowCount = dataGridViewVegetable.Rows.Count;
            int columnCount = dataGridViewVegetable.Columns.Count;

            if (columnCount >= 2)
            {
                dataGridViewVegetable.Columns[columnCount - 2].HeaderText = newColumnName1;
                dataGridViewVegetable.Columns[columnCount - 1].HeaderText = newColumnName2;

                dataGridViewVegetable.Columns[columnCount - 2].Name = newText1;
                dataGridViewVegetable.Columns[columnCount - 2].Name = newText2;
            }
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "Choose")
            {
                BindingList<Product> products = p.GetProducts();
                DisplayAllProductsInGrid(products);
                this.BackgroundImage = null;
                VisibleandEnable(true, false);
                VisibleandEnableCarrot(false);
                VisibleandEnableCucumber(false);
                VisibleandEnablePepper(false);
                VisibleandEnableLettuce(false);
                VisibleandEnableTomato(false);
                buttonAdd.Enabled = false;
                buttonClear.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
                buttonClear.Enabled = true;
            }

            if (comboBoxType.SelectedItem.ToString() == "Tomato")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);

                VisibleandEnableCarrot(false);
                VisibleandEnable(true, true);
                VisibleandEnableCucumber(false);
                VisibleandEnablePepper(false);
                VisibleandEnableLettuce(false);
                VisibleandEnableTomato(true);

                lblIsRedTomato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lbl_IsCherryTomato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }
            else if (comboBoxType.SelectedItem.ToString() == "Cucumber")
            {
                this.BackgroundImage = null;
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnableCarrot(false);
                VisibleandEnable(true, true);
                VisibleandEnableTomato(false);
                VisibleandEnablePepper(false);
                VisibleandEnableLettuce(false);
                VisibleandEnableCucumber(true);
                lblIsGreenCucumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lbl_IsCrunchyCucumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }
            else if (comboBoxType.SelectedItem.ToString() == "Pepper")
            {
                this.BackgroundImage = null;
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnableCarrot(false);
                VisibleandEnable(true, true);
                VisibleandEnableTomato(false);
                VisibleandEnableCucumber(false);
                VisibleandEnableLettuce(false);
                VisibleandEnablePepper(true);
                lblIsSpicyPepper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lbl_IsRedPepper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }
            else if (comboBoxType.SelectedItem.ToString() == "Lettuce")
            {
                this.BackgroundImage = null;
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnableCarrot(false);
                VisibleandEnable(true, true);
                VisibleandEnableTomato(false);
                VisibleandEnableCucumber(false);
                VisibleandEnablePepper(false);
                VisibleandEnableLettuce(true);
                lblIsGreenLettuce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblIsCrispyLettuce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }
            else if (comboBoxType.SelectedItem.ToString() == "Carrot")
            {
                this.BackgroundImage = null;
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnableCarrot(true);
                VisibleandEnable(true, true);
                VisibleandEnableTomato(false);
                VisibleandEnableCucumber(false);
                VisibleandEnablePepper(false);
                VisibleandEnableLettuce(false);
                lbl_IsSweetCarrot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lbl_IsOrangeCarrot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }

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
                PictureBox Vegetable = (PictureBox)sender;
                Vegetable.Left += e.X - startPosition.X;
                Vegetable.Top += e.Y - startPosition.Y;
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
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
                {
                    throw new Exception("Invalid price value");
                }
                if (!Validator.ValidateValue(dateTimeBuyingDate.Value, typeof(DateTime)))
                {
                    throw new Exception("Invalid Buying date value");
                }
                if (dateTimeBuyingDate.Value > DateTime.Today.AddDays(+1))
                {
                    throw new Exception("Invalid Buying date value");
                }
                int shelf;
                if (int.TryParse(txtShelfLife.Text, out shelf))
                {
                    if (shelf <= 0)
                    {
                        throw new Exception("Invalid shelf life value");
                    }
                }
                if (!Validator.ValidateValue(txtShelfLife.Text, typeof(int)))
                    throw new Exception("Invalid shelf life value");
                if (comboBoxColors.SelectedIndex == 0)
                {
                    throw new Exception("Please choose Color");
                }
                if (comboBoxSize.SelectedIndex == 0)
                {
                    throw new Exception("Please choose Size");
                }
                if (!Validator.ValidateValue(txtWeight.Text, typeof(double)))
                {
                    throw new Exception("Invalid weight value");
                }
                int weight;
                if (int.TryParse(txtWeight.Text, out weight))
                {
                    if (weight <= 0)
                    {
                        throw new Exception("Invalid weight value");
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
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (validtion())
            {

                int rowCount = dataGridViewVegetable.Rows.Count;

                string type = comboBoxType.Text;
                double price = double.Parse(textBoxPrice.Text);
                DateTime date = dateTimeBuyingDate.Value;
                int shelf = int.Parse(txtShelfLife.Text);
                bool organic = chkBoxIsOrganic.Checked;
                string color = comboBoxColors.Text;
                string size = comboBoxSize.Text;
                double weight = double.Parse(txtWeight.Text);
                List<string> vitamins = new List<string>();
                foreach (var item in checkedListVitamins.CheckedItems)
                {
                    string vitamin = item.ToString();
                    vitamins.Add(vitamin);
                }
                bool isRedTomato = chkIsRedTomato.Checked;
                bool IsCherryTomato = chk_IsCherryTomato.Checked;
                bool IsCrunchyCucumber = _IsCrunchyCucumber.Checked;
                bool IsGreenCucumber = chk_IsGreenCucumber.Checked;
                bool IsRedPepper = chkIsRedPepper.Checked;
                bool IsSpicyPepper = chkIsSpicyPepper.Checked;
                bool IsGreenLettuce = chkIsGreenLettuce.Checked;
                bool IsCrispyLettuce = chkIsCrispyLettuce.Checked;
                bool IsOrangeCarrot = chk_IsOrangeCarrot.Checked;
                bool IsSweetCarrot = chk_IsSweetCarrot.Checked;

                switch (comboBoxType.SelectedItem.ToString())
                {
                    case "Tomato":
                        Tomato t = null;
                        t = new Tomato(type, price, date, shelf, organic, color, size, weight, vitamins.ToArray(), isRedTomato, IsCherryTomato);
                        p.AddProduct(t);
                        int row = dataGridViewVegetable.Rows.Add();

                        dataGridViewVegetable.Rows[row].Cells["Name"].Value = t.Name;
                        dataGridViewVegetable.Rows[row].Cells["Price"].Value = t.Price;
                        dataGridViewVegetable.Rows[row].Cells["PurchaseDay"].Value = t.PurchaseDay;
                        dataGridViewVegetable.Rows[row].Cells["ShelfLife"].Value = t.ShelfLife;
                        dataGridViewVegetable.Rows[row].Cells["ID"].Value = t.Id;
                        dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = t.IsOrganic;
                        dataGridViewVegetable.Rows[row].Cells["Color"].Value = t.Color;
                        dataGridViewVegetable.Rows[row].Cells["Size"].Value = t.Size;
                        dataGridViewVegetable.Rows[row].Cells["Weight"].Value = t.Weight;
                        dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", t.Vitamins);
                        dataGridViewVegetable.Rows[row].Cells["IsRed"].Value = t.IsRed;
                        dataGridViewVegetable.Rows[row].Cells["IsCherry"].Value = t.IsCherry;
                        PictureBox tomato = new PictureBox();
                        tomato.Image = Properties.Resources.tom; 
                        Image originalImage = tomato.Image;
                        Image resizedImage = new Bitmap(originalImage, new Size(100, 100));
                        tomato.Image = resizedImage;
                        tomato.SizeMode = PictureBoxSizeMode.AutoSize;// Automatically adjust image size into the picturebox
                        tomato.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        tomato.Cursor = Cursors.Hand; //Change the mouse shape to a hand shape
                        tomato.MouseDown += MouseDown;
                        tomato.MouseMove += MouseMove;
                        tomato.MouseUp += MouseUp;
                        Controls.Add(tomato);
                        break;
                    case "Cucumber":
                        Cucumber c = null;
                        c = new Cucumber(type, price, date, shelf, organic, color, size, weight, vitamins.ToArray(), IsGreenCucumber, IsCrunchyCucumber);
                        p.AddProduct(c);

                        int row1 = dataGridViewVegetable.Rows.Add();
                        dataGridViewVegetable.Rows[row1].Cells["Name"].Value = c.Name;
                        dataGridViewVegetable.Rows[row1].Cells["Price"].Value = c.Price;
                        dataGridViewVegetable.Rows[row1].Cells["PurchaseDay"].Value = c.PurchaseDay;
                        dataGridViewVegetable.Rows[row1].Cells["ShelfLife"].Value = c.ShelfLife;
                        dataGridViewVegetable.Rows[row1].Cells["ID"].Value = c.Id;
                        dataGridViewVegetable.Rows[row1].Cells["IsOrganic"].Value = c.IsOrganic;
                        dataGridViewVegetable.Rows[row1].Cells["Color"].Value = c.Color;
                        dataGridViewVegetable.Rows[row1].Cells["Size"].Value = c.Size;
                        dataGridViewVegetable.Rows[row1].Cells["Weight"].Value = c.Weight;
                        dataGridViewVegetable.Rows[row1].Cells["Vitamins"].Value = string.Join(", ", c.Vitamins);
                        dataGridViewVegetable.Rows[row1].Cells["IsGreen"].Value = c.IsGreen;
                        dataGridViewVegetable.Rows[row1].Cells["IsCrunchy"].Value = c.IsCrunchy;
                        PictureBox Cucumber = new PictureBox();
                        Cucumber.Image = Properties.Resources.Cumem;
                        Image originalImage2 = Cucumber.Image;
                        Image resizedImage2 = new Bitmap(originalImage2, new Size(100, 50));
                        Cucumber.Image = resizedImage2;
                        Cucumber.SizeMode = PictureBoxSizeMode.AutoSize;
                        Cucumber.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        Cucumber.Cursor = Cursors.Hand;
                        Cucumber.MouseDown += MouseDown;
                        Cucumber.MouseMove += MouseMove;
                        Cucumber.MouseUp += MouseUp;
                        Controls.Add(Cucumber);
                        break;
                    case "Pepper":
                        Pepper pep = null;
                        pep = new Pepper(type, price, date, shelf, organic, color, size, weight, vitamins.ToArray(), IsRedPepper, IsSpicyPepper);
                        p.AddProduct(pep);

                        int row2 = dataGridViewVegetable.Rows.Add();
                        dataGridViewVegetable.Rows[row2].Cells["Name"].Value = pep.Name;
                        dataGridViewVegetable.Rows[row2].Cells["Price"].Value = pep.Price;
                        dataGridViewVegetable.Rows[row2].Cells["PurchaseDay"].Value = pep.PurchaseDay;
                        dataGridViewVegetable.Rows[row2].Cells["ShelfLife"].Value = pep.ShelfLife;
                        dataGridViewVegetable.Rows[row2].Cells["IsOrganic"].Value = pep.IsOrganic;
                        dataGridViewVegetable.Rows[row2].Cells["ID"].Value = pep.Id;
                        dataGridViewVegetable.Rows[row2].Cells["Color"].Value = pep.Color;
                        dataGridViewVegetable.Rows[row2].Cells["Size"].Value = pep.Size;
                        dataGridViewVegetable.Rows[row2].Cells["Weight"].Value = pep.Weight;
                        dataGridViewVegetable.Rows[row2].Cells["Vitamins"].Value = string.Join(", ", pep.Vitamins);
                        dataGridViewVegetable.Rows[row2].Cells["IsRed"].Value = pep.IsRed;
                        dataGridViewVegetable.Rows[row2].Cells["IsSpicy"].Value = pep.IsSpicy;
                        PictureBox Pepper = new PictureBox();
                        Pepper.Image = Properties.Resources.pep;
                        Image originalImage3 = Pepper.Image;
                        Image resizedImage3 = new Bitmap(originalImage3, new Size(100, 100));
                        Pepper.Image = resizedImage3;
                        Pepper.SizeMode = PictureBoxSizeMode.AutoSize;
                        Pepper.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        Pepper.Cursor = Cursors.Hand;
                        Pepper.MouseDown += MouseDown;
                        Pepper.MouseMove += MouseMove;
                        Pepper.MouseUp += MouseUp;
                        Controls.Add(Pepper);
                        break;
                    case "Lettuce":
                        Lettuce l = null;
                        l = new Lettuce(type, price, date, shelf, organic, color, size, weight, vitamins.ToArray(), IsGreenLettuce, IsCrispyLettuce);
                        p.AddProduct(l);

                        int row3 = dataGridViewVegetable.Rows.Add();
                        dataGridViewVegetable.Rows[row3].Cells["Name"].Value = l.Name;
                        dataGridViewVegetable.Rows[row3].Cells["Price"].Value = l.Price;
                        dataGridViewVegetable.Rows[row3].Cells["PurchaseDay"].Value = l.PurchaseDay;
                        dataGridViewVegetable.Rows[row3].Cells["ShelfLife"].Value = l.ShelfLife;
                        dataGridViewVegetable.Rows[row3].Cells["ID"].Value = l.Id;
                        dataGridViewVegetable.Rows[row3].Cells["IsOrganic"].Value = l.IsOrganic;
                        dataGridViewVegetable.Rows[row3].Cells["Color"].Value = l.Color;
                        dataGridViewVegetable.Rows[row3].Cells["Size"].Value = l.Size;
                        dataGridViewVegetable.Rows[row3].Cells["Weight"].Value = l.Weight;
                        dataGridViewVegetable.Rows[row3].Cells["Vitamins"].Value = string.Join(", ", l.Vitamins);
                        dataGridViewVegetable.Rows[row3].Cells["IsGreen"].Value = l.IsGreen;
                        dataGridViewVegetable.Rows[row3].Cells["IsCrispy"].Value = l.IsCrispy;
                        PictureBox Lettuce = new PictureBox();
                        Lettuce.Image = Properties.Resources.lettuce1;
                        Image originalImage4 = Lettuce.Image;
                        Image resizedImage4 = new Bitmap(originalImage4, new Size(75, 75));
                        Lettuce.Image = resizedImage4;
                        Lettuce.SizeMode = PictureBoxSizeMode.AutoSize;
                        Lettuce.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        Lettuce.Cursor = Cursors.Hand;
                        Lettuce.MouseDown += MouseDown;
                        Lettuce.MouseMove += MouseMove;
                        Lettuce.MouseUp += MouseUp;
                        Controls.Add(Lettuce);
                        break;
                    case "Carrot":
                        Carrot car = null;
                        car = new Carrot(type, price, date, shelf, organic, color, size, weight, vitamins.ToArray(), IsOrangeCarrot, IsSweetCarrot);
                        p.AddProduct(car);

                        int row4 = dataGridViewVegetable.Rows.Add();
                        dataGridViewVegetable.Rows[row4].Cells["Name"].Value = car.Name;
                        dataGridViewVegetable.Rows[row4].Cells["Price"].Value = car.Price;
                        dataGridViewVegetable.Rows[row4].Cells["PurchaseDay"].Value = car.PurchaseDay;
                        dataGridViewVegetable.Rows[row4].Cells["ShelfLife"].Value = car.ShelfLife;
                        dataGridViewVegetable.Rows[row4].Cells["IsOrganic"].Value = car.IsOrganic;
                        dataGridViewVegetable.Rows[row4].Cells["Color"].Value = car.Color;
                        dataGridViewVegetable.Rows[row4].Cells["ID"].Value = car.Id;
                        dataGridViewVegetable.Rows[row4].Cells["Size"].Value = car.Size;
                        dataGridViewVegetable.Rows[row4].Cells["Weight"].Value = car.Weight;
                        dataGridViewVegetable.Rows[row4].Cells["Vitamins"].Value = string.Join(", ", car.Vitamins);
                        dataGridViewVegetable.Rows[row4].Cells["IsOrange"].Value = car.IsOrange;
                        dataGridViewVegetable.Rows[row4].Cells["IsSweet"].Value = car.IsSweet;
                        PictureBox Carrot = new PictureBox();
                        Carrot.Image = Properties.Resources.Carrotjpg;
                        Image originalImage5 = Carrot.Image;
                        Image resizedImage5 = new Bitmap(originalImage5, new Size(100, 50));
                        Carrot.Image = resizedImage5;
                        Carrot.SizeMode = PictureBoxSizeMode.AutoSize;
                        Carrot.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        Carrot.Cursor = Cursors.Hand;
                        Carrot.MouseDown += MouseDown;
                        Carrot.MouseMove += MouseMove;
                        Carrot.MouseUp += MouseUp;
                        Controls.Add(Carrot);
                        break;
                }
                MessageBox.Show("The product has been successfully Added");
                ClearForm();

            }

        }

        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColors.SelectedItem.ToString() == "Red" && comboBoxType.SelectedItem.ToString() == "Tomato")
                chkIsRedTomato.Checked = true;
            else
                chkIsRedTomato.Checked = false;
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

        private List<Product> GetFAllProducts()
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (Product product in P.GetProducts())
            {
                filteredProducts.Add(product);
            }

            return filteredProducts;
        }
        private void DisplayProductsInGrid(List<Product> filteredProducts)
        {
            dataGridViewVegetable.Rows.Clear();

            foreach (Product product in filteredProducts)
            {
                int row = dataGridViewVegetable.Rows.Add();
                dataGridViewVegetable.Rows[row].Cells["Name"].Value = product.Name;
                dataGridViewVegetable.Rows[row].Cells["Price"].Value = product.Price;
                dataGridViewVegetable.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                dataGridViewVegetable.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                if (product is Tomato)
                {
                    Tomato tomato = (Tomato)product;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = tomato.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = tomato.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = tomato.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = tomato.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = tomato.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", tomato.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsRed"].Value = tomato.IsRed;
                    dataGridViewVegetable.Rows[row].Cells["IsCherry"].Value = tomato.IsCherry;

                }
                if (product is Cucumber)
                {
                    Cucumber cucumber = (Cucumber)product;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = cucumber.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = cucumber.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = cucumber.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = cucumber.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = cucumber.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", cucumber.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsGreen"].Value = cucumber.IsGreen;
                    dataGridViewVegetable.Rows[row].Cells["IsCrunchy"].Value = cucumber.IsCrunchy;
                }
                if (product is Lettuce)
                {
                    Lettuce lettuce = (Lettuce)product;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = lettuce.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = lettuce.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = lettuce.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = lettuce.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = lettuce.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", lettuce.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsGreen"].Value = lettuce.IsGreen;
                    dataGridViewVegetable.Rows[row].Cells["IsCrispy"].Value = lettuce.IsCrispy;
                }
                if (product is Pepper)
                {
                    Pepper pepper = (Pepper)product;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = pepper.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = pepper.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = pepper.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = pepper.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = pepper.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", pepper.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsRed"].Value = pepper.IsRed;
                    dataGridViewVegetable.Rows[row].Cells["IsSpicy"].Value = pepper.IsSpicy;
                }
                if (product is Carrot)
                {
                    Carrot carrot = (Carrot)product;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = carrot.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = carrot.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = carrot.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = carrot.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = carrot.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", carrot.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsOrange"].Value = carrot.IsOrange;
                    dataGridViewVegetable.Rows[row].Cells["IsSweet"].Value = carrot.IsSweet;
                }
            }
        }
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = cmbProducts.SelectedItem.ToString();
            List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
            DisplayProductsInGrid(filteredProducts);
        }
        private void DisplayProductsInGrid2(string filteredProducts)
        {
            dataGridViewVegetable.Rows.Clear();

            List<Product> filteredTomatoes = p.GetFilteredProducts(filteredProducts);

            foreach (Tomato tomato in filteredTomatoes)
            {
                int row = dataGridViewVegetable.Rows.Add();
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
            foreach (DataGridViewRow row in dataGridViewVegetable.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == idToRemove.ToString())
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                dataGridViewVegetable.Rows.RemoveAt(rowIndex);
                p.RemoveProductById(idToRemove);
                MessageBox.Show("The product has been successfully deleted");
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
                comboBoxType.DataSource = Enum.GetValues(typeof(eVegetableType));
                comboBoxColors.DataSource = Enum.GetValues(typeof(Enums_Collections.eColors));
                comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
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
                comboBoxType.DataSource = Enum.GetValues(typeof(eVegetableType));
                comboBoxColors.DataSource = Enum.GetValues(typeof(Enums_Collections.eColors));
                comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
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
                comboBoxType.DataSource = Enum.GetValues(typeof(eVegetableType));
                comboBoxColors.DataSource = Enum.GetValues(typeof(Enums_Collections.eColors));
                comboBoxSize.DataSource = Enum.GetValues(typeof(Enums_Collections.esizes));
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
            if (productToUpdate.Name == "Tomato")
            {
                comboBoxType.SelectedIndex = 1;
            }
            else if (productToUpdate.Name == "Cucumber")
            {
                comboBoxType.SelectedIndex = 2;
            }
            else if (productToUpdate.Name == "Pepper")
            {
                comboBoxType.SelectedIndex = 3;
            }
            else if (productToUpdate.Name == "Lettuce")
            {
                comboBoxType.SelectedIndex = 4;
            }
            else if (productToUpdate.Name == "Carrot")
            {
                comboBoxType.SelectedIndex = 5;
            }
            comboBoxType.Enabled = false;

            // Update the fields based on the selected product type
            switch (productToUpdate)
            {
                case Tomato tomato:
                    chkBoxIsOrganic.Checked = tomato.IsOrganic;
                    chkIsRedTomato.Checked = tomato.IsRed;
                    chk_IsCherryTomato.Checked = tomato.IsCherry;
                    break;
                case Cucumber cucumber:
                    chkBoxIsOrganic.Checked = cucumber.IsOrganic;
                    chk_IsGreenCucumber.Checked = cucumber.IsGreen;
                    _IsCrunchyCucumber.Checked = cucumber.IsCrunchy;
                    break;
                case Lettuce lettuce:
                    chkBoxIsOrganic.Checked = lettuce.IsOrganic;
                    chkIsGreenLettuce.Checked = lettuce.IsGreen;
                    chkIsCrispyLettuce.Checked = lettuce.IsCrispy;
                    break;
                case Pepper pepper:
                    chkBoxIsOrganic.Checked = pepper.IsOrganic;
                    chkIsRedPepper.Checked = pepper.IsRed;
                    chkIsSpicyPepper.Checked = pepper.IsSpicy;
                    break;
                case Carrot carrot:
                    chkBoxIsOrganic.Checked = carrot.IsOrganic;
                    chk_IsOrangeCarrot.Checked = carrot.IsOrange;
                    chk_IsSweetCarrot.Checked = carrot.IsSweet;
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
            DisplayIDInGrid(productToUpdate, id);

            if (validtion())
            {
                double price = double.Parse(textBoxPrice.Text);
                DateTime date = dateTimeBuyingDate.Value;
                int shelf = int.Parse(txtShelfLife.Text);
                bool organic = chkBoxIsOrganic.Checked;
                string color = comboBoxColors.Text;
                string size = comboBoxSize.Text;
                double weight = double.Parse(txtWeight.Text);
                List<string> vitamins = new List<string>();
                foreach (var item in checkedListVitamins.CheckedItems)
                {
                    string vitamin = item.ToString();
                    vitamins.Add(vitamin);
                }
                bool isRedTomato = chkIsRedTomato.Checked;
                bool IsCherryTomato = chk_IsCherryTomato.Checked;
                bool IsCrunchyCucumber = _IsCrunchyCucumber.Checked;
                bool IsGreenCucumber = chk_IsGreenCucumber.Checked;
                bool IsRedPepper = chkIsRedPepper.Checked;
                bool IsSpicyPepper = chkIsSpicyPepper.Checked;
                bool IsGreenLettuce = chkIsGreenLettuce.Checked;
                bool IsCrispyLettuce = chkIsCrispyLettuce.Checked;
                bool IsOrangeCarrot = chk_IsOrangeCarrot.Checked;
                bool IsSweetCarrot = chk_IsSweetCarrot.Checked;
                productToUpdate.Price = price;
                productToUpdate.PurchaseDay = date;
                productToUpdate.ShelfLife = shelf;
                productToUpdate.Color = color;
                productToUpdate.Size = size;
                productToUpdate.Weight = weight;


                if (comboBoxType.SelectedItem.ToString() == "Tomato")
                {
                    Tomato tomato = productToUpdate as Tomato;
                    tomato.IsOrganic = organic;
                    tomato.IsRed = isRedTomato;
                    tomato.IsCherry = IsCherryTomato;
                    if (tomato != null)
                    {
                        tomato.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
                    }
                }
                else if (comboBoxType.SelectedItem.ToString() == "Cucumber")
                {
                    Cucumber cucumber = productToUpdate as Cucumber;
                    cucumber.IsOrganic = organic;
                    cucumber.IsGreen = IsGreenCucumber;
                    cucumber.IsCrunchy = IsCrunchyCucumber;
                    if (cucumber != null)
                    {
                        cucumber.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
                    }
                }
                else if (comboBoxType.SelectedItem.ToString() == "Lettuce")
                {
                    Lettuce lettuce = productToUpdate as Lettuce;
                    lettuce.IsOrganic = organic;
                    lettuce.IsGreen = IsGreenLettuce;
                    lettuce.IsCrispy = IsCrispyLettuce;
                    if (lettuce != null)
                    {
                        lettuce.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
                    }
                }
                else if (comboBoxType.SelectedItem.ToString() == "Pepper")
                {
                    Pepper pepper = productToUpdate as Pepper;
                    pepper.IsOrganic = organic;
                    pepper.IsRed = IsRedPepper;
                    pepper.IsSpicy = IsSpicyPepper;
                    if (pepper != null)
                    {
                        pepper.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
                    }
                }
                else if (comboBoxType.SelectedItem.ToString() == "Carrot")
                {
                    Carrot carrot = productToUpdate as Carrot; carrot.IsOrganic = organic;
                    carrot.IsOrange = IsOrangeCarrot;
                    carrot.IsSweet = IsSweetCarrot;
                    if (carrot != null)
                    {
                        carrot.Vitamins = checkedListVitamins.CheckedItems.Cast<string>().ToArray();
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
        private void DisplayAllProductsInGrid(BindingList<Product> products)
        {
            dataGridViewVegetable.Rows.Clear();

            foreach (Product product in products)
            {
                if (product.Name == "Tomato" || product.Name == "Cucumber" || product.Name == "Lettuce" || product.Name == "Pepper" || product.Name == "Carrot")
                {

                    int row = dataGridViewVegetable.Rows.Add();
                    dataGridViewVegetable.Rows[row].Cells["Name"].Value = product.Name;
                    dataGridViewVegetable.Rows[row].Cells["Price"].Value = product.Price;
                    dataGridViewVegetable.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                    dataGridViewVegetable.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                    if (product is Tomato)
                    {
                        Tomato tomato = (Tomato)product;
                        dataGridViewVegetable.Rows[row].Cells["ID"].Value = tomato.Id;
                        dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = tomato.IsOrganic;
                        dataGridViewVegetable.Rows[row].Cells["Color"].Value = tomato.Color;
                        dataGridViewVegetable.Rows[row].Cells["Size"].Value = tomato.Size;
                        dataGridViewVegetable.Rows[row].Cells["Weight"].Value = tomato.Weight;
                        dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", tomato.Vitamins);
                        dataGridViewVegetable.Rows[row].Cells["IsRed"].Value = tomato.IsRed;
                        dataGridViewVegetable.Rows[row].Cells["IsCherry"].Value = tomato.IsCherry;
                    }
                    else if (product is Cucumber)
                    {
                        Cucumber cucumber = (Cucumber)product;
                        dataGridViewVegetable.Rows[row].Cells["ID"].Value = cucumber.Id;
                        dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = cucumber.IsOrganic;
                        dataGridViewVegetable.Rows[row].Cells["Color"].Value = cucumber.Color;
                        dataGridViewVegetable.Rows[row].Cells["Size"].Value = cucumber.Size;
                        dataGridViewVegetable.Rows[row].Cells["Weight"].Value = cucumber.Weight;
                        dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", cucumber.Vitamins);
                        dataGridViewVegetable.Rows[row].Cells["IsGreen"].Value = cucumber.IsGreen;
                        dataGridViewVegetable.Rows[row].Cells["IsCrunchy"].Value = cucumber.IsCrunchy;
                    }
                    else if (product is Lettuce)
                    {
                        Lettuce lettuce = (Lettuce)product;
                        dataGridViewVegetable.Rows[row].Cells["ID"].Value = lettuce.Id;
                        dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = lettuce.IsOrganic;
                        dataGridViewVegetable.Rows[row].Cells["Color"].Value = lettuce.Color;
                        dataGridViewVegetable.Rows[row].Cells["Size"].Value = lettuce.Size;
                        dataGridViewVegetable.Rows[row].Cells["Weight"].Value = lettuce.Weight;
                        dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", lettuce.Vitamins);
                        dataGridViewVegetable.Rows[row].Cells["IsGreen"].Value = lettuce.IsGreen;
                        dataGridViewVegetable.Rows[row].Cells["IsCrispy"].Value = lettuce.IsCrispy;
                    }
                    else if (product is Pepper)
                    {
                        Pepper pepper = (Pepper)product;
                        dataGridViewVegetable.Rows[row].Cells["ID"].Value = pepper.Id;
                        dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = pepper.IsOrganic;
                        dataGridViewVegetable.Rows[row].Cells["Color"].Value = pepper.Color;
                        dataGridViewVegetable.Rows[row].Cells["Size"].Value = pepper.Size;
                        dataGridViewVegetable.Rows[row].Cells["Weight"].Value = pepper.Weight;
                        dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", pepper.Vitamins);
                        dataGridViewVegetable.Rows[row].Cells["IsRed"].Value = pepper.IsRed;
                        dataGridViewVegetable.Rows[row].Cells["IsSpicy"].Value = pepper.IsSpicy;
                    }
                    else if (product is Carrot)
                    {
                        Carrot carrot = (Carrot)product;
                        dataGridViewVegetable.Rows[row].Cells["ID"].Value = carrot.Id;
                        dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = carrot.IsOrganic;
                        dataGridViewVegetable.Rows[row].Cells["Color"].Value = carrot.Color;
                        dataGridViewVegetable.Rows[row].Cells["Size"].Value = carrot.Size;
                        dataGridViewVegetable.Rows[row].Cells["Weight"].Value = carrot.Weight;
                        dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", carrot.Vitamins);
                        dataGridViewVegetable.Rows[row].Cells["IsOrange"].Value = carrot.IsOrange;
                        dataGridViewVegetable.Rows[row].Cells["IsSweet"].Value = carrot.IsSweet;
                    }
                }
            }
        }
        private void DisplayIDInGrid(Product pro, int ID)
        {
            dataGridViewVegetable.Rows.Clear();

            if (pro.Id == ID)
            {
                int row = dataGridViewVegetable.Rows.Add();
                dataGridViewVegetable.Rows[row].Cells["Name"].Value = pro.Name;
                dataGridViewVegetable.Rows[row].Cells["Price"].Value = pro.Price;
                dataGridViewVegetable.Rows[row].Cells["PurchaseDay"].Value = pro.PurchaseDay;
                dataGridViewVegetable.Rows[row].Cells["ShelfLife"].Value = pro.ShelfLife;

                if (pro is Tomato)
                {
                    Tomato tomato = (Tomato)pro;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = tomato.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = tomato.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = tomato.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = tomato.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = tomato.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", tomato.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsRed"].Value = tomato.IsRed;
                    dataGridViewVegetable.Rows[row].Cells["IsCherry"].Value = tomato.IsCherry;

                }
                else if (pro is Cucumber)
                {
                    Cucumber cucumber = (Cucumber)pro;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = cucumber.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = cucumber.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = cucumber.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = cucumber.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = cucumber.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", cucumber.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsGreen"].Value = cucumber.IsGreen;
                    dataGridViewVegetable.Rows[row].Cells["IsCrunchy"].Value = cucumber.IsCrunchy;
                }
                else if (pro is Lettuce)
                {
                    Lettuce lettuce = (Lettuce)pro;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = lettuce.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = lettuce.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = lettuce.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = lettuce.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = lettuce.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", lettuce.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsGreen"].Value = lettuce.IsGreen;
                    dataGridViewVegetable.Rows[row].Cells["IsCrispy"].Value = lettuce.IsCrispy;
                }
                else if (pro is Pepper)
                {
                    Pepper pepper = (Pepper)pro;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = pepper.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = pepper.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = pepper.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = pepper.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = pepper.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", pepper.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsRed"].Value = pepper.IsRed;
                    dataGridViewVegetable.Rows[row].Cells["IsSpicy"].Value = pepper.IsSpicy;
                }
                else if (pro is Carrot)
                {
                    Carrot carrot = (Carrot)pro;
                    dataGridViewVegetable.Rows[row].Cells["ID"].Value = carrot.Id;
                    dataGridViewVegetable.Rows[row].Cells["IsOrganic"].Value = carrot.IsOrganic;
                    dataGridViewVegetable.Rows[row].Cells["Color"].Value = carrot.Color;
                    dataGridViewVegetable.Rows[row].Cells["Size"].Value = carrot.Size;
                    dataGridViewVegetable.Rows[row].Cells["Weight"].Value = carrot.Weight;
                    dataGridViewVegetable.Rows[row].Cells["Vitamins"].Value = string.Join(", ", carrot.Vitamins);
                    dataGridViewVegetable.Rows[row].Cells["IsOrange"].Value = carrot.IsOrange;
                    dataGridViewVegetable.Rows[row].Cells["IsSweet"].Value = carrot.IsSweet;
                }
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
            foreach (DataGridViewRow row in dataGridViewVegetable.Rows)
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
    }
}