using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje3.API.Infrastructure;
using Proje3.Model;
using Proje3.Service.Product;

namespace Proje3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;  
        }

        [HttpPost]
        public General<Model.Product.ProductDetail> Insert([FromBody] Proje3.Model.Product.InsertProduct newProduct)
        {
            General<Model.Product.ProductDetail> response = new();
            response = productService.Insert(newProduct);

            return response;
        }

        [HttpGet]
        public General<Model.Product.ListProduct> GetList()
        {
            General<Model.Product.ListProduct> response = new();

            return response;
        }

        [HttpGet("{id:int}")]
        public General<Model.Product.ProductDetail> GetById(int id)
        {
            General<Model.Product.ProductDetail> response = new();

            return response;

        }


    }
}
