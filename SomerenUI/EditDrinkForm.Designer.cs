namespace SomerenUI
{
    partial class EditDrinkForm
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
            rdoTrue = new System.Windows.Forms.RadioButton();
            rdoFalse = new System.Windows.Forms.RadioButton();
            lblAlcoholic = new System.Windows.Forms.Label();
            txtDrinkPrice = new System.Windows.Forms.TextBox();
            txtDrinkName = new System.Windows.Forms.TextBox();
            txtDrinkStock = new System.Windows.Forms.TextBox();
            lblDrinkStock = new System.Windows.Forms.Label();
            lblDrinkPrice = new System.Windows.Forms.Label();
            lblDrinkName = new System.Windows.Forms.Label();
            btnCreateDrink = new System.Windows.Forms.Button();
            btnUpdateDrink = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // rdoTrue
            // 
            rdoTrue.AutoSize = true;
            rdoTrue.Checked = true;
            rdoTrue.Location = new System.Drawing.Point(107, 97);
            rdoTrue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            rdoTrue.Name = "rdoTrue";
            rdoTrue.Size = new System.Drawing.Size(42, 19);
            rdoTrue.TabIndex = 2;
            rdoTrue.TabStop = true;
            rdoTrue.Text = "Yes";
            rdoTrue.UseVisualStyleBackColor = true;
            // 
            // rdoFalse
            // 
            rdoFalse.AutoSize = true;
            rdoFalse.Location = new System.Drawing.Point(160, 97);
            rdoFalse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            rdoFalse.Name = "rdoFalse";
            rdoFalse.Size = new System.Drawing.Size(41, 19);
            rdoFalse.TabIndex = 3;
            rdoFalse.Text = "No";
            rdoFalse.UseVisualStyleBackColor = true;
            // 
            // lblAlcoholic
            // 
            lblAlcoholic.AutoSize = true;
            lblAlcoholic.Location = new System.Drawing.Point(41, 97);
            lblAlcoholic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAlcoholic.Name = "lblAlcoholic";
            lblAlcoholic.Size = new System.Drawing.Size(60, 15);
            lblAlcoholic.TabIndex = 2;
            lblAlcoholic.Text = "Alcoholic:";
            // 
            // txtDrinkPrice
            // 
            txtDrinkPrice.Location = new System.Drawing.Point(107, 63);
            txtDrinkPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtDrinkPrice.Name = "txtDrinkPrice";
            txtDrinkPrice.Size = new System.Drawing.Size(106, 23);
            txtDrinkPrice.TabIndex = 1;
            // 
            // txtDrinkName
            // 
            txtDrinkName.Location = new System.Drawing.Point(107, 28);
            txtDrinkName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtDrinkName.Name = "txtDrinkName";
            txtDrinkName.Size = new System.Drawing.Size(106, 23);
            txtDrinkName.TabIndex = 0;
            // 
            // txtDrinkStock
            // 
            txtDrinkStock.Location = new System.Drawing.Point(107, 129);
            txtDrinkStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtDrinkStock.Name = "txtDrinkStock";
            txtDrinkStock.Size = new System.Drawing.Size(106, 23);
            txtDrinkStock.TabIndex = 4;
            // 
            // lblDrinkStock
            // 
            lblDrinkStock.AutoSize = true;
            lblDrinkStock.Location = new System.Drawing.Point(62, 131);
            lblDrinkStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDrinkStock.Name = "lblDrinkStock";
            lblDrinkStock.Size = new System.Drawing.Size(39, 15);
            lblDrinkStock.TabIndex = 6;
            lblDrinkStock.Text = "Stock:";
            // 
            // lblDrinkPrice
            // 
            lblDrinkPrice.AutoSize = true;
            lblDrinkPrice.Location = new System.Drawing.Point(66, 67);
            lblDrinkPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDrinkPrice.Name = "lblDrinkPrice";
            lblDrinkPrice.Size = new System.Drawing.Size(36, 15);
            lblDrinkPrice.TabIndex = 7;
            lblDrinkPrice.Text = "Price:";
            // 
            // lblDrinkName
            // 
            lblDrinkName.AutoSize = true;
            lblDrinkName.Location = new System.Drawing.Point(59, 30);
            lblDrinkName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDrinkName.Name = "lblDrinkName";
            lblDrinkName.Size = new System.Drawing.Size(42, 15);
            lblDrinkName.TabIndex = 8;
            lblDrinkName.Text = "Name:";
            // 
            // btnCreateDrink
            // 
            btnCreateDrink.AutoSize = true;
            btnCreateDrink.Location = new System.Drawing.Point(79, 175);
            btnCreateDrink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCreateDrink.Name = "btnCreateDrink";
            btnCreateDrink.Size = new System.Drawing.Size(105, 27);
            btnCreateDrink.TabIndex = 5;
            btnCreateDrink.Text = "Create drink";
            btnCreateDrink.UseVisualStyleBackColor = true;
            btnCreateDrink.Click += btnCreateDrink_Click;
            // 
            // btnUpdateDrink
            // 
            btnUpdateDrink.Location = new System.Drawing.Point(79, 175);
            btnUpdateDrink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnUpdateDrink.Name = "btnUpdateDrink";
            btnUpdateDrink.Size = new System.Drawing.Size(105, 27);
            btnUpdateDrink.TabIndex = 5;
            btnUpdateDrink.Text = "Update drink";
            btnUpdateDrink.UseVisualStyleBackColor = true;
            btnUpdateDrink.Click += btnUpdateDrink_Click;
            // 
            // EditDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(272, 229);
            Controls.Add(btnUpdateDrink);
            Controls.Add(btnCreateDrink);
            Controls.Add(lblDrinkName);
            Controls.Add(lblDrinkPrice);
            Controls.Add(lblDrinkStock);
            Controls.Add(txtDrinkStock);
            Controls.Add(txtDrinkName);
            Controls.Add(txtDrinkPrice);
            Controls.Add(lblAlcoholic);
            Controls.Add(rdoFalse);
            Controls.Add(rdoTrue);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "EditDrinkForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton rdoTrue;
        private System.Windows.Forms.RadioButton rdoFalse;
        private System.Windows.Forms.Label lblAlcoholic;
        private System.Windows.Forms.TextBox txtDrinkPrice;
        private System.Windows.Forms.TextBox txtDrinkName;
        private System.Windows.Forms.TextBox txtDrinkStock;
        private System.Windows.Forms.Label lblDrinkStock;
        private System.Windows.Forms.Label lblDrinkPrice;
        private System.Windows.Forms.Label lblDrinkName;
        private System.Windows.Forms.Button btnCreateDrink;
        private System.Windows.Forms.Button btnUpdateDrink;
    }
}