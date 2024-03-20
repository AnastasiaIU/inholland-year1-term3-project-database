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

        public void CreateDrink(Drink drink)
        {
            drinkdb.CreateDrink(drink);
        }

        public void UpdateDrink(Drink drink) 
        {
            drinkdb.UpdateDrink(drink);
        }

        public void DeleteDrink(Drink drink) 
        {
            drinkdb.DeleteDrink(drink);
        }
    }
}
