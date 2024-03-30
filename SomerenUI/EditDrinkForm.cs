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
            LoadForm(Properties.Resources.CreateDrink);
        }

        public EditDrinkForm(Drink drink)
        {
            InitializeComponent();
            currentDrink = drink;
            LoadForm(Properties.Resources.EditDrink);
        }

        private void btnCreateDrink_Click(object sender, EventArgs e)
        {
            try
            {
                string name = ValidateStringOrThrow(txtDrinkName.Text, Properties.Resources.ErrorMessageNoName);
                double price = ParsePriceOrThrow(txtDrinkPrice.Text);
                int stock = ParseIntOrThrow(txtDrinkStock.Text, Properties.Resources.ErrorMessageWrongStock);
                bool isAlcoholic = rdoTrue.Checked;
                int purchases = int.Parse(Properties.Resources.Zero);

                Drink drink = new Drink(price, isAlcoholic, name, stock, purchases);
                drinkService.CreateDrink(drink);
                Close();
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
                string name = ValidateStringOrThrow(txtDrinkName.Text, Properties.Resources.ErrorMessageNoName);
                double price = ParsePriceOrThrow(txtDrinkPrice.Text);
                int stock = ParseIntOrThrow(txtDrinkStock.Text, Properties.Resources.ErrorMessageWrongStock);
                bool isAlcoholic = rdoTrue.Checked;

                Drink drink = new Drink(currentDrink.Id, price, isAlcoholic, name, stock, currentDrink.NumberOfPurchases);
                drinkService.UpdateDrink(drink);
                Close();
            }
            catch (Exception ex)
            {
                string errorMessage = ex is FormatException ? Properties.Resources.ErrorMessageWrongPrice : ex.Message;
                ShowMessage(Properties.Resources.ErrorMessage, errorMessage);
            }
        }

        private void LoadForm(string formName)
        {
            Text = formName;
            if (Text.Equals(Properties.Resources.CreateDrink))
                btnUpdateDrink.Hide();
            else
            {
                btnCreateDrink.Hide();
                LoadText();
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