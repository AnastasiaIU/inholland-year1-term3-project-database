namespace SomerenModel
{
    public class Purchase
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DrinkId { get; set; }
        public int Quantity { get; set; }

        public Purchase(int id, int studentId, int drinkId, int quantity)
        {
            Id = id;
            StudentId = studentId;
            DrinkId = drinkId;
            Quantity = quantity;
        }
    }
}
