using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        public IActionResult Home()
        {
            return Ok("WebHook working well.");
        }
    }
}