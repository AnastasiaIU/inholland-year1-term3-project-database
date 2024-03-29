namespace SomerenModel
{
    public class Purchase
    {
        /// <value>Property <c>Id</c> represents the ID of the purchase and matches the database primary key in purchases.</value>
        public int Id { get; set; }
        /// <value>Property <c>StudentId</c> represents the student ID and the foreign key reference in students.</value>
        public Student Student { get; set; }
        /// <value>Property <c>DrinkId</c> represents the drink ID and the foreign key reference in drinks.</value>
        public Drink Drink { get; set; }
        public int Quantity { get; set; }
        /// <value>Calculated property <c>TotalPrice</c> determines the total price by multiplying the <see cref="Drink"/>'s price by the <see cref="Quantity"/> of the drink purchased.</value>
        public double TotalPrice { get { return Drink.Price * Quantity; } }

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
        /// Initializes a new instance of the Purchase class with a specified ID, representing a recorded transaction where a student purchases a specified quantity of a drink.
        /// </summary>
        /// <remarks>
        /// This constructor is typically used for loading existing purchase records from a database, where the purchase already has an assigned ID. It can also be used for creating a purchase record with a pre-defined ID, if necessary.
        /// </remarks>
        /// <param name="id">The unique identifier for the purchase. This ID is used to reference the transaction in the database.</param>
        /// <param name="student">The student who made the purchase. This is the entity representing the buyer in the transaction.</param>
        /// <param name="drink">The drink that was purchased. This entity contains details about the drink, such as its name and price.</param>
        /// <param name="quantity">The number of units of the drink that were purchased. This value represents the total quantity bought in the transaction.</param>
        public Purchase(int id, Student student, Drink drink, int quantity)
            : this(student, drink, quantity)
        {
            Id = id;
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
