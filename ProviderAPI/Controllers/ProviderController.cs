using Microsoft.AspNetCore.Mvc;
using ProviderAPI.Model;

namespace ProviderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly Product _product = new Product()
        {
            Id = Guid.NewGuid(),
            Name = "Sample Product",
            Price = 19.99m,
            Weight = 0.5m
        };

        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            return Ok(_product);
        }
    }
}
