namespace SomerenModel
{
    public class Purchase
    {
        /// <value>Property <c>Id</c> represents the ID of the purchase and matches the database primary key in purchases.</value>
        public int Id { get; set; }
        /// <value>Property <c>StudentId</c> represents the student ID and the foreign key reference in students.</value>
        public int StudentId { get; set; }
        /// <value>Property <c>DrinkId</c> represents the drink ID and the foreign key reference in drinks.</value>
        public int DrinkId { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// A Purchase constructor without an ID for the purchase.
        /// </summary>
        /// <param name="studentId">The student ID of the purchase.</param>
        /// <param name="drinkId">The drink ID of the purchase.</param>
        /// <param name="quantity">The quantity of the drink of the purchase.</param>
        public Purchase(int studentId, int drinkId, int quantity)
        {
            StudentId = studentId;
            DrinkId = drinkId;
            Quantity = quantity;
        }

        /// <summary>
        /// A Purchase constructor with an ID for the purchase.
        /// </summary>
        /// <param name="id">The ID of the purchase.</param>
        /// <param name="studentId">The student ID of the purchase.</param>
        /// <param name="drinkId">The drink ID of the purchase.</param>
        /// <param name="quantity">The quantity of the drink of the purchase.</param>
        public Purchase(int id, int studentId, int drinkId, int quantity)
            : this(studentId, drinkId, quantity)
        {
            Id = id;
        }
    }
}
