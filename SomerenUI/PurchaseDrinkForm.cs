using SomerenModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class PurchaseDrinkForm : BaseForm
    {
        public PurchaseDrinkForm()
        {
            InitializeComponent();
            FillComboBox(cmbBoxChooseDrink, GetDrinks);
            FillComboBox(cmbBoxChooseBuyer, GetStudents);
        }

        private void DisplayDataInComboBox<T>(ComboBox comboBox, List<T> data)
        {
            // clear the comboBox before filling it
            comboBox.Items.Clear();

            foreach (T t in data)
                comboBox.Items.Add(t);            

            comboBox.SelectedIndex = int.Parse(Properties.Resources.Zero);
        }

        void FillComboBox<T>(ComboBox comboBox, Func<List<T>> fetchData)
        {
            List<T> data = fetchData();

            if (data != null)
                DisplayDataInComboBox(comboBox, data);
        }

        private void CreatePurchase(Drink currentDrink, int quantity)
        {
            int studentId = ((Student)cmbBoxChooseBuyer.SelectedItem).StudentNumber;
            int drinkId = currentDrink.Id;

            Purchase purchase = new Purchase(studentId, drinkId, quantity);
            purchaseService.CreatePurchase(purchase);
        }

        private void UpdateStock(Drink currentDrink, int quantity)
        {            
            currentDrink.Stock -= quantity;
            drinkService.UpdateDrink(currentDrink);
        }

        private void calculateTotalPrice_Event(object sender, EventArgs e)
        {
            try
            {
                Drink currentDrink = (Drink)cmbBoxChooseDrink.SelectedItem;
                int quantity = int.Parse(txtBoxQuantity.Text);
                double totalPrice = drinkService.GetTotalPrice(currentDrink, quantity);
                lblTotalPriceValue.Text = totalPrice.ToString(Properties.Resources.MoneyFormat);
            }
            catch
            {
                lblTotalPriceValue.Text = Properties.Resources.Zero;
            }
        }

        private void btnAddPurchaseDrink_Click(object sender, EventArgs e)
        {
            try
            {
                Drink currentDrink = (Drink)cmbBoxChooseDrink.SelectedItem;
                int quantity = int.Parse(txtBoxQuantity.Text);

                CreatePurchase(currentDrink, quantity);
                UpdateStock(currentDrink, quantity);

                ShowMessage(Properties.Resources.SuccessfullyAdded, Properties.Resources.NewPurchase, this);
            }
            catch (Exception ex)
            {
                string errorMessage = ex is FormatException ? Properties.Resources.ErrorMessageWrongQuantityFormat : Properties.Resources.ErrorMessage;
                ShowError(errorMessage, ex);
            }
        }
    }
}
