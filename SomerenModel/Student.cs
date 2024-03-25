namespace SomerenModel
{
    public class Student : Person
    {
        /// <value>Property <c>StudentNumber</c> represents the student number and matches the database primary key in students.</value>
        public int StudentNumber { get; set; }
        /// <value>Property <c>ClassNumber</c> represents the clas number of the student, e.g. "IT1A".</value>
        public string ClassNumber { get; set; }

        public Student(int studentNumber, string roomNumber, string firstName, string lastName, string phoneNumber, string classNumber)
            : base(firstName, lastName, phoneNumber)
        {
            StudentNumber = studentNumber;
            RoomNumber = roomNumber;
            ClassNumber = classNumber;
        }

        /// <summary>
        /// Returns a string representation of the student.
        /// </summary>
        /// <returns>A string representing the full name and student number of the student, formatted as "FullName (StudentNumber)". For example, "John Doe (123456)".</returns>
        public override string ToString()
        {
            return $"{FullName} ({StudentNumber})";
        }
    }
}