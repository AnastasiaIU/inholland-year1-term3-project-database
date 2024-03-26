using Microsoft.IdentityModel.Tokens;
using SomerenModel;
using System;

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
                if (txtDrinkName.Text.IsNullOrEmpty())
                    throw new ArgumentNullException();

                double price = GetDoubleFromString(txtDrinkPrice.Text);
                int stock = int.Parse(txtDrinkStock.Text);
                bool isAlcoholic = rdoTrue.Checked;

                Drink drink = new Drink(price, isAlcoholic, txtDrinkName.Text, stock, 0);
                drinkService.CreateDrink(drink);
                ShowMessageAndCloseForm(Properties.Resources.SuccessfullyAdded, this, drink.Name);
            }
            catch (Exception ex)
            {
                string errorMessage = ex is ArgumentNullException ? Properties.Resources.ErrorMessageNullField : Properties.Resources.ErrorMessage;
                ShowMessage(errorMessage, ex.Message);
            }
        }

        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDrinkName.Text.IsNullOrEmpty())
                    throw new ArgumentNullException();

                double price = GetDoubleFromString(txtDrinkPrice.Text);
                int stock = int.Parse(txtDrinkStock.Text);
                bool isAlcoholic = rdoTrue.Checked;

                Drink drink = new Drink(currentDrink.Id, price, isAlcoholic, txtDrinkName.Text, stock, currentDrink.NumberOfPurchases);
                drinkService.UpdateDrink(drink);
                ShowMessageAndCloseForm(Properties.Resources.SuccessfullyEdited, this, drink.Name);
            }
            catch (Exception ex)
            {
                string errorMessage = ex is ArgumentNullException ? Properties.Resources.ErrorMessageNullField : Properties.Resources.ErrorMessage;
                ShowMessage(errorMessage, ex.Message);
            }
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