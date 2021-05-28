using Dapper;
using DataLayer.Entity;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using static DataLayer.Entity.Product;

namespace DataLayer.Helpers
{
    public class DataAccess
    {
        private string _connectionSting = "server=localhost;port=3306;database=the_fish_shop_db;uid=root;password=admin;";

        public IEnumerable<Product> GetProductList()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionSting))
            {
                connection.Open();
                //   var procedure = "get_products_with_stock_data";
                var sql = "SELECT * FROM product";
                return connection.Query<Product>(sql);
            }
        }
        public void InsertProduct(string title, string description, EProductType productType)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionSting))
            {
                connection.Open();
                //   var procedure = "insertProduct";
                var parameters = new
                {
                    title = title,
                    description = description,
                    productType = productType
                };
                string sql = "INSERT INTO product(title, description, the_type) VALUES(@title, @description, @productType)";
                connection.Execute(sql, parameters);
                // TODO - take in account other tables other than product (stock)
                //connection.Execute(procedure, inputValues, commandType: CommandType.StoredProcedure);

            };
        }

        // problem here
        public IEnumerable<object> GetProductListWithSearchCriteria(string columnName, string searchString)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionSting))
            {
                connection.Open();

                var dictionary = new Dictionary<string, object>
                {
                    { "@column", columnName},
                    { "@target", searchString}
                };
                var parameters = new DynamicParameters(dictionary);

                var sql = "SELECT * FROM product WHERE @column = @target";
                var result = connection.Query<object>(sql, parameters);

                return result;
            };
        }


    }
}
