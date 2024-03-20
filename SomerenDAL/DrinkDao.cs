using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT * FROM Drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void CreateDrink(Drink drink)
        {            
            string query = "INSERT INTO Drinks VALUES (@Price, @IsAlcoholic, @Name, @Stock);" + "SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Price", drink.Price),
                new SqlParameter("@IsAlcoholic", drink.IsAlcholic),
                new SqlParameter("@Name", drink.Name),
                new SqlParameter("@Stock", drink.Stock)
            };

            int id = ExecuteInsertQuery(query, sqlParameters);            
        }

        public void UpdateDrink(Drink drink) 
        {
            string query = "UPDATE Drinks SET price=@Price, alcoholic=@IsAlcoholic, drink_name=@Name, current_stock=@Stock WHERE drinkId=@Id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Price", drink.Price),
                new SqlParameter("@IsAlcoholic", drink.IsAlcholic),
                new SqlParameter("@Name", drink.Name),
                new SqlParameter("@Stock", drink.Stock),
                new SqlParameter("@Id", drink.Id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteDrink(Drink drink) 
        {
            string query = "DELETE FROM Drinks WHERE drinkId=@Id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Id", drink.Id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int id = (int)dr["drinkId"];
                double price = (double)dr["price"];                
                bool isAlcoholic = (bool)dr["alcoholic"];
                string name = (string)dr["drink_name"];
                int stock = (int)dr["current_stock"];

                Drink drink = new Drink(id, price, isAlcoholic, name, stock);
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
