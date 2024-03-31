using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        const string QueryGetAllActivities = $"SELECT {ColumnActivityId}, {ColumnStartTime}, {ColumnEndTime}, {ColumnActivityName} FROM Activities ORDER BY {ColumnActivityName};";

        const string ColumnActivityId = "activityId";
        const string ColumnStartTime = "start_time";
        const string ColumnEndTime = "end_time";
        const string ColumnActivityName = "activity_name";

        public List<Activity> GetAllActivities()
        {
            SqlParameter[] sqlParameters = new SqlParameter[Zero];
            DataTable dataTable = ExecuteSelectQuery(QueryGetAllActivities, sqlParameters);
            return ReadTable(dataTable, ReadRow);
        }

        private Activity ReadRow(DataRow dr)
        {
            int id = (int)dr[ColumnActivityId];
            DateTime startTime = (DateTime)dr[ColumnStartTime];
            DateTime endTime = (DateTime)dr[ColumnEndTime];
            string activityName = dr[ColumnActivityName].ToString();

            return new Activity(id, startTime, endTime, activityName);
        }
    }
}
