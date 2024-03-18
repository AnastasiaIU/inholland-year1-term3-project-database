using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkDAO;

        public DrinkService()
        {
            drinkDAO = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            return drinkDAO.GetAllDrinks();
        }
    }
}
