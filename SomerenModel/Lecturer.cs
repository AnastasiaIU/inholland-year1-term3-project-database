namespace SomerenModel
{
    public class Lecturer : Person
    {
        public int Id { get; set; }                 // lecturerId, database primary key
        public int Age { get; set; }                
        public string RoomNumber { get; set; }      // room_number, foreign key referencing Rooms table

        public Lecturer(int id, int age, string roomNumber, string firstName, string lastName, string phoneNumber)
            :base(firstName, lastName, phoneNumber)
        {
            Id = id;
            Age = age;
            RoomNumber = roomNumber;
        }
    }
}