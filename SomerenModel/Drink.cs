namespace SomerenModel
{
    public class Drink
    {
        public int Id { get; set; }
        public double Price {  get; set; }
        public bool IsAlcholic { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string StockLevel 
        {
            get 
            {
                if (Stock == 0)
                {
                    return "stock empty";
                }
                else if (Stock < 50)
                {
                    return "stock nearly depleted";
                }
                else
                {
                    return "stock sufficient";
                }
            } 
        }

        public Drink(int id, double price, bool isAlcholic, string name, int stock)
        {
            Id = id;
            Price = price;
            IsAlcholic = isAlcholic;
            Name = name;
            Stock = stock;
        }
    }
}
