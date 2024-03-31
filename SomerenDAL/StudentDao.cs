using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        const string QueryGetAllStudents = $"SELECT {ColumnStudentNumber}, {ColumnRoomNumber}, {ColumnFirstName}, {ColumnLastName}, {ColumnPhoneNumber}, {ColumnClassNumber} FROM Students ORDER BY {ColumnLastName};";
        const string QueryCreateStudent = $"INSERT INTO Students ({ColumnStudentNumber}, {ColumnRoomNumber}, {ColumnFirstName}, {ColumnLastName}, {ColumnPhoneNumber}, {ColumnClassNumber}) VALUES ({ParameterNameStudentNumber}, {ParameterNameRoomNumber}, {ParameterNameFirstName}, {ParameterNameLastName}, {ParameterNamePhoneNumber}, {ParameterNameClassNumber});";
        const string QueryUpdateStudent = $"UPDATE Students SET {ColumnFirstName}={ParameterNameFirstName}, {ColumnLastName}={ParameterNameLastName}, {ColumnPhoneNumber}={ParameterNamePhoneNumber} WHERE {ColumnStudentNumber}={ParameterNameStudentNumber};";
        const string QueryDeleteStudent = $"DELETE FROM Students WHERE {ColumnStudentNumber}={ParameterNameStudentNumber};";

        const string ParameterNameStudentNumber = "@StudentNumber";
        const string ParameterNameRoomNumber = "@RoomNumber";
        const string ParameterNameFirstName = "@FirstName";
        const string ParameterNameLastName = "@LastName";
        const string ParameterNamePhoneNumber = "@PhoneNumber";
        const string ParameterNameClassNumber = "@ClassNumber";

        const string ColumnStudentNumber = "student_number";
        const string ColumnRoomNumber = "room_number";
        const string ColumnFirstName = "first_name";
        const string ColumnLastName = "last_name";
        const string ColumnPhoneNumber = "phone_number";
        const string ColumnClassNumber = "class_number";

        public List<Student> GetAllStudents()
        {
            SqlParameter[] sqlParameters = new SqlParameter[Zero];
            DataTable dataTable = ExecuteSelectQuery(QueryGetAllStudents, sqlParameters);
            return ReadTable(dataTable, ReadRow);
        }

        public void CreateStudent(Student student)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameStudentNumber, student.StudentNumber),
                new SqlParameter(ParameterNameRoomNumber, student.RoomNumber),
                new SqlParameter(ParameterNameFirstName, student.FirstName),
                new SqlParameter(ParameterNameLastName, student.LastName),
                new SqlParameter(ParameterNamePhoneNumber, student.PhoneNumber),
                new SqlParameter(ParameterNameClassNumber, student.ClassNumber)
            };

            ExecuteEditQuery(QueryCreateStudent, sqlParameters);
        }

        public void UpdateStudent(Student student)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameStudentNumber, student.StudentNumber),
                new SqlParameter(ParameterNameFirstName, student.FirstName),
                new SqlParameter(ParameterNameLastName, student.LastName),
                new SqlParameter(ParameterNamePhoneNumber, student.PhoneNumber)
            };

            ExecuteEditQuery(QueryUpdateStudent, sqlParameters);
        }

        public void DeleteStudent(Student student)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameStudentNumber, student.StudentNumber)
            };

            ExecuteEditQuery(QueryDeleteStudent, sqlParameters);
        }

        private Student ReadRow(DataRow dr)
        {
            int studentNumber = (int)dr[ColumnStudentNumber];
            string roomNumber = dr[ColumnRoomNumber].ToString();
            string firstName = dr[ColumnFirstName].ToString();
            string lastName = dr[ColumnLastName].ToString();
            string phoneNumber = dr[ColumnPhoneNumber] == DBNull.Value ? null : (string)dr[ColumnPhoneNumber];
            string classNumber = dr[ColumnClassNumber].ToString();

            return new Student(studentNumber, roomNumber, firstName, lastName, phoneNumber, classNumber);
        }
    }
}