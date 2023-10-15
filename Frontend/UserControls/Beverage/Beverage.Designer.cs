
namespace Refrigerator_FinalProj.Frontend.UserControls
{
    partial class Beverage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtShelfLife = new System.Windows.Forms.TextBox();
            this.lblShelfLife = new System.Windows.Forms.Label();
            this.dataGridViewBeverage = new System.Windows.Forms.DataGridView();
            this.lbl_BuyingDate = new System.Windows.Forms.Label();
            this.dateTimeBuyingDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxNameBeverage = new System.Windows.Forms.ComboBox();
            this.lblNameBeverage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Flavor = new System.Windows.Forms.Label();
            this.txtLiters = new System.Windows.Forms.TextBox();
            this.lblliters = new System.Windows.Forms.Label();
            this.lblIsCarbonated = new System.Windows.Forms.Label();
            this.chkIsCarbonated = new System.Windows.Forms.CheckBox();
            this.lblMilkTypeDairy = new System.Windows.Forms.Label();
            this.chkisLactoseFreeDairy = new System.Windows.Forms.CheckBox();
            this.lblisLactoseFreeDairy = new System.Windows.Forms.Label();
            this.chkisVeganDairy = new System.Windows.Forms.CheckBox();
            this.lblisVeganDairy = new System.Windows.Forms.Label();
            this.chkisAlmondMilkDairy = new System.Windows.Forms.CheckBox();
            this.lblIsAlmondMilkDairy = new System.Windows.Forms.Label();
            this.comboBoxMilkTypeDairy = new System.Windows.Forms.ComboBox();
            this.txtFatDairy = new System.Windows.Forms.TextBox();
            this.lblfatPercentageDairy = new System.Windows.Forms.Label();
            this.chkhasCaffeineCola = new System.Windows.Forms.CheckBox();
            this.lblhasCaffeineCola = new System.Windows.Forms.Label();
            this.comboBoxFlavor = new System.Windows.Forms.ComboBox();
            this.txtsugarContentSweet = new System.Windows.Forms.TextBox();
            this.lblsugarContentSweet = new System.Windows.Forms.Label();
            this.chkisDietSweet = new System.Windows.Forms.CheckBox();
            this.lblisDietSweet = new System.Windows.Forms.Label();
            this.txtcaffeineContentEnergy = new System.Windows.Forms.TextBox();
            this.lblcaffeineContentEnergy = new System.Windows.Forms.Label();
            this.lblfruitCombinationFruitPunch = new System.Windows.Forms.Label();
            this.chkisPulpFreeFruitPunch = new System.Windows.Forms.CheckBox();
            this.lblisPulpFreeFruitPunch = new System.Windows.Forms.Label();
            this.comboBoxfruitCombinationFruitPunch = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRotten = new System.Windows.Forms.Button();
            this.btnPrintInfo = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.meat1 = new Refrigerator_FinalProj.Frontend.Usre.Meat();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeverage)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(294, 21);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(148, 43);
            this.comboBoxType.TabIndex = 114;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // txtShelfLife
            // 
            this.txtShelfLife.Enabled = false;
            this.txtShelfLife.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShelfLife.Location = new System.Drawing.Point(294, 242);
            this.txtShelfLife.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShelfLife.Name = "txtShelfLife";
            this.txtShelfLife.Size = new System.Drawing.Size(148, 43);
            this.txtShelfLife.TabIndex = 124;
            // 
            // lblShelfLife
            // 
            this.lblShelfLife.AutoSize = true;
            this.lblShelfLife.BackColor = System.Drawing.Color.Transparent;
            this.lblShelfLife.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShelfLife.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelfLife.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShelfLife.Location = new System.Drawing.Point(14, 235);
            this.lblShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShelfLife.Name = "lblShelfLife";
            this.lblShelfLife.Size = new System.Drawing.Size(115, 37);
            this.lblShelfLife.TabIndex = 123;
            this.lblShelfLife.Text = "Shelf Life:";
            // 
            // dataGridViewBeverage
            // 
            this.dataGridViewBeverage.AllowUserToAddRows = false;
            this.dataGridViewBeverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeverage.Location = new System.Drawing.Point(635, 21);
            this.dataGridViewBeverage.Name = "dataGridViewBeverage";
            this.dataGridViewBeverage.RowHeadersWidth = 62;
            this.dataGridViewBeverage.RowTemplate.Height = 28;
            this.dataGridViewBeverage.Size = new System.Drawing.Size(810, 567);
            this.dataGridViewBeverage.TabIndex = 121;
            // 
            // lbl_BuyingDate
            // 
            this.lbl_BuyingDate.AutoSize = true;
            this.lbl_BuyingDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BuyingDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BuyingDate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuyingDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_BuyingDate.Location = new System.Drawing.Point(14, 178);
            this.lbl_BuyingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BuyingDate.Name = "lbl_BuyingDate";
            this.lbl_BuyingDate.Size = new System.Drawing.Size(147, 37);
            this.lbl_BuyingDate.TabIndex = 118;
            this.lbl_BuyingDate.Text = "Buying Date:";
            // 
            // dateTimeBuyingDate
            // 
            this.dateTimeBuyingDate.Enabled = false;
            this.dateTimeBuyingDate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBuyingDate.Location = new System.Drawing.Point(294, 185);
            this.dateTimeBuyingDate.Name = "dateTimeBuyingDate";
            this.dateTimeBuyingDate.Size = new System.Drawing.Size(329, 43);
            this.dateTimeBuyingDate.TabIndex = 117;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(294, 131);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(148, 43);
            this.textBoxPrice.TabIndex = 113;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrice.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(14, 124);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 37);
            this.lblPrice.TabIndex = 112;
            this.lblPrice.Text = "Price:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblType.Location = new System.Drawing.Point(14, 21);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 37);
            this.lblType.TabIndex = 111;
            this.lblType.Text = "Type:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(0, 867);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 47);
            this.buttonAdd.TabIndex = 126;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_2);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(192, 867);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(123, 47);
            this.buttonClear.TabIndex = 125;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxNameBeverage
            // 
            this.comboBoxNameBeverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNameBeverage.Enabled = false;
            this.comboBoxNameBeverage.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNameBeverage.FormattingEnabled = true;
            this.comboBoxNameBeverage.Location = new System.Drawing.Point(294, 74);
            this.comboBoxNameBeverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxNameBeverage.Name = "comboBoxNameBeverage";
            this.comboBoxNameBeverage.Size = new System.Drawing.Size(148, 43);
            this.comboBoxNameBeverage.TabIndex = 128;
            this.comboBoxNameBeverage.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameBeverage_SelectedIndexChanged);
            // 
            // lblNameBeverage
            // 
            this.lblNameBeverage.AutoSize = true;
            this.lblNameBeverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameBeverage.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBeverage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameBeverage.Location = new System.Drawing.Point(14, 67);
            this.lblNameBeverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameBeverage.Name = "lblNameBeverage";
            this.lblNameBeverage.Size = new System.Drawing.Size(81, 37);
            this.lblNameBeverage.TabIndex = 127;
            this.lblNameBeverage.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 37);
            this.label1.TabIndex = 129;
            this.label1.Text = "Brand:";
            // 
            // lbl_Flavor
            // 
            this.lbl_Flavor.AutoSize = true;
            this.lbl_Flavor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Flavor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Flavor.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Flavor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Flavor.Location = new System.Drawing.Point(14, 347);
            this.lbl_Flavor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Flavor.Name = "lbl_Flavor";
            this.lbl_Flavor.Size = new System.Drawing.Size(85, 37);
            this.lbl_Flavor.TabIndex = 131;
            this.lbl_Flavor.Text = "Flavor:";
            // 
            // txtLiters
            // 
            this.txtLiters.Enabled = false;
            this.txtLiters.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiters.Location = new System.Drawing.Point(294, 407);
            this.txtLiters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLiters.Name = "txtLiters";
            this.txtLiters.Size = new System.Drawing.Size(148, 43);
            this.txtLiters.TabIndex = 134;
            // 
            // lblliters
            // 
            this.lblliters.AutoSize = true;
            this.lblliters.BackColor = System.Drawing.Color.Transparent;
            this.lblliters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblliters.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliters.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblliters.Location = new System.Drawing.Point(14, 398);
            this.lblliters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblliters.Name = "lblliters";
            this.lblliters.Size = new System.Drawing.Size(79, 37);
            this.lblliters.TabIndex = 133;
            this.lblliters.Text = "Liters:";
            // 
            // lblIsCarbonated
            // 
            this.lblIsCarbonated.AutoSize = true;
            this.lblIsCarbonated.BackColor = System.Drawing.Color.Transparent;
            this.lblIsCarbonated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIsCarbonated.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsCarbonated.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIsCarbonated.Location = new System.Drawing.Point(14, 451);
            this.lblIsCarbonated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsCarbonated.Name = "lblIsCarbonated";
            this.lblIsCarbonated.Size = new System.Drawing.Size(161, 37);
            this.lblIsCarbonated.TabIndex = 135;
            this.lblIsCarbonated.Text = "Is Carbonated:";
            // 
            // chkIsCarbonated
            // 
            this.chkIsCarbonated.AutoSize = true;
            this.chkIsCarbonated.Enabled = false;
            this.chkIsCarbonated.Location = new System.Drawing.Point(294, 471);
            this.chkIsCarbonated.Name = "chkIsCarbonated";
            this.chkIsCarbonated.Size = new System.Drawing.Size(113, 24);
            this.chkIsCarbonated.TabIndex = 136;
            this.chkIsCarbonated.Text = "checkBox1";
            this.chkIsCarbonated.UseVisualStyleBackColor = true;
            // 
            // lblMilkTypeDairy
            // 
            this.lblMilkTypeDairy.AutoSize = true;
            this.lblMilkTypeDairy.BackColor = System.Drawing.Color.Transparent;
            this.lblMilkTypeDairy.Enabled = false;
            this.lblMilkTypeDairy.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilkTypeDairy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMilkTypeDairy.Location = new System.Drawing.Point(16, 508);
            this.lblMilkTypeDairy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilkTypeDairy.Name = "lblMilkTypeDairy";
            this.lblMilkTypeDairy.Size = new System.Drawing.Size(120, 35);
            this.lblMilkTypeDairy.TabIndex = 137;
            this.lblMilkTypeDairy.Text = "Milk Type:";
            this.lblMilkTypeDairy.Visible = false;
            // 
            // chkisLactoseFreeDairy
            // 
            this.chkisLactoseFreeDairy.AutoSize = true;
            this.chkisLactoseFreeDairy.Enabled = false;
            this.chkisLactoseFreeDairy.Location = new System.Drawing.Point(294, 571);
            this.chkisLactoseFreeDairy.Name = "chkisLactoseFreeDairy";
            this.chkisLactoseFreeDairy.Size = new System.Drawing.Size(113, 24);
            this.chkisLactoseFreeDairy.TabIndex = 140;
            this.chkisLactoseFreeDairy.Text = "checkBox1";
            this.chkisLactoseFreeDairy.UseVisualStyleBackColor = true;
            this.chkisLactoseFreeDairy.Visible = false;
            // 
            // lblisLactoseFreeDairy
            // 
            this.lblisLactoseFreeDairy.AutoSize = true;
            this.lblisLactoseFreeDairy.BackColor = System.Drawing.Color.Transparent;
            this.lblisLactoseFreeDairy.Enabled = false;
            this.lblisLactoseFreeDairy.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisLactoseFreeDairy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblisLactoseFreeDairy.Location = new System.Drawing.Point(14, 551);
            this.lblisLactoseFreeDairy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisLactoseFreeDairy.Name = "lblisLactoseFreeDairy";
            this.lblisLactoseFreeDairy.Size = new System.Drawing.Size(166, 35);
            this.lblisLactoseFreeDairy.TabIndex = 139;
            this.lblisLactoseFreeDairy.Text = "Is Lactose Free:";
            this.lblisLactoseFreeDairy.Visible = false;
            // 
            // chkisVeganDairy
            // 
            this.chkisVeganDairy.AutoSize = true;
            this.chkisVeganDairy.Enabled = false;
            this.chkisVeganDairy.Location = new System.Drawing.Point(294, 632);
            this.chkisVeganDairy.Name = "chkisVeganDairy";
            this.chkisVeganDairy.Size = new System.Drawing.Size(113, 24);
            this.chkisVeganDairy.TabIndex = 142;
            this.chkisVeganDairy.Text = "checkBox1";
            this.chkisVeganDairy.UseVisualStyleBackColor = true;
            this.chkisVeganDairy.Visible = false;
            // 
            // lblisVeganDairy
            // 
            this.lblisVeganDairy.AutoSize = true;
            this.lblisVeganDairy.BackColor = System.Drawing.Color.Transparent;
            this.lblisVeganDairy.Enabled = false;
            this.lblisVeganDairy.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisVeganDairy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblisVeganDairy.Location = new System.Drawing.Point(16, 611);
            this.lblisVeganDairy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisVeganDairy.Name = "lblisVeganDairy";
            this.lblisVeganDairy.Size = new System.Drawing.Size(103, 35);
            this.lblisVeganDairy.TabIndex = 141;
            this.lblisVeganDairy.Text = "Is Vegan:";
            this.lblisVeganDairy.Visible = false;
            // 
            // chkisAlmondMilkDairy
            // 
            this.chkisAlmondMilkDairy.AutoSize = true;
            this.chkisAlmondMilkDairy.Enabled = false;
            this.chkisAlmondMilkDairy.Location = new System.Drawing.Point(294, 668);
            this.chkisAlmondMilkDairy.Name = "chkisAlmondMilkDairy";
            this.chkisAlmondMilkDairy.Size = new System.Drawing.Size(113, 24);
            this.chkisAlmondMilkDairy.TabIndex = 144;
            this.chkisAlmondMilkDairy.Text = "checkBox1";
            this.chkisAlmondMilkDairy.UseVisualStyleBackColor = true;
            this.chkisAlmondMilkDairy.Visible = false;
            // 
            // lblIsAlmondMilkDairy
            // 
            this.lblIsAlmondMilkDairy.AutoSize = true;
            this.lblIsAlmondMilkDairy.BackColor = System.Drawing.Color.Transparent;
            this.lblIsAlmondMilkDairy.Enabled = false;
            this.lblIsAlmondMilkDairy.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsAlmondMilkDairy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIsAlmondMilkDairy.Location = new System.Drawing.Point(14, 661);
            this.lblIsAlmondMilkDairy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsAlmondMilkDairy.Name = "lblIsAlmondMilkDairy";
            this.lblIsAlmondMilkDairy.Size = new System.Drawing.Size(122, 35);
            this.lblIsAlmondMilkDairy.TabIndex = 143;
            this.lblIsAlmondMilkDairy.Text = "Is Almond:";
            this.lblIsAlmondMilkDairy.Visible = false;
            // 
            // comboBoxMilkTypeDairy
            // 
            this.comboBoxMilkTypeDairy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMilkTypeDairy.Enabled = false;
            this.comboBoxMilkTypeDairy.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMilkTypeDairy.FormattingEnabled = true;
            this.comboBoxMilkTypeDairy.Location = new System.Drawing.Point(294, 505);
            this.comboBoxMilkTypeDairy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMilkTypeDairy.Name = "comboBoxMilkTypeDairy";
            this.comboBoxMilkTypeDairy.Size = new System.Drawing.Size(148, 43);
            this.comboBoxMilkTypeDairy.TabIndex = 145;
            this.comboBoxMilkTypeDairy.Visible = false;
            // 
            // txtFatDairy
            // 
            this.txtFatDairy.Enabled = false;
            this.txtFatDairy.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatDairy.Location = new System.Drawing.Point(294, 713);
            this.txtFatDairy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFatDairy.Name = "txtFatDairy";
            this.txtFatDairy.Size = new System.Drawing.Size(148, 43);
            this.txtFatDairy.TabIndex = 147;
            this.txtFatDairy.Visible = false;
            // 
            // lblfatPercentageDairy
            // 
            this.lblfatPercentageDairy.AutoSize = true;
            this.lblfatPercentageDairy.BackColor = System.Drawing.Color.Transparent;
            this.lblfatPercentageDairy.Enabled = false;
            this.lblfatPercentageDairy.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfatPercentageDairy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfatPercentageDairy.Location = new System.Drawing.Point(14, 714);
            this.lblfatPercentageDairy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfatPercentageDairy.Name = "lblfatPercentageDairy";
            this.lblfatPercentageDairy.Size = new System.Drawing.Size(100, 35);
            this.lblfatPercentageDairy.TabIndex = 146;
            this.lblfatPercentageDairy.Text = "Fat (%) :";
            this.lblfatPercentageDairy.Visible = false;
            // 
            // chkhasCaffeineCola
            // 
            this.chkhasCaffeineCola.AutoSize = true;
            this.chkhasCaffeineCola.Enabled = false;
            this.chkhasCaffeineCola.Location = new System.Drawing.Point(294, 632);
            this.chkhasCaffeineCola.Name = "chkhasCaffeineCola";
            this.chkhasCaffeineCola.Size = new System.Drawing.Size(113, 24);
            this.chkhasCaffeineCola.TabIndex = 149;
            this.chkhasCaffeineCola.Text = "checkBox1";
            this.chkhasCaffeineCola.UseVisualStyleBackColor = true;
            this.chkhasCaffeineCola.Visible = false;
            // 
            // lblhasCaffeineCola
            // 
            this.lblhasCaffeineCola.AutoSize = true;
            this.lblhasCaffeineCola.BackColor = System.Drawing.Color.Transparent;
            this.lblhasCaffeineCola.Enabled = false;
            this.lblhasCaffeineCola.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhasCaffeineCola.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblhasCaffeineCola.Location = new System.Drawing.Point(16, 611);
            this.lblhasCaffeineCola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhasCaffeineCola.Name = "lblhasCaffeineCola";
            this.lblhasCaffeineCola.Size = new System.Drawing.Size(140, 35);
            this.lblhasCaffeineCola.TabIndex = 148;
            this.lblhasCaffeineCola.Text = "has Caffeine:";
            this.lblhasCaffeineCola.Visible = false;
            // 
            // comboBoxFlavor
            // 
            this.comboBoxFlavor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlavor.Enabled = false;
            this.comboBoxFlavor.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFlavor.FormattingEnabled = true;
            this.comboBoxFlavor.Location = new System.Drawing.Point(294, 348);
            this.comboBoxFlavor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFlavor.Name = "comboBoxFlavor";
            this.comboBoxFlavor.Size = new System.Drawing.Size(148, 43);
            this.comboBoxFlavor.TabIndex = 150;
            // 
            // txtsugarContentSweet
            // 
            this.txtsugarContentSweet.Enabled = false;
            this.txtsugarContentSweet.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsugarContentSweet.Location = new System.Drawing.Point(294, 558);
            this.txtsugarContentSweet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsugarContentSweet.Name = "txtsugarContentSweet";
            this.txtsugarContentSweet.Size = new System.Drawing.Size(148, 43);
            this.txtsugarContentSweet.TabIndex = 154;
            this.txtsugarContentSweet.Visible = false;
            // 
            // lblsugarContentSweet
            // 
            this.lblsugarContentSweet.AutoSize = true;
            this.lblsugarContentSweet.BackColor = System.Drawing.Color.Transparent;
            this.lblsugarContentSweet.Enabled = false;
            this.lblsugarContentSweet.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsugarContentSweet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsugarContentSweet.Location = new System.Drawing.Point(14, 558);
            this.lblsugarContentSweet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsugarContentSweet.Name = "lblsugarContentSweet";
            this.lblsugarContentSweet.Size = new System.Drawing.Size(250, 35);
            this.lblsugarContentSweet.TabIndex = 153;
            this.lblsugarContentSweet.Text = "Sugar Content (grams):";
            this.lblsugarContentSweet.Visible = false;
            // 
            // chkisDietSweet
            // 
            this.chkisDietSweet.AutoSize = true;
            this.chkisDietSweet.Enabled = false;
            this.chkisDietSweet.Location = new System.Drawing.Point(294, 505);
            this.chkisDietSweet.Name = "chkisDietSweet";
            this.chkisDietSweet.Size = new System.Drawing.Size(113, 24);
            this.chkisDietSweet.TabIndex = 152;
            this.chkisDietSweet.Text = "checkBox1";
            this.chkisDietSweet.UseVisualStyleBackColor = true;
            this.chkisDietSweet.Visible = false;
            // 
            // lblisDietSweet
            // 
            this.lblisDietSweet.AutoSize = true;
            this.lblisDietSweet.BackColor = System.Drawing.Color.Transparent;
            this.lblisDietSweet.Enabled = false;
            this.lblisDietSweet.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisDietSweet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblisDietSweet.Location = new System.Drawing.Point(16, 508);
            this.lblisDietSweet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisDietSweet.Name = "lblisDietSweet";
            this.lblisDietSweet.Size = new System.Drawing.Size(84, 35);
            this.lblisDietSweet.TabIndex = 151;
            this.lblisDietSweet.Text = "Is Diet:";
            this.lblisDietSweet.Visible = false;
            // 
            // txtcaffeineContentEnergy
            // 
            this.txtcaffeineContentEnergy.Enabled = false;
            this.txtcaffeineContentEnergy.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaffeineContentEnergy.Location = new System.Drawing.Point(294, 611);
            this.txtcaffeineContentEnergy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcaffeineContentEnergy.Name = "txtcaffeineContentEnergy";
            this.txtcaffeineContentEnergy.Size = new System.Drawing.Size(148, 43);
            this.txtcaffeineContentEnergy.TabIndex = 156;
            this.txtcaffeineContentEnergy.Visible = false;
            // 
            // lblcaffeineContentEnergy
            // 
            this.lblcaffeineContentEnergy.AutoSize = true;
            this.lblcaffeineContentEnergy.BackColor = System.Drawing.Color.Transparent;
            this.lblcaffeineContentEnergy.Enabled = false;
            this.lblcaffeineContentEnergy.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaffeineContentEnergy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcaffeineContentEnergy.Location = new System.Drawing.Point(16, 611);
            this.lblcaffeineContentEnergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcaffeineContentEnergy.Name = "lblcaffeineContentEnergy";
            this.lblcaffeineContentEnergy.Size = new System.Drawing.Size(225, 35);
            this.lblcaffeineContentEnergy.TabIndex = 155;
            this.lblcaffeineContentEnergy.Text = "Caffeine Content (%):";
            this.lblcaffeineContentEnergy.Visible = false;
            // 
            // lblfruitCombinationFruitPunch
            // 
            this.lblfruitCombinationFruitPunch.AutoSize = true;
            this.lblfruitCombinationFruitPunch.BackColor = System.Drawing.Color.Transparent;
            this.lblfruitCombinationFruitPunch.Enabled = false;
            this.lblfruitCombinationFruitPunch.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfruitCombinationFruitPunch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfruitCombinationFruitPunch.Location = new System.Drawing.Point(16, 611);
            this.lblfruitCombinationFruitPunch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfruitCombinationFruitPunch.Name = "lblfruitCombinationFruitPunch";
            this.lblfruitCombinationFruitPunch.Size = new System.Drawing.Size(200, 35);
            this.lblfruitCombinationFruitPunch.TabIndex = 159;
            this.lblfruitCombinationFruitPunch.Text = "fruit Combination:";
            this.lblfruitCombinationFruitPunch.Visible = false;
            // 
            // chkisPulpFreeFruitPunch
            // 
            this.chkisPulpFreeFruitPunch.AutoSize = true;
            this.chkisPulpFreeFruitPunch.Enabled = false;
            this.chkisPulpFreeFruitPunch.Location = new System.Drawing.Point(294, 668);
            this.chkisPulpFreeFruitPunch.Name = "chkisPulpFreeFruitPunch";
            this.chkisPulpFreeFruitPunch.Size = new System.Drawing.Size(113, 24);
            this.chkisPulpFreeFruitPunch.TabIndex = 158;
            this.chkisPulpFreeFruitPunch.Text = "checkBox1";
            this.chkisPulpFreeFruitPunch.UseVisualStyleBackColor = true;
            this.chkisPulpFreeFruitPunch.Visible = false;
            // 
            // lblisPulpFreeFruitPunch
            // 
            this.lblisPulpFreeFruitPunch.AutoSize = true;
            this.lblisPulpFreeFruitPunch.BackColor = System.Drawing.Color.Transparent;
            this.lblisPulpFreeFruitPunch.Enabled = false;
            this.lblisPulpFreeFruitPunch.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisPulpFreeFruitPunch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblisPulpFreeFruitPunch.Location = new System.Drawing.Point(14, 661);
            this.lblisPulpFreeFruitPunch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisPulpFreeFruitPunch.Name = "lblisPulpFreeFruitPunch";
            this.lblisPulpFreeFruitPunch.Size = new System.Drawing.Size(138, 35);
            this.lblisPulpFreeFruitPunch.TabIndex = 157;
            this.lblisPulpFreeFruitPunch.Text = "Is Pulp Free:";
            this.lblisPulpFreeFruitPunch.Visible = false;
            // 
            // comboBoxfruitCombinationFruitPunch
            // 
            this.comboBoxfruitCombinationFruitPunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxfruitCombinationFruitPunch.Enabled = false;
            this.comboBoxfruitCombinationFruitPunch.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxfruitCombinationFruitPunch.FormattingEnabled = true;
            this.comboBoxfruitCombinationFruitPunch.Location = new System.Drawing.Point(294, 611);
            this.comboBoxfruitCombinationFruitPunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxfruitCombinationFruitPunch.Name = "comboBoxfruitCombinationFruitPunch";
            this.comboBoxfruitCombinationFruitPunch.Size = new System.Drawing.Size(221, 43);
            this.comboBoxfruitCombinationFruitPunch.TabIndex = 161;
            this.comboBoxfruitCombinationFruitPunch.Visible = false;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrand.Enabled = false;
            this.comboBoxBrand.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(294, 296);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(148, 43);
            this.comboBoxBrand.TabIndex = 162;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(827, 717);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(123, 43);
            this.txtID.TabIndex = 235;
            this.txtID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(827, 660);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 47);
            this.btnUpdate.TabIndex = 234;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(1017, 605);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 47);
            this.btnRemove.TabIndex = 233;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRotten
            // 
            this.btnRotten.Enabled = false;
            this.btnRotten.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotten.Location = new System.Drawing.Point(1209, 605);
            this.btnRotten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRotten.Name = "btnRotten";
            this.btnRotten.Size = new System.Drawing.Size(123, 47);
            this.btnRotten.TabIndex = 232;
            this.btnRotten.Text = "Rotten";
            this.btnRotten.UseVisualStyleBackColor = true;
            this.btnRotten.Visible = false;
            // 
            // btnPrintInfo
            // 
            this.btnPrintInfo.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInfo.Location = new System.Drawing.Point(635, 605);
            this.btnPrintInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintInfo.Name = "btnPrintInfo";
            this.btnPrintInfo.Size = new System.Drawing.Size(123, 47);
            this.btnPrintInfo.TabIndex = 231;
            this.btnPrintInfo.Text = "Print Info";
            this.btnPrintInfo.UseVisualStyleBackColor = true;
            this.btnPrintInfo.Click += new System.EventHandler(this.btnPrintInfo_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(827, 605);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 47);
            this.btnEdit.TabIndex = 230;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // meat1
            // 
            this.meat1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.meat1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.meat1.Location = new System.Drawing.Point(326, 31);
            this.meat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meat1.Name = "meat1";
            this.meat1.Size = new System.Drawing.Size(8, 8);
            this.meat1.TabIndex = 122;
            // 
            // Beverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRotten);
            this.Controls.Add(this.btnPrintInfo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxfruitCombinationFruitPunch);
            this.Controls.Add(this.lblfruitCombinationFruitPunch);
            this.Controls.Add(this.chkisPulpFreeFruitPunch);
            this.Controls.Add(this.lblisPulpFreeFruitPunch);
            this.Controls.Add(this.txtcaffeineContentEnergy);
            this.Controls.Add(this.lblcaffeineContentEnergy);
            this.Controls.Add(this.txtsugarContentSweet);
            this.Controls.Add(this.lblsugarContentSweet);
            this.Controls.Add(this.chkisDietSweet);
            this.Controls.Add(this.lblisDietSweet);
            this.Controls.Add(this.comboBoxFlavor);
            this.Controls.Add(this.chkhasCaffeineCola);
            this.Controls.Add(this.lblhasCaffeineCola);
            this.Controls.Add(this.txtFatDairy);
            this.Controls.Add(this.lblfatPercentageDairy);
            this.Controls.Add(this.comboBoxMilkTypeDairy);
            this.Controls.Add(this.chkisAlmondMilkDairy);
            this.Controls.Add(this.lblIsAlmondMilkDairy);
            this.Controls.Add(this.chkisVeganDairy);
            this.Controls.Add(this.lblisVeganDairy);
            this.Controls.Add(this.chkisLactoseFreeDairy);
            this.Controls.Add(this.lblisLactoseFreeDairy);
            this.Controls.Add(this.lblMilkTypeDairy);
            this.Controls.Add(this.chkIsCarbonated);
            this.Controls.Add(this.lblIsCarbonated);
            this.Controls.Add(this.txtLiters);
            this.Controls.Add(this.lblliters);
            this.Controls.Add(this.lbl_Flavor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNameBeverage);
            this.Controls.Add(this.lblNameBeverage);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.txtShelfLife);
            this.Controls.Add(this.lblShelfLife);
            this.Controls.Add(this.meat1);
            this.Controls.Add(this.dataGridViewBeverage);
            this.Controls.Add(this.lbl_BuyingDate);
            this.Controls.Add(this.dateTimeBuyingDate);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Name = "Beverage";
            this.Size = new System.Drawing.Size(1472, 942);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeverage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox txtShelfLife;
        private System.Windows.Forms.Label lblShelfLife;
        private Usre.Meat meat1;
        private System.Windows.Forms.DataGridView dataGridViewBeverage;
        private System.Windows.Forms.Label lbl_BuyingDate;
        private System.Windows.Forms.DateTimePicker dateTimeBuyingDate;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxNameBeverage;
        private System.Windows.Forms.Label lblNameBeverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Flavor;
        private System.Windows.Forms.TextBox txtLiters;
        private System.Windows.Forms.Label lblliters;
        private System.Windows.Forms.Label lblIsCarbonated;
        private System.Windows.Forms.CheckBox chkIsCarbonated;
        private System.Windows.Forms.Label lblMilkTypeDairy;
        private System.Windows.Forms.CheckBox chkisLactoseFreeDairy;
        private System.Windows.Forms.Label lblisLactoseFreeDairy;
        private System.Windows.Forms.CheckBox chkisVeganDairy;
        private System.Windows.Forms.Label lblisVeganDairy;
        private System.Windows.Forms.CheckBox chkisAlmondMilkDairy;
        private System.Windows.Forms.Label lblIsAlmondMilkDairy;
        private System.Windows.Forms.ComboBox comboBoxMilkTypeDairy;
        private System.Windows.Forms.TextBox txtFatDairy;
        private System.Windows.Forms.Label lblfatPercentageDairy;
        private System.Windows.Forms.CheckBox chkhasCaffeineCola;
        private System.Windows.Forms.Label lblhasCaffeineCola;
        private System.Windows.Forms.ComboBox comboBoxFlavor;
        private System.Windows.Forms.TextBox txtsugarContentSweet;
        private System.Windows.Forms.Label lblsugarContentSweet;
        private System.Windows.Forms.CheckBox chkisDietSweet;
        private System.Windows.Forms.Label lblisDietSweet;
        private System.Windows.Forms.TextBox txtcaffeineContentEnergy;
        private System.Windows.Forms.Label lblcaffeineContentEnergy;
        private System.Windows.Forms.Label lblfruitCombinationFruitPunch;
        private System.Windows.Forms.CheckBox chkisPulpFreeFruitPunch;
        private System.Windows.Forms.Label lblisPulpFreeFruitPunch;
        private System.Windows.Forms.ComboBox comboBoxfruitCombinationFruitPunch;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRotten;
        private System.Windows.Forms.Button btnPrintInfo;
        private System.Windows.Forms.Button btnEdit;
    }
}
