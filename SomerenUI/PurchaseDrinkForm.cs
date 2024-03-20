using SomerenService;
using SomerenModel;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace SomerenUI
{
    public partial class PurchaseDrinkForm : Form
    {
        private DrinkService drinkService = new DrinkService();
        private StudentService studentService = new StudentService();
        private PurchaseService purchaseService = new PurchaseService();

        public PurchaseDrinkForm()
        {
            InitializeComponent();
            FillChooseDrinkCmbBox();
            FillBuyerCmbBox();
        }

        void FillChooseDrinkCmbBox()
        {
            cmbBoxChooseDrink.Items.Clear();
            List<Drink> drinks = drinkService.GetDrinks();

            foreach (Drink drink in drinks)
            {
                cmbBoxChooseDrink.Items.Add(drink);
            }

            cmbBoxChooseDrink.SelectedIndex = 0;
        }

        void FillBuyerCmbBox()
        {
            cmbBoxChooseBuyer.Items.Clear();
            List<Student> students = studentService.GetStudents();

            foreach (Student student in students)
            {
                cmbBoxChooseBuyer.Items.Add(student);
            }

            cmbBoxChooseBuyer.SelectedIndex = 0;
        }

        private void calculateTotalPrice_OnSelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                int quantity = int.Parse(txtBoxQuantity.Text);
                Drink currentDrink = (Drink)cmbBoxChooseDrink.SelectedItem;
                double totalPrice = currentDrink.GetTotalPrice(quantity);
                lblTotalPriceValue.Text = totalPrice.ToString("C2");
            }
            catch
            {
                lblTotalPriceValue.Text = "0";
            }
        }

        private void btnAddPurchaseDrink_Click(object sender, System.EventArgs e)
        {
            Drink currentDrink = (Drink)cmbBoxChooseDrink.SelectedItem;
            int fakeId = -1;
            int studentId = ((Student)cmbBoxChooseBuyer.SelectedItem).StudentNumber;
            int drinkId = currentDrink.Id;
            int quantity = int.Parse(txtBoxQuantity.Text);
            Purchase purchase = new Purchase(fakeId, studentId, drinkId, quantity);
            purchaseService.CreatePurchase(purchase);
            int updatedStock = currentDrink.Stock - quantity;
            currentDrink.Stock = updatedStock;
            drinkService.UpdateDrink(currentDrink);
            MessageBox.Show($"The purchase successfully added!");
            Close();
        }
    }
}
