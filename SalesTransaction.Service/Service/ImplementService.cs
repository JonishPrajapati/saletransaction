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


            using (SqlConnection sql = new SqlConnection(conn.ToString()))
            {
                using (SqlCommand command = new SqlCommand("SpUserLoginCheck", sql))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@UserName", userLogin.UserName));
                    command.Parameters.Add(new SqlParameter("@Password", userLogin.Password));
                    

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine("user Exist");
                            return reader;
                        }
                        return null;
                    }
                }
            }           
        }

        public dynamic GetDetails(string json)
        {
            using (SqlConnection sql = new SqlConnection(conn.ToString()))
            {
                using (SqlCommand command = new SqlCommand("SpUserLoginSelByUser", sql))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Json", json.ToString()));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine("user Detail");
                            return reader;
                        }
                        return null;
                    }
                }
            }
        }
    }
}
