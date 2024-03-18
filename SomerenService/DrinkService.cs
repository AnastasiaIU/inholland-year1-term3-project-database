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
    }
}
