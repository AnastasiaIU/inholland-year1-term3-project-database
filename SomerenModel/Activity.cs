using System;

namespace SomerenModel
{
    public class Activity
    {
        /// <value>Property <c>Id</c> represents the ID of the activity and matches the database primary key in activities.</value>
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Name { get; set; }

        public Activity(int id, DateTime startTime, DateTime endTime, string name)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            Name = name;
        }
    }
}
