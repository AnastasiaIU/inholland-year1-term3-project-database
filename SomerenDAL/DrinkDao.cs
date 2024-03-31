using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        const string QueryGetAllDrinks = $"SELECT {ColumnDrinkId}, {ColumnPrice}, {ColumnAlcoholic}, {ColumnDrinkName}, {ColumnCurrentStock}, (SELECT SUM(quantity) FROM Purchases WHERE Purchases.{ColumnDrinkId} = Drinks.{ColumnDrinkId} GROUP BY {ColumnDrinkId}) AS {ColumnNumberOfPurchases} FROM Drinks ORDER BY {ColumnDrinkName};";
        const string QueryCreateDrink = $"INSERT INTO Drinks VALUES ({ParameterNamePrice}, {ParameterNameIsAlcoholic}, {ParameterNameDrinkName}, {ParameterNameStock}); SELECT CAST(scope_identity() AS int);";
        const string QueryUpdateDrink = $"UPDATE Drinks SET {ColumnPrice}={ParameterNamePrice}, {ColumnAlcoholic}={ParameterNameIsAlcoholic}, {ColumnDrinkName}={ParameterNameDrinkName}, {ColumnCurrentStock}={ParameterNameStock} WHERE {ColumnDrinkId}={ParameterNameDrinkId};";
        const string QueryDeleteDrink = $"DELETE FROM Drinks WHERE {ColumnDrinkId}={ParameterNameDrinkId};";

        const string ParameterNameDrinkId = "@DrinkId";
        const string ParameterNamePrice = "@Price";
        const string ParameterNameIsAlcoholic = "@IsAlcoholic";
        const string ParameterNameDrinkName = "@DrinkName";
        const string ParameterNameStock = "@Stock";

        const string ColumnDrinkId = "drinkId";
        const string ColumnPrice = "price";
        const string ColumnAlcoholic = "alcoholic";
        const string ColumnDrinkName = "drink_name";
        const string ColumnCurrentStock = "current_stock";
        const string ColumnNumberOfPurchases = "number_of_purchases";

        public List<Drink> GetAllDrinks()
        {
            SqlParameter[] sqlParameters = new SqlParameter[Zero];
            DataTable dataTable = ExecuteSelectQuery(QueryGetAllDrinks, sqlParameters);
            return ReadTable(dataTable, ReadRow);
        }

        public void CreateDrink(Drink drink)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNamePrice, drink.Price),
                new SqlParameter(ParameterNameIsAlcoholic, drink.IsAlcoholic),
                new SqlParameter(ParameterNameDrinkName, drink.Name),
                new SqlParameter(ParameterNameStock, drink.Stock)
            };

            ExecuteEditQuery(QueryCreateDrink, sqlParameters);
        }

        public void UpdateDrink(Drink drink)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameDrinkId, drink.Id),
                new SqlParameter(ParameterNamePrice, drink.Price),
                new SqlParameter(ParameterNameIsAlcoholic, drink.IsAlcoholic),
                new SqlParameter(ParameterNameDrinkName, drink.Name),
                new SqlParameter(ParameterNameStock, drink.Stock)
            };

            ExecuteEditQuery(QueryUpdateDrink, sqlParameters);
        }

        public void DeleteDrink(Drink drink)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter(ParameterNameDrinkId, drink.Id)
            };

            ExecuteEditQuery(QueryDeleteDrink, sqlParameters);
        }

        private Drink ReadRow(DataRow dr)
        {
            int id = (int)dr[ColumnDrinkId];
            double price = (double)dr[ColumnPrice];
            bool isAlcoholic = (bool)dr[ColumnAlcoholic];
            string name = (string)dr[ColumnDrinkName];
            int stock = (int)dr[ColumnCurrentStock];
            int numberOfPurchases = dr[ColumnNumberOfPurchases] == DBNull.Value ? Zero : (int)dr[ColumnNumberOfPurchases];

            return new Drink(id, price, isAlcoholic, name, stock, numberOfPurchases);
        }
    }
}
