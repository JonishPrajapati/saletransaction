using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SalesTransaction.DataAccess;
using SalesTransaction.Model;

namespace SalesTransaction.Service.Service
{
   public class ImplementService : ILoginService
    {
        private SqlConnection conn;
        private DataAccessHelper dah;
        public ImplementService()
        {
            this.dah = new DataAccessHelper();
            this.conn = dah.SetConnection();
        }


     
         public dynamic GetLogin(MvUserLogin userLogin)
        {
            
                 //invoking connection method

                SqlCommand command = new SqlCommand("select u.username, u.password from [dbo].userlogin where" +
                                       " u.username ='" + userLogin.UserName + "'AND" +
                                       " u.password = '" + userLogin.Password + "' ", conn);
                conn.Open();
                command.CommandType = CommandType.Text;
                //command.CommandText = ;
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

        public dynamic GetDetails()
        {
     
            SqlCommand command = new SqlCommand("select * from [dbo].[UserLogin]", conn);
            command.CommandType = CommandType.Text;
            //command.CommandText = ;
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
