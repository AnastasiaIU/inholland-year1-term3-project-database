namespace SomerenModel
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        /// <value>Property <c>RoomNumber</c> represents the room number and the foreign key reference in rooms.</value>
        public string RoomNumber { get; set; }
        /// <value>Calculated property <c>FullName</c> combines FirstName and LastName.</value>
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        protected Person(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Returns a string representation of the person.
        /// </summary>
        /// <returns>A string representing the full name of the person, formatted as "FullName". For example, "John Doe".</returns>
        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}
