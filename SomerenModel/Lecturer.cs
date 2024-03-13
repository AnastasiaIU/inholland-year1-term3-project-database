namespace SomerenModel
{
    public class Lecturer : Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string RoomNumber { get; set; }

        public Lecturer(int id, int age, string roomNumber, string firstName, string lastName, string phoneNumber)
            :base(firstName, lastName, phoneNumber)
        {
            Id = id;
            Age = age;
            RoomNumber = roomNumber;
        }
    }
}