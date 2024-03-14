using System;

namespace SomerenModel
{
    public class Activity
    {
        public int Id { get; set; }                // activityId, database primary key
        public DateTime StartTime { get; set; }    // start_time
        public DateTime EndTime { get; set; }      // end_time
        public string ActivityName { get; set; }   // activity_name

        public Activity(int id, DateTime startTime, DateTime endTime, string activityName)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            ActivityName = activityName;
        }
    }
}
