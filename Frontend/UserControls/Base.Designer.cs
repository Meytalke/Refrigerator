
namespace Refrigerator_FinalProj.Frontend.UserControls
{
    partial class Base
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
            this.dataGridViewMeats = new System.Windows.Forms.DataGridView();
            this.dateTime_ExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_ExpirationDate = new System.Windows.Forms.Label();
            this.lbl_ManufacturingDate = new System.Windows.Forms.Label();
            this.dateTime_ManufacturingDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox_ShelfLife = new System.Windows.Forms.TextBox();
            this.lbl_ShelfLife = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeats)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMeats
            // 
            this.dataGridViewMeats.AllowUserToAddRows = false;
            this.dataGridViewMeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeats.Location = new System.Drawing.Point(627, 21);
            this.dataGridViewMeats.Name = "dataGridViewMeats";
            this.dataGridViewMeats.RowHeadersWidth = 62;
            this.dataGridViewMeats.RowTemplate.Height = 28;
            this.dataGridViewMeats.Size = new System.Drawing.Size(810, 567);
            this.dataGridViewMeats.TabIndex = 61;
            // 
            // dateTime_ExpirationDate
            // 
            this.dateTime_ExpirationDate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_ExpirationDate.Location = new System.Drawing.Point(260, 255);
            this.dateTime_ExpirationDate.Name = "dateTime_ExpirationDate";
            this.dateTime_ExpirationDate.Size = new System.Drawing.Size(329, 43);
            this.dateTime_ExpirationDate.TabIndex = 54;
            // 
            // lbl_ExpirationDate
            // 
            this.lbl_ExpirationDate.AutoSize = true;
            this.lbl_ExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ExpirationDate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExpirationDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ExpirationDate.Location = new System.Drawing.Point(11, 255);
            this.lbl_ExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ExpirationDate.Name = "lbl_ExpirationDate";
            this.lbl_ExpirationDate.Size = new System.Drawing.Size(181, 35);
            this.lbl_ExpirationDate.TabIndex = 53;
            this.lbl_ExpirationDate.Text = "Expiration Date:";
            // 
            // lbl_ManufacturingDate
            // 
            this.lbl_ManufacturingDate.AutoSize = true;
            this.lbl_ManufacturingDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ManufacturingDate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManufacturingDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ManufacturingDate.Location = new System.Drawing.Point(11, 192);
            this.lbl_ManufacturingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ManufacturingDate.Name = "lbl_ManufacturingDate";
            this.lbl_ManufacturingDate.Size = new System.Drawing.Size(222, 35);
            this.lbl_ManufacturingDate.TabIndex = 52;
            this.lbl_ManufacturingDate.Text = "Manufacturing Date:";
            // 
            // dateTime_ManufacturingDate
            // 
            this.dateTime_ManufacturingDate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_ManufacturingDate.Location = new System.Drawing.Point(260, 186);
            this.dateTime_ManufacturingDate.Name = "dateTime_ManufacturingDate";
            this.dateTime_ManufacturingDate.Size = new System.Drawing.Size(329, 43);
            this.dateTime_ManufacturingDate.TabIndex = 51;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(260, 127);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(148, 43);
            this.txtQuantity.TabIndex = 50;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuantity.Location = new System.Drawing.Point(11, 133);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(110, 35);
            this.lblQuantity.TabIndex = 49;
            this.lblQuantity.Text = "Quantity:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(260, 21);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(148, 43);
            this.comboBoxType.TabIndex = 48;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(0, 867);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 47);
            this.buttonAdd.TabIndex = 47;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.Location = new System.Drawing.Point(260, 73);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(148, 43);
            this.textBoxWeight.TabIndex = 46;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(11, 79);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 35);
            this.lblPrice.TabIndex = 45;
            this.lblPrice.Text = "Price:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblType.Location = new System.Drawing.Point(11, 21);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(69, 35);
            this.lblType.TabIndex = 44;
            this.lblType.Text = "Type:";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(192, 867);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(123, 47);
            this.buttonClear.TabIndex = 43;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // textBox_ShelfLife
            // 
            this.textBox_ShelfLife.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ShelfLife.Location = new System.Drawing.Point(260, 309);
            this.textBox_ShelfLife.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_ShelfLife.Name = "textBox_ShelfLife";
            this.textBox_ShelfLife.Size = new System.Drawing.Size(148, 43);
            this.textBox_ShelfLife.TabIndex = 56;
            // 
            // lbl_ShelfLife
            // 
            this.lbl_ShelfLife.AutoSize = true;
            this.lbl_ShelfLife.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ShelfLife.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShelfLife.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ShelfLife.Location = new System.Drawing.Point(11, 315);
            this.lbl_ShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ShelfLife.Name = "lbl_ShelfLife";
            this.lbl_ShelfLife.Size = new System.Drawing.Size(113, 35);
            this.lbl_ShelfLife.TabIndex = 55;
            this.lbl_ShelfLife.Text = "Shelf Life:";
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.dataGridViewMeats);
            this.Controls.Add(this.textBox_ShelfLife);
            this.Controls.Add(this.lbl_ShelfLife);
            this.Controls.Add(this.dateTime_ExpirationDate);
            this.Controls.Add(this.lbl_ExpirationDate);
            this.Controls.Add(this.lbl_ManufacturingDate);
            this.Controls.Add(this.dateTime_ManufacturingDate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.buttonClear);
            this.Name = "Base";
            this.Size = new System.Drawing.Size(1500, 950);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMeats;
        private System.Windows.Forms.DateTimePicker dateTime_ExpirationDate;
        private System.Windows.Forms.Label lbl_ExpirationDate;
        private System.Windows.Forms.Label lbl_ManufacturingDate;
        private System.Windows.Forms.DateTimePicker dateTime_ManufacturingDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox_ShelfLife;
        private System.Windows.Forms.Label lbl_ShelfLife;
    }
}
