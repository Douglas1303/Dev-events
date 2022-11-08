using Newtonsoft.Json;

namespace Poc.Application.ViewModel
{
    public class CepUsuarioVm
    {
        public CepUsuarioVm(string cep, string logradouro, string complemento, string bairro, string localidade, string uF, string dDD)
        {
            Cep = cep;
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Localidade = localidade;
            UF = uF;
            DDD = dDD;
        }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cidade")]
        public string Localidade { get; set; }

        [JsonProperty("uf")]
        public string UF { get; set; }

        [JsonProperty("ddd")]
        public string DDD { get; set; }
    }
}