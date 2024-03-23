using Microsoft.IdentityModel.Tokens;
using SomerenModel;
using System;
using System.Windows.Forms;

namespace SomerenUI
{
    // Use string resources
    // Unify exeptions handling
    public partial class EditDrinkForm : BaseForm
    {
        Drink currentDrink;

        public EditDrinkForm()
        {
            InitializeComponent();
            btnUpdateDrink.Hide();
            Text = "Edit";
        }

        public EditDrinkForm(Drink drink)
        {
            InitializeComponent();
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
                {
                    throw new Exception("Please input a name for the drink!");
                }

                Drink drink = new Drink(double.Parse(txtDrinkPrice.Text), isAlcoholic, txtDrinkName.Text, int.Parse(txtDrinkStock.Text));
                drinkService.CreateDrink(drink);
                MessageBox.Show($"Successfully added: {drink.Name}");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while creating the drink: " + ex.Message);
            }
        }

        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {
            bool isAlcoholic = rdoTrue.Checked;
            try
            {
                if (txtDrinkName.Text.IsNullOrEmpty())
                {
                    throw new Exception("Please input a name for the drink!");
                }

                Drink drink = new Drink(currentDrink.Id, double.Parse(txtDrinkPrice.Text), isAlcoholic, txtDrinkName.Text, int.Parse(txtDrinkStock.Text));
                drinkService.UpdateDrink(drink);
                MessageBox.Show($"Successfully updated: {drink.Name}");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while updating the drink: " + ex.Message);
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