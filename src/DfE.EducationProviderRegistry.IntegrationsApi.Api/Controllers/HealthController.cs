using Microsoft.AspNetCore.Mvc;

namespace DfE.EducationProviderRegistry.IntegrationsApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet(Name = "HealthCheck")]
    public IActionResult Index()
    {
        return Ok(new
        {
            status = "Service is running",
            timestamp = DateTime.UtcNow
        });
    }
}
