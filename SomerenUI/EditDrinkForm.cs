using Microsoft.IdentityModel.Tokens;
using SomerenModel;
using System;
using System.Globalization;

namespace SomerenUI
{
    public partial class EditDrinkForm : BaseForm
    {
        Drink currentDrink;

        public EditDrinkForm()
        {
            InitializeComponent();
            Text = "Create Drink";
            btnUpdateDrink.Hide();
            rdoTrue.Checked = true;
        }

        public EditDrinkForm(Drink drink)
        {
            InitializeComponent();
            Text = "Edit Drink";
            btnCreateDrink.Hide();
            currentDrink = drink;
            LoadText();
            if (drink.IsAlcoholic)
                rdoTrue.Checked = true;
            else
                rdoFalse.Checked = true;
        }

        private void btnCreateDrink_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs(out double tryGetPrice, out int tryGetStock);

                double price = tryGetPrice;
                int stock = tryGetStock;
                bool isAlcoholic = rdoTrue.Checked;

                Drink drink = new Drink(price, isAlcoholic, txtDrinkName.Text, stock, 0);
                drinkService.CreateDrink(drink);
                ShowMessageAndCloseForm(Properties.Resources.SuccessfullyAdded, this, drink.Name);
            }
            catch (Exception ex)
            {
                string errorMessage = ex is FormatException ? Properties.Resources.ErrorMessageWrongPrice : ex.Message;
                ShowMessage(Properties.Resources.ErrorMessage, errorMessage);
            }
        }

        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs(out double tryGetPrice, out int tryGetStock);

                double price = tryGetPrice;
                int stock = tryGetStock;
                bool isAlcoholic = rdoTrue.Checked;

                Drink drink = new Drink(currentDrink.Id, price, isAlcoholic, txtDrinkName.Text, stock, currentDrink.NumberOfPurchases);
                drinkService.UpdateDrink(drink);
                ShowMessageAndCloseForm(Properties.Resources.SuccessfullyEdited, this, drink.Name);
            }
            catch (Exception ex)
            {
                string errorMessage = ex is FormatException ? Properties.Resources.ErrorMessageWrongPrice : ex.Message;
                ShowMessage(Properties.Resources.ErrorMessage, errorMessage);
            }
        }

        private void ValidateInputs(out double tryGetPrice, out int tryGetStock)
        {
            if (txtDrinkName.Text.IsNullOrEmpty())
                throw new Exception(Properties.Resources.ErrorMessageNoName);

            tryGetPrice = double.Parse(txtDrinkPrice.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

            if (!int.TryParse(txtDrinkStock.Text, out int tryGetInt))
                throw new Exception(Properties.Resources.ErrorMessageWrongStock);

            tryGetStock = tryGetInt;
        }

        private void LoadText()
        {
            txtDrinkName.Text = currentDrink.Name;
            txtDrinkPrice.Text = currentDrink.Price.ToString();
            txtDrinkStock.Text = currentDrink.Stock.ToString();
            if (currentDrink.IsAlcoholic)
                rdoTrue.Checked = true;
            else
                rdoFalse.Checked = true;
        }
    }
}