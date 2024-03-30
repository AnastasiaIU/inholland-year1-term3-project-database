namespace SomerenModel
{
    public class Room
    {
        const int RoomCapacityForLecturer = 1;

        /// <value>Property <c>Number</c> represents the number of the room and matches the database primary key in rooms.</value>
        public string Number { get; set; }
        /// <value>Property <c>BuildingNumber</c> represents the number of the building. Can be either 'A' or 'B'.</value>
        public char BuildingNumber { get; set; }
        /// <value>Property <c>Floor</c> represents the floor of the building for the room. Can be either 0 or 1.</value>
        public int Floor { get; set; }
        /// <value>Property <c>Capacity</c> represents the number of beds in the room. Can be either 1 or 8.</value>
        public int Capacity { get; set; }
        /// <value>Calculated property <c>IsForLecturer</c> indicates whether the room is for lecturer or not. Depends on <see cref="RoomCapacityForLecturer"/></value>
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

        /// <summary>
        /// Returns a string representation of the room.
        /// </summary>
        /// <returns>A string representing the number of the room, formatted as "Number". For example, "A0-001".</returns>
        public override string ToString()
        {
            return $"{Number}";
        }
    }
}