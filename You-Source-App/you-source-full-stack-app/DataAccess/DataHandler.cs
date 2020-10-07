using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

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
    }
}
