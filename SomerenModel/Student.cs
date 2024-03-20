namespace SomerenModel
{
    public class Student : Person
    {
        public int StudentNumber { get; set; }      //student_number, database primary key
        public string RoomNumber { get; set; }
        public string ClassNumber { get; set; }     //class_numer, IT1A-IT1F

        public Student(int studentNumber, string roomNumber, string firstName, string lastName, string phoneNumber, string classNumber)
            : base(firstName, lastName, phoneNumber)
        {
            StudentNumber = studentNumber;
            RoomNumber = roomNumber;
            ClassNumber = classNumber;
        }

        public override string ToString()
        {
            return $"{FullName} - {StudentNumber}";
        }
    }
}