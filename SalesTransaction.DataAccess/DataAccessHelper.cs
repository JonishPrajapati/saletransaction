using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SalesTransaction.DataAccess
{
    public class DataAccessHelper
    {

        public DataAccessHelper()
        {

        }
        //establishing connection
        public SqlConnection SetConnection()
        {
            SqlConnection _connection = new SqlConnection("Data Source=10.6.0.246;" +
                                             "Initial Catalog=Jonish;" +
                                             "User ID=intern;" +
                                             "Password=intern001;" +
                                             "TrustServerCertificate=False");
            try {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                    Console.WriteLine("Connected successfully.");
                    Console.ReadKey(true);
                }
                else
                {
                    _connection.Close();
                    _connection.Open();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("error occured");
            }
            return _connection;
        }



    }
}
