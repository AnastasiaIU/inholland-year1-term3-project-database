﻿using SomerenModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class PurchaseDao : BaseDao
    {
        public List<Purchase> GetAllPurchases()
        {
            string query = "SELECT [purchaseId], [student_number], [drinkId], [quantity] FROM Purchases";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTable(dataTable, ReadRow);
        }

        public void CreatePurchase(Purchase purchase)
        {
            string query = "INSERT INTO Purchases VALUES (@StudentId, @DrinkId, @Quantity); SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentId", purchase.StudentId),
                new SqlParameter("@DrinkId", purchase.DrinkId),
                new SqlParameter("@Quantity", purchase.Quantity)
            };

            ExecuteEditQuery(query, sqlParameters);
        }

        private Purchase ReadRow(DataRow dr)
        {
            int id = (int)dr["purchaseId"];
            int studentId = (int)dr["student_number"];
            int drinkId = (int)dr["drinkId"];
            int quantity = (int)dr["quantity"];

            return new Purchase(id, studentId, drinkId, quantity);
        }
    }
}
