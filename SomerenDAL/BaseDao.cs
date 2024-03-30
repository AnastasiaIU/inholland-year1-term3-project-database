using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public abstract class BaseDao
    {
        const string ConnectionStringName = "SomerenDatabase";
        const string DatabaseErrorMessage = "Database operation failed.";

        protected SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// For Create/Update/Delete Queries.
        /// </summary>
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    using (SqlCommand command = CreateCommand(connection, query, sqlParameters))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                HandleSqlException(ex);
            }
        }

        /* We don't use this method currently but we want to keep it till the end of the project in case we will need it. */
        /// <summary>
        /// For Insert Queries with Scalar.
        /// </summary>
        /*protected int ExecuteInsertQueryWithScalar(string query, SqlParameter[] sqlParameters)
        {
            int newId = -1;

            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    using (SqlCommand command = CreateCommand(connection, query, sqlParameters))
                    {
                        newId = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                HandleSqlException(ex);
            }

            return newId;
        }*/

        /// <summary>
        /// For Select Queries.
        /// </summary>
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();

            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    using (SqlCommand command = CreateCommand(connection, query, sqlParameters))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {

                            adapter.SelectCommand = command;
                            adapter.Fill(dataSet);
                            dataTable = dataSet.Tables[0];
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                HandleSqlException(e);
            }

            return dataTable;
        }

        private void HandleSqlException(SqlException ex)
        {
            // Preserve the original exception as an inner exception
            throw new Exception(DatabaseErrorMessage, ex);
        }

        private SqlCommand CreateCommand(SqlConnection connection, string query, SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);
            return command;
        }
    }
}