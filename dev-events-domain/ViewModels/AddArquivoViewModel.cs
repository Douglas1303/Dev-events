using Microsoft.AspNetCore.Http;

namespace Poc.Application.ViewModel
{
    public class AddArquivoViewModel
    {
        public IFormFile Arquivo { get; set; }
        public int TipoArquivoId { get; set; }
    }
}