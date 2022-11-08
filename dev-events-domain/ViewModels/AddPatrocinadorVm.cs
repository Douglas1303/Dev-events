using System.ComponentModel.DataAnnotations;

namespace Poc.Application.ViewModel
{
    public class AddPatrocinadorVm
    {
        [Required]
        public int TipoPatrocinador { get; set; }
        [Required]
        public string NomePatrocinador { get; set; }

        [Required]
        public string Documento { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Cep { get; set; }

        [Required]
        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        //[JsonProperty("cidade")]
        public string Localidade { get; set; }

        [Required]
        public string UF { get; set; }

        [Required]
        public int DDD { get; set; }
    }
}