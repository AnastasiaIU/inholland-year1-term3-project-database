namespace SomerenModel
{
    public class Room
    {
        const int RoomCapacityForLecturer = 1;

        public string Number { get; set; }           // room_number, database primary key
        public char BuildingNumber { get; set; }     // building_number, either 'A' or 'B'
        public int Floor { get; set; }               // floor, either 0 or 1
        public int Capacity { get; set; }            // number_of_beds, either 1 or 8
        public bool IsForLecturer
        {
            get { return Capacity == RoomCapacityForLecturer; }
        }

        public Room(string number, char buildingNumber, int floor, int capacity)
        {
            Number = number;
            BuildingNumber = buildingNumber;
            Floor = floor;
            Capacity = capacity;
        }
    }
}