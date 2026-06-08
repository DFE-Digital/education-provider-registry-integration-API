using Microsoft.AspNetCore.Mvc;

namespace DfE.EducationProviderRegistry.IntegrationsApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet("health", Name = "HealthCheck")]
    public IActionResult Health()
    {
        return Ok(new
        {
            status = "Service is running",
            timestamp = DateTime.UtcNow
        });
    }
}
