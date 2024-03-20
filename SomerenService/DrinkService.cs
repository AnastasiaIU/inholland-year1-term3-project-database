using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkDao;

        public DrinkService()
        {
            drinkDao = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            return drinkDao.GetAllDrinks();
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
