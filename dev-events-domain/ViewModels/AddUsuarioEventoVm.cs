using System.ComponentModel.DataAnnotations;

namespace Poc.Application.ViewModel
{
    public class AddUsuarioEventoVm
    {
        [Required]
        public int EventoId { get; set; }
        [Required]
        public int UsuarioId { get; set; }
    }
}