using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backendApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("get-products")]
        public IActionResult Products() 
        {
            return Ok(new JsonResult(new { message = "Only authorize users can view products" }));
        }
    }
}
