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
