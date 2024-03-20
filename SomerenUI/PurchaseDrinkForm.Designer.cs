namespace SomerenUI
{
    partial class PurchaseDrinkForm
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
            lblBuyer = new System.Windows.Forms.Label();
            cmbBoxChooseBuyer = new System.Windows.Forms.ComboBox();
            lblTotalPrice = new System.Windows.Forms.Label();
            lblTotalPriceValue = new System.Windows.Forms.Label();
            btnAddPurchaseDrink = new System.Windows.Forms.Button();
            lblQuantity = new System.Windows.Forms.Label();
            txtBoxQuantity = new System.Windows.Forms.TextBox();
            cmbBoxChooseDrink = new System.Windows.Forms.ComboBox();
            lblChooseDrink = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblBuyer
            // 
            lblBuyer.AutoSize = true;
            lblBuyer.Location = new System.Drawing.Point(16, 69);
            lblBuyer.Name = "lblBuyer";
            lblBuyer.Size = new System.Drawing.Size(40, 15);
            lblBuyer.TabIndex = 0;
            lblBuyer.Text = "Buyer:";
            // 
            // cmbBoxChooseBuyer
            // 
            cmbBoxChooseBuyer.FormattingEnabled = true;
            cmbBoxChooseBuyer.Location = new System.Drawing.Point(115, 66);
            cmbBoxChooseBuyer.Name = "cmbBoxChooseBuyer";
            cmbBoxChooseBuyer.Size = new System.Drawing.Size(350, 23);
            cmbBoxChooseBuyer.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new System.Drawing.Point(265, 162);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new System.Drawing.Size(64, 15);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "Total price:";
            // 
            // lblTotalPriceValue
            // 
            lblTotalPriceValue.Location = new System.Drawing.Point(395, 162);
            lblTotalPriceValue.Name = "lblTotalPriceValue";
            lblTotalPriceValue.Size = new System.Drawing.Size(70, 15);
            lblTotalPriceValue.TabIndex = 5;
            lblTotalPriceValue.Text = "0.00";
            lblTotalPriceValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAddPurchaseDrink
            // 
            btnAddPurchaseDrink.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnAddPurchaseDrink.AutoSize = true;
            btnAddPurchaseDrink.Location = new System.Drawing.Point(375, 199);
            btnAddPurchaseDrink.Name = "btnAddPurchaseDrink";
            btnAddPurchaseDrink.Size = new System.Drawing.Size(90, 25);
            btnAddPurchaseDrink.TabIndex = 8;
            btnAddPurchaseDrink.Text = "Add purchase";
            btnAddPurchaseDrink.UseVisualStyleBackColor = true;
            btnAddPurchaseDrink.Click += btnAddPurchaseDrink_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(16, 117);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(56, 15);
            lblQuantity.TabIndex = 13;
            lblQuantity.Text = "Quantity:";
            // 
            // textBox1
            // 
            txtBoxQuantity.Location = new System.Drawing.Point(115, 114);
            txtBoxQuantity.Name = "textBox1";
            txtBoxQuantity.Size = new System.Drawing.Size(100, 23);
            txtBoxQuantity.TabIndex = 14;
            txtBoxQuantity.TextChanged += calculateTotalPrice_OnSelectedIndexChanged;
            // 
            // cmbBoxChooseDrink
            // 
            cmbBoxChooseDrink.FormattingEnabled = true;
            cmbBoxChooseDrink.Location = new System.Drawing.Point(115, 26);
            cmbBoxChooseDrink.Name = "cmbBoxChooseDrink";
            cmbBoxChooseDrink.Size = new System.Drawing.Size(350, 23);
            cmbBoxChooseDrink.TabIndex = 16;
            cmbBoxChooseDrink.SelectedIndexChanged += calculateTotalPrice_OnSelectedIndexChanged;
            // 
            // lblChooseDrink
            // 
            lblChooseDrink.AutoSize = true;
            lblChooseDrink.Location = new System.Drawing.Point(16, 29);
            lblChooseDrink.Name = "lblChooseDrink";
            lblChooseDrink.Size = new System.Drawing.Size(80, 15);
            lblChooseDrink.TabIndex = 15;
            lblChooseDrink.Text = "Choose drink:";
            // 
            // PurchaseDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 236);
            Controls.Add(cmbBoxChooseDrink);
            Controls.Add(lblChooseDrink);
            Controls.Add(txtBoxQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(btnAddPurchaseDrink);
            Controls.Add(lblTotalPriceValue);
            Controls.Add(lblTotalPrice);
            Controls.Add(cmbBoxChooseBuyer);
            Controls.Add(lblBuyer);
            Name = "PurchaseDrinkForm";
            Text = "Drink Purchase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.ComboBox cmbBoxChooseBuyer;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Button btnAddPurchaseDrink;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.ComboBox cmbBoxChooseDrink;
        private System.Windows.Forms.Label lblChooseDrink;
    }
}