using dev_events_service.Interface;
using Microsoft.AspNetCore.Mvc;
using Poc.Application.ViewModel;

namespace dev_events_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatrocinadorController : ControllerBase
    {
        private readonly IPatrocinadorService _patrocinadorService;

        public PatrocinadorController(IPatrocinadorService patrocinadorService)
        {
            _patrocinadorService = patrocinadorService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _patrocinadorService.GetAllAsync());
        }

        /// <summary>
        /// Insere um novo Patrocinador
        /// </summary>
        /// <param name="novoPatrocinador"></param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddPatrocinadorVm viewModel)
        {
            return Ok(await _patrocinadorService.AddAsync(viewModel));
        }

        [HttpDelete("{id=int}")]
        public async Task<IActionResult> Remove(int id)
        {
            return Ok(await _patrocinadorService.RemoveAsync(id));
        }
    }
}
