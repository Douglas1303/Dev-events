using dev_events_service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace dev_events_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly ICepService _cepService;

        public CepController(ICepService cepService)
        {
            _cepService = cepService;
        }

        [HttpGet("{cep}")]
        public async Task<IActionResult> GetByCepAsync(string cep)
        {
            try
            {
                return Ok(await _cepService.GetCepAsync(cep));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
