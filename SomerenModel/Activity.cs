using System;

namespace SomerenModel
{
    public class Activity
    {
        public int Id { get; set; }                // activityId, database primary key
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
