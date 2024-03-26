namespace SomerenModel
{
    public class Lecturer : Person
    {
        /// <value>Property <c>Id</c> represents the ID of the lecturer and matches the database primary key in lecturers.</value>
        public int Id { get; set; }
        public int Age { get; set; }

        public Lecturer(int id, int age, string roomNumber, string firstName, string lastName, string phoneNumber)
            : base(firstName, lastName, phoneNumber)
        {
            Id = id;
            Age = age;
            RoomNumber = roomNumber;
        }
    }
}