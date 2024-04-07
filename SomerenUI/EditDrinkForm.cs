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
            LoadForm(Properties.Resources.CreateDrink);
        }

        public EditDrinkForm(Drink drink)
        {
            InitializeComponent();
            currentDrink = drink;
            LoadForm(Properties.Resources.EditDrink);
        }

        /// <summary>
        /// Handles the click event for the "Create drink" button.
        /// </summary>
        /// <remarks>
        /// Validates the drink details from the form, creates a new Drink instance, and invokes the service to add the drink to the database.
        /// Closes the form upon successful creation. Displays an error message if validation fails or an exception is encountered.
        /// </remarks>
        private void ButtonCreateDrink_Click(object sender, EventArgs e)
        {
            try
            {
                Drink drink = ReadDrink();
                drinkService.CreateDrink(drink);
                Close();
            }
            catch (Exception ex)
            {
                string errorMessage = ex is FormatException ? Properties.Resources.ErrorMessageWrongPrice : ex.Message;
                ShowMessage(Properties.Resources.ErrorMessage, errorMessage);
            }
        }

        /// <summary>
        /// Handles the click event for the "Update drink" button.
        /// </summary>
        /// <remarks>
        /// Gathers updated details from the form, creates a new Drink instance, and updates the existing drink record in the database using the drink service.
        /// Closes the form upon successful update. Displays an error message if validation fails or if an exception occurs.
        /// </remarks>
        private void ButtonUpdateDrink_Click(object sender, EventArgs e)
        {
            try
            {
                bool forEditDrink = true;

                Drink drink = ReadDrink(forEditDrink);
                drinkService.UpdateDrink(drink);
                Close();
            }
            catch (Exception ex)
            {
                string errorMessage = ex is FormatException ? Properties.Resources.ErrorMessageWrongPrice : ex.Message;
                ShowMessage(Properties.Resources.ErrorMessage, errorMessage);
            }
        }

        /// <summary>
        /// Parses the given string as an integer or throws an exception if parsing fails.
        /// </summary>
        /// <param name="number">The string to parse as an integer.</param>
        /// <param name="errorMessage">The error message to throw if parsing fails.</param>
        /// <returns>The parsed integer from the given string.</returns>
        /// <exception cref="Exception">Thrown when the string cannot be parsed as an integer.</exception>
        private int ParseIntOrThrow(string number, string errorMessage)
        {
            if (!int.TryParse(number, out int result))
                throw new Exception(errorMessage);
            return result;
        }

        /// <summary>
        /// Parses the given string as a double, interpreting it as a price.
        /// </summary>
        /// <param name="price">The string representing the price to parse.</param>
        /// <returns>The parsed price as a double.</returns>
        /// <exception cref="FormatException">Thrown when the string cannot be parsed into a double.</exception>
        /// <remarks>
        /// Converts comma to dot for compatibility with different regional settings, ensuring the price is parsed correctly in any locale.
        /// </remarks>
        private double ParsePriceOrThrow(string price)
        {
            return double.Parse(price.Replace(',', '.'), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Configures the form based on its intended purpose, either to create or update a drink.
        /// </summary>
        /// <param name="formName">The name indicating the purpose of the form: creating or updating a drink.</param>
        /// <remarks>
        /// Adjusts the visibility of buttons and loads existing drink details if the form is set to update mode.
        /// </remarks>
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

        /// <summary>
        /// Loads the current drink's details into the form fields.
        /// </summary>
        /// <remarks>
        /// Populates the form fields with the details of the current drink, preparing the form for update operations. Sets the alcohol radio button according to the drink's alcoholic status.
        /// </remarks>
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

        private Drink ReadDrink(bool forEditDrink = false)
        {
            string name = ValidateStringOrThrow(txtDrinkName.Text, Properties.Resources.ErrorMessageNoName);
            double price = ParsePriceOrThrow(txtDrinkPrice.Text);
            int stock = ParseIntOrThrow(txtDrinkStock.Text, Properties.Resources.ErrorMessageWrongStock);
            bool isAlcoholic = rdoTrue.Checked;
            int numberOfPurchases = zero;

            if (!forEditDrink)
                return new Drink(price, isAlcoholic, name, stock, numberOfPurchases);

            return new Drink(currentDrink.Id, price, isAlcoholic, name, stock, currentDrink.NumberOfPurchases);
        }
    }
}