using SomerenModel;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class PurchaseDao : BaseDao
    {
        const string QueryCreatePurchase = $"INSERT INTO Purchases VALUES ({ParameterNameStudentNumber}, {ParameterNameDrinkId}, {ParameterNameQuantity}); SELECT CAST(scope_identity() AS int);";

        const string ParameterNameStudentNumber = "@StudentNumber";
        const string ParameterNameDrinkId = "@DrinkId";
        const string ParameterNameQuantity = "@Quantity";

        public void CreatePurchase(Purchase purchase)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameStudentNumber, purchase.Student.StudentNumber),
                new SqlParameter(ParameterNameDrinkId, purchase.Drink.Id),
                new SqlParameter(ParameterNameQuantity, purchase.Quantity)
            };

            ExecuteEditQuery(QueryCreatePurchase, sqlParameters);
        }
    }
}