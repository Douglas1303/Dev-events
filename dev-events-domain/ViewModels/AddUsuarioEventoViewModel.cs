using System.ComponentModel.DataAnnotations;

namespace Poc.Application.ViewModel
{
    public class AddUsuarioEventoViewModel
    {
        [Required]
        public int EventoId { get; set; }
        [Required]
        public int UsuarioId { get; set; }
    }
}