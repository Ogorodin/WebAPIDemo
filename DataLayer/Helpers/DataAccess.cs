using Dapper;
using DataLayer.Entity;
using MySql.Data.MySqlClient;
using System.Data;
using static DataLayer.Entity.Product;

namespace DataLayer.Helpers
{
    public class DataAccess
    {

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
               connection.Query<Product>(procedure, inputValues, commandType: CommandType.StoredProcedure);
            };
        }
    }
}
