using SomerenModel;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class PurchaseDao : BaseDao
    {
        public void CreatePurchase(Purchase purchase)
        {
            string query = "INSERT INTO Purchases VALUES (@StudentId, @DrinkId, @Quantity); SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@StudentId", purchase.Student.StudentNumber),
                new SqlParameter("@DrinkId", purchase.Drink.Id),
                new SqlParameter("@Quantity", purchase.Quantity)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
