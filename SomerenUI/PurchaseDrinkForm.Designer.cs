namespace SomerenUI
{
    partial class purchaseDrinkForm
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
            lblChooseDrink = new System.Windows.Forms.Label();
            cmbBoxChooseDrink = new System.Windows.Forms.ComboBox();
            txtBoxDrinkQuantity = new System.Windows.Forms.TextBox();
            lblDrinkQuantity = new System.Windows.Forms.Label();
            lblTotalPrice = new System.Windows.Forms.Label();
            lblTotalPriceValue = new System.Windows.Forms.Label();
            lbllblTotalPriceWithVatValue = new System.Windows.Forms.Label();
            lbllblTotalPriceWithVat = new System.Windows.Forms.Label();
            btnAddPurchaseDrink = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblChooseDrink
            // 
            lblChooseDrink.AutoSize = true;
            lblChooseDrink.Location = new System.Drawing.Point(16, 24);
            lblChooseDrink.Name = "lblChooseDrink";
            lblChooseDrink.Size = new System.Drawing.Size(77, 15);
            lblChooseDrink.TabIndex = 0;
            lblChooseDrink.Text = "Choose drink";
            // 
            // cmbBoxChooseDrink
            // 
            cmbBoxChooseDrink.FormattingEnabled = true;
            cmbBoxChooseDrink.Location = new System.Drawing.Point(130, 21);
            cmbBoxChooseDrink.Name = "cmbBoxChooseDrink";
            cmbBoxChooseDrink.Size = new System.Drawing.Size(200, 23);
            cmbBoxChooseDrink.TabIndex = 1;
            // 
            // txtBoxDrinkQuantity
            // 
            txtBoxDrinkQuantity.Location = new System.Drawing.Point(130, 60);
            txtBoxDrinkQuantity.Name = "txtBoxDrinkQuantity";
            txtBoxDrinkQuantity.Size = new System.Drawing.Size(100, 23);
            txtBoxDrinkQuantity.TabIndex = 2;
            // 
            // lblDrinkQuantity
            // 
            lblDrinkQuantity.AutoSize = true;
            lblDrinkQuantity.Location = new System.Drawing.Point(16, 63);
            lblDrinkQuantity.Name = "lblDrinkQuantity";
            lblDrinkQuantity.Size = new System.Drawing.Size(85, 15);
            lblDrinkQuantity.TabIndex = 3;
            lblDrinkQuantity.Text = "Drink quantity:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new System.Drawing.Point(130, 120);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new System.Drawing.Size(64, 15);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "Total price:";
            // 
            // lblTotalPriceValue
            // 
            lblTotalPriceValue.Location = new System.Drawing.Point(260, 120);
            lblTotalPriceValue.Name = "lblTotalPriceValue";
            lblTotalPriceValue.Size = new System.Drawing.Size(70, 15);
            lblTotalPriceValue.TabIndex = 5;
            lblTotalPriceValue.Text = "0.00";
            lblTotalPriceValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbllblTotalPriceWithVatValue
            // 
            lbllblTotalPriceWithVatValue.Location = new System.Drawing.Point(260, 150);
            lbllblTotalPriceWithVatValue.Name = "lbllblTotalPriceWithVatValue";
            lbllblTotalPriceWithVatValue.Size = new System.Drawing.Size(70, 15);
            lbllblTotalPriceWithVatValue.TabIndex = 7;
            lbllblTotalPriceWithVatValue.Text = "0.00";
            lbllblTotalPriceWithVatValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbllblTotalPriceWithVat
            // 
            lbllblTotalPriceWithVat.AutoSize = true;
            lbllblTotalPriceWithVat.Location = new System.Drawing.Point(130, 150);
            lbllblTotalPriceWithVat.Name = "lbllblTotalPriceWithVat";
            lbllblTotalPriceWithVat.Size = new System.Drawing.Size(112, 15);
            lbllblTotalPriceWithVat.TabIndex = 6;
            lbllblTotalPriceWithVat.Text = "Total price with VAT:";
            // 
            // btnAddPurchaseDrink
            // 
            btnAddPurchaseDrink.Location = new System.Drawing.Point(255, 200);
            btnAddPurchaseDrink.Name = "btnAddPurchaseDrink";
            btnAddPurchaseDrink.Size = new System.Drawing.Size(75, 23);
            btnAddPurchaseDrink.TabIndex = 8;
            btnAddPurchaseDrink.Text = "button1";
            btnAddPurchaseDrink.UseVisualStyleBackColor = true;
            // 
            // purchaseDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(354, 251);
            Controls.Add(btnAddPurchaseDrink);
            Controls.Add(lbllblTotalPriceWithVatValue);
            Controls.Add(lbllblTotalPriceWithVat);
            Controls.Add(lblTotalPriceValue);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblDrinkQuantity);
            Controls.Add(txtBoxDrinkQuantity);
            Controls.Add(cmbBoxChooseDrink);
            Controls.Add(lblChooseDrink);
            Name = "purchaseDrinkForm";
            Text = "Drink Purchase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblChooseDrink;
        private System.Windows.Forms.ComboBox cmbBoxChooseDrink;
        private System.Windows.Forms.TextBox txtBoxDrinkQuantity;
        private System.Windows.Forms.Label lblDrinkQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lbllblTotalPriceWithVatValue;
        private System.Windows.Forms.Label lbllblTotalPriceWithVat;
        private System.Windows.Forms.Button btnAddPurchaseDrink;
    }
}