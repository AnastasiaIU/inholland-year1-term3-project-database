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
        }

        public EditDrinkForm(Drink drink)
        {
            InitializeComponent();
            Text = "Edit Drink";
            btnCreateDrink.Hide();
            currentDrink = drink;
            LoadText();
        }

        private void btnCreateDrink_Click(object sender, EventArgs e)
        {
            bool isAlcoholic = rdoTrue.Checked;
            try
            {
                if (txtDrinkName.Text.IsNullOrEmpty())
                    throw new ArgumentNullException();

                double price = double.Parse(txtDrinkPrice.Text);
                int stock = int.Parse(txtDrinkStock.Text);

                Drink drink = new Drink(price, isAlcoholic, txtDrinkName.Text, stock);
                drinkService.CreateDrink(drink);
                ShowMessage(Properties.Resources.SuccessfullyAdded, drink.Name, this);
            }
            catch (Exception ex)
            {
                string errorMessage = ex is ArgumentNullException ? Properties.Resources.ErrorMessageNullField : Properties.Resources.ErrorMessage;
                ShowError(errorMessage, ex);
            }
        }

        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {
            bool isAlcoholic = rdoTrue.Checked;
            try
            {
                if (txtDrinkName.Text.IsNullOrEmpty())                
                    throw new ArgumentNullException();

                double price = double.Parse(txtDrinkPrice.Text);
                int stock = int.Parse(txtDrinkStock.Text);

                Drink drink = new Drink(currentDrink.Id, price, isAlcoholic, txtDrinkName.Text, stock);
                drinkService.UpdateDrink(drink);
                ShowMessage(Properties.Resources.SuccessfullyEdited, drink.Name, this);
            }
            catch (Exception ex)
            {
                string errorMessage = ex is ArgumentNullException ? Properties.Resources.ErrorMessageNullField : Properties.Resources.ErrorMessage;
                ShowError(errorMessage, ex);
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