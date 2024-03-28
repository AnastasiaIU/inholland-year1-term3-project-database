using SomerenModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class SupervisorDao : LecturerDao
    {
        public List<Lecturer> GetAllSupervisorsForActivity(Activity activity)
        {
            string query = "SELECT [lecturerId], [age], [room_number], [first_name], [last_name], [phone_number] FROM Lecturers WHERE [lecturerId] IN (SELECT [lecturerId] FROM Supervisions WHERE [activityId] = @ActivityId) ORDER BY [last_name];";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activity.Id)
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable, ReadRow);
        }

        public List<Lecturer> GetAllAvailableSupervisorsForActivity(Activity activity)
        {
            string query = "SELECT [lecturerId], [age], [room_number], [first_name], [last_name], [phone_number] FROM Lecturers WHERE [lecturerId] NOT IN (SELECT [lecturerId] FROM Supervisions WHERE [activityId] = @ActivityId) ORDER BY [last_name];";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activity.Id)
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable, ReadRow);
        }

        public void AddSupervisorToActivity(Lecturer lecturer, Activity activity)
        {
            string query = "INSERT INTO Supervisions VALUES (@LecturerId, @ActivityId)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LecturerId", lecturer.Id),
                new SqlParameter("@ActivityId", activity.Id)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteSupervisorFromActivity(Lecturer lecturer, Activity activity)
        {
            string query = "DELETE FROM Supervisions WHERE activityId=@ActivityId AND lecturerId=@LecturerId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@LecturerId", lecturer.Id),
                new SqlParameter("@ActivityId", activity.Id)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
