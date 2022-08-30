using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace MinhaApp.Controllers
{
    public class CategoryController : ControllerBase
    {
        [HttpGet("v1/categorias")]
        public IActionResult Get(
            [FromServices]BlogDataContext context)
        {
            var categories = context.Categories.ToList();
            return Ok(categories);
        }
    }
}
