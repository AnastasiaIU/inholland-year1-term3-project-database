using SomerenModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class SupervisorDao : LecturerDao
    {
        const string QueryGetAllSupervisorsForActivity = $"SELECT {ColumnLecturerId}, {ColumnAge}, {ColumnRoomNumber}, {ColumnFirstName}, {ColumnLastName}, {ColumnPhoneNumber} FROM Lecturers WHERE {ColumnLecturerId} IN (SELECT {ColumnLecturerId} FROM Supervisions WHERE {ColumnActivityId}={ParameterNameActivityId}) ORDER BY {ColumnLastName};";
        const string QueryGetAllAvailableSupervisorsForActivity = $"SELECT {ColumnLecturerId}, {ColumnAge}, {ColumnRoomNumber}, {ColumnFirstName}, {ColumnLastName}, {ColumnPhoneNumber} FROM Lecturers WHERE {ColumnLecturerId} NOT IN (SELECT {ColumnLecturerId} FROM Supervisions WHERE {ColumnActivityId}={ParameterNameActivityId}) ORDER BY {ColumnLastName};";
        const string QueryAddSupervisorToActivity = $"INSERT INTO Supervisions VALUES ({ParameterNameLecturerId}, {ParameterNameActivityId});";
        const string QueryDeleteSupervisorFromActivity = $"DELETE FROM Supervisions WHERE {ColumnActivityId}={ParameterNameActivityId} AND {ColumnLecturerId}={ParameterNameLecturerId};";

        const string ParameterNameLecturerId = "@LecturerId";
        const string ParameterNameActivityId = "@ActivityId";

        const string ColumnActivityId = "activityId";

        public List<Lecturer> GetAllSupervisorsForActivity(Activity activity)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameActivityId, activity.Id)
            };
            DataTable dataTable = ExecuteSelectQuery(QueryGetAllSupervisorsForActivity, sqlParameters);
            return ReadTable(dataTable, ReadRow);
        }

        public List<Lecturer> GetAllAvailableSupervisorsForActivity(Activity activity)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameActivityId, activity.Id)
            };
            DataTable dataTable = ExecuteSelectQuery(QueryGetAllAvailableSupervisorsForActivity, sqlParameters);
            return ReadTable(dataTable, ReadRow);
        }

        public void AddSupervisorToActivity(Lecturer lecturer, Activity activity)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameLecturerId, lecturer.Id),
                new SqlParameter(ParameterNameActivityId, activity.Id)
            };

            ExecuteEditQuery(QueryAddSupervisorToActivity, sqlParameters);
        }

        public void DeleteSupervisorFromActivity(Lecturer lecturer, Activity activity)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameLecturerId, lecturer.Id),
                new SqlParameter(ParameterNameActivityId, activity.Id)
            };

            ExecuteEditQuery(QueryDeleteSupervisorFromActivity, sqlParameters);
        }
    }
}
