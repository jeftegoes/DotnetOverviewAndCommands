using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{

    private readonly ILogger<ValuesController> _logger;

    public ValuesController(ILogger<ValuesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("You requested the ValuesController...");

        try
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 56)
                {
                    throw new Exception("This is our demo exception.");
                }
                else
                {
                    _logger.LogInformation("The value of i is {LoopCountValue}", i);
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "We caught this expcetion in the Index Get call.");
        }

        return Ok(new string[] { "Value1", "Value2" });
    }
}
