using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkDao = new DrinkDao();

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

        /// <summary>
        /// Updates the stock quantity of a specified drink by decrementing it with the given quantity.
        /// </summary>
        /// <param name="drink">The drink whose stock is to be updated.</param>
        /// <param name="quantity">The quantity by which to decrement the drink's stock. This value should represent the number of units sold.</param>
        /// <remarks>
        /// This method directly modifies the <paramref name="drink"/>'s stock property in memory. To persist these changes to the database, ensure to call <see cref="UpdateDrink(Drink)"/> after modifying the stock.
        /// </remarks>
        public void UpdateStock(Drink drink, int quantity)
        {
            drink.Stock -= quantity;
        }
    }
}
