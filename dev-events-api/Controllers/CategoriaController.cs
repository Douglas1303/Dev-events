using Microsoft.AspNetCore.Mvc;

namespace dev_events_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        public CategoriaController()
        {
           
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            
            return Ok("Caiuuuuuu");
        }
    }
}
