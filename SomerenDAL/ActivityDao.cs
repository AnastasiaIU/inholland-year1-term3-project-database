using SomerenModel;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT * FROM Activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
