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
                string name = ValidateString(txtDrinkName.Text, Properties.Resources.ErrorMessageNoName);
                double price = ValidatePrice(txtDrinkPrice.Text);
                int stock = ValidateInt(txtDrinkStock.Text, Properties.Resources.ErrorMessageWrongStock);
                bool isAlcoholic = rdoTrue.Checked;

                Drink drink = new Drink(price, isAlcoholic, name, stock, 0);
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
                string name = ValidateString(txtDrinkName.Text, Properties.Resources.ErrorMessageNoName);
                double price = ValidatePrice(txtDrinkPrice.Text);
                int stock = ValidateInt(txtDrinkStock.Text, Properties.Resources.ErrorMessageWrongStock);
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
            if (formName.Equals(Properties.Resources.CreateDrink))
            {
                Text = formName;
                btnUpdateDrink.Hide();
                rdoTrue.Checked = true;
            }
            else
            {
                Text = formName;
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