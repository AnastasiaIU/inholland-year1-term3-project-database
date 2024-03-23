namespace SomerenModel
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string RoomNumber { get; set; }                                 // room_number, foreign key referencing Rooms table
        public string FullName { get { return $"{FirstName} {LastName}"; } }   // calculated property to combine FirstName and LastName

        protected Person(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
