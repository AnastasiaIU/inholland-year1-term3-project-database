﻿namespace SomerenModel
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


        /// <summary>
        /// A Drink constructor without an ID.
        /// </summary>
        /// <param name="price">The price of the drink.</param>
        /// <param name="isAlcoholic">Indicates whether the drink contains alcohol.</param>
        /// <param name="name">The name of the drink.</param>
        /// <param name="stock">The quantity of the drink.</param>
        public Drink(double price, bool isAlcoholic, string name, int stock)
        {
            Price = price;
            IsAlcoholic = isAlcoholic;
            Name = name;
            Stock = stock;
        }

        /// <summary>
        /// A Drink constructor with an ID.
        /// </summary>
        /// <param name="id">The ID of the drink.</param>
        /// <param name="price">The price of the drink.</param>
        /// <param name="isAlcoholic">Indicates whether the drink contains alcohol.</param>
        /// <param name="name">The name of the drink.</param>
        /// <param name="stock">The quantity of the drink.</param>
        public Drink(int id, double price, bool isAlcoholic, string name, int stock)
            : this(price, isAlcoholic, name, stock)
        {
            Id = id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
