using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleTransaction.Application.Model;
using SaleTransaction.Application.Service.Product;
using SaleTransaction.Application.WebApi.Base;

namespace SaleTransaction.Application.WebApi.Areas.Product
{
    public class ProductController : BaseController {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public IActionResult productAdd(MvProduct product)
        {
            try
            {
                _productService.AddProduct(product);
                return (IActionResult)product;
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }
    }
}
