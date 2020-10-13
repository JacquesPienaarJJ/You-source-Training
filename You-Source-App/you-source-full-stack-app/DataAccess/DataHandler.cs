using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Services;

namespace DataAccess
{
    public class DataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        SqlConnection conn;
        SqlCommand command;
        private string qry;
        public string Qry { get => qry; set => qry = value; }
        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlConnectionStringBuilder Connection { get => connection; set => connection = value; }

        public DataHandler()
        {
            Connection.DataSource = @"LAPTOP-JKPOH1K5\SQLEXPRESS";
            Connection.InitialCatalog = "VoucherHoundDB";//name of database
            Connection.IntegratedSecurity = true;// for windows login
            /*
            connection.DataSource = @"d.online,1433\SQLEXPRESS";
            connection.InitialCatalog = "BigShop";//name of database
            connection.IntegratedSecurity = false;// for windows login
            connection.UserID = "sqlserverlogin";//username
            connection.Password = "verysafepass";//userpass
            */
        }
        
        //READ EXAMPLE
        //public DataSet ReadData()
        //{
        //    DataSet rawData = new DataSet();
        //    Conn = new SqlConnection(Connection.ToString());
        //    try
        //    {
        //        Conn.Open();//conects to server

        //        SqlDataAdapter adapter = new SqlDataAdapter(Qry, Conn);
        //        adapter.FillSchema(rawData, SchemaType.Source, tblName);//where, schema type, newtablename
        //        rawData.EnforceConstraints = false;
        //        adapter.Fill(rawData, tblName);//fills the data
        //    }
        //    catch (SqlException se)//connection
        //    {
        //        throw new Exception(se.Message, se);
        //    }
        //    finally
        //    {
        //        if (Conn.State == ConnectionState.Open)
        //        {
        //            Conn.Close();
        //        }
        //    }
        //    return rawData;
        //}


        //CRUD Operations
        //CREATE NEW ORDER {ProductID, CustomerID, SenderMail, RecipientMail}
        public void CreateNewOrder()
        {

        }

        //CREATE NEW PRODUCT {MerchantID, ProductName, Quantity}
        public void CreateNewProduct()
        {

        }

        //CREATE NEW CUSTOMER {FirstName, LastName, Age, Email, PhoneNumber}
        public void CreateNewCustomer()
        {

        }

        //CREATE NEW MERCHANT {MerchantName, Country}
        public void CreateNewMerchant()
        {

        }

        //READ ALL ORDERS
        public List<Order> GetOrders()
        {
            return null;
        }

        //READ ALL PRODUCTS
        public List<Product> GetProducts()
        {
            DataSet rawData = new DataSet();
            Conn = new SqlConnection(Connection.ToString());
            List<Product> productList = new List<Product>();
            try
            {
                Conn.Open();//conects to server
                SqlDataAdapter adapter = new SqlDataAdapter(Qry, Conn);
                adapter.FillSchema(rawData, SchemaType.Source, "Products");//where, schema type, newtablename
                rawData.EnforceConstraints = false;
                adapter.Fill(rawData, "Products");//fills the data

                
                for (int i = 0; i < rawData.Tables[0].Rows.Count; i++)
                {
                    Product p = new Product();
                    p.ProductID = int.Parse(rawData.Tables[0].Rows[i]["ProductID"].ToString());
                    p.MerchantID = int.Parse(rawData.Tables[0].Rows[i]["MerchantID"].ToString());
                    p.ProductName = rawData.Tables[0].Rows[i]["ProductName"].ToString();
                    p.Quantity = int.Parse(rawData.Tables[0].Rows[i]["Quantity"].ToString());
                    productList.Add(p);
                }
                
            }
            catch (SqlException se)//connection
            {
                throw new Exception(se.Message, se);
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
            }
            return productList;
        }

        //READ ALL CUSTOMERS
        public List<Customer> GetCustomers()
        {
            return null;
        }

        //READ ALL MERCHANTS
        public List<Merchant> GetMerchants()
        {
            return null;
        }


        //UPDATE ORDER
        public void UpdateOrder()
        {

        }

        public void UpdateProduct()
        {

        }


    }
}
