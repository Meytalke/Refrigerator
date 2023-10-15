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

namespace Refrigerator_FinalProj.Frontend.UserControls.DairyProduct
{
    public partial class DairyProduct : UserControl
    {
        ProductsManager p;

        public ProductsManager P { get => p; }
        public DairyProduct()
        {
            InitializeComponent();
            p = new ProductsManager();
            comboBoxherbLabneh.DataSource = Enum.GetValues(typeof(Enums_Collections.eHerbType));
            comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eDairyType));
            comboBoxoriginCheese.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheeseOrigin));
            string[] DairyProducts = { "Butter", "Yogurt", "Cottage","Labneh","Mozzarella","BlueCheese"};
            AddProductImages(0, DairyProducts);
            regularAddToTable();
        }
        private Image GetProductImage(string productName)
        {
            switch (productName)
            {
                case "Butter":
                    return Properties.Resources.butter1;
                case "Yogurt":
                    return Properties.Resources.Yogurt1;
                case "Cottage":
                    return Properties.Resources.Cottage1;
                case "Labneh":
                    return Properties.Resources.Labneh1;
                case "Mozzarella":
                    return Properties.Resources.Mozzarella1;
                case "BlueCheese":
                    return Properties.Resources.BlueCheese1;
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

                    // Location decision for each product using switch
                    switch (productName)
                    {
                        case "Butter":
                            pictureBox.Location = new Point(x, y);
                            break;
                        case "Yogurt":
                            pictureBox.Location = new Point(x + 100, y);
                            break;
                        case "Cottage":
                            pictureBox.Location = new Point(x + 200, y);
                            break;
                        case "Labneh":
                            pictureBox.Location = new Point(x + 300, y);
                            break;
                        case "Mozzarella":
                            pictureBox.Location = new Point(x + 400, y);
                            break;
                        case "BlueCheese":
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
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxType.SelectedItem.ToString() == "Choose")
            {
                BindingList<Product> products = p.GetProducts();
                DisplayAllProductsInGrid(products);
                VisibleandEnable(true, false);
                VisibleandEnableCheese(false, false);
                VisibleandEnableButter(false);
                VisibleandEnableYogurt(false);
                VisibleandEnableBlueCheese(false);
                VisibleandEnableCottageCheese(false);
                VisibleandEnableLabnehCheese(false);
                VisibleandEnableMozzarellaCheese(false);
                comboBoxName.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheese));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyCheese));
                comboBoxoriginCheese.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheeseOrigin));
                buttonAdd.Enabled = false;
                buttonClear.Enabled = false;
            }
            if (comboBoxType.SelectedIndex == 1)
            {
                VisibleandEnableButter(false);
                VisibleandEnableCheese(true, false);
                VisibleandEnableYogurt(false);
                VisibleandEnableBlueCheese(false);
                VisibleandEnableCottageCheese(false);
                VisibleandEnableLabnehCheese(false);
                VisibleandEnableMozzarellaCheese(false);
                comboBoxName.Enabled = true;
                comboBoxName.Enabled = true;
                comboBoxName.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheese));

                lbloriginCheese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblFatCheese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            if (comboBoxType.SelectedItem.ToString() == "Other")
            {
                VisibleandEnableButter(false);
                VisibleandEnableCheese(false, false);
                VisibleandEnableYogurt(false);
                VisibleandEnableBlueCheese(false);
                VisibleandEnableCottageCheese(false);
                VisibleandEnableLabnehCheese(false);
                VisibleandEnableMozzarellaCheese(false);
                comboBoxName.Enabled = true;
                comboBoxName.DataSource = Enum.GetValues(typeof(Enums_Collections.eOtherDairy));
            }
            //ClearForm();
            buttonAdd.Enabled = false;
            buttonClear.Enabled = false;
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayAllProductsInGrid(BindingList<Product> products)
        {
            dataGridViewDairyProduct.Rows.Clear();

            foreach (Product product in products)
            {
                if (product.Name == "Yogurt" || product.Name == "Butter" || product.Name == "BlueCheese" || product.Name == "Cottage" || product.Name == "Labneh" || product.Name == "Mozzarella")
                {
                    int row = dataGridViewDairyProduct.Rows.Add();
                    dataGridViewDairyProduct.Rows[row].Cells["Name"].Value = product.Name;
                    dataGridViewDairyProduct.Rows[row].Cells["Price"].Value = product.Price;
                    dataGridViewDairyProduct.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                    dataGridViewDairyProduct.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                    if (product is Yogurt)
                    {
                        Yogurt yogurt = (Yogurt)product;
                        dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = yogurt.Id;
                        dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = yogurt.Brand;
                        dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = yogurt.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = yogurt.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Flavor"].Value = yogurt.Flavor;
                        dataGridViewDairyProduct.Rows[row].Cells["IsGreekYogurt"].Value = yogurt.IsGreekYogurt;
                    }
                    else if (product is Butter)
                    {
                        Butter butter = (Butter)product;
                        dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = butter.Id;
                        dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = butter.Brand;
                        dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = butter.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = butter.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = butter.FatPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["IsSalted"].Value = butter.IsSalted;
                    }
                    else if (product is BlueCheese)
                    {
                        BlueCheese blueCheese = (BlueCheese)product;
                        dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = blueCheese.Origin;
                        dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = blueCheese.FatPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = blueCheese.Id;
                        dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = blueCheese.Brand;
                        dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = blueCheese.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = blueCheese.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = blueCheese.FatPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = blueCheese.Origin;
                        dataGridViewDairyProduct.Rows[row].Cells["AgingTime"].Value = blueCheese.AgingTime;
                        dataGridViewDairyProduct.Rows[row].Cells["HasMold"].Value = blueCheese.HasMold;
                    }
                    else if (product is CottageCheese)
                    {
                        CottageCheese cottageCheese = (CottageCheese)product;
                        dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = cottageCheese.Id;
                        dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = cottageCheese.Brand;
                        dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = cottageCheese.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = cottageCheese.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = cottageCheese.FatPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = cottageCheese.Origin;
                        dataGridViewDairyProduct.Rows[row].Cells["IsCreamy"].Value = cottageCheese.IsCreamy;
                        dataGridViewDairyProduct.Rows[row].Cells["HasCurds"].Value = cottageCheese.HasCurds;
                    }
                    else if (product is LabnehCheese)
                    {
                        LabnehCheese labnehCheese = (LabnehCheese)product;
                        dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = labnehCheese.Id;
                        dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = labnehCheese.Brand;
                        dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = labnehCheese.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = labnehCheese.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = labnehCheese.FatPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = labnehCheese.Origin;
                        dataGridViewDairyProduct.Rows[row].Cells["IsStrained"].Value = labnehCheese.IsStrained;
                        dataGridViewDairyProduct.Rows[row].Cells["Herb"].Value = labnehCheese.Herb;
                    }
                    else if (product is MozzarellaCheese)
                    {
                        MozzarellaCheese mozzarellaCheese = (MozzarellaCheese)product;
                        dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = mozzarellaCheese.Id;
                        dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = mozzarellaCheese.Brand;
                        dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = mozzarellaCheese.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = mozzarellaCheese.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = mozzarellaCheese.FatPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = mozzarellaCheese.Origin;
                        dataGridViewDairyProduct.Rows[row].Cells["IsFresh"].Value = mozzarellaCheese.IsFresh;
                        dataGridViewDairyProduct.Rows[row].Cells["IsStretchy"].Value = mozzarellaCheese.IsStretchy;
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
            dataGridViewDairyProduct.Rows.Clear();

            foreach (Product product in filteredProducts)
            {
                int row = dataGridViewDairyProduct.Rows.Add();
                dataGridViewDairyProduct.Rows[row].Cells["Name"].Value = product.Name;
                dataGridViewDairyProduct.Rows[row].Cells["Price"].Value = product.Price;
                dataGridViewDairyProduct.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                dataGridViewDairyProduct.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                if (product is Yogurt)
                {
                    Yogurt yogurt = (Yogurt)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = yogurt.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = yogurt.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = yogurt.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = yogurt.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Flavor"].Value = yogurt.Flavor;
                    dataGridViewDairyProduct.Rows[row].Cells["IsGreekYogurt"].Value = yogurt.IsGreekYogurt;
                }
                else if (product is Butter)
                {
                    Butter butter = (Butter)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = butter.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = butter.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = butter.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = butter.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = butter.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["IsSalted"].Value = butter.IsSalted;
                }
                else if (product is BlueCheese)
                {
                    BlueCheese blueCheese = (BlueCheese)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = blueCheese.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = blueCheese.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = blueCheese.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = blueCheese.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = blueCheese.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = blueCheese.Origin;
                    dataGridViewDairyProduct.Rows[row].Cells["AgingTime"].Value = blueCheese.AgingTime;
                    dataGridViewDairyProduct.Rows[row].Cells["HasMold"].Value = blueCheese.HasMold;
                }
                else if (product is CottageCheese)
                {
                    CottageCheese cottageCheese = (CottageCheese)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = cottageCheese.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = cottageCheese.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = cottageCheese.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = cottageCheese.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = cottageCheese.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = cottageCheese.Origin;
                    dataGridViewDairyProduct.Rows[row].Cells["IsCreamy"].Value = cottageCheese.IsCreamy;
                    dataGridViewDairyProduct.Rows[row].Cells["HasCurds"].Value = cottageCheese.HasCurds;
                }
                else if (product is LabnehCheese)
                {
                    LabnehCheese labnehCheese = (LabnehCheese)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = labnehCheese.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = labnehCheese.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = labnehCheese.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = labnehCheese.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = labnehCheese.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = labnehCheese.Origin;
                    dataGridViewDairyProduct.Rows[row].Cells["IsStrained"].Value = labnehCheese.IsStrained;
                    dataGridViewDairyProduct.Rows[row].Cells["Herb"].Value = labnehCheese.Herb;
                }
                else if (product is MozzarellaCheese)
                {
                    MozzarellaCheese mozzarellaCheese = (MozzarellaCheese)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = mozzarellaCheese.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = mozzarellaCheese.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = mozzarellaCheese.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = mozzarellaCheese.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = mozzarellaCheese.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = mozzarellaCheese.Origin;
                    dataGridViewDairyProduct.Rows[row].Cells["IsFresh"].Value = mozzarellaCheese.IsFresh;
                    dataGridViewDairyProduct.Rows[row].Cells["IsStretchy"].Value = mozzarellaCheese.IsStretchy;
                }
            }
        }
        private void regularAddToTable()
        {

            dataGridViewDairyProduct.Columns.Add("ID", "ID");
            dataGridViewDairyProduct.Columns.Add("Name", "Name");
            dataGridViewDairyProduct.Columns.Add("Price", "Price");
            dataGridViewDairyProduct.Columns.Add("PurchaseDay", "Purchase Day");
            dataGridViewDairyProduct.Columns.Add("ShelfLife", "Shelf Life");
            dataGridViewDairyProduct.Columns.Add("Calories", "Calories");
            dataGridViewDairyProduct.Columns.Add("Lactose", "Lactose");
            dataGridViewDairyProduct.Columns.Add("Brand", "Brand");
            dataGridViewDairyProduct.Columns.Add("IsSalted", "Is Salted");
            dataGridViewDairyProduct.Columns.Add("Fat", "Fat");
            dataGridViewDairyProduct.Columns.Add("Flavor", "Flavor");
            dataGridViewDairyProduct.Columns.Add("IsGreekYogurt", "Is Greek Yogurt");
            dataGridViewDairyProduct.Columns.Add("Origin", "Origin");
            dataGridViewDairyProduct.Columns.Add("IsCreamy", "Is Creamy");
            dataGridViewDairyProduct.Columns.Add("HasCurds", "HasCurds");
            dataGridViewDairyProduct.Columns.Add("IsStrained", "Is Strained");
            dataGridViewDairyProduct.Columns.Add("Herb", "Herb");
            dataGridViewDairyProduct.Columns.Add("IsStretchy", "Is Stretchy");
            dataGridViewDairyProduct.Columns.Add("IsFresh", "Is Fresh");
            dataGridViewDairyProduct.Columns.Add("HasMold", "Has Mold");
            dataGridViewDairyProduct.Columns.Add("AgingTime", "Aging Time");
        }
        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 1 && comboBoxName.SelectedIndex == 0)
            {
                VisibleandEnable(true, false);
                VisibleandEnableCheese(true, false);
                comboBoxName.Enabled = true;
                VisibleandEnableButter(false);
                VisibleandEnableYogurt(false);
                VisibleandEnableBlueCheese(false);
                VisibleandEnableCottageCheese(false);
                VisibleandEnableLabnehCheese(false);
                VisibleandEnableMozzarellaCheese(false);
                comboBoxName.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheese));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyCheese));
                comboBoxoriginCheese.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheeseOrigin));
                buttonAdd.Enabled = false;
                buttonClear.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
                buttonClear.Enabled = true;
            }
            if (comboBoxName.SelectedItem.ToString() == "Butter")
            {
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyButter));
                string selectedProduct = comboBoxName.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnable(true, true);
                VisibleandEnableCheese(false, false);
                VisibleandEnableButter(true);
                VisibleandEnableYogurt(false);
                VisibleandEnableBlueCheese(false);
                VisibleandEnableCottageCheese(false);
                VisibleandEnableLabnehCheese(false);
                VisibleandEnableMozzarellaCheese(false);


                lblFatButter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblisSaltedButter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;          
                DisplayProductsInGrid(filteredProducts);
            }
            else if (comboBoxName.SelectedItem.ToString() == "Yogurt")
            {
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyYogurt));
                comboBoxflavorYogurt.DataSource = Enum.GetValues(typeof(Enums_Collections.eFlavorYogurt));
                string selectedProduct = comboBoxName.SelectedItem.ToString();
                List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                VisibleandEnableCheese(false, false);
                VisibleandEnable(true, true);
                VisibleandEnableButter(false);
                VisibleandEnableYogurt(true);
                VisibleandEnableBlueCheese(false);
                VisibleandEnableCottageCheese(false);
                VisibleandEnableLabnehCheese(false);
                VisibleandEnableMozzarellaCheese(false);

                lblflavorYogurt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lblisGreekYogurt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                DisplayProductsInGrid(filteredProducts);
            }

            else if (comboBoxType.SelectedItem.ToString() == "Cheese")
            {
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyCheese));
                if (comboBoxName.SelectedItem.ToString() == "Cottage")
                {
                    string selectedProduct = comboBoxName.SelectedItem.ToString();
                    List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                    VisibleandEnableCheese(true, true);
                    VisibleandEnable(true, true);
                    VisibleandEnableButter(false);
                    VisibleandEnableYogurt(false);
                    VisibleandEnableBlueCheese(false);
                    VisibleandEnableCottageCheese(true);
                    VisibleandEnableLabnehCheese(false);
                    VisibleandEnableMozzarellaCheese(false);

                    lblhasCurdsCottage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lblisCreamyCottage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    DisplayProductsInGrid(filteredProducts);
                }
                else if (comboBoxName.SelectedItem.ToString() == "Labneh")
                {

                    string selectedProduct = comboBoxName.SelectedItem.ToString();
                    List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                    VisibleandEnableCheese(true, true);
                    VisibleandEnable(true, true);
                    VisibleandEnableButter(false);
                    VisibleandEnableYogurt(false);
                    VisibleandEnableBlueCheese(false);
                    VisibleandEnableCottageCheese(false);
                    VisibleandEnableLabnehCheese(true);
                    VisibleandEnableMozzarellaCheese(false);

                    lblherbLabneh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lblisStrainedLabneh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    DisplayProductsInGrid(filteredProducts);
                }
                else if (comboBoxName.SelectedItem.ToString() == "Mozzarella")
                {
                    string selectedProduct = comboBoxName.SelectedItem.ToString();
                    List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                    VisibleandEnableCheese(true, true);
                    VisibleandEnable(true, true);
                    VisibleandEnableButter(false);
                    VisibleandEnableYogurt(false);
                    VisibleandEnableBlueCheese(false);
                    VisibleandEnableCottageCheese(false);
                    VisibleandEnableLabnehCheese(false);
                    VisibleandEnableMozzarellaCheese(true);

                    lblisFreshMozzarella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lblisStretchyisMozzarella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    DisplayProductsInGrid(filteredProducts);
                }
                if (comboBoxName.SelectedItem.ToString() == "BlueCheese")
                {
                    string selectedProduct = comboBoxName.SelectedItem.ToString();
                    List<Product> filteredProducts = GetFilteredProducts(selectedProduct);
                    VisibleandEnableCheese(true, true);
                    VisibleandEnable(true, true);
                    VisibleandEnableButter(false);
                    VisibleandEnableYogurt(false);
                    VisibleandEnableBlueCheese(true);
                    VisibleandEnableCottageCheese(false);
                    VisibleandEnableLabnehCheese(false);
                    VisibleandEnableMozzarellaCheese(false);

                    lblAgingTimeBlueCheese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lblhasMoldBlueCheese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    DisplayProductsInGrid(filteredProducts);
                }
            }

        }
        private void ClearForm()
        {
            ComboBox[] comboBoxes = { comboBoxoriginCheese, comboBoxType, comboBoxBrand, comboBoxName, comboBoxflavorYogurt, comboBoxherbLabneh };
            TextBox[] textBoxes = { txtFatCheese, textBoxPrice, txtShelfLife, txtCaloriesPercentage, txtFatButter, txtlactosPercentage };
            DateTimePicker[] dateTimePickers = { dateTimeBuyingDate };
            CheckBox[] checkboxes = { chkasMoldBlueCheese, chkhasCurdsCottage, chkisCreamyCottage, chkisFreshMozzarella, chkisGreekYogurt, chkisSaltedButter, chkisStrainedLabneh, chkisStretchyisMozzarella };

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
            if (comboBoxName.SelectedIndex == 1)
            {
                comboBoxoriginCheese.SelectedIndex = 0;
            }
            if (comboBoxName.SelectedIndex == 1 && comboBoxType.SelectedIndex == 1)
            {
                comboBoxherbLabneh.SelectedIndex = 0;
            }
            if (comboBoxName.SelectedIndex == 2 && comboBoxType.SelectedIndex == 2)
            {
                comboBoxflavorYogurt.SelectedIndex = 0;
            }
            comboBoxType.SelectedIndex = 0;
            if (comboBoxName.SelectedIndex != 0)
            {
                comboBoxName.SelectedIndex = 0;
            }

            comboBoxBrand.SelectedIndex = 0;
            VisibleandEnableCheese(false, false);
            VisibleandEnable(true, false);
            VisibleandEnableButter(false);
            VisibleandEnableYogurt(false);
            VisibleandEnableBlueCheese(false);
            VisibleandEnableCottageCheese(false);
            VisibleandEnableLabnehCheese(false);
            VisibleandEnableMozzarellaCheese(false);
        }
        private void VisibleandEnableCheese(bool i, bool j)
        {
            Control[] CheeseControls = { lbloriginCheese, comboBoxoriginCheese, txtFatCheese, lblFatCheese };

            foreach (Control control in CheeseControls)
            {
                control.Visible = i;
                control.Enabled = j;
            }
        }
        private void VisibleandEnable(bool i, bool j)
        {
            Control[] VisibleandEnableControls = { comboBoxName, textBoxPrice, dateTimeBuyingDate, txtShelfLife, txtCaloriesPercentage, txtlactosPercentage, comboBoxBrand };
            foreach (Control control in VisibleandEnableControls)
            {
                control.Visible = i;
                control.Enabled = j;
            }
        }

        private void VisibleandEnableButter(bool i)
        {
            Control[] ButterControls = { chkisSaltedButter, lblFatButter, lblisSaltedButter, txtFatButter };

            foreach (Control control in ButterControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableYogurt(bool i)
        {
            Control[] YogurtrControls = { chkisGreekYogurt, comboBoxflavorYogurt, lblflavorYogurt, lblisGreekYogurt };

            foreach (Control control in YogurtrControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableBlueCheese(bool i)
        {
            Control[] BlueCheeseControls = { chkasMoldBlueCheese, lblAgingTimeBlueCheese, lblhasMoldBlueCheese, txtAgingTimeBlueCheese };

            foreach (Control control in BlueCheeseControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableCottageCheese(bool i)
        {
            Control[] CottageCheeseControls = { chkhasCurdsCottage, chkisCreamyCottage, lblhasCurdsCottage, lblisCreamyCottage };

            foreach (Control control in CottageCheeseControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableLabnehCheese(bool i)
        {
            Control[] LabnehCheeseControls = { chkisStrainedLabneh, lblherbLabneh, lblisStrainedLabneh, comboBoxherbLabneh };

            foreach (Control control in LabnehCheeseControls)
            {
                control.Visible = i;
                control.Enabled = i;
            }
        }

        private void VisibleandEnableMozzarellaCheese(bool i)
        {
            Control[] MozzarellaCheeseControls = { chkisFreshMozzarella, chkisStretchyisMozzarella, lblisFreshMozzarella, lblisStretchyisMozzarella };

            foreach (Control control in MozzarellaCheeseControls)
            {
                control.Visible = i;
                control.Enabled = i;
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
                if (!Validator.ValidateValue(txtCaloriesPercentage.Text, typeof(double)))
                    throw new Exception("Invalid Calories value");
                double Calories;
                if (double.TryParse(textBoxPrice.Text, out Calories))
                {
                    if (price <= 0)
                    {
                        throw new Exception("Invalid Calories value");
                    }
                }
                if (!Validator.ValidateValue(txtlactosPercentage.Text, typeof(double)))
                    throw new Exception("Invalid lactos value");
                double lactos;
                if (double.TryParse(txtlactosPercentage.Text, out lactos))
                {
                    if (lactos <= 0 || lactos > 100)
                    {
                        throw new Exception("Invalid lactos value");
                    }
                }
                if (comboBoxType.SelectedIndex == 1)
                {

                    if (comboBoxBrand.SelectedIndex == 0)
                    {
                        throw new Exception("Please choose Brand");
                    }
                    if (comboBoxoriginCheese.SelectedIndex == 0)
                    {
                        throw new Exception("Please choose origin");
                    }

                    if (!Validator.ValidateValue(txtFatCheese.Text, typeof(double)))
                    {
                        throw new Exception("Invalid fat value");
                    }
                    double fat;
                    if (double.TryParse(txtFatCheese.Text, out fat))
                    {
                        if (fat <= 0 || fat > 100)
                        {
                            throw new Exception("Invalid fat value");
                        }
                    }
                    if (comboBoxName.SelectedIndex == 1 && comboBoxherbLabneh.SelectedIndex == 0)
                    {
                        throw new Exception("Please choose herb");
                    }
                    if (comboBoxName.SelectedIndex == 4 && !Validator.ValidateValue(txtAgingTimeBlueCheese.Text, typeof(int)))
                    {
                        throw new Exception("Invalid Aging Time value");
                    }
                }
                if (comboBoxType.SelectedIndex == 2)
                {
                    if (comboBoxBrand.SelectedIndex == 0)
                    {
                        throw new Exception("Please choose Brand");
                    }
                    if (!Validator.ValidateValue(txtFatButter.Text, typeof(double)) && comboBoxName.SelectedIndex == 1)
                    {
                        throw new Exception("Invalid fat value");
                    }
                    double fat;
                    if (double.TryParse(txtlactosPercentage.Text, out fat))
                    {
                        if (fat <= 0 || fat > 100)
                        {
                            throw new Exception("Invalid fat value");
                        }
                    }
                    if (comboBoxName.SelectedIndex == 2 && comboBoxflavorYogurt.SelectedIndex == 0)
                    {
                        throw new Exception("Please choose flavor");
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
                PictureBox DairyProduct = (PictureBox)sender;
                DairyProduct.Left += e.X - startPosition.X;
                DairyProduct.Top += e.Y - startPosition.Y;
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
                int rowCount = dataGridViewDairyProduct.Rows.Count;

                string type = comboBoxType.Text;
                string name = comboBoxName.Text;
                double price = double.Parse(textBoxPrice.Text);
                DateTime date = dateTimeBuyingDate.Value;
                int shelf = int.Parse(txtShelfLife.Text);
                double Calories = double.Parse(txtCaloriesPercentage.Text);
                double lactos = double.Parse(txtlactosPercentage.Text);
                string Brand = comboBoxBrand.Text;
                
                switch (comboBoxName.SelectedItem.ToString())
                {

                    case "Butter":
                        double FatButter = double.Parse(txtFatButter.Text);
                        bool IsSaltedButter = chkisSaltedButter.Checked;
                        Butter butter = null;
                        butter = new Butter(name, price, date, shelf, Calories, lactos, Brand, IsSaltedButter, FatButter);
                        p.AddProduct(butter);
                        int row = dataGridViewDairyProduct.Rows.Add();
                        dataGridViewDairyProduct.Rows[row].Cells["Name"].Value = butter.Name;
                        dataGridViewDairyProduct.Rows[row].Cells["Price"].Value = butter.Price;
                        dataGridViewDairyProduct.Rows[row].Cells["PurchaseDay"].Value = butter.PurchaseDay;
                        dataGridViewDairyProduct.Rows[row].Cells["ShelfLife"].Value = butter.ShelfLife;
                        dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = butter.Id;
                        dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = butter.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = butter.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = butter.Brand;
                        dataGridViewDairyProduct.Rows[row].Cells["IsSalted"].Value = butter.IsSalted;
                        dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = butter.FatPercentage;
                        PictureBox butterim = new PictureBox();
                        butterim.Image = Properties.Resources.butter1;
                        Image originalImage = butterim.Image;
                        Image resizedImage = new Bitmap(originalImage, new Size(100, 100));
                        butterim.Image = resizedImage;
                        butterim.SizeMode = PictureBoxSizeMode.AutoSize; // Automatically adjust image size into the picturebox
                        butterim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        butterim.Cursor = Cursors.Hand; //Change the mouse shape to a hand shape
                        butterim.MouseDown += MouseDown;
                        butterim.MouseMove += MouseMove;
                        butterim.MouseUp += MouseUp;
                        Controls.Add(butterim);
                        break;
                    case "Yogurt":
                        string flavorYogurt = comboBoxflavorYogurt.Text;
                        bool isGreekYogurt = chkisGreekYogurt.Checked;
                        Yogurt yogurt = null;
                        yogurt = new Yogurt(name, price, date, shelf, Calories, lactos, Brand, isGreekYogurt, flavorYogurt);
                        p.AddProduct(yogurt);
                        int row1 = dataGridViewDairyProduct.Rows.Add();

                        dataGridViewDairyProduct.Rows[row1].Cells["Name"].Value = yogurt.Name;
                        dataGridViewDairyProduct.Rows[row1].Cells["Price"].Value = yogurt.Price;
                        dataGridViewDairyProduct.Rows[row1].Cells["PurchaseDay"].Value = yogurt.PurchaseDay;
                        dataGridViewDairyProduct.Rows[row1].Cells["ShelfLife"].Value = yogurt.ShelfLife;
                        dataGridViewDairyProduct.Rows[row1].Cells["ID"].Value = yogurt.Id;
                        dataGridViewDairyProduct.Rows[row1].Cells["Calories"].Value = yogurt.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row1].Cells["Lactose"].Value = yogurt.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row1].Cells["Brand"].Value = yogurt.Brand;
                        dataGridViewDairyProduct.Rows[row1].Cells["IsGreekYogurt"].Value = yogurt.IsGreekYogurt;
                        dataGridViewDairyProduct.Rows[row1].Cells["Flavor"].Value = yogurt.Flavor;
                        PictureBox yogurtim = new PictureBox();
                        yogurtim.Image = Properties.Resources.Yogurt1;
                        Image originalImage1 = yogurtim.Image;
                        Image resizedImage1 = new Bitmap(originalImage1, new Size(100, 100));
                        yogurtim.Image = resizedImage1;
                        yogurtim.SizeMode = PictureBoxSizeMode.AutoSize;
                        yogurtim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        yogurtim.Cursor = Cursors.Hand; 
                        yogurtim.MouseDown += MouseDown;
                        yogurtim.MouseMove += MouseMove;
                        yogurtim.MouseUp += MouseUp;
                        Controls.Add(yogurtim);
                        break;

                    case "Cottage":
                        string originCheese = comboBoxoriginCheese.Text;
                        double FatCheese = double.Parse(txtFatCheese.Text);
                        bool hasCurdsCottage = chkhasCurdsCottage.Checked;
                        bool isCreamyCottage = chkisCreamyCottage.Checked;

                        CottageCheese cottageCheese = null;
                        cottageCheese = new CottageCheese(name, price, date, shelf, Calories, lactos, Brand, originCheese, FatCheese, isCreamyCottage, hasCurdsCottage);
                        p.AddProduct(cottageCheese);
                        int row2 = dataGridViewDairyProduct.Rows.Add();

                        dataGridViewDairyProduct.Rows[row2].Cells["Name"].Value = cottageCheese.Name;
                        dataGridViewDairyProduct.Rows[row2].Cells["Price"].Value = cottageCheese.Price;
                        dataGridViewDairyProduct.Rows[row2].Cells["PurchaseDay"].Value = cottageCheese.PurchaseDay;
                        dataGridViewDairyProduct.Rows[row2].Cells["ShelfLife"].Value = cottageCheese.ShelfLife;
                        dataGridViewDairyProduct.Rows[row2].Cells["ID"].Value = cottageCheese.Id;
                        dataGridViewDairyProduct.Rows[row2].Cells["Calories"].Value = cottageCheese.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row2].Cells["Lactose"].Value = cottageCheese.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row2].Cells["Brand"].Value = cottageCheese.Brand;
                        dataGridViewDairyProduct.Rows[row2].Cells["Origin"].Value = cottageCheese.Origin;
                        dataGridViewDairyProduct.Rows[row2].Cells["Fat"].Value = cottageCheese.FatPercentage;
                        dataGridViewDairyProduct.Rows[row2].Cells["IsCreamy"].Value = cottageCheese.IsCreamy;
                        dataGridViewDairyProduct.Rows[row2].Cells["HasCurds"].Value = cottageCheese.HasCurds;
                        PictureBox cottageCheeseim = new PictureBox();
                        cottageCheeseim.Image = Properties.Resources.Cottage1;
                        Image originalImage2 = cottageCheeseim.Image;
                        Image resizedImage2 = new Bitmap(originalImage2, new Size(100, 100));
                        cottageCheeseim.Image = resizedImage2;
                        cottageCheeseim.SizeMode = PictureBoxSizeMode.AutoSize;
                        cottageCheeseim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        cottageCheeseim.Cursor = Cursors.Hand; 
                        cottageCheeseim.MouseDown += MouseDown;
                        cottageCheeseim.MouseMove += MouseMove;
                        cottageCheeseim.MouseUp += MouseUp;
                        Controls.Add(cottageCheeseim);
                        break;
                    case "Labneh":
                        string originCheese1 = comboBoxoriginCheese.Text;
                        double FatCheese1 = double.Parse(txtFatCheese.Text);
                        String herbLabneh = comboBoxherbLabneh.Text;
                        bool isStrainedLabneh = chkisStrainedLabneh.Checked;

                        LabnehCheese labnehCheese = null;
                        labnehCheese = new LabnehCheese(name, price, date, shelf, Calories, lactos, Brand, originCheese1, FatCheese1, isStrainedLabneh, herbLabneh);
                        p.AddProduct(labnehCheese);
                        int row3 = dataGridViewDairyProduct.Rows.Add();

                        dataGridViewDairyProduct.Rows[row3].Cells["Name"].Value = labnehCheese.Name;
                        dataGridViewDairyProduct.Rows[row3].Cells["Price"].Value = labnehCheese.Price;
                        dataGridViewDairyProduct.Rows[row3].Cells["PurchaseDay"].Value = labnehCheese.PurchaseDay;
                        dataGridViewDairyProduct.Rows[row3].Cells["ShelfLife"].Value = labnehCheese.ShelfLife;
                        dataGridViewDairyProduct.Rows[row3].Cells["ID"].Value = labnehCheese.Id;
                        dataGridViewDairyProduct.Rows[row3].Cells["Calories"].Value = labnehCheese.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row3].Cells["Lactose"].Value = labnehCheese.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row3].Cells["Brand"].Value = labnehCheese.Brand;
                        dataGridViewDairyProduct.Rows[row3].Cells["Origin"].Value = labnehCheese.Origin;
                        dataGridViewDairyProduct.Rows[row3].Cells["Fat"].Value = labnehCheese.FatPercentage;
                        dataGridViewDairyProduct.Rows[row3].Cells["Herb"].Value = labnehCheese.Herb;
                        dataGridViewDairyProduct.Rows[row3].Cells["IsStrained"].Value = labnehCheese.IsStrained;
                        PictureBox labnehCheeseim = new PictureBox();
                        labnehCheeseim.Image = Properties.Resources.Labneh1;
                        Image originalImage3 = labnehCheeseim.Image;
                        Image resizedImage3 = new Bitmap(originalImage3, new Size(100, 100));
                        labnehCheeseim.Image = resizedImage3;
                        labnehCheeseim.SizeMode = PictureBoxSizeMode.AutoSize; 
                        labnehCheeseim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        labnehCheeseim.Cursor = Cursors.Hand; 
                        labnehCheeseim.MouseDown += MouseDown;
                        labnehCheeseim.MouseMove += MouseMove;
                        labnehCheeseim.MouseUp += MouseUp;
                        Controls.Add(labnehCheeseim);
                        break;
                    case "Mozzarella":
                        string originCheese2 = comboBoxoriginCheese.Text;
                        double FatCheese2 = double.Parse(txtFatCheese.Text);
                        bool isFreshMozzarella = chkisFreshMozzarella.Checked;
                        bool isStretchyisMozzarella = chkisStretchyisMozzarella.Checked;

                        MozzarellaCheese mozzarellaCheese = null;
                        mozzarellaCheese = new MozzarellaCheese(name, price, date, shelf, Calories, lactos, Brand, originCheese2, FatCheese2, isFreshMozzarella, isStretchyisMozzarella);
                        p.AddProduct(mozzarellaCheese);
                        int row4 = dataGridViewDairyProduct.Rows.Add();

                        dataGridViewDairyProduct.Rows[row4].Cells["Name"].Value = mozzarellaCheese.Name;
                        dataGridViewDairyProduct.Rows[row4].Cells["Price"].Value = mozzarellaCheese.Price;
                        dataGridViewDairyProduct.Rows[row4].Cells["PurchaseDay"].Value = mozzarellaCheese.PurchaseDay;
                        dataGridViewDairyProduct.Rows[row4].Cells["ShelfLife"].Value = mozzarellaCheese.ShelfLife;
                        dataGridViewDairyProduct.Rows[row4].Cells["ID"].Value = mozzarellaCheese.Id;
                        dataGridViewDairyProduct.Rows[row4].Cells["Calories"].Value = mozzarellaCheese.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row4].Cells["Lactose"].Value = mozzarellaCheese.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row4].Cells["Brand"].Value = mozzarellaCheese.Brand;
                        dataGridViewDairyProduct.Rows[row4].Cells["Origin"].Value = mozzarellaCheese.Origin;
                        dataGridViewDairyProduct.Rows[row4].Cells["Fat"].Value = mozzarellaCheese.FatPercentage;
                        dataGridViewDairyProduct.Rows[row4].Cells["IsFresh"].Value = mozzarellaCheese.IsFresh;
                        dataGridViewDairyProduct.Rows[row4].Cells["IsStretchy"].Value = mozzarellaCheese.IsStretchy;
                        PictureBox mozzarellaCheeseim = new PictureBox();
                        mozzarellaCheeseim.Image = Properties.Resources.Mozzarella1;
                        Image originalImage4 = mozzarellaCheeseim.Image;
                        Image resizedImage4 = new Bitmap(originalImage4, new Size(100, 100));
                        mozzarellaCheeseim.Image = resizedImage4;
                        mozzarellaCheeseim.SizeMode = PictureBoxSizeMode.AutoSize; 
                        mozzarellaCheeseim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        mozzarellaCheeseim.Cursor = Cursors.Hand;
                        mozzarellaCheeseim.MouseDown += MouseDown;
                        mozzarellaCheeseim.MouseMove += MouseMove;
                        mozzarellaCheeseim.MouseUp += MouseUp;
                        Controls.Add(mozzarellaCheeseim);
                        break;
                    case "BlueCheese":
                        string originCheese3 = comboBoxoriginCheese.Text;
                        double FatCheese3 = double.Parse(txtFatCheese.Text);
                        bool kasMoldBlueCheese = chkasMoldBlueCheese.Checked;
                        int AgingTimeBlueCheese = int.Parse(txtAgingTimeBlueCheese.Text);

                        BlueCheese blueCheese = null;
                        blueCheese = new BlueCheese(name, price, date, shelf, Calories, lactos, Brand, originCheese3, FatCheese3, AgingTimeBlueCheese, kasMoldBlueCheese);
                        p.AddProduct(blueCheese);
                        int row5 = dataGridViewDairyProduct.Rows.Add();

                        dataGridViewDairyProduct.Rows[row5].Cells["Name"].Value = blueCheese.Name;
                        dataGridViewDairyProduct.Rows[row5].Cells["Price"].Value = blueCheese.Price;
                        dataGridViewDairyProduct.Rows[row5].Cells["PurchaseDay"].Value = blueCheese.PurchaseDay;
                        dataGridViewDairyProduct.Rows[row5].Cells["ShelfLife"].Value = blueCheese.ShelfLife;
                        dataGridViewDairyProduct.Rows[row5].Cells["ID"].Value = blueCheese.Id;
                        dataGridViewDairyProduct.Rows[row5].Cells["Calories"].Value = blueCheese.CaloriesPercentage;
                        dataGridViewDairyProduct.Rows[row5].Cells["Lactose"].Value = blueCheese.LactosePercentage;
                        dataGridViewDairyProduct.Rows[row5].Cells["Brand"].Value = blueCheese.Brand;
                        dataGridViewDairyProduct.Rows[row5].Cells["Origin"].Value = blueCheese.Origin;
                        dataGridViewDairyProduct.Rows[row5].Cells["Fat"].Value = blueCheese.FatPercentage;
                        dataGridViewDairyProduct.Rows[row5].Cells["HasMold"].Value = blueCheese.HasMold;
                        dataGridViewDairyProduct.Rows[row5].Cells["AgingTime"].Value = blueCheese.AgingTime;
                        PictureBox blueCheeseim = new PictureBox();
                        blueCheeseim.Image = Properties.Resources.BlueCheese1;
                        Image originalImage5 = blueCheeseim.Image;
                        Image resizedImage5 = new Bitmap(originalImage5, new Size(100, 100));
                        blueCheeseim.Image = resizedImage5;
                        blueCheeseim.SizeMode = PictureBoxSizeMode.AutoSize; 
                        blueCheeseim.Location = new Point(buttonAdd.Location.X + buttonAdd.Width, buttonAdd.Location.Y - 75);
                        blueCheeseim.Cursor = Cursors.Hand; 
                        blueCheeseim.MouseDown += MouseDown;
                        blueCheeseim.MouseMove += MouseMove;
                        blueCheeseim.MouseUp += MouseUp;
                        Controls.Add(blueCheeseim);
                        break;
                }
                MessageBox.Show("The product has been successfully Added");
                ClearForm();
            }

        }
        private void DisplayIDInGrid(Product product, int ID)
        {
            dataGridViewDairyProduct.Rows.Clear();

            if (product.Id == ID)
            {

                int row = dataGridViewDairyProduct.Rows.Add();
                dataGridViewDairyProduct.Rows[row].Cells["Name"].Value = product.Name;
                dataGridViewDairyProduct.Rows[row].Cells["Price"].Value = product.Price;
                dataGridViewDairyProduct.Rows[row].Cells["PurchaseDay"].Value = product.PurchaseDay;
                dataGridViewDairyProduct.Rows[row].Cells["ShelfLife"].Value = product.ShelfLife;

                if (product is Yogurt)
                {
                    Yogurt yogurt = (Yogurt)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = yogurt.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = yogurt.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = yogurt.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = yogurt.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Flavor"].Value = yogurt.Flavor;
                    dataGridViewDairyProduct.Rows[row].Cells["IsGreekYogurt"].Value = yogurt.IsGreekYogurt;
                }
                else if (product is Butter)
                {
                    Butter butter = (Butter)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = butter.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = butter.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = butter.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = butter.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = butter.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["IsSalted"].Value = butter.IsSalted;
                }
                else if (product is BlueCheese)
                {
                    BlueCheese blueCheese = (BlueCheese)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = blueCheese.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = blueCheese.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = blueCheese.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = blueCheese.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = blueCheese.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = blueCheese.Origin;
                    dataGridViewDairyProduct.Rows[row].Cells["AgingTime"].Value = blueCheese.AgingTime;
                    dataGridViewDairyProduct.Rows[row].Cells["HasMold"].Value = blueCheese.HasMold;
                }
                else if (product is CottageCheese)
                {
                    CottageCheese cottageCheese = (CottageCheese)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = cottageCheese.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = cottageCheese.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = cottageCheese.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = cottageCheese.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = cottageCheese.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = cottageCheese.Origin;
                    dataGridViewDairyProduct.Rows[row].Cells["IsCreamy"].Value = cottageCheese.IsCreamy;
                    dataGridViewDairyProduct.Rows[row].Cells["HasCurds"].Value = cottageCheese.HasCurds;
                }
                else if (product is LabnehCheese)
                {
                    LabnehCheese labnehCheese = (LabnehCheese)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = labnehCheese.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = labnehCheese.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = labnehCheese.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = labnehCheese.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = labnehCheese.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = labnehCheese.Origin;
                    dataGridViewDairyProduct.Rows[row].Cells["IsStrained"].Value = labnehCheese.IsStrained;
                    dataGridViewDairyProduct.Rows[row].Cells["Herb"].Value = labnehCheese.Herb;
                }
                else if (product is MozzarellaCheese)
                {
                    MozzarellaCheese mozzarellaCheese = (MozzarellaCheese)product;
                    dataGridViewDairyProduct.Rows[row].Cells["ID"].Value = mozzarellaCheese.Id;
                    dataGridViewDairyProduct.Rows[row].Cells["Brand"].Value = mozzarellaCheese.Brand;
                    dataGridViewDairyProduct.Rows[row].Cells["Calories"].Value = mozzarellaCheese.CaloriesPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Lactose"].Value = mozzarellaCheese.LactosePercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Fat"].Value = mozzarellaCheese.FatPercentage;
                    dataGridViewDairyProduct.Rows[row].Cells["Origin"].Value = mozzarellaCheese.Origin;
                    dataGridViewDairyProduct.Rows[row].Cells["IsFresh"].Value = mozzarellaCheese.IsFresh;
                    dataGridViewDairyProduct.Rows[row].Cells["IsStretchy"].Value = mozzarellaCheese.IsStretchy;
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
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eDairyType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyCheese));
                comboBoxName.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxflavorYogurt.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyYogurt));
                comboBoxherbLabneh.DataSource = Enum.GetValues(typeof(Enums_Collections.eHerbType));
                comboBoxoriginCheese.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheeseOrigin));
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
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eDairyType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyCheese));
                comboBoxName.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxflavorYogurt.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyYogurt));
                comboBoxherbLabneh.DataSource = Enum.GetValues(typeof(Enums_Collections.eHerbType));
                comboBoxoriginCheese.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheeseOrigin));
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
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eDairyType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyCheese));
                comboBoxName.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxflavorYogurt.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyYogurt));
                comboBoxherbLabneh.DataSource = Enum.GetValues(typeof(Enums_Collections.eHerbType));
                comboBoxoriginCheese.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheeseOrigin));
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
            if (productToUpdate.Name == "Butter")
            {
                comboBoxType.SelectedIndex = 2;
                comboBoxName.SelectedIndex = 1;
            }
            else if (productToUpdate.Name == "Yogurt")
            {
                comboBoxType.SelectedIndex = 2;
                comboBoxName.SelectedIndex = 2;
            }
            else if (productToUpdate.Name == "Cottage")
            {
                comboBoxType.SelectedIndex = 1;
                comboBoxName.SelectedIndex = 2;
            }
            else if (productToUpdate.Name == "Labneh")
            {
                comboBoxType.SelectedIndex = 1;
                comboBoxName.SelectedIndex = 1;
            }
            else if (productToUpdate.Name == "Mozzarella")
            {
                comboBoxType.SelectedIndex = 1;
                comboBoxName.SelectedIndex = 3;
            }
            else if (productToUpdate.Name == "BlueCheese")
            {
                comboBoxType.SelectedIndex = 1;
                comboBoxName.SelectedIndex = 4;
            }
            comboBoxType.Enabled = false;
            comboBoxName.Enabled = false;

            //Update the fields based on the selected product type
            switch (productToUpdate)
            {
                case Butter butter:
                    txtCaloriesPercentage.Text = butter.CaloriesPercentage.ToString();
                    txtlactosPercentage.Text = butter.LactosePercentage.ToString();
                    comboBoxBrand.SelectedItem = butter.Brand;
                    chkisSaltedButter.Checked = butter.IsSalted;
                    txtFatButter.Text = butter.FatPercentage.ToString();
                    break;
                case Yogurt yogurt:
                    txtCaloriesPercentage.Text = yogurt.CaloriesPercentage.ToString();
                    txtlactosPercentage.Text = yogurt.LactosePercentage.ToString();
                    comboBoxBrand.SelectedItem = yogurt.Brand;
                    comboBoxflavorYogurt.SelectedItem = yogurt.Flavor;
                    chkisGreekYogurt.Checked = yogurt.IsGreekYogurt;
                    break;
                case CottageCheese cottage:
                    txtCaloriesPercentage.Text = cottage.CaloriesPercentage.ToString();
                    txtlactosPercentage.Text = cottage.LactosePercentage.ToString();
                    comboBoxBrand.SelectedItem = cottage.Brand;
                    comboBoxoriginCheese.SelectedItem = cottage.Origin;
                    txtFatCheese.Text = cottage.FatPercentage.ToString();
                    chkisCreamyCottage.Checked = cottage.IsCreamy;
                    chkhasCurdsCottage.Checked = cottage.HasCurds;
                    break;
                case LabnehCheese labneh:
                    txtCaloriesPercentage.Text = labneh.CaloriesPercentage.ToString();
                    txtlactosPercentage.Text = labneh.LactosePercentage.ToString();
                    comboBoxBrand.SelectedItem = labneh.Brand;
                    comboBoxoriginCheese.SelectedItem = labneh.Origin;
                    txtFatCheese.Text = labneh.FatPercentage.ToString();
                    chkisStrainedLabneh.Checked = labneh.IsStrained;
                    comboBoxherbLabneh.SelectedItem = labneh.Herb;
                    break;
                case MozzarellaCheese mozzarella:
                    txtCaloriesPercentage.Text = mozzarella.CaloriesPercentage.ToString();
                    txtlactosPercentage.Text = mozzarella.LactosePercentage.ToString();
                    comboBoxBrand.SelectedItem = mozzarella.Brand;
                    comboBoxoriginCheese.SelectedItem = mozzarella.Origin;
                    txtFatCheese.Text = mozzarella.FatPercentage.ToString();
                    chkisStretchyisMozzarella.Checked = mozzarella.IsStretchy;
                    chkisFreshMozzarella.Checked = mozzarella.IsFresh;
                    break;
                case BlueCheese blueCheese:
                    txtCaloriesPercentage.Text = blueCheese.CaloriesPercentage.ToString();
                    txtlactosPercentage.Text = blueCheese.LactosePercentage.ToString();
                    comboBoxBrand.SelectedItem = blueCheese.Brand;
                    comboBoxoriginCheese.SelectedItem = blueCheese.Origin;
                    txtFatCheese.Text = blueCheese.FatPercentage.ToString();
                    chkasMoldBlueCheese.Checked = blueCheese.HasMold;
                    txtAgingTimeBlueCheese.Text = blueCheese.AgingTime.ToString();
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
            foreach (DataGridViewRow row in dataGridViewDairyProduct.Rows)
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
            foreach (DataGridViewRow row in dataGridViewDairyProduct.Rows)
            {
                if (row.Cells["ID"].Value.ToString() == idToRemove.ToString())
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                dataGridViewDairyProduct.Rows.RemoveAt(rowIndex);
                p.RemoveProductById(idToRemove);
                MessageBox.Show("The product has been successfully deleted");
            }
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
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eDairyType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyCheese));
                comboBoxName.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxflavorYogurt.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyYogurt));
                comboBoxherbLabneh.DataSource = Enum.GetValues(typeof(Enums_Collections.eHerbType));
                comboBoxoriginCheese.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheeseOrigin));
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
                comboBoxType.DataSource = Enum.GetValues(typeof(Enums_Collections.eDairyType));
                comboBoxBrand.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyCheese));
                comboBoxName.DataSource = Enum.GetValues(typeof(Enums_Collections.eBeverageNameDairy));
                comboBoxflavorYogurt.DataSource = Enum.GetValues(typeof(Enums_Collections.eBrandDairyYogurt));
                comboBoxherbLabneh.DataSource = Enum.GetValues(typeof(Enums_Collections.eHerbType));
                comboBoxoriginCheese.DataSource = Enum.GetValues(typeof(Enums_Collections.eCheeseOrigin));
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
                string name = comboBoxName.Text;
                double price = double.Parse(textBoxPrice.Text);
                DateTime date = dateTimeBuyingDate.Value;
                int shelf = int.Parse(txtShelfLife.Text);
                double Calories = double.Parse(txtCaloriesPercentage.Text);
                double lactos = double.Parse(txtlactosPercentage.Text);
                string Brand = comboBoxBrand.Text;
              
                productToUpdate.Price = price;
                productToUpdate.PurchaseDay = date;
                productToUpdate.ShelfLife = shelf;

                if (comboBoxName.SelectedItem.ToString() == "Butter")
                {
                    double FatButter = double.Parse(txtFatButter.Text);
                    bool IsSaltedButter = chkisSaltedButter.Checked;
                    Butter butter = productToUpdate as Butter;
                    butter.CaloriesPercentage = Calories;
                    butter.LactosePercentage =lactos;
                    butter.Brand= Brand;
                    butter.IsSalted= IsSaltedButter;
                    butter.FatPercentage=FatButter;
                }
                else if (comboBoxName.SelectedItem.ToString() == "Yogurt")
                {
                    string flavorYogurt = comboBoxflavorYogurt.Text;
                    bool isGreekYogurt = chkisGreekYogurt.Checked;
                    Yogurt yogurt = productToUpdate as Yogurt;
                    yogurt.CaloriesPercentage =Calories;
                    yogurt.LactosePercentage =lactos;
                    yogurt.Brand=Brand;
                    yogurt.Flavor= flavorYogurt;
                    yogurt.IsGreekYogurt= isGreekYogurt;
                }
                else if (comboBoxName.SelectedItem.ToString() == "Cottage")
                {
                    string originCheese = comboBoxoriginCheese.Text;
                    double FatCheese = double.Parse(txtFatCheese.Text);
                    bool hasCurdsCottage = chkhasCurdsCottage.Checked;
                    bool isCreamyCottage = chkisCreamyCottage.Checked;
                    CottageCheese Cottage = productToUpdate as CottageCheese;
                    Cottage.CaloriesPercentage = Calories;
                    Cottage.LactosePercentage = lactos;
                    Cottage.Brand = Brand;
                    Cottage.Origin = originCheese;
                    Cottage.FatPercentage = FatCheese;
                    Cottage.IsCreamy = isCreamyCottage;
                    Cottage.HasCurds = hasCurdsCottage;
                }
                else if (comboBoxName.SelectedItem.ToString() == "Labneh")
                {
                    string originCheese = comboBoxoriginCheese.Text;
                    double FatCheese = double.Parse(txtFatCheese.Text);
                    String herbLabneh = comboBoxherbLabneh.Text;
                    bool isStrainedLabneh = chkisStrainedLabneh.Checked;
                    LabnehCheese labneh = productToUpdate as LabnehCheese;
                    labneh.CaloriesPercentage = Calories;
                    labneh.LactosePercentage = lactos;
                    labneh.Brand = Brand;
                    labneh.Origin = originCheese;
                    labneh.FatPercentage = FatCheese;
                    labneh.IsStrained = isStrainedLabneh;
                    labneh.Herb = herbLabneh;
                }
                else if (comboBoxName.SelectedItem.ToString() == "Mozzarella")
                {
                    string originCheese = comboBoxoriginCheese.Text;
                    double FatCheese = double.Parse(txtFatCheese.Text);
                    bool isFreshMozzarella = chkisFreshMozzarella.Checked;
                    bool isStretchyisMozzarella = chkisStretchyisMozzarella.Checked;
                    MozzarellaCheese Mozzarella = productToUpdate as MozzarellaCheese;
                    Mozzarella.CaloriesPercentage = Calories;
                    Mozzarella.LactosePercentage = lactos;
                    Mozzarella.Brand = Brand;
                    Mozzarella.Origin = originCheese;
                    Mozzarella.FatPercentage = FatCheese;
                    Mozzarella.IsFresh = isFreshMozzarella;
                    Mozzarella.IsStretchy = isStretchyisMozzarella;
                }
                else if (comboBoxName.SelectedItem.ToString() == "BlueCheese")
                {
                    string originCheese = comboBoxoriginCheese.Text;
                    double FatCheese = double.Parse(txtFatCheese.Text);
                    bool hasMoldBlueCheese = chkasMoldBlueCheese.Checked;
                    int AgingTimeBlueCheese = int.Parse(txtAgingTimeBlueCheese.Text);
                    BlueCheese blueCheese = productToUpdate as BlueCheese;
                    blueCheese.CaloriesPercentage = Calories;
                    blueCheese.LactosePercentage = lactos;
                    blueCheese.Brand = Brand;
                    blueCheese.Origin = originCheese;
                    blueCheese.FatPercentage = FatCheese;
                    blueCheese.HasMold = hasMoldBlueCheese;
                    blueCheese.AgingTime = AgingTimeBlueCheese;
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
