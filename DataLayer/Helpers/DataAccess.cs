using Dapper;
using DataLayer.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using static DataLayer.Entity.Product;

namespace DataLayer.Helpers
{
    public class DataAccess
    {

        // STUCK STUCKSTUCK STUCK STUCK STUCK STUCKSTUCK STUCK STUCK STUCKSTUCK STUCK
        // STUCK STUCKSTUCK STUCK STUCK STUCK STUCKSTUCK STUCK STUCK STUCKSTUCK STUCK
        // STUCK STUCKSTUCK STUCK STUCK STUCK STUCKSTUCK STUCK STUCK STUCKSTUCK STUCK
        public DataTable GetCompleteProductWithStockData()
        {
            DataTable dataTable = new DataTable();
            string connectionSting = "server=localhost;port=3306;database=the_fish_shop_db;uid=root;password=admin;";
            using (MySqlConnection connection = new MySqlConnection(connectionSting))
            {
                connection.Open();
                var procedure = "get_products_with_stock_data";
                //using (MySqlCommand command = new MySqlCommand(procedure, connection))
                //{
                //  MySqlDataReader reader = command.ExecuteReader();
                var result = connection.Query<object>(procedure, commandType: CommandType.StoredProcedure);
                
         //       dataTable.Load((IDataReader)result);
                //}
                //   var result = connection.Query<object>(procedure, commandType: CommandType.StoredProcedure);

                //connection.Open();
                //var procedure = "get_products_with_stock_data";
                //

                //MySqlCommand command = new MySqlCommand();
                //MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                //DataTable dataTable = new DataTable();
                //try
                //{
                //    dataTable.Columns.Add("Id", typeof(int));
                //    dataTable.Columns.Add("Title", typeof(string));
                //    dataTable.Columns.Add("Description", typeof(string));
                //    dataTable.Columns.Add("Price", typeof(double));
                //    dataTable.Columns.Add("Quantity", typeof(int));
                //    dataTable.Columns.Add("Type", typeof(EProductType));
                //    dataTable.Columns.Add("Date", typeof(DateTime));





                //    command = new MySqlCommand(procedure, connection);
                //    command.CommandType = CommandType.StoredProcedure;
                //    dataAdapter.SelectCommand = command;
                //    dataAdapter.Fill(dataTable);

                //    return dataTable;

                //}
                //catch (Exception exc)
                //{
                //    return null;
                //}



                return dataTable;
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
                connection.Query<Product>(procedure, inputValues, commandType: CommandType.StoredProcedure);
            };
        }


    }
}
