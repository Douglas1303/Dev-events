using System.ComponentModel.DataAnnotations;

namespace Poc.Application.ViewModel
{
    public class AddCategoriaViewModel
    {
        [Required]
        public string Descricao { get; set; }
    }
}