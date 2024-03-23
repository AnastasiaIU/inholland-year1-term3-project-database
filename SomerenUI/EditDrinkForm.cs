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

                Drink drink = new Drink(double.Parse(txtDrinkPrice.Text), isAlcoholic, txtDrinkName.Text, int.Parse(txtDrinkStock.Text));
                drinkService.CreateDrink(drink);
                ShowMessage(Properties.Resources.SuccessfullyAdded, drink.Name);
                Close();
            }
            catch (Exception ex)
            {
                string errorMessage = ex is ArgumentNullException ? Properties.Resources.NullField : Properties.Resources.ErrorMessage;
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

                Drink drink = new Drink(currentDrink.Id, double.Parse(txtDrinkPrice.Text), isAlcoholic, txtDrinkName.Text, int.Parse(txtDrinkStock.Text));
                drinkService.UpdateDrink(drink);
                ShowMessage(Properties.Resources.SuccessfullyEdited, drink.Name);
                Close();
            }
            catch (Exception ex)
            {
                string errorMessage = ex is ArgumentNullException ? Properties.Resources.NullField : Properties.Resources.ErrorMessage;
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