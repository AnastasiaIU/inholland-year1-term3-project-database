using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class EditDrinkForm : Form
    {        
        Drink drink;
        DrinkService drinkService;
        public EditDrinkForm()
        {
            InitializeComponent();
            btnUpdateDrink.Hide();
            drinkService = new DrinkService();
        }

        public EditDrinkForm(Drink drink) 
        {
            InitializeComponent();
            btnCreateDrink.Hide();
            this.drink = drink;
            LoadText(drink);
            drinkService = new DrinkService();
        }

        private void btnCreateDrink_Click(object sender, System.EventArgs e)
        {
            bool isAlcoholic = rdoTrue.Checked;
            int fakeId = -1;
            Drink drink = new Drink(fakeId, double.Parse(txtDrinkPrice.Text), isAlcoholic, txtDrinkName.Text, int.Parse(txtDrinkStock.Text));
            drinkService.CreateDrink(drink);

            MessageBox.Show($"Successfully added: {drink.Name}");
            this.Close();
        }

        private void btnUpdateDrink_Click(object sender, System.EventArgs e)
        {
            bool isAlcoholic = rdoTrue.Checked;
            Drink drink = new Drink(this.drink.Id, double.Parse(txtDrinkPrice.Text), isAlcoholic, txtDrinkName.Text, int.Parse(txtDrinkStock.Text));
            drinkService.UpdateDrink(drink);         
            MessageBox.Show($"Successfully updated: {drink.Name}");
            this.Close();            
        }

        private void LoadText(Drink drink)
        {
            txtDrinkName.Text = drink.Name;
            txtDrinkPrice.Text = drink.Price.ToString();
            if (drink.IsAlcholic)
            {
                rdoTrue.Checked = true;
            }
            else
            {
                rdoFalse.Checked = true;
            }
            txtDrinkStock.Text = drink.Stock.ToString();
        }
    }
}
