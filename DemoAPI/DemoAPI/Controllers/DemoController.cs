using DemoAPI.Infrastructure.Provider;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DemoController(IProviderRestEaseClient providerRestEaseClient) 
    : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var data = await providerRestEaseClient.GetProviderDataAsync();

        return Ok(data);
    }
}
