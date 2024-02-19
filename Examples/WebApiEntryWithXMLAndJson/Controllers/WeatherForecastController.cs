using ExampleWebApiEntryWithXMLAndJson.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApiEntryWithXMLAndJson.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    [HttpPost]
    public IActionResult SetCar([FromBody] Car car)
    {
        return Ok(car);
    }
}
