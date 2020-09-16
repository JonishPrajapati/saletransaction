using System;

namespace SalesTransaction.DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessHelper ad = new DataAccessHelper();
            ad.SetConnection();
        }
    }
}
