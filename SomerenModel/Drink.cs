namespace SomerenModel
{
    public class Drink
    {
        public int Id { get; set; }             // drinkId, database primary key
        public double Price { get; set; }
        public bool IsAlcoholic { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public StockLevel StockLevel
        {
            get
            {
                switch (Stock)
                {
                    case <= (int)StockLevel.Empty:
                        return StockLevel.Empty;
                    case <= (int)StockLevel.NearlyDepleted:
                        return StockLevel.NearlyDepleted;
                    default:
                        return StockLevel.Sufficient;
                }
            }
        }

        public Drink(int id, double price, bool isAlcholic, string name, int stock)
        {
            Id = id;
            Price = price;
            IsAlcoholic = isAlcholic;
            Name = name;
            Stock = stock;
        }

        /// <summary>
        /// Calculates the total price for a given drink and quantity.
        /// </summary>
        /// <param name="price">The drink for which to calculate the total price.</param>
        /// <param name="isAlcholic">The quantity of the drink.</param>
        /// <returns>The total price for the given drink and quantity.</returns>
        public Drink(double price, bool isAlcholic, string name, int stock)
        {
            Price = price;
            IsAlcoholic = isAlcholic;
            Name = name;
            Stock = stock;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
