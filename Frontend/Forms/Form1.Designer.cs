
namespace Refrigerator_FinalProj
{
    partial class fRefrigerator
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRefrigeratorDetails = new System.Windows.Forms.Button();
            this.TimerForIce = new System.Windows.Forms.Timer(this.components);
            this.btnIce = new System.Windows.Forms.Button();
            this.lblIce = new System.Windows.Forms.Label();
            this.btnTakeIce = new System.Windows.Forms.Button();
            this.TimerOpen = new System.Windows.Forms.Timer(this.components);
            this.btnReturnToOpeningPage = new System.Windows.Forms.Button();
            this.pMoveToProducts = new System.Windows.Forms.Panel();
            this.pictureice = new System.Windows.Forms.PictureBox();
            this.lblrandom = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.pictureBoxProducts = new System.Windows.Forms.PictureBox();
            this.dataGridViewAllProducts = new System.Windows.Forms.DataGridView();
            this.picturegif3 = new System.Windows.Forms.PictureBox();
            this.pWelcome = new System.Windows.Forms.Panel();
            this.pOpHome = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pLeft = new System.Windows.Forms.Panel();
            this.pAllTheProducts = new System.Windows.Forms.Panel();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.pHelp = new System.Windows.Forms.Panel();
            this.pVegetable = new System.Windows.Forms.Panel();
            this.btnVegetable = new System.Windows.Forms.Button();
            this.pHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pFruit = new System.Windows.Forms.Panel();
            this.btnFruit = new System.Windows.Forms.Button();
            this.pDairyProduct = new System.Windows.Forms.Panel();
            this.btnDairyProduct = new System.Windows.Forms.Button();
            this.pBeverage = new System.Windows.Forms.Panel();
            this.btnBeverage = new System.Windows.Forms.Button();
            this.pMeat = new System.Windows.Forms.Panel();
            this.btnMeat = new System.Windows.Forms.Button();
            this.picturetomato = new System.Windows.Forms.PictureBox();
            this.pictureBox2Gif = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelice = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fruit1 = new Refrigerator_FinalProj.Frontend.UserControls.Fruit.Fruit();
            this.dairyProduct1 = new Refrigerator_FinalProj.Frontend.UserControls.DairyProduct.DairyProduct();
            this.beverage1 = new Refrigerator_FinalProj.Frontend.UserControls.Beverage();
            this.vegetable1 = new Refrigerator_FinalProj.Frontend.UserControls.Vegetable.Vegetable();
            this.Meat1 = new Refrigerator_FinalProj.Frontend.Usre.Meat();
            this.pMoveToProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegif3)).BeginInit();
            this.pWelcome.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.pAllTheProducts.SuspendLayout();
            this.pHelp.SuspendLayout();
            this.pVegetable.SuspendLayout();
            this.pHome.SuspendLayout();
            this.pFruit.SuspendLayout();
            this.pDairyProduct.SuspendLayout();
            this.pBeverage.SuspendLayout();
            this.pMeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturetomato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStart.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(900, 500);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Click to open";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRefrigeratorDetails
            // 
            this.btnRefrigeratorDetails.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRefrigeratorDetails.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrigeratorDetails.Location = new System.Drawing.Point(-4, 2);
            this.btnRefrigeratorDetails.Name = "btnRefrigeratorDetails";
            this.btnRefrigeratorDetails.Size = new System.Drawing.Size(500, 69);
            this.btnRefrigeratorDetails.TabIndex = 2;
            this.btnRefrigeratorDetails.Text = "Fridge details";
            this.btnRefrigeratorDetails.UseVisualStyleBackColor = false;
            this.btnRefrigeratorDetails.Click += new System.EventHandler(this.btnRefrigeratorDetails_Click_1);
            // 
            // TimerForIce
            // 
            this.TimerForIce.Interval = 1000;
            this.TimerForIce.Tick += new System.EventHandler(this.TimerForIce_Tick);
            // 
            // btnIce
            // 
            this.btnIce.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnIce.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnIce.Location = new System.Drawing.Point(710, 500);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(180, 50);
            this.btnIce.TabIndex = 3;
            this.btnIce.Text = "Click for ice";
            this.btnIce.UseVisualStyleBackColor = false;
            this.btnIce.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // lblIce
            // 
            this.lblIce.AutoSize = true;
            this.lblIce.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblIce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIce.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.lblIce.ForeColor = System.Drawing.Color.Black;
            this.lblIce.Location = new System.Drawing.Point(710, 570);
            this.lblIce.Name = "lblIce";
            this.lblIce.Size = new System.Drawing.Size(2, 45);
            this.lblIce.TabIndex = 4;
            // 
            // btnTakeIce
            // 
            this.btnTakeIce.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTakeIce.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnTakeIce.Location = new System.Drawing.Point(710, 620);
            this.btnTakeIce.Name = "btnTakeIce";
            this.btnTakeIce.Size = new System.Drawing.Size(180, 50);
            this.btnTakeIce.TabIndex = 5;
            this.btnTakeIce.Text = "Take";
            this.btnTakeIce.UseVisualStyleBackColor = false;
            this.btnTakeIce.Visible = false;
            this.btnTakeIce.Click += new System.EventHandler(this.btnTakeIce_Click);
            // 
            // TimerOpen
            // 
            this.TimerOpen.Interval = 1000;
            // 
            // btnReturnToOpeningPage
            // 
            this.btnReturnToOpeningPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnReturnToOpeningPage.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnReturnToOpeningPage.Location = new System.Drawing.Point(-3, 3);
            this.btnReturnToOpeningPage.Name = "btnReturnToOpeningPage";
            this.btnReturnToOpeningPage.Size = new System.Drawing.Size(350, 96);
            this.btnReturnToOpeningPage.TabIndex = 7;
            this.btnReturnToOpeningPage.Text = "Back";
            this.btnReturnToOpeningPage.UseVisualStyleBackColor = false;
            this.btnReturnToOpeningPage.Click += new System.EventHandler(this.btnReturnToOpeningPage_Click);
            // 
            // pMoveToProducts
            // 
            this.pMoveToProducts.Controls.Add(this.panelice);
            this.pMoveToProducts.Controls.Add(this.lblrandom);
            this.pMoveToProducts.Controls.Add(this.comboBoxProducts);
            this.pMoveToProducts.Controls.Add(this.pictureBoxProducts);
            this.pMoveToProducts.Controls.Add(this.dataGridViewAllProducts);
            this.pMoveToProducts.Controls.Add(this.fruit1);
            this.pMoveToProducts.Controls.Add(this.dairyProduct1);
            this.pMoveToProducts.Controls.Add(this.beverage1);
            this.pMoveToProducts.Controls.Add(this.vegetable1);
            this.pMoveToProducts.Controls.Add(this.Meat1);
            this.pMoveToProducts.Controls.Add(this.picturegif3);
            this.pMoveToProducts.Controls.Add(this.pWelcome);
            this.pMoveToProducts.Controls.Add(this.pLeft);
            this.pMoveToProducts.Controls.Add(this.picturetomato);
            this.pMoveToProducts.Location = new System.Drawing.Point(0, 0);
            this.pMoveToProducts.Name = "pMoveToProducts";
            this.pMoveToProducts.Size = new System.Drawing.Size(2000, 1000);
            this.pMoveToProducts.TabIndex = 8;
            this.pMoveToProducts.Visible = false;
            // 
            // pictureice
            // 
            this.pictureice.Image = global::Refrigerator_FinalProj.Properties.Resources.glassWithIce;
            this.pictureice.Location = new System.Drawing.Point(0, 3);
            this.pictureice.Name = "pictureice";
            this.pictureice.Size = new System.Drawing.Size(287, 259);
            this.pictureice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureice.TabIndex = 13;
            this.pictureice.TabStop = false;
            // 
            // lblrandom
            // 
            this.lblrandom.AutoSize = true;
            this.lblrandom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblrandom.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblrandom.Location = new System.Drawing.Point(1339, 89);
            this.lblrandom.Name = "lblrandom";
            this.lblrandom.Size = new System.Drawing.Size(383, 20);
            this.lblrandom.TabIndex = 12;
            this.lblrandom.Text = "Choose something to Random Pictures From Google";
            this.lblrandom.Visible = false;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.Enabled = false;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(1343, 120);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(119, 28);
            this.comboBoxProducts.TabIndex = 11;
            this.comboBoxProducts.Visible = false;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // pictureBoxProducts
            // 
            this.pictureBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProducts.Enabled = false;
            this.pictureBoxProducts.Location = new System.Drawing.Point(1343, 167);
            this.pictureBoxProducts.Name = "pictureBoxProducts";
            this.pictureBoxProducts.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProducts.TabIndex = 10;
            this.pictureBoxProducts.TabStop = false;
            this.pictureBoxProducts.Visible = false;
            // 
            // dataGridViewAllProducts
            // 
            this.dataGridViewAllProducts.AllowUserToDeleteRows = false;
            this.dataGridViewAllProducts.AllowUserToOrderColumns = true;
            this.dataGridViewAllProducts.AutoGenerateColumns = false;
            this.dataGridViewAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.purchaseDayDataGridViewTextBoxColumn,
            this.shelfLifeDataGridViewTextBoxColumn});
            this.dataGridViewAllProducts.DataSource = this.productBindingSource;
            this.dataGridViewAllProducts.Enabled = false;
            this.dataGridViewAllProducts.Location = new System.Drawing.Point(359, 103);
            this.dataGridViewAllProducts.Name = "dataGridViewAllProducts";
            this.dataGridViewAllProducts.ReadOnly = true;
            this.dataGridViewAllProducts.RowHeadersWidth = 62;
            this.dataGridViewAllProducts.RowTemplate.Height = 28;
            this.dataGridViewAllProducts.Size = new System.Drawing.Size(960, 737);
            this.dataGridViewAllProducts.TabIndex = 9;
            this.dataGridViewAllProducts.Visible = false;
            // 
            // picturegif3
            // 
            this.picturegif3.Image = global::Refrigerator_FinalProj.Properties.Resources.refriderator_fridge_open_close_1;
            this.picturegif3.Location = new System.Drawing.Point(466, 115);
            this.picturegif3.Name = "picturegif3";
            this.picturegif3.Size = new System.Drawing.Size(2000, 1000);
            this.picturegif3.TabIndex = 2;
            this.picturegif3.TabStop = false;
            // 
            // pWelcome
            // 
            this.pWelcome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pWelcome.Controls.Add(this.pOpHome);
            this.pWelcome.Controls.Add(this.lblWelcome);
            this.pWelcome.Location = new System.Drawing.Point(350, 0);
            this.pWelcome.Name = "pWelcome";
            this.pWelcome.Size = new System.Drawing.Size(1650, 79);
            this.pWelcome.TabIndex = 1;
            // 
            // pOpHome
            // 
            this.pOpHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pOpHome.Location = new System.Drawing.Point(0, 77);
            this.pOpHome.Name = "pOpHome";
            this.pOpHome.Size = new System.Drawing.Size(1334, 942);
            this.pOpHome.TabIndex = 4;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(68, 2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(1);
            this.lblWelcome.Size = new System.Drawing.Size(1493, 73);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome back to the fridge Click on one of the categories to get started";
            // 
            // pLeft
            // 
            this.pLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pLeft.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pLeft.Controls.Add(this.pAllTheProducts);
            this.pLeft.Controls.Add(this.pHelp);
            this.pLeft.Controls.Add(this.pVegetable);
            this.pLeft.Controls.Add(this.pHome);
            this.pLeft.Controls.Add(this.pFruit);
            this.pLeft.Controls.Add(this.pDairyProduct);
            this.pLeft.Controls.Add(this.pBeverage);
            this.pLeft.Controls.Add(this.pMeat);
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(352, 1000);
            this.pLeft.TabIndex = 0;
            // 
            // pAllTheProducts
            // 
            this.pAllTheProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pAllTheProducts.Controls.Add(this.btnAllProducts);
            this.pAllTheProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pAllTheProducts.Location = new System.Drawing.Point(0, 115);
            this.pAllTheProducts.Name = "pAllTheProducts";
            this.pAllTheProducts.Padding = new System.Windows.Forms.Padding(1);
            this.pAllTheProducts.Size = new System.Drawing.Size(350, 107);
            this.pAllTheProducts.TabIndex = 7;
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAllProducts.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnAllProducts.Location = new System.Drawing.Point(-3, 3);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(350, 96);
            this.btnAllProducts.TabIndex = 13;
            this.btnAllProducts.Text = "All Products";
            this.btnAllProducts.UseVisualStyleBackColor = false;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // pHelp
            // 
            this.pHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHelp.Controls.Add(this.btnReturnToOpeningPage);
            this.pHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pHelp.Location = new System.Drawing.Point(0, 890);
            this.pHelp.Name = "pHelp";
            this.pHelp.Padding = new System.Windows.Forms.Padding(1);
            this.pHelp.Size = new System.Drawing.Size(350, 107);
            this.pHelp.TabIndex = 6;
            // 
            // pVegetable
            // 
            this.pVegetable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pVegetable.Controls.Add(this.btnVegetable);
            this.pVegetable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pVegetable.Location = new System.Drawing.Point(3, 679);
            this.pVegetable.Name = "pVegetable";
            this.pVegetable.Padding = new System.Windows.Forms.Padding(1);
            this.pVegetable.Size = new System.Drawing.Size(350, 107);
            this.pVegetable.TabIndex = 5;
            // 
            // btnVegetable
            // 
            this.btnVegetable.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVegetable.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnVegetable.Location = new System.Drawing.Point(-3, 3);
            this.btnVegetable.Name = "btnVegetable";
            this.btnVegetable.Size = new System.Drawing.Size(350, 96);
            this.btnVegetable.TabIndex = 8;
            this.btnVegetable.Text = "Vegetables";
            this.btnVegetable.UseVisualStyleBackColor = false;
            this.btnVegetable.Click += new System.EventHandler(this.btnVegetable_Click);
            // 
            // pHome
            // 
            this.pHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHome.Controls.Add(this.btnHome);
            this.pHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pHome.Location = new System.Drawing.Point(3, 2);
            this.pHome.Name = "pHome";
            this.pHome.Padding = new System.Windows.Forms.Padding(1);
            this.pHome.Size = new System.Drawing.Size(350, 107);
            this.pHome.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHome.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnHome.Location = new System.Drawing.Point(-3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(350, 96);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pFruit
            // 
            this.pFruit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pFruit.Controls.Add(this.btnFruit);
            this.pFruit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pFruit.Location = new System.Drawing.Point(0, 566);
            this.pFruit.Name = "pFruit";
            this.pFruit.Padding = new System.Windows.Forms.Padding(1);
            this.pFruit.Size = new System.Drawing.Size(350, 107);
            this.pFruit.TabIndex = 2;
            // 
            // btnFruit
            // 
            this.btnFruit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFruit.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnFruit.Location = new System.Drawing.Point(-3, 3);
            this.btnFruit.Name = "btnFruit";
            this.btnFruit.Size = new System.Drawing.Size(350, 96);
            this.btnFruit.TabIndex = 9;
            this.btnFruit.Text = "Fruits";
            this.btnFruit.UseVisualStyleBackColor = false;
            this.btnFruit.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // pDairyProduct
            // 
            this.pDairyProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pDairyProduct.Controls.Add(this.btnDairyProduct);
            this.pDairyProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pDairyProduct.Location = new System.Drawing.Point(0, 453);
            this.pDairyProduct.Name = "pDairyProduct";
            this.pDairyProduct.Padding = new System.Windows.Forms.Padding(1);
            this.pDairyProduct.Size = new System.Drawing.Size(350, 107);
            this.pDairyProduct.TabIndex = 3;
            // 
            // btnDairyProduct
            // 
            this.btnDairyProduct.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDairyProduct.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnDairyProduct.Location = new System.Drawing.Point(-3, 3);
            this.btnDairyProduct.Name = "btnDairyProduct";
            this.btnDairyProduct.Size = new System.Drawing.Size(350, 96);
            this.btnDairyProduct.TabIndex = 10;
            this.btnDairyProduct.Text = "Dairy Products";
            this.btnDairyProduct.UseVisualStyleBackColor = false;
            this.btnDairyProduct.Click += new System.EventHandler(this.btnDairyProduct_Click);
            // 
            // pBeverage
            // 
            this.pBeverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBeverage.Controls.Add(this.btnBeverage);
            this.pBeverage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBeverage.Location = new System.Drawing.Point(0, 340);
            this.pBeverage.Name = "pBeverage";
            this.pBeverage.Padding = new System.Windows.Forms.Padding(1);
            this.pBeverage.Size = new System.Drawing.Size(350, 107);
            this.pBeverage.TabIndex = 2;
            // 
            // btnBeverage
            // 
            this.btnBeverage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBeverage.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnBeverage.Location = new System.Drawing.Point(-3, 3);
            this.btnBeverage.Name = "btnBeverage";
            this.btnBeverage.Size = new System.Drawing.Size(350, 96);
            this.btnBeverage.TabIndex = 11;
            this.btnBeverage.Text = "Beverages";
            this.btnBeverage.UseVisualStyleBackColor = false;
            this.btnBeverage.Click += new System.EventHandler(this.btnBeverage_Click);
            // 
            // pMeat
            // 
            this.pMeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pMeat.Controls.Add(this.btnMeat);
            this.pMeat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pMeat.Location = new System.Drawing.Point(0, 227);
            this.pMeat.Name = "pMeat";
            this.pMeat.Padding = new System.Windows.Forms.Padding(1);
            this.pMeat.Size = new System.Drawing.Size(350, 107);
            this.pMeat.TabIndex = 1;
            // 
            // btnMeat
            // 
            this.btnMeat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMeat.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.btnMeat.Location = new System.Drawing.Point(-3, 3);
            this.btnMeat.Name = "btnMeat";
            this.btnMeat.Size = new System.Drawing.Size(350, 96);
            this.btnMeat.TabIndex = 12;
            this.btnMeat.Text = "Meat";
            this.btnMeat.UseVisualStyleBackColor = false;
            this.btnMeat.Click += new System.EventHandler(this.btnMeat_Click);
            // 
            // picturetomato
            // 
            this.picturetomato.Enabled = false;
            this.picturetomato.Location = new System.Drawing.Point(346, 78);
            this.picturetomato.Name = "picturetomato";
            this.picturetomato.Size = new System.Drawing.Size(1500, 950);
            this.picturetomato.TabIndex = 8;
            this.picturetomato.TabStop = false;
            this.picturetomato.Visible = false;
            // 
            // pictureBox2Gif
            // 
            this.pictureBox2Gif.Image = global::Refrigerator_FinalProj.Properties.Resources.refriderator_fridge_open_close_1;
            this.pictureBox2Gif.Location = new System.Drawing.Point(466, 115);
            this.pictureBox2Gif.Name = "pictureBox2Gif";
            this.pictureBox2Gif.Size = new System.Drawing.Size(2000, 1000);
            this.pictureBox2Gif.TabIndex = 6;
            this.pictureBox2Gif.TabStop = false;
            this.pictureBox2Gif.Visible = false;
            this.pictureBox2Gif.Click += new System.EventHandler(this.pictureBox2Gif_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::Refrigerator_FinalProj.Properties.Resources.reg;
            this.pictureBox.Location = new System.Drawing.Point(-4, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1661, 1044);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panelice
            // 
            this.panelice.Controls.Add(this.pictureice);
            this.panelice.Enabled = false;
            this.panelice.Location = new System.Drawing.Point(466, 518);
            this.panelice.Name = "panelice";
            this.panelice.Size = new System.Drawing.Size(289, 268);
            this.panelice.TabIndex = 14;
            this.panelice.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // purchaseDayDataGridViewTextBoxColumn
            // 
            this.purchaseDayDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDay";
            this.purchaseDayDataGridViewTextBoxColumn.HeaderText = "PurchaseDay";
            this.purchaseDayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.purchaseDayDataGridViewTextBoxColumn.Name = "purchaseDayDataGridViewTextBoxColumn";
            this.purchaseDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchaseDayDataGridViewTextBoxColumn.Width = 150;
            // 
            // shelfLifeDataGridViewTextBoxColumn
            // 
            this.shelfLifeDataGridViewTextBoxColumn.DataPropertyName = "ShelfLife";
            this.shelfLifeDataGridViewTextBoxColumn.HeaderText = "ShelfLife";
            this.shelfLifeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.shelfLifeDataGridViewTextBoxColumn.Name = "shelfLifeDataGridViewTextBoxColumn";
            this.shelfLifeDataGridViewTextBoxColumn.ReadOnly = true;
            this.shelfLifeDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Refrigerator_FinalProj.Backend.Model.Product);
            // 
            // fruit1
            // 
            this.fruit1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fruit1.Location = new System.Drawing.Point(346, 77);
            this.fruit1.Name = "fruit1";
            this.fruit1.Size = new System.Drawing.Size(1500, 950);
            this.fruit1.TabIndex = 7;
            // 
            // dairyProduct1
            // 
            this.dairyProduct1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dairyProduct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dairyProduct1.Location = new System.Drawing.Point(346, 78);
            this.dairyProduct1.Name = "dairyProduct1";
            this.dairyProduct1.Size = new System.Drawing.Size(1472, 942);
            this.dairyProduct1.TabIndex = 6;
            this.dairyProduct1.Visible = false;
            // 
            // beverage1
            // 
            this.beverage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.beverage1.Location = new System.Drawing.Point(346, 77);
            this.beverage1.Name = "beverage1";
            this.beverage1.Size = new System.Drawing.Size(1500, 950);
            this.beverage1.TabIndex = 5;
            this.beverage1.Visible = false;
            // 
            // vegetable1
            // 
            this.vegetable1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vegetable1.Location = new System.Drawing.Point(346, 78);
            this.vegetable1.Name = "vegetable1";
            this.vegetable1.Size = new System.Drawing.Size(1472, 942);
            this.vegetable1.TabIndex = 4;
            this.vegetable1.Visible = false;
            // 
            // Meat1
            // 
            this.Meat1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Meat1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Meat1.Location = new System.Drawing.Point(346, 77);
            this.Meat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Meat1.Name = "Meat1";
            this.Meat1.Size = new System.Drawing.Size(1500, 950);
            this.Meat1.TabIndex = 3;
            this.Meat1.Visible = false;
            // 
            // fRefrigerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1682, 1027);
            this.Controls.Add(this.pMoveToProducts);
            this.Controls.Add(this.btnRefrigeratorDetails);
            this.Controls.Add(this.btnTakeIce);
            this.Controls.Add(this.lblIce);
            this.Controls.Add(this.btnIce);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox2Gif);
            this.Controls.Add(this.pictureBox);
            this.Name = "fRefrigerator";
            this.ShowIcon = false;
            this.Text = "Welcome to Refrigerator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pMoveToProducts.ResumeLayout(false);
            this.pMoveToProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturegif3)).EndInit();
            this.pWelcome.ResumeLayout(false);
            this.pWelcome.PerformLayout();
            this.pLeft.ResumeLayout(false);
            this.pAllTheProducts.ResumeLayout(false);
            this.pHelp.ResumeLayout(false);
            this.pVegetable.ResumeLayout(false);
            this.pHome.ResumeLayout(false);
            this.pFruit.ResumeLayout(false);
            this.pDairyProduct.ResumeLayout(false);
            this.pBeverage.ResumeLayout(false);
            this.pMeat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturetomato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRefrigeratorDetails;
        private System.Windows.Forms.Timer TimerForIce;
        private System.Windows.Forms.Button btnIce;
        private System.Windows.Forms.Label lblIce;
        private System.Windows.Forms.Button btnTakeIce;
        private System.Windows.Forms.PictureBox pictureBox2Gif;
        private System.Windows.Forms.Timer TimerOpen;
        private System.Windows.Forms.Button btnReturnToOpeningPage;
        private System.Windows.Forms.Panel pMoveToProducts;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pMeat;
        private System.Windows.Forms.PictureBox picturegif3;
        private System.Windows.Forms.Panel pFruit;
        private System.Windows.Forms.Panel pDairyProduct;
        private System.Windows.Forms.Panel pBeverage;
        private System.Windows.Forms.Panel pHome;
        private System.Windows.Forms.Panel pHelp;
        private System.Windows.Forms.Panel pVegetable;
        private System.Windows.Forms.Panel pAllTheProducts;
        private System.Windows.Forms.Button btnAllProducts;
        private System.Windows.Forms.Button btnVegetable;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFruit;
        private System.Windows.Forms.Button btnDairyProduct;
        private System.Windows.Forms.Button btnBeverage;
        private System.Windows.Forms.Button btnMeat;
        private Frontend.Usre.Meat Meat1;
        private System.Windows.Forms.Panel pOpHome;
        private Frontend.UserControls.Vegetable.Vegetable vegetable1;
        private Frontend.UserControls.Beverage beverage1;
        private Frontend.UserControls.DairyProduct.DairyProduct dairyProduct1;
        private Frontend.UserControls.Fruit.Fruit fruit1;
        private System.Windows.Forms.PictureBox picturetomato;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.PictureBox pictureBoxProducts;
        private System.Windows.Forms.DataGridView dataGridViewAllProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfLifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label lblrandom;
        private System.Windows.Forms.PictureBox pictureice;
        private System.Windows.Forms.Panel panelice;
        //private Frontend.Usre.Meat meat;
        //private Frontend.Usre.Meat meat1;
    }
}

