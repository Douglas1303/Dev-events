using Microsoft.AspNetCore.Http;

namespace Poc.Application.ViewModel
{
    public class AddArquivoVm
    {
        public IFormFile Arquivo { get; set; }
        public int TipoArquivoId { get; set; }
    }
}