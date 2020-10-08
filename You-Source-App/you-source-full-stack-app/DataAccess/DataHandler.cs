using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Services;

namespace DataAccess
{
    public abstract class DataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        SqlConnection conn;
        SqlCommand command;
        private string qry;
        private string tblName;

        public string TblName { get => tblName; set => tblName = value; }
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
        public DataSet ReadData()
        {
            DataSet rawData = new DataSet();
            Conn = new SqlConnection(Connection.ToString());
            try
            {
                Conn.Open();//conects to server

                SqlDataAdapter adapter = new SqlDataAdapter(Qry, Conn);
                adapter.FillSchema(rawData, SchemaType.Source, tblName);//where, schema type, newtablename
                rawData.EnforceConstraints = false;
                adapter.Fill(rawData, tblName);//fills the data
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
            return rawData;
        }


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
            return null;
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
