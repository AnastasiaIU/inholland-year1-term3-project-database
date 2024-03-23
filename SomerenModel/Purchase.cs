namespace SomerenModel
{
    public class Purchase
    {
        const int DummyId = -1;

        public int Id { get; set; }             // purchaseId, database primary key
        public int StudentId { get; set; }      // studentId, foreign key referencing Students table
        public int DrinkId { get; set; }        // drinkId, foreign key referencing Drinks table
        public int Quantity { get; set; }

        public Purchase(int id, int studentId, int drinkId, int quantity)
        {
            Id = id;
            StudentId = studentId;
            DrinkId = drinkId;
            Quantity = quantity;
        }

        /*
         * Add comment about Id.
         */
        public Purchase(int studentId, int drinkId, int quantity)
        {
            Id = DummyId;
            StudentId = studentId;
            DrinkId = drinkId;
            Quantity = quantity;
        }
    }
}
