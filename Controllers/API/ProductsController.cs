using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperShopBrunoFerreira.Data;
using System.Collections.Concurrent;

namespace SuperShopBrunoFerreira.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productRepository.GetAllWithUsers());
        }
    }
}
