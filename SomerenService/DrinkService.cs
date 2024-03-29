using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class DrinkService
    {
        /* We don't use these constants currently but we want to keep them till the end of the project in case we will need them.
        const double NonAlcoholicVatRate = 0.09; // 9%
        const double AlcoholicVatRate = 0.21; // 21%*/

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

        public void UpdateStock(Drink drink, int quantity)
        {
            drink.Stock -= quantity;
        }

        /* We don't use this method currently but we want to keep it till the end of the project in case we will need it.
        public double GetTotalPriceWithVat(Drink drink, int quantity)
        {
            double vatRate = drink.IsAlcoholic ? AlcoholicVatRate : NonAlcoholicVatRate;
            double priceWithoutVat = GetTotalPrice(drink, quantity);
            double vatAmount = priceWithoutVat * vatRate;
            return priceWithoutVat + vatAmount;
        }*/
    }
}
