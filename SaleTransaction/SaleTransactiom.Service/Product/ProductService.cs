using Microsoft.Extensions.Configuration;
using SaleTransaction.Application.DataAccess;
using SaleTransaction.Application.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SaleTransaction.Application.Service.Product
{
    public class ProductService : IProductService
    {
        private readonly string _connectionString;
        private DataAccessHelper _dah;

        public ProductService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            if (_connectionString != null)
            {
                _dah = new DataAccessHelper(_connectionString);
            }
        }
        public dynamic AddProduct(MvProduct productItem)
        {
            using (var sql = _dah.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("SpProductIns_JSON", sql))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ProductName", productItem.ProductName));
                    command.Parameters.Add(new SqlParameter("@ProductCategory", productItem.ProductCategory));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine("Product Added Successfully");
                            return _dah.GetJson(reader);
                        }
                        return null;
                    }
                }
            }
        }

        public dynamic DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic GetAllProductDetails()
        {
            throw new NotImplementedException();
        }

        public dynamic GetProductDetail(string json)
        {
            throw new NotImplementedException();
        }

        public dynamic UpdateProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
