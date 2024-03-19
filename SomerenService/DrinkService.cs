using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            return drinkdb.GetAllDrinks();
        }

        public void CreateCustomer(Drink drink)
        {
            drinkdb.CreateDrink(drink);
        }

        public void UpdateCustomer(Drink drink) 
        {
            drinkdb.UpdateDrink(drink);
        }

        public void DeleteCustomer(Drink drink) 
        {
            drinkdb.DeleteDrink(drink);
        }
    }
}
