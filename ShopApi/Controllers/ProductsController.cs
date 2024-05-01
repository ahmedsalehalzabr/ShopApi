using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopApi.Core.Interfaces;
using ShopApi.Data;


namespace ShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProudectRepository proudectRepository;

        public ProductsController(IProudectRepository proudectRepository)
        {
            this.proudectRepository = proudectRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var product = await proudectRepository.GetProductsAsync();

            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var product = await proudectRepository.GetProductByIdAsync(id);
             
            return Ok(product);
             
        }

    }
}
