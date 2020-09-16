using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SalesTransaction.DataAccess;
using SalesTransaction.Model;

namespace SalesTransaction.Service.Service
{
    class ImplementService : ILoginService
    {

        private DataAccessHelper _connection;

        public ImplementService(DataAccessHelper _connection)
        {
            this._connection = _connection;
        }
    
         public dynamic GetLogin(MvUserLogin userLogin)
        {

                var conn = _connection.SetConnection(); //invoking connection method
                SqlCommand command = new SqlCommand(conn);
                conn.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = "select u.username, u.password from [dbo].userlogin where" +
                                       " u.username ='"+userLogin.UserName+"'AND" +
                                       " u.password = '"+userLogin.Password+"' ";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Console.WriteLine("user Exist");
                return reader;
                }
                else
                {
                    Console.WriteLine("no such user created");
                    return null;
                }
            
           
        }

        public dynamic GetDetails(string data)
        {
            var conn = _connection.SetConnection(); //invoking connection method
            SqlCommand command = new SqlCommand(conn);
            conn.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from [dbo].[UserLogin]";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("done");
                return reader;
            }
            else
            {
                Console.WriteLine("faulty");
                return null;
            } 
        }
    }
}
