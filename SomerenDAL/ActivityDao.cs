using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT [activityId], [start_time], [end_time], [activity_name] FROM Activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable);
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["activityId"];
                DateTime startTime = (DateTime)dr["start_time"];
                DateTime endTime = (DateTime)dr["end_time"];
                string activityName = dr["activity_name"].ToString();

                Activity activity = new Activity(id, startTime, endTime, activityName);
                activities.Add(activity);
            }

            return activities;
        }
    }
}
