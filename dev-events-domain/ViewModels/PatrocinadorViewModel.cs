using Newtonsoft.Json;

namespace Poc.Application.ViewModel
{
    public class PatrocinadorViewModel
    {
        public string NomePatrocinador { get; set; }

        public string Documento { get; set; }

        public string Telefone { get; set; }

        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        [JsonProperty("cidade")]
        public string Localidade { get; set; }

        public string UF { get; set; }

        public int DDD { get; set; }
    }
}