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

namespace Refrigerator_FinalProj.Frontend.Usre
{
    public partial class Meat : UserControl
    {
        ProductsManager p;
        public ProductsManager P { get => p; }
        public  Meat()
        {
            p = new ProductsManager();
            InitializeComponent();
            comboBoxType.DataSource = Enum.GetValues(typeof(eMeatType));
            string[] MeatProducts = { "Beef","Chicken","Pork","Lamb"};
            AddProductImages(0, MeatProducts);
            regularAddToTable();
        }
        private Image GetProductImage(string productName)
        {
            switch (productName)
            {
                case "Beef":
                    return Properties.Resources.Beef;
                case "Chicken":
                    return Properties.Resources.Chicken;
                case "Pork":
                    return Properties.Resources.Porkjpg;
                case "Lamb":
                    return Properties.Resources.Lamb;
                default:
                    return null;
            }
        }
        private void AddProductImages(int imageCount, string[] productNames)
        {
            int x = 150;  
            int y = 450; 

            foreach (string productName in productNames)
            {
                int productCount = p.CountOccurrences(productName);
                for (int i = 0; i < productCount; i++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = GetProductImage(productName);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(100, 50);

                    switch (productName)
                    {
                        case "Beef":
                            pictureBox.Location = new Point(x, y);
                            break;
                        case "Chicken":
                            pictureBox.Location = new Point(x + 100, y);
                            break;
                        case "Pork":
                            pictureBox.Location = new Point(x + 200, y);
                            break;
                        case "Lamb":
                            pictureBox.Location = new Point(x + 300, y);
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
        private void hide_widgets()
        {

        }

        private void show_meats_widgets()
        {

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
                PictureBox meat = (PictureBox)sender;
                meat.Left += e.X - startPosition.X;
                meat.Top += e.Y - startPosition.Y;
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if(validtion())
            {
                int rowCount = dataGridViewMeat.Rows.Count;

                string type = comboBoxType.Text;
                double price = double.Parse(textBoxPrice.Text);
                DateTime date = dateTimeBuyingDate.Value;
                int shelf = int.Parse(txtShelfLife.Text);
                double fat = double.Parse(txtFatPercentage.Text);
                double weight = double.Parse(txtWeight.Text);
                bool IsKosher = chkIsKosher.Checked;

                bool IsMarinatedPork = chkisMarinatedPork.Checked;
                bool IsSmokedPork = chkisSmokedPork.Checked;
                bool IsGrassFedLamb = chkisGrassFedLamb.Checked;
                bool IsHalalCertifiedLamb = chkisHalalCertifiedLamb.Checked;
                bool IsOrganicChicken = chkisOrganicChicken.Checked;
                bool IsSkinlessChicken = chkisSkinlessChicken.Checked;
                bool IsDryAgedBeef = chk_IsDryAgedBeef.Checked;
                bool IsGrassFedBeef = chk_IsGrassFedBeef.Checked;


                switch (comboBoxType.SelectedItem.ToString())
                {
                    case "Pork":
                        Pork pork = null;
                        pork = new Pork(type, price, date, shelf, weight, fat, IsKosher, IsSmokedPork, IsMarinatedPork);
                        int row = dataGridViewMeat.Rows.Add();
                        p.AddProduct(pork);
                        dataGridViewMeat.Rows[row].Cells["Fat"].Value = pork.FatPercentage;
                        dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = pork.IsKosher;
                        dataGridViewMeat.Rows[row].Cells["Name"].Value = pork.Name;
                        dataGridViewMeat.Rows[row].Cells["Price"].Value = pork.Price;
                        dataGridViewMeat.Rows[row].Cells["PurchaseDay"].Value = pork.PurchaseDay;
                        dataGridViewMeat.Rows[row].Cells["ShelfLife"].Value = pork.ShelfLife;
                        dataGridViewMeat.Rows[row].Cells["ID"].Value = pork.Id;
                        dataGridViewMeat.Rows[row].Cells["Weight"].Value = pork.Weight;
                        dataGridViewMeat.Rows[row].Cells["IsMarinated"].Value = pork.IsMarinated;
                        dataGridViewMeat.Rows[row].Cells["IsSmoked"].Value = pork.IsSmoked;
                        PictureBox Pork = new PictureBox();
                        Pork.Image = Properties.Resources.Porkjpg; 
                        Image originalImage = Pork.Image;
                        Image resizedImage = new Bitmap(originalImage, new Size(100, 100));
                        Pork.Image = resizedImage;
                        Pork.SizeMode = PictureBoxSizeMode.AutoSize; 
                        Pork.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        Pork.Cursor = Cursors.Hand; 
                        Pork.MouseDown += MouseDown;
                        Pork.MouseMove += MouseMove;
                        Pork.MouseUp += MouseUp;
                        Controls.Add(Pork);
                        break;
                    case "Lamb":
                        Lamb lamb = null;
                        lamb = new Lamb(type, price, date, shelf, weight, fat, IsKosher, IsGrassFedLamb, IsHalalCertifiedLamb);
                        p.AddProduct(lamb);
                        int row1 = dataGridViewMeat.Rows.Add();
                        dataGridViewMeat.Rows[row1].Cells["Fat"].Value = lamb.FatPercentage;
                        dataGridViewMeat.Rows[row1].Cells["IsKosher"].Value = lamb.IsKosher;
                        dataGridViewMeat.Rows[row1].Cells["Name"].Value = lamb.Name;
                        dataGridViewMeat.Rows[row1].Cells["Price"].Value = lamb.Price;
                        dataGridViewMeat.Rows[row1].Cells["PurchaseDay"].Value = lamb.PurchaseDay;
                        dataGridViewMeat.Rows[row1].Cells["ShelfLife"].Value = lamb.ShelfLife;
                        dataGridViewMeat.Rows[row1].Cells["ID"].Value = lamb.Id;
                        dataGridViewMeat.Rows[row1].Cells["Weight"].Value = lamb.Weight;
                        dataGridViewMeat.Rows[row1].Cells["IsGrassFed"].Value = lamb.IsGrassFed;
                        dataGridViewMeat.Rows[row1].Cells["IsHalalCertified"].Value = lamb.IsHalalCertified;
                        PictureBox Lamb = new PictureBox();
                        Lamb.Image = Properties.Resources.Lamb;
                        Image originalImage2 = Lamb.Image;
                        Image resizedImage2 = new Bitmap(originalImage2, new Size(100, 50));
                        Lamb.Image = resizedImage2;
                        Lamb.SizeMode = PictureBoxSizeMode.AutoSize;
                        Lamb.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        Lamb.Cursor = Cursors.Hand;
                        Lamb.MouseDown += MouseDown;
                        Lamb.MouseMove += MouseMove;
                        Lamb.MouseUp += MouseUp;
                        Controls.Add(Lamb);
                        break;
                    case "Chicken":
                        Chicken chicken = null;
                        chicken = new Chicken(type, price, date, shelf, weight, fat, IsKosher,IsOrganicChicken , IsSkinlessChicken);
                        p.AddProduct(chicken);

                        int row2 = dataGridViewMeat.Rows.Add();
                        dataGridViewMeat.Rows[row2].Cells["Fat"].Value = chicken.FatPercentage;
                        dataGridViewMeat.Rows[row2].Cells["IsKosher"].Value = chicken.IsKosher;
                        dataGridViewMeat.Rows[row2].Cells["Name"].Value = chicken.Name;
                        dataGridViewMeat.Rows[row2].Cells["Price"].Value = chicken.Price;
                        dataGridViewMeat.Rows[row2].Cells["PurchaseDay"].Value = chicken.PurchaseDay;
                        dataGridViewMeat.Rows[row2].Cells["ShelfLife"].Value = chicken.ShelfLife;
                        dataGridViewMeat.Rows[row2].Cells["ID"].Value = chicken.Id;
                        dataGridViewMeat.Rows[row2].Cells["Weight"].Value = chicken.Weight;
                        dataGridViewMeat.Rows[row2].Cells["IsOrganic"].Value = chicken.IsOrganic;
                        dataGridViewMeat.Rows[row2].Cells["IsSkinless"].Value = chicken.IsSkinless;
                        PictureBox Chicken = new PictureBox();
                        Chicken.Image = Properties.Resources.Chicken;
                        Image originalImage3 = Chicken.Image;
                        Image resizedImage3 = new Bitmap(originalImage3, new Size(100, 100));
                        Chicken.Image = resizedImage3;
                        Chicken.SizeMode = PictureBoxSizeMode.AutoSize;
                        Chicken.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        Chicken.Cursor = Cursors.Hand;
                        Chicken.MouseDown += MouseDown;
                        Chicken.MouseMove += MouseMove;
                        Chicken.MouseUp += MouseUp;
                        Controls.Add(Chicken);
                        break;
                    case "Beef":
                        Beef beef = null;
                        beef = new Beef(type, price, date, shelf, weight, fat, IsKosher, IsGrassFedBeef, IsDryAgedBeef);
                        p.AddProduct(beef);

                        int row3 = dataGridViewMeat.Rows.Add();
                        dataGridViewMeat.Rows[row3].Cells["Fat"].Value = beef.FatPercentage;
                        dataGridViewMeat.Rows[row3].Cells["IsKosher"].Value = beef.IsKosher;
                        dataGridViewMeat.Rows[row3].Cells["Name"].Value = beef.Name;
                        dataGridViewMeat.Rows[row3].Cells["Price"].Value = beef.Price;
                        dataGridViewMeat.Rows[row3].Cells["PurchaseDay"].Value = beef.PurchaseDay;
                        dataGridViewMeat.Rows[row3].Cells["ShelfLife"].Value = beef.ShelfLife;
                        dataGridViewMeat.Rows[row3].Cells["ID"].Value = beef.Id;
                        dataGridViewMeat.Rows[row3].Cells["Weight"].Value = beef.Weight;
                        dataGridViewMeat.Rows[row3].Cells["IsGrassFed"].Value = beef.IsGrassFed;
                        dataGridViewMeat.Rows[row3].Cells["IsDryAged"].Value = beef.IsDryAged;
                        PictureBox Beef = new PictureBox();
                        Beef.Image = Properties.Resources.Beef;
                        Image originalImage4 = Beef.Image;
                        Image resizedImage4 = new Bitmap(originalImage4, new Size(75, 75));
                        Beef.Image = resizedImage4;
                        Beef.SizeMode = PictureBoxSizeMode.AutoSize;
                        Beef.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        Beef.Cursor = Cursors.Hand;
                        Beef.MouseDown += MouseDown;
                        Beef.MouseMove += MouseMove;
                        Beef.MouseUp += MouseUp;
                        Controls.Add(Beef);
                        break;
                }
                MessageBox.Show("The product has been successfully Added");
                ClearForm();
            }

            
        }
        private void VisibleandEnable(bool i, bool j)
        {
            Control[] VisibleandEnableControls = {textBoxPrice , dateTimeBuyingDate , txtShelfLife , txtFatPercentage , txtWeight , chkIsKosher };

            foreach (Control control in VisibleandEnableControls)
            {
                control.Visible = i;
                control.Enabled = j;
            }
        }
        private void VisibleandEnableBeef(bool i)
        {
            Control[] BeefControls = { chk_IsDryAgedBeef,chk_IsGrassFedBeef,lbl_IsDryAgedBeef,lbl_IsGrassFedBeef};

            foreach (Control control in BeefControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableChicken(bool i)
        {
            Control[] ChickenControls = {chkisOrganicChicken , chkisSkinlessChicken,lblisOrganicChicken,lblisSkinlessChicken };

            foreach (Control control in ChickenControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableLamb(bool i)
        {
            Control[] LambControls = {chkisGrassFedLamb,chkisHalalCertifiedLamb,lblisGrassFedLamb,lblisHalalCertifiedLamb};

            foreach (Control control in LambControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void VisibleandEnablePork(bool i)
        {
            Control[] PorkControls = {chkisMarinatedPork,chkisSmokedPork,lblisMarinatedPork,lblisSmokedPork};

            foreach (Control control in PorkControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }
        private void ClearForm()
        {

            ComboBox[] comboBoxes = { comboBoxType};
            TextBox[] textBoxes = { textBoxPrice, txtShelfLife, txtWeight ,txtFatPercentage};
            DateTimePicker[] dateTimePickers = { dateTimeBuyingDate };
            CheckBox[] checkboxes = { chkIsKosher , chk_IsGrassFedBeef , chk_IsDryAgedBeef , chkisMarinatedPork , chkisSmokedPork , chkisGrassFedLamb ,chkisHalalCertifiedLamb , chkisOrganicChicken , chkisSkinlessChicken };

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.ResetText();
            }
            comboBoxType.SelectedIndex = 0;
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
            VisibleandEnableBeef(false);
            VisibleandEnableChicken(false);
            VisibleandEnableLamb(false);
            VisibleandEnablePork(false);
            comboBoxType.SelectedItem = "Choose";
        }
        private void DisplayAllProductsInGrid(BindingList<Product> products)
        {
            dataGridViewMeat.Rows.Clear();

            foreach (Product product in products)
            {
                if (product.Name == "Lamb" || product.Name == "Chicken" || product.Name == "Pork" || product.Name == "Beef")
                {
                    int row = dataGridViewMeat.Rows.Add();

                    dataGridViewMeat.Rows[row].Cells["Name"].Value = product.Name;
                    dataGridViewMeat.Rows[row].Cells["Price"].Value = product.Price;
                    dataGridViewMeat.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                    dataGridViewMeat.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                    if (product is Lamb)
                    {
                        Lamb lamb = (Lamb)product;
                        dataGridViewMeat.Rows[row].Cells["Fat"].Value = lamb.FatPercentage;
                        dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = lamb.IsKosher;
                        dataGridViewMeat.Rows[row].Cells["ID"].Value = lamb.Id;
                        dataGridViewMeat.Rows[row].Cells["Weight"].Value = lamb.Weight;
                        dataGridViewMeat.Rows[row].Cells["IsGrassFed"].Value = lamb.IsGrassFed;
                        dataGridViewMeat.Rows[row].Cells["IsHalalCertified"].Value = lamb.IsHalalCertified;
                    }
                    else if (product is Chicken)
                    {
                        Chicken chicken = (Chicken)product;
                        dataGridViewMeat.Rows[row].Cells["Fat"].Value = chicken.FatPercentage;
                        dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = chicken.IsKosher;
                        dataGridViewMeat.Rows[row].Cells["ID"].Value = chicken.Id;
                        dataGridViewMeat.Rows[row].Cells["Weight"].Value = chicken.Weight;
                        dataGridViewMeat.Rows[row].Cells["IsOrganic"].Value = chicken.IsOrganic;
                        dataGridViewMeat.Rows[row].Cells["IsSkinless"].Value = chicken.IsSkinless;
                    }
                    else if (product is Pork)
                    {
                        Pork pork = (Pork)product;
                        dataGridViewMeat.Rows[row].Cells["Fat"].Value = pork.FatPercentage;
                        dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = pork.IsKosher;
                        dataGridViewMeat.Rows[row].Cells["ID"].Value = pork.Id;
                        dataGridViewMeat.Rows[row].Cells["Weight"].Value = pork.Weight;
                        dataGridViewMeat.Rows[row].Cells["IsMarinated"].Value = pork.IsMarinated;
                        dataGridViewMeat.Rows[row].Cells["IsSmoked"].Value = pork.IsSmoked;
                    }
                    else if (product is Beef)
                    {
                        Beef beef = (Beef)product;
                        dataGridViewMeat.Rows[row].Cells["Fat"].Value = beef.FatPercentage;
                        dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = beef.IsKosher;
                        dataGridViewMeat.Rows[row].Cells["ID"].Value = beef.Id;
                        dataGridViewMeat.Rows[row].Cells["Weight"].Value = beef.Weight;
                        dataGridViewMeat.Rows[row].Cells["IsGrassFed"].Value = beef.IsGrassFed;
                        dataGridViewMeat.Rows[row].Cells["IsDryAged"].Value = beef.IsDryAged;
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
            dataGridViewMeat.Rows.Clear();

            foreach (Product product in filteredProducts)
            {
                int row = dataGridViewMeat.Rows.Add();
                dataGridViewMeat.Rows[row].Cells["Name"].Value = product.Name;
                dataGridViewMeat.Rows[row].Cells["Price"].Value = product.Price;
                dataGridViewMeat.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                dataGridViewMeat.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;
                

                if (product is Lamb)
                {
                    Lamb lamb = (Lamb)product;
                    dataGridViewMeat.Rows[row].Cells["Fat"].Value = lamb.FatPercentage;
                    dataGridViewMeat.Rows[row].Cells["Weight"].Value = lamb.Weight;
                    dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = lamb.IsKosher;
                    dataGridViewMeat.Rows[row].Cells["ID"].Value = lamb.Id;
                    dataGridViewMeat.Rows[row].Cells["IsGrassFed"].Value = lamb.IsGrassFed;
                    dataGridViewMeat.Rows[row].Cells["IsHalalCertified"].Value = lamb.IsHalalCertified;
                }
                else if (product is Chicken)
                {
                    Chicken chicken = (Chicken)product;
                    dataGridViewMeat.Rows[row].Cells["Fat"].Value = chicken.FatPercentage;
                    dataGridViewMeat.Rows[row].Cells["Weight"].Value = chicken.Weight;
                    dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = chicken.IsKosher;
                    dataGridViewMeat.Rows[row].Cells["ID"].Value = chicken.Id;
                    dataGridViewMeat.Rows[row].Cells["IsOrganic"].Value = chicken.IsOrganic;
                    dataGridViewMeat.Rows[row].Cells["IsSkinless"].Value = chicken.IsSkinless;
                }
                else if (product is Pork)
                {
                    Pork pork = (Pork)product;
                    dataGridViewMeat.Rows[row].Cells["Fat"].Value = pork.FatPercentage;
                    dataGridViewMeat.Rows[row].Cells["Weight"].Value = pork.Weight;
                    dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = pork.IsKosher;
                    dataGridViewMeat.Rows[row].Cells["ID"].Value = pork.Id;
                    dataGridViewMeat.Rows[row].Cells["IsMarinated"].Value = pork.IsMarinated;
                    dataGridViewMeat.Rows[row].Cells["IsSmoked"].Value = pork.IsSmoked;
                }
                else if (product is Beef)
                {
                    Beef beef = (Beef)product;
                    dataGridViewMeat.Rows[row].Cells["Fat"].Value = beef.FatPercentage;
                    dataGridViewMeat.Rows[row].Cells["Weight"].Value = beef.Weight;
                    dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = beef.IsKosher;
                    dataGridViewMeat.Rows[row].Cells["ID"].Value = beef.Id;
                    dataGridViewMeat.Rows[row].Cells["IsGrassFed"].Value = beef.IsGrassFed;
                    dataGridViewMeat.Rows[row].Cells["IsDryAged"].Value = beef.IsDryAged;
                }
            }
        }
        private void regularAddToTable()
        {

            dataGridViewMeat.Columns.Add("ID", "ID");
            dataGridViewMeat.Columns.Add("Name", "Name");
            dataGridViewMeat.Columns.Add("Price", "Price");
            dataGridViewMeat.Columns.Add("PurchaseDay", "Purchase Day");
            dataGridViewMeat.Columns.Add("ShelfLife", "Shelf Life");
            dataGridViewMeat.Columns.Add("fat", "Fat");
            dataGridViewMeat.Columns.Add("isKosher", "Is Kosher");
            dataGridViewMeat.Columns.Add("Weight", "Weight");
            dataGridViewMeat.Columns.Add("IsMarinated", "Is Marinated");
            dataGridViewMeat.Columns.Add("IsSmoked", "Is Smoked");
            dataGridViewMeat.Columns.Add("IsGrassFed", "Is GrassFed");
            dataGridViewMeat.Columns.Add("IsDryAged", "Is Dry Aged");
            dataGridViewMeat.Columns.Add("IsOrganic", "Is Organic");
            dataGridViewMeat.Columns.Add("IsSkinless", "Is Skinless");
            dataGridViewMeat.Columns.Add("IsHalalCertified", "Is Halal Certified");
        }
        private void comboBoxType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (comboBoxType.SelectedItem.ToString() == "Choose")
            {
                BindingList<Product> products = p.GetProducts();
                DisplayAllProductsInGrid(products);
                VisibleandEnable(true, false);
                VisibleandEnableBeef(false);
                VisibleandEnableChicken(false);
                VisibleandEnableLamb(false);
                VisibleandEnablePork(false);
                buttonAdd.Enabled = false;
                buttonClear.Enabled = false;

            }
            else
            {
                buttonAdd.Enabled = true;
                buttonClear.Enabled = true;
            }
            if(comboBoxType.SelectedItem.ToString() == "Pork")
            {
                chkIsKosher.Enabled = false;
            }
            else
            {
                chkIsKosher.Enabled = true;
            }
            if (comboBoxType.SelectedItem.ToString() == "Pork")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnablePork(true);
                VisibleandEnableBeef(false);
                VisibleandEnableChicken(false);
                VisibleandEnableLamb(false);
                VisibleandEnable(true, true);

                lblisMarinatedPork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblisSmokedPork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
               
            }
            if (comboBoxType.SelectedItem.ToString() == "Beef")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableBeef(true);
                VisibleandEnablePork(false);
                VisibleandEnableChicken(false);
                VisibleandEnableLamb(false);

                lbl_IsDryAgedBeef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lbl_IsGrassFedBeef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }
            if (comboBoxType.SelectedItem.ToString() == "Chicken")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableChicken(true);
                VisibleandEnableBeef(false);
                VisibleandEnablePork(false);
                VisibleandEnableLamb(false);

                lblisOrganicChicken.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblisSkinlessChicken.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }
            if (comboBoxType.SelectedItem.ToString() == "Lamb")
            {
                string selectedProduct = comboBoxType.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableLamb(true);
                VisibleandEnableChicken(false);
                VisibleandEnableBeef(false);
                VisibleandEnablePork(false);
               
                lblisGrassFedLamb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblisHalalCertifiedLamb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
                    throw new Exception("Invalid Buying Date value");
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
                if (!Validator.ValidateValue(txtFatPercentage.Text, typeof(double)))
                    throw new Exception("Invalid Fat Percentage value");
                double Fat;
                if (double.TryParse(txtFatPercentage.Text, out Fat))
                {
                    if (Fat <= 0 || Fat > 100)
                    {
                        throw new Exception("Invalid Fat value");
                    }
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
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
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

        private void btnPrintInfo_Click_1(object sender, EventArgs e)
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
            foreach (DataGridViewRow row in dataGridViewMeat.Rows)
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
            foreach (DataGridViewRow row in dataGridViewMeat.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == idToRemove.ToString())
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                dataGridViewMeat.Rows.RemoveAt(rowIndex);
                p.RemoveProductById(idToRemove);
                MessageBox.Show("The product has been successfully deleted");
            }
        }
        private void DisplayIDInGrid(Product pro, int ID)
        {
            dataGridViewMeat.Rows.Clear();

            if (pro.Id == ID)
            {
                int row = dataGridViewMeat.Rows.Add();
                dataGridViewMeat.Rows[row].Cells["Name"].Value = pro.Name;
                dataGridViewMeat.Rows[row].Cells["Price"].Value = pro.Price;
                dataGridViewMeat.Rows[row].Cells["PurchaseDay"].Value = pro.PurchaseDay;
                dataGridViewMeat.Rows[row].Cells["ShelfLife"].Value = pro.ShelfLife;

                if (pro is Lamb)
                {
                    Lamb lamb = (Lamb)pro;
                    dataGridViewMeat.Rows[row].Cells["Fat"].Value = lamb.FatPercentage;
                    dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = lamb.IsKosher;
                    dataGridViewMeat.Rows[row].Cells["ID"].Value = lamb.Id;
                    dataGridViewMeat.Rows[row].Cells["Weight"].Value = lamb.Weight;
                    dataGridViewMeat.Rows[row].Cells["IsGrassFed"].Value = lamb.IsGrassFed;
                    dataGridViewMeat.Rows[row].Cells["IsHalalCertified"].Value = lamb.IsHalalCertified;
                }
                else if (pro is Chicken)
                {
                    Chicken chicken = (Chicken)pro;
                    dataGridViewMeat.Rows[row].Cells["Fat"].Value = chicken.FatPercentage;
                    dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = chicken.IsKosher;
                    dataGridViewMeat.Rows[row].Cells["ID"].Value = chicken.Id;
                    dataGridViewMeat.Rows[row].Cells["Weight"].Value = chicken.Weight;
                    dataGridViewMeat.Rows[row].Cells["IsOrganic"].Value = chicken.IsOrganic;
                    dataGridViewMeat.Rows[row].Cells["IsSkinless"].Value = chicken.IsSkinless;
                }
                else if (pro is Pork)
                {
                    Pork pork = (Pork)pro;
                    dataGridViewMeat.Rows[row].Cells["Fat"].Value = pork.FatPercentage;
                    dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = pork.IsKosher;
                    dataGridViewMeat.Rows[row].Cells["ID"].Value = pork.Id;
                    dataGridViewMeat.Rows[row].Cells["Weight"].Value = pork.Weight;
                    dataGridViewMeat.Rows[row].Cells["IsMarinated"].Value = pork.IsMarinated;
                    dataGridViewMeat.Rows[row].Cells["IsSmoked"].Value = pork.IsSmoked;
                }
                else if (pro is Beef)
                {
                    Beef beef = (Beef)pro;
                    dataGridViewMeat.Rows[row].Cells["Fat"].Value = beef.FatPercentage;
                    dataGridViewMeat.Rows[row].Cells["IsKosher"].Value = beef.IsKosher;
                    dataGridViewMeat.Rows[row].Cells["ID"].Value = beef.Id;
                    dataGridViewMeat.Rows[row].Cells["Weight"].Value = beef.Weight;
                    dataGridViewMeat.Rows[row].Cells["IsGrassFed"].Value = beef.IsGrassFed;
                    dataGridViewMeat.Rows[row].Cells["IsDryAged"].Value = beef.IsDryAged;
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
            string idInput = ShowInputDialog("Update", "Enter ID:");
            txtID.Text = idInput;
            if (string.IsNullOrEmpty(idInput))
            {
                MessageBox.Show("Please enter ID");
                comboBoxType.DataSource = Enum.GetValues(typeof(eMeatType));
 
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
                comboBoxType.DataSource = Enum.GetValues(typeof(eMeatType));
                btnRemove.Enabled = true;
                buttonClear.Enabled = true;
                comboBoxType.Enabled = true;
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
            DisplayIDInGrid(productToUpdate, idToUpdate);
            if (productToUpdate == null)
            {
                MessageBox.Show("The ID does not exist");
                comboBoxType.DataSource = Enum.GetValues(typeof(eMeatType));
                comboBoxType.Enabled = true;
                btnRemove.Enabled = true;
                buttonClear.Enabled = true;
                btnUpdate.Enabled = false;
                btnUpdate.Visible = false;
                txtID.Visible = false;
                ClearForm();
                return;
            }

            if (productToUpdate.Name == "Beef")
            {
                comboBoxType.SelectedIndex = 1;
            }
            else if (productToUpdate.Name == "Chicken")
            {
                comboBoxType.SelectedIndex = 2;
            }
            else if (productToUpdate.Name == "Pork")
            {
                comboBoxType.SelectedIndex = 3;
            }
            else if (productToUpdate.Name == "Lamb")
            {
                comboBoxType.SelectedIndex = 4;
            }
            comboBoxType.Enabled = false;

            // Update the fields based on the selected product type
            switch (productToUpdate)
            {
                case Pork pork:
                    txtFatPercentage.Text = pork.FatPercentage.ToString();
                    chkIsKosher.Checked = pork.IsKosher;
                    chkisMarinatedPork.Checked = pork.IsMarinated;
                    chkisSmokedPork.Checked= pork.IsSmoked;
                    txtWeight.Text= pork.Weight.ToString();
                    break;
                case Lamb lamb:
                    txtFatPercentage.Text = lamb.FatPercentage.ToString();
                    chkIsKosher.Checked = lamb.IsKosher;
                    chkisGrassFedLamb.Checked = lamb.IsGrassFed;
                    chkisHalalCertifiedLamb.Checked = lamb.IsHalalCertified;
                    txtWeight.Text = lamb.Weight.ToString();
                    break;
                case Chicken chicken:
                    txtFatPercentage.Text = chicken.FatPercentage.ToString();
                    chkIsKosher.Checked = chicken.IsKosher;
                    chkisOrganicChicken.Checked = chicken.IsOrganic;
                    chkisSkinlessChicken.Checked = chicken.IsSkinless;
                    txtWeight.Text = chicken.Weight.ToString();
                    break;
                case Beef beef:
                    txtFatPercentage.Text = beef.FatPercentage.ToString();
                    chkIsKosher.Checked = beef.IsKosher;
                    chk_IsDryAgedBeef.Checked = beef.IsDryAged;
                    chk_IsGrassFedBeef.Checked = beef.IsGrassFed;
                    txtWeight.Text = beef.Weight.ToString();
                    break;
                default:
                    // Handle default case
                    break;
            }

            // Update other fields
            textBoxPrice.Text = productToUpdate.Price.ToString();
            dateTimeBuyingDate.Value = productToUpdate.PurchaseDay;
            txtShelfLife.Text = productToUpdate.ShelfLife.ToString();
            txtWeight.Text = productToUpdate.Weight.ToString();

            MessageBox.Show("When you finish- click on update");
            buttonAdd.Enabled = false;
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
                comboBoxType.DataSource = Enum.GetValues(typeof(eMeatType));
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
                //If the ID type is not an integer - handle the case of an error here
                MessageBox.Show("Invalid ID");
                comboBoxType.DataSource = Enum.GetValues(typeof(eMeatType));
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
                double weight = double.Parse(txtWeight.Text);
                double fat = double.Parse(txtFatPercentage.Text);
                bool isKosher = chkIsKosher.Checked;
                bool isSmokedPork = chkisSmokedPork.Checked;
                bool isMarinatedPork = chkisMarinatedPork.Checked;
                bool isGrassFedLamb = chkisGrassFedLamb.Checked;
                bool isHalalCertifiedLamb = chkisHalalCertifiedLamb.Checked;
                bool isOrganicChicken = chkisOrganicChicken.Checked;
                bool isSkinlessChicken = chkisSkinlessChicken.Checked;
                bool IsDryAgedBeef = chk_IsDryAgedBeef.Checked;
                bool IsGrassFedBeef = chk_IsGrassFedBeef.Checked;



                productToUpdate.Price = price;
                productToUpdate.PurchaseDay = date;
                productToUpdate.ShelfLife = shelf;
                productToUpdate.Weight = weight;
                if (comboBoxType.SelectedItem.ToString() == "Pork")
                {
                    Pork pork = productToUpdate as Pork;
                    pork.FatPercentage = fat;
                    pork.IsKosher = isKosher;
                    pork.IsSmoked = isSmokedPork;
                    pork.IsMarinated = isMarinatedPork;
                }
                else if (comboBoxType.SelectedItem.ToString() == "Lamb")
                {
                    Lamb lamb = productToUpdate as Lamb;
                    lamb.FatPercentage = fat;
                    lamb.IsKosher = isKosher;
                    lamb.IsGrassFed = isGrassFedLamb;
                    lamb.IsHalalCertified = isHalalCertifiedLamb;

                }
                else if (comboBoxType.SelectedItem.ToString() == "Chicken")
                {
                    Chicken chicken = productToUpdate as Chicken;
                    chicken.FatPercentage = fat;
                    chicken.IsKosher = isKosher;
                    chicken.IsOrganic = isSkinlessChicken;
                    chicken.IsSkinless = isSkinlessChicken;

                }
                else if (comboBoxType.SelectedItem.ToString() == "Beef")
                {
                    Beef beef = productToUpdate as Beef;
                    beef.FatPercentage = fat;
                    beef.IsKosher = isKosher;
                    beef.IsDryAged = IsDryAgedBeef;
                    beef.IsGrassFed = IsGrassFedBeef;

                }
            }
            MessageBox.Show("The product has been successfully updated");
            return 1;
        }
    }
}
