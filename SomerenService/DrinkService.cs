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

        public List<Drink> GetAllDrinks()
        {
            return drinkDao.GetAllDrinks();
        }

        public void CreateDrink(Drink drink)
        {
            drinkDao.CreateDrink(drink);
        }

        public void UpdateDrink(Drink drink)
        {
            drinkDao.UpdateDrink(drink);
        }

        public void DeleteDrink(Drink drink)
        {
            drinkDao.DeleteDrink(drink);
        }

        public double GetTotalPrice(Drink drink, int quantity)
        {
            return drink.Price * quantity;
        }
    }
}
