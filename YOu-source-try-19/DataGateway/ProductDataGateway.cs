using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YOu_source_try_19.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace YOu_source_try_19.DataGateway
{
    public class ProductDataGateway : IProductDataGateway
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;
        private string procName;

        public SqlConnectionStringBuilder Connection { get => connection; set => connection = value; }
        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public string ProcName { get => procName; set => procName = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }

        public ProductDataGateway()
        {
            Connection.DataSource = @"LAPTOP-JKPOH1K5\SQLEXPRESS";
            Connection.InitialCatalog = "VoucherDB";
            Connection.IntegratedSecurity = true;
        }

        public List<Product> GetProducts()
        {
            DataSet rawData = new DataSet();
            Conn = new SqlConnection(Connection.ToString());
            List<Product> products = new List<Product>();
            try
            {
                procName = "sp_GetAllProducts";
                command = new SqlCommand(ProcName, Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                Conn.Open(); //Connects with Server
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product p = new Product();

                        p.ProductID = reader.GetInt32(0);
                        p.MerchantID = reader.GetInt32(1);
                        p.ProductName = reader.GetString(2);
                        p.Price = Convert.ToSingle(reader.GetDecimal(3));
                        p.Quantity = reader.GetInt32(4);
                        products.Add(p);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return products;
        }
    }
}
