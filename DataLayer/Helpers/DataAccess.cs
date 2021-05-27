using Dapper;
using DataLayer.Entity;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using static DataLayer.Entity.Product;

namespace DataLayer.Helpers
{
    public class DataAccess
    {
        public IEnumerable<object> GetCompleteProductWithStockData()
        {
            string connectionSting = "server=localhost;port=3306;database=the_fish_shop_db;uid=root;password=admin;";
            using (MySqlConnection connection = new MySqlConnection(connectionSting))
            {
                connection.Open();
             //   var procedure = "get_products_with_stock_data";

                return connection.Query<object>("SELECT * FROM product");

            }
        }
        public void InsertProduct(string title, string description, EProductType productType)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=the_fish_shop_db;uid=root;password=admin;"))
            {
                connection.Open();
                var procedure = "insertProduct";
                var inputValues = new
                {
                    title = title,
                    description = description,
                    productType = productType
                };

                connection.Execute("INSERT INTO product(title, description, the_type) VALUES(@title, @description, @productType)", inputValues);
                // TODO
                //connection.Execute(procedure, inputValues, commandType: CommandType.StoredProcedure);

            };
        }


    }
}
