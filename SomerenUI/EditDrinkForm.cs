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
                rdoFalse.Checked = false;
        }

        private void btnCreateDrink_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDrinkName.Text.IsNullOrEmpty())
                    throw new ArgumentNullException();

                double price = GetDoubleFromString(txtDrinkPrice.Text);
                int stock = int.Parse(txtDrinkStock.Text);

                Drink drink = new Drink(price, currentDrink.IsAlcoholic, txtDrinkName.Text, stock);
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

                Drink drink = new Drink(currentDrink.Id, price, currentDrink.IsAlcoholic, txtDrinkName.Text, stock);
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