using Microsoft.AspNetCore.Mvc;

namespace MinhaApp.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "Hello World";
        }
    }
}
