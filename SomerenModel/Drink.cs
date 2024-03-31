namespace SomerenModel
{
    public class Drink
    {
        /// <value>Property <c>Id</c> represents the ID of the drink and matches the database primary key in drinks.</value>
        public int Id { get; set; }
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
        public int NumberOfPurchases { get; set; }

        /// <summary>
        /// Initializes a new instance of the Drink class without an ID.
        /// </summary>
        /// <remarks>
        /// This constructor is typically used for creating new drink records before saving them to a database, where an ID will be generated.
        /// </remarks>
        /// <param name="price">The price of the drink.</param>
        /// <param name="isAlcoholic">Indicates whether the drink contains alcohol.</param>
        /// <param name="name">The name of the drink.</param>
        /// <param name="stock">The quantity of the drink.</param>
        /// <param name="numberOfPurchases"">The number of times the drink type has been purchased</param>
        public Drink(double price, bool isAlcoholic, string name, int stock, int numberOfPurchases)
        {
            Price = price;
            IsAlcoholic = isAlcoholic;
            Name = name;
            Stock = stock;
            NumberOfPurchases = numberOfPurchases;
        }

        /// <summary>
        /// Initializes a new instance of the Drink class with a specified ID.
        /// </summary>
        /// <remarks>
        /// This constructor is typically used for loading existing drink records from a database, where the drink already has an assigned ID. It can also be used for creating a drink record with a pre-defined ID, if necessary.
        /// </remarks>
        /// <param name="id">The ID of the drink.</param>
        /// <param name="price">The price of the drink.</param>
        /// <param name="isAlcoholic">Indicates whether the drink contains alcohol.</param>
        /// <param name="name">The name of the drink.</param>
        /// <param name="stock">The quantity of the drink.</param>
        /// <param name="numberOfPurchases"">The number of times the drink type has been purchased</param>
        public Drink(int id, double price, bool isAlcoholic, string name, int stock, int numberOfPurchases)
            : this(price, isAlcoholic, name, stock, numberOfPurchases)
        {
            Id = id;
        }

        /// <summary>
        /// Returns a string representation of the drink.
        /// </summary>
        /// <returns>A string representing the name of the drink, formatted as "Name". For example, "Coca Cola".</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
