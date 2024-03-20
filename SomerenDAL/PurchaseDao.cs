using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class PurchaseDao : BaseDao
    {
        public List<Purchase> GetAllPurchases()
        {
            string query = "SELECT * FROM Purchases";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void CreatePurchase(Purchase purchase)
        {
            string query = "INSERT INTO Purchases VALUES (@StudentId, @DrinkId, @Quantity);" + "SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentId", purchase.StudentId),
                new SqlParameter("@DrinkId", purchase.DrinkId),
                new SqlParameter("@Quantity", purchase.Quantity)
            };

            int id = ExecuteInsertQuery(query, sqlParameters);
        }

        private List<Purchase> ReadTables(DataTable dataTable)
        {
            List<Purchase> purchases = new List<Purchase>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["purchaseId"];
                int studentId = (int)dr["student_number"];
                int drinkId = (int)dr["drinkId"];
                int quantity = (int)dr["amount"];

                Purchase purchase = new Purchase(id, studentId, drinkId, quantity);
                purchases.Add(purchase);
            }
            return purchases;
        }
    }
}
