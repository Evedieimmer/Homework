using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Homework_SQL_query
{
    class ProductDB
    {
        public static SqlConnection sqlConnection = new SqlConnection("Data Source=WIN-NJK75T1QS28\\SQLEXPRESS;Initial Catalog=CalorieCalculatorDB;Integrated Security=True");

        public static List<Product> DBload()
        {
            List<Product> products = new List<Product>();
            string sqlQuery = "SELECT NameProduct, Calorie FROM Products";
            SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    int calorie = reader.GetInt32(1);
                    products.Add(new Product(name, calorie));
                }
            }
            sqlConnection.Close();
            return products;
        }


        public static void DBProductDelete(Product prod)
        {
            string sql = $"DELETE FROM Products WHERE NameProduct = '{prod.Name}' AND Calorie = {prod.Calorie}";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            int DeletedCount = command.ExecuteNonQuery();
            sqlConnection.Close();
            if (DeletedCount > 1)
                throw (new Exception("Удалили больше 1 юзера!"));
            else if (DeletedCount == 0)
                throw (new Exception("Продукта нет в базе данных!"));
        }

        public static void DBSave(List<Product> prod)
        {
            string sql = "DELETE  FROM Products";
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
                sql = "INSERT students VALUES";
                foreach (var p in prod)
                {
                    if (sql[sql.Length - 1] == ')')
                        sql += ",";
                    sql += $" ('{p.Name}', {p.Calorie})";
                }
                command = new SqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw (new Exception("Ошибка при сохранении!"));
            }

            sqlConnection.Close();
        }

    }
}
