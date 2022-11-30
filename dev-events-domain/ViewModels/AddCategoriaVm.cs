using System.ComponentModel.DataAnnotations;

namespace Poc.Application.ViewModel
{
    public class AddCategoriaVm
    {
        [Required]
        public string Descricao { get; set; }
    }
}