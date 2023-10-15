
namespace Refrigerator_FinalProj.Frontend.UserControls.Fruit
{
    partial class Fruit
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtShelfLife = new System.Windows.Forms.TextBox();
            this.lblShelfLife = new System.Windows.Forms.Label();
            this.lblBuyingDate = new System.Windows.Forms.Label();
            this.dateTimeBuyingDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.dataGridViewFruit = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRotten = new System.Windows.Forms.Button();
            this.btnPrintInfo = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblIsVarietyApple = new System.Windows.Forms.Label();
            this.lblhasSeedsApple = new System.Windows.Forms.Label();
            this.chkhasSeedsApple = new System.Windows.Forms.CheckBox();
            this.lbllblhasSeedsBanana = new System.Windows.Forms.Label();
            this.chkhasSeedsBanana = new System.Windows.Forms.CheckBox();
            this.lblisRipeBanana = new System.Windows.Forms.Label();
            this.chkIsRipeBanana = new System.Windows.Forms.CheckBox();
            this.lbllblhasSeedsGrapes = new System.Windows.Forms.Label();
            this.chkhasSeedsGrapes = new System.Windows.Forms.CheckBox();
            this.lblisGreenGrapes = new System.Windows.Forms.Label();
            this.chkisGreenGrapes = new System.Windows.Forms.CheckBox();
            this.lblHasSeedsOrange = new System.Windows.Forms.Label();
            this.chkHasSeedsOrange = new System.Windows.Forms.CheckBox();
            this.lblisOrange = new System.Windows.Forms.Label();
            this.chkisOrange = new System.Windows.Forms.CheckBox();
            this.lbllblhasSeedsPeach = new System.Windows.Forms.Label();
            this.chkhasSeedsPeach = new System.Windows.Forms.CheckBox();
            this.lblisRipePeach = new System.Windows.Forms.Label();
            this.chkIsRipePeach = new System.Windows.Forms.CheckBox();
            this.comboBoxVarietyApple = new System.Windows.Forms.ComboBox();
            this.checkedListVitamins = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTaste = new System.Windows.Forms.ComboBox();
            this.lblTaste = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFruit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(0, 867);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 47);
            this.buttonAdd.TabIndex = 198;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(192, 867);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(123, 47);
            this.buttonClear.TabIndex = 197;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(268, 13);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(148, 43);
            this.comboBoxType.TabIndex = 211;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // txtShelfLife
            // 
            this.txtShelfLife.Enabled = false;
            this.txtShelfLife.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShelfLife.Location = new System.Drawing.Point(268, 184);
            this.txtShelfLife.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShelfLife.Name = "txtShelfLife";
            this.txtShelfLife.Size = new System.Drawing.Size(148, 43);
            this.txtShelfLife.TabIndex = 215;
            // 
            // lblShelfLife
            // 
            this.lblShelfLife.AutoSize = true;
            this.lblShelfLife.BackColor = System.Drawing.Color.Transparent;
            this.lblShelfLife.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShelfLife.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelfLife.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShelfLife.Location = new System.Drawing.Point(17, 184);
            this.lblShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShelfLife.Name = "lblShelfLife";
            this.lblShelfLife.Size = new System.Drawing.Size(115, 37);
            this.lblShelfLife.TabIndex = 214;
            this.lblShelfLife.Text = "Shelf Life:";
            // 
            // lblBuyingDate
            // 
            this.lblBuyingDate.AutoSize = true;
            this.lblBuyingDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyingDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBuyingDate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyingDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBuyingDate.Location = new System.Drawing.Point(17, 131);
            this.lblBuyingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyingDate.Name = "lblBuyingDate";
            this.lblBuyingDate.Size = new System.Drawing.Size(147, 37);
            this.lblBuyingDate.TabIndex = 213;
            this.lblBuyingDate.Text = "Buying Date:";
            // 
            // dateTimeBuyingDate
            // 
            this.dateTimeBuyingDate.Enabled = false;
            this.dateTimeBuyingDate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBuyingDate.Location = new System.Drawing.Point(268, 125);
            this.dateTimeBuyingDate.Name = "dateTimeBuyingDate";
            this.dateTimeBuyingDate.Size = new System.Drawing.Size(329, 43);
            this.dateTimeBuyingDate.TabIndex = 212;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(268, 69);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(148, 43);
            this.textBoxPrice.TabIndex = 210;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrice.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(17, 75);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 37);
            this.lblPrice.TabIndex = 209;
            this.lblPrice.Text = "Price:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblType.Location = new System.Drawing.Point(17, 20);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 37);
            this.lblType.TabIndex = 208;
            this.lblType.Text = "Type:";
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(268, 350);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(148, 43);
            this.txtWeight.TabIndex = 207;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.Enabled = false;
            this.comboBoxSize.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(268, 297);
            this.comboBoxSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(148, 43);
            this.comboBoxSize.TabIndex = 206;
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColors.Enabled = false;
            this.comboBoxColors.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Location = new System.Drawing.Point(268, 242);
            this.comboBoxColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.Size = new System.Drawing.Size(148, 43);
            this.comboBoxColors.TabIndex = 205;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeight.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWeight.Location = new System.Drawing.Point(17, 350);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(137, 37);
            this.lblWeight.TabIndex = 203;
            this.lblWeight.Text = "Weight (kg):";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSize.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSize.Location = new System.Drawing.Point(17, 297);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(62, 37);
            this.lblSize.TabIndex = 202;
            this.lblSize.Text = "Size:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColor.Location = new System.Drawing.Point(17, 242);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(75, 37);
            this.lblColor.TabIndex = 201;
            this.lblColor.Text = "Color:";
            // 
            // dataGridViewFruit
            // 
            this.dataGridViewFruit.AllowUserToAddRows = false;
            this.dataGridViewFruit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFruit.Location = new System.Drawing.Point(633, 13);
            this.dataGridViewFruit.Name = "dataGridViewFruit";
            this.dataGridViewFruit.RowHeadersWidth = 62;
            this.dataGridViewFruit.RowTemplate.Height = 28;
            this.dataGridViewFruit.Size = new System.Drawing.Size(837, 567);
            this.dataGridViewFruit.TabIndex = 199;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(1015, 604);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 47);
            this.btnRemove.TabIndex = 222;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRotten
            // 
            this.btnRotten.Enabled = false;
            this.btnRotten.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotten.Location = new System.Drawing.Point(1207, 604);
            this.btnRotten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRotten.Name = "btnRotten";
            this.btnRotten.Size = new System.Drawing.Size(123, 47);
            this.btnRotten.TabIndex = 221;
            this.btnRotten.Text = "Rotten";
            this.btnRotten.UseVisualStyleBackColor = true;
            this.btnRotten.Visible = false;
            // 
            // btnPrintInfo
            // 
            this.btnPrintInfo.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInfo.Location = new System.Drawing.Point(633, 604);
            this.btnPrintInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintInfo.Name = "btnPrintInfo";
            this.btnPrintInfo.Size = new System.Drawing.Size(123, 47);
            this.btnPrintInfo.TabIndex = 220;
            this.btnPrintInfo.Text = "Print Info";
            this.btnPrintInfo.UseVisualStyleBackColor = true;
            this.btnPrintInfo.Click += new System.EventHandler(this.btnPrintInfo_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(825, 604);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 47);
            this.btnEdit.TabIndex = 219;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblIsVarietyApple
            // 
            this.lblIsVarietyApple.AutoSize = true;
            this.lblIsVarietyApple.Enabled = false;
            this.lblIsVarietyApple.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsVarietyApple.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIsVarietyApple.Location = new System.Drawing.Point(20, 570);
            this.lblIsVarietyApple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsVarietyApple.Name = "lblIsVarietyApple";
            this.lblIsVarietyApple.Size = new System.Drawing.Size(94, 35);
            this.lblIsVarietyApple.TabIndex = 223;
            this.lblIsVarietyApple.Text = "Variety:";
            this.lblIsVarietyApple.Visible = false;
            // 
            // lblhasSeedsApple
            // 
            this.lblhasSeedsApple.AutoSize = true;
            this.lblhasSeedsApple.Enabled = false;
            this.lblhasSeedsApple.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhasSeedsApple.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblhasSeedsApple.Location = new System.Drawing.Point(21, 621);
            this.lblhasSeedsApple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhasSeedsApple.Name = "lblhasSeedsApple";
            this.lblhasSeedsApple.Size = new System.Drawing.Size(115, 35);
            this.lblhasSeedsApple.TabIndex = 225;
            this.lblhasSeedsApple.Text = "has Seeds:";
            this.lblhasSeedsApple.Visible = false;
            // 
            // chkhasSeedsApple
            // 
            this.chkhasSeedsApple.AutoSize = true;
            this.chkhasSeedsApple.Enabled = false;
            this.chkhasSeedsApple.Location = new System.Drawing.Point(272, 632);
            this.chkhasSeedsApple.Name = "chkhasSeedsApple";
            this.chkhasSeedsApple.Size = new System.Drawing.Size(113, 24);
            this.chkhasSeedsApple.TabIndex = 226;
            this.chkhasSeedsApple.Text = "checkBox1";
            this.chkhasSeedsApple.UseVisualStyleBackColor = true;
            this.chkhasSeedsApple.Visible = false;
            // 
            // lbllblhasSeedsBanana
            // 
            this.lbllblhasSeedsBanana.AutoSize = true;
            this.lbllblhasSeedsBanana.Enabled = false;
            this.lbllblhasSeedsBanana.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblhasSeedsBanana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllblhasSeedsBanana.Location = new System.Drawing.Point(21, 621);
            this.lbllblhasSeedsBanana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllblhasSeedsBanana.Name = "lbllblhasSeedsBanana";
            this.lbllblhasSeedsBanana.Size = new System.Drawing.Size(115, 35);
            this.lbllblhasSeedsBanana.TabIndex = 229;
            this.lbllblhasSeedsBanana.Text = "has Seeds:";
            this.lbllblhasSeedsBanana.Visible = false;
            // 
            // chkhasSeedsBanana
            // 
            this.chkhasSeedsBanana.AutoSize = true;
            this.chkhasSeedsBanana.Enabled = false;
            this.chkhasSeedsBanana.Location = new System.Drawing.Point(272, 632);
            this.chkhasSeedsBanana.Name = "chkhasSeedsBanana";
            this.chkhasSeedsBanana.Size = new System.Drawing.Size(113, 24);
            this.chkhasSeedsBanana.TabIndex = 230;
            this.chkhasSeedsBanana.Text = "checkBox1";
            this.chkhasSeedsBanana.UseVisualStyleBackColor = true;
            this.chkhasSeedsBanana.Visible = false;
            // 
            // lblisRipeBanana
            // 
            this.lblisRipeBanana.AutoSize = true;
            this.lblisRipeBanana.Enabled = false;
            this.lblisRipeBanana.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisRipeBanana.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblisRipeBanana.Location = new System.Drawing.Point(20, 570);
            this.lblisRipeBanana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisRipeBanana.Name = "lblisRipeBanana";
            this.lblisRipeBanana.Size = new System.Drawing.Size(87, 35);
            this.lblisRipeBanana.TabIndex = 227;
            this.lblisRipeBanana.Text = "Is Ripe:";
            this.lblisRipeBanana.Visible = false;
            // 
            // chkIsRipeBanana
            // 
            this.chkIsRipeBanana.AutoSize = true;
            this.chkIsRipeBanana.Enabled = false;
            this.chkIsRipeBanana.Location = new System.Drawing.Point(271, 581);
            this.chkIsRipeBanana.Name = "chkIsRipeBanana";
            this.chkIsRipeBanana.Size = new System.Drawing.Size(113, 24);
            this.chkIsRipeBanana.TabIndex = 228;
            this.chkIsRipeBanana.Text = "checkBox1";
            this.chkIsRipeBanana.UseVisualStyleBackColor = true;
            this.chkIsRipeBanana.Visible = false;
            // 
            // lbllblhasSeedsGrapes
            // 
            this.lbllblhasSeedsGrapes.AutoSize = true;
            this.lbllblhasSeedsGrapes.Enabled = false;
            this.lbllblhasSeedsGrapes.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblhasSeedsGrapes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllblhasSeedsGrapes.Location = new System.Drawing.Point(21, 621);
            this.lbllblhasSeedsGrapes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllblhasSeedsGrapes.Name = "lbllblhasSeedsGrapes";
            this.lbllblhasSeedsGrapes.Size = new System.Drawing.Size(115, 35);
            this.lbllblhasSeedsGrapes.TabIndex = 233;
            this.lbllblhasSeedsGrapes.Text = "has Seeds:";
            this.lbllblhasSeedsGrapes.Visible = false;
            // 
            // chkhasSeedsGrapes
            // 
            this.chkhasSeedsGrapes.AutoSize = true;
            this.chkhasSeedsGrapes.Enabled = false;
            this.chkhasSeedsGrapes.Location = new System.Drawing.Point(272, 632);
            this.chkhasSeedsGrapes.Name = "chkhasSeedsGrapes";
            this.chkhasSeedsGrapes.Size = new System.Drawing.Size(113, 24);
            this.chkhasSeedsGrapes.TabIndex = 234;
            this.chkhasSeedsGrapes.Text = "checkBox1";
            this.chkhasSeedsGrapes.UseVisualStyleBackColor = true;
            this.chkhasSeedsGrapes.Visible = false;
            // 
            // lblisGreenGrapes
            // 
            this.lblisGreenGrapes.AutoSize = true;
            this.lblisGreenGrapes.Enabled = false;
            this.lblisGreenGrapes.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisGreenGrapes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblisGreenGrapes.Location = new System.Drawing.Point(20, 570);
            this.lblisGreenGrapes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisGreenGrapes.Name = "lblisGreenGrapes";
            this.lblisGreenGrapes.Size = new System.Drawing.Size(101, 35);
            this.lblisGreenGrapes.TabIndex = 231;
            this.lblisGreenGrapes.Text = "Is Green:";
            this.lblisGreenGrapes.Visible = false;
            // 
            // chkisGreenGrapes
            // 
            this.chkisGreenGrapes.AutoSize = true;
            this.chkisGreenGrapes.Enabled = false;
            this.chkisGreenGrapes.Location = new System.Drawing.Point(271, 581);
            this.chkisGreenGrapes.Name = "chkisGreenGrapes";
            this.chkisGreenGrapes.Size = new System.Drawing.Size(113, 24);
            this.chkisGreenGrapes.TabIndex = 232;
            this.chkisGreenGrapes.Text = "checkBox1";
            this.chkisGreenGrapes.UseVisualStyleBackColor = true;
            this.chkisGreenGrapes.Visible = false;
            // 
            // lblHasSeedsOrange
            // 
            this.lblHasSeedsOrange.AutoSize = true;
            this.lblHasSeedsOrange.Enabled = false;
            this.lblHasSeedsOrange.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasSeedsOrange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHasSeedsOrange.Location = new System.Drawing.Point(21, 621);
            this.lblHasSeedsOrange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasSeedsOrange.Name = "lblHasSeedsOrange";
            this.lblHasSeedsOrange.Size = new System.Drawing.Size(115, 35);
            this.lblHasSeedsOrange.TabIndex = 237;
            this.lblHasSeedsOrange.Text = "has Seeds:";
            this.lblHasSeedsOrange.Visible = false;
            // 
            // chkHasSeedsOrange
            // 
            this.chkHasSeedsOrange.AutoSize = true;
            this.chkHasSeedsOrange.Enabled = false;
            this.chkHasSeedsOrange.Location = new System.Drawing.Point(272, 632);
            this.chkHasSeedsOrange.Name = "chkHasSeedsOrange";
            this.chkHasSeedsOrange.Size = new System.Drawing.Size(113, 24);
            this.chkHasSeedsOrange.TabIndex = 238;
            this.chkHasSeedsOrange.Text = "checkBox1";
            this.chkHasSeedsOrange.UseVisualStyleBackColor = true;
            this.chkHasSeedsOrange.Visible = false;
            // 
            // lblisOrange
            // 
            this.lblisOrange.AutoSize = true;
            this.lblisOrange.Enabled = false;
            this.lblisOrange.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisOrange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblisOrange.Location = new System.Drawing.Point(20, 570);
            this.lblisOrange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisOrange.Name = "lblisOrange";
            this.lblisOrange.Size = new System.Drawing.Size(115, 35);
            this.lblisOrange.TabIndex = 235;
            this.lblisOrange.Text = "Is Orange:";
            this.lblisOrange.Visible = false;
            // 
            // chkisOrange
            // 
            this.chkisOrange.AutoSize = true;
            this.chkisOrange.Enabled = false;
            this.chkisOrange.Location = new System.Drawing.Point(271, 581);
            this.chkisOrange.Name = "chkisOrange";
            this.chkisOrange.Size = new System.Drawing.Size(113, 24);
            this.chkisOrange.TabIndex = 236;
            this.chkisOrange.Text = "checkBox1";
            this.chkisOrange.UseVisualStyleBackColor = true;
            this.chkisOrange.Visible = false;
            // 
            // lbllblhasSeedsPeach
            // 
            this.lbllblhasSeedsPeach.AutoSize = true;
            this.lbllblhasSeedsPeach.Enabled = false;
            this.lbllblhasSeedsPeach.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblhasSeedsPeach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllblhasSeedsPeach.Location = new System.Drawing.Point(21, 621);
            this.lbllblhasSeedsPeach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllblhasSeedsPeach.Name = "lbllblhasSeedsPeach";
            this.lbllblhasSeedsPeach.Size = new System.Drawing.Size(115, 35);
            this.lbllblhasSeedsPeach.TabIndex = 241;
            this.lbllblhasSeedsPeach.Text = "has Seeds:";
            this.lbllblhasSeedsPeach.Visible = false;
            // 
            // chkhasSeedsPeach
            // 
            this.chkhasSeedsPeach.AutoSize = true;
            this.chkhasSeedsPeach.Enabled = false;
            this.chkhasSeedsPeach.Location = new System.Drawing.Point(272, 632);
            this.chkhasSeedsPeach.Name = "chkhasSeedsPeach";
            this.chkhasSeedsPeach.Size = new System.Drawing.Size(113, 24);
            this.chkhasSeedsPeach.TabIndex = 242;
            this.chkhasSeedsPeach.Text = "checkBox1";
            this.chkhasSeedsPeach.UseVisualStyleBackColor = true;
            this.chkhasSeedsPeach.Visible = false;
            // 
            // lblisRipePeach
            // 
            this.lblisRipePeach.AutoSize = true;
            this.lblisRipePeach.Enabled = false;
            this.lblisRipePeach.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisRipePeach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblisRipePeach.Location = new System.Drawing.Point(20, 570);
            this.lblisRipePeach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisRipePeach.Name = "lblisRipePeach";
            this.lblisRipePeach.Size = new System.Drawing.Size(87, 35);
            this.lblisRipePeach.TabIndex = 239;
            this.lblisRipePeach.Text = "Is Ripe:";
            this.lblisRipePeach.Visible = false;
            // 
            // chkIsRipePeach
            // 
            this.chkIsRipePeach.AutoSize = true;
            this.chkIsRipePeach.Enabled = false;
            this.chkIsRipePeach.Location = new System.Drawing.Point(271, 581);
            this.chkIsRipePeach.Name = "chkIsRipePeach";
            this.chkIsRipePeach.Size = new System.Drawing.Size(113, 24);
            this.chkIsRipePeach.TabIndex = 240;
            this.chkIsRipePeach.Text = "checkBox1";
            this.chkIsRipePeach.UseVisualStyleBackColor = true;
            this.chkIsRipePeach.Visible = false;
            // 
            // comboBoxVarietyApple
            // 
            this.comboBoxVarietyApple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVarietyApple.Enabled = false;
            this.comboBoxVarietyApple.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVarietyApple.FormattingEnabled = true;
            this.comboBoxVarietyApple.Location = new System.Drawing.Point(271, 574);
            this.comboBoxVarietyApple.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxVarietyApple.Name = "comboBoxVarietyApple";
            this.comboBoxVarietyApple.Size = new System.Drawing.Size(148, 43);
            this.comboBoxVarietyApple.TabIndex = 243;
            // 
            // checkedListVitamins
            // 
            this.checkedListVitamins.Enabled = false;
            this.checkedListVitamins.FormattingEnabled = true;
            this.checkedListVitamins.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "H",
            "K"});
            this.checkedListVitamins.Location = new System.Drawing.Point(268, 459);
            this.checkedListVitamins.Name = "checkedListVitamins";
            this.checkedListVitamins.Size = new System.Drawing.Size(204, 96);
            this.checkedListVitamins.TabIndex = 245;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 244;
            this.label1.Text = "Vitamins:";
            // 
            // comboBoxTaste
            // 
            this.comboBoxTaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTaste.Enabled = false;
            this.comboBoxTaste.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTaste.FormattingEnabled = true;
            this.comboBoxTaste.Location = new System.Drawing.Point(268, 402);
            this.comboBoxTaste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTaste.Name = "comboBoxTaste";
            this.comboBoxTaste.Size = new System.Drawing.Size(148, 43);
            this.comboBoxTaste.TabIndex = 247;
            // 
            // lblTaste
            // 
            this.lblTaste.AutoSize = true;
            this.lblTaste.BackColor = System.Drawing.Color.Transparent;
            this.lblTaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaste.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTaste.Location = new System.Drawing.Point(17, 402);
            this.lblTaste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaste.Name = "lblTaste";
            this.lblTaste.Size = new System.Drawing.Size(75, 37);
            this.lblTaste.TabIndex = 246;
            this.lblTaste.Text = "Taste:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(825, 718);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(123, 43);
            this.txtID.TabIndex = 249;
            this.txtID.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(825, 661);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 47);
            this.btnUpdate.TabIndex = 248;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Fruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBoxTaste);
            this.Controls.Add(this.lblTaste);
            this.Controls.Add(this.checkedListVitamins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVarietyApple);
            this.Controls.Add(this.lbllblhasSeedsPeach);
            this.Controls.Add(this.chkhasSeedsPeach);
            this.Controls.Add(this.lblisRipePeach);
            this.Controls.Add(this.chkIsRipePeach);
            this.Controls.Add(this.lblHasSeedsOrange);
            this.Controls.Add(this.chkHasSeedsOrange);
            this.Controls.Add(this.lblisOrange);
            this.Controls.Add(this.chkisOrange);
            this.Controls.Add(this.lbllblhasSeedsGrapes);
            this.Controls.Add(this.chkhasSeedsGrapes);
            this.Controls.Add(this.lblisGreenGrapes);
            this.Controls.Add(this.chkisGreenGrapes);
            this.Controls.Add(this.lbllblhasSeedsBanana);
            this.Controls.Add(this.chkhasSeedsBanana);
            this.Controls.Add(this.lblisRipeBanana);
            this.Controls.Add(this.chkIsRipeBanana);
            this.Controls.Add(this.lblhasSeedsApple);
            this.Controls.Add(this.chkhasSeedsApple);
            this.Controls.Add(this.lblIsVarietyApple);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRotten);
            this.Controls.Add(this.btnPrintInfo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.txtShelfLife);
            this.Controls.Add(this.lblShelfLife);
            this.Controls.Add(this.lblBuyingDate);
            this.Controls.Add(this.dateTimeBuyingDate);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxColors);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.dataGridViewFruit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Name = "Fruit";
            this.Size = new System.Drawing.Size(1500, 950);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFruit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox txtShelfLife;
        private System.Windows.Forms.Label lblShelfLife;
        private System.Windows.Forms.Label lblBuyingDate;
        private System.Windows.Forms.DateTimePicker dateTimeBuyingDate;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxColors;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.DataGridView dataGridViewFruit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRotten;
        private System.Windows.Forms.Button btnPrintInfo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblIsVarietyApple;
        private System.Windows.Forms.Label lblhasSeedsApple;
        private System.Windows.Forms.CheckBox chkhasSeedsApple;
        private System.Windows.Forms.Label lbllblhasSeedsBanana;
        private System.Windows.Forms.CheckBox chkhasSeedsBanana;
        private System.Windows.Forms.Label lblisRipeBanana;
        private System.Windows.Forms.CheckBox chkIsRipeBanana;
        private System.Windows.Forms.Label lbllblhasSeedsGrapes;
        private System.Windows.Forms.CheckBox chkhasSeedsGrapes;
        private System.Windows.Forms.Label lblisGreenGrapes;
        private System.Windows.Forms.CheckBox chkisGreenGrapes;
        private System.Windows.Forms.Label lblHasSeedsOrange;
        private System.Windows.Forms.CheckBox chkHasSeedsOrange;
        private System.Windows.Forms.Label lblisOrange;
        private System.Windows.Forms.CheckBox chkisOrange;
        private System.Windows.Forms.Label lbllblhasSeedsPeach;
        private System.Windows.Forms.CheckBox chkhasSeedsPeach;
        private System.Windows.Forms.Label lblisRipePeach;
        private System.Windows.Forms.CheckBox chkIsRipePeach;
        private System.Windows.Forms.ComboBox comboBoxVarietyApple;
        private System.Windows.Forms.CheckedListBox checkedListVitamins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTaste;
        private System.Windows.Forms.Label lblTaste;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdate;
    }
}
