namespace SomerenModel
{
    public class Purchase
    {
        /// <value>Property <c>Student</c> represents the buyer in the transaction.</value>
        public Student Student { get; set; }
        /// <value>Property <c>Drink</c> represents the drink that was purchased.</value>
        public Drink Drink { get; set; }
        public int Quantity { get; set; }
        /// <value>Calculated property <c>TotalPrice</c> determines the total price by multiplying the <see cref="Drink"/>'s price by the <see cref="Quantity"/> of the drink purchased.</value>
        public double TotalPrice { get { return Drink.Price * Quantity; } }
        /// <value>Calculated property <c>IsQuantityAvailable</c> returns <c>true</c> if the drink's stock is greater than or equal to the requested quantity, indicating availability; otherwise, <c>false</c>.</value>
        public bool IsQuantityAvailable { get { return Drink.Stock >= Quantity; } }

        /// <summary>
        /// Initializes a new instance of the Purchase class without an ID, representing a transaction where a student purchases a specified quantity of a drink.
        /// </summary>
        /// <remarks>
        /// This constructor is typically used for creating new purchase records before saving them to a database, where an ID will be generated.
        /// </remarks>
        /// <param name="student">The student who made the purchase. This is the entity representing the buyer in the transaction.</param>
        /// <param name="drink">The drink that was purchased. This entity contains details about the drink, such as its name and price.</param>
        /// <param name="quantity">The number of units of the drink that were purchased. This value represents the total quantity bought in the transaction.</param>
        public Purchase(Student student, Drink drink, int quantity)
        {
            Student = student;
            Drink = drink;
            Quantity = quantity;
        }

        /// <summary>
        /// Returns a string representation of the purchase.
        /// </summary>
        /// <returns>A string representing the purchase, formatted as "Student, Quantity Drink". For example, "John Doe, 1 Coca Cola".</returns>
        public override string ToString()
        {
            return $"{Student}, {Quantity} {Drink}";
        }
    }
}
