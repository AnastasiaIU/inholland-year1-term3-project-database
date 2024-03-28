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
            string query = "SELECT [activityId], [start_time], [end_time], [activity_name] FROM Activities ORDER BY [activity_name]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable, ReadRow);
        }

        private Activity ReadRow(DataRow dr)
        {
            int id = (int)dr["activityId"];
            DateTime startTime = (DateTime)dr["start_time"];
            DateTime endTime = (DateTime)dr["end_time"];
            string activityName = dr["activity_name"].ToString();

            return new Activity(id, startTime, endTime, activityName);
        }
    }
}
