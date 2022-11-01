using System.ComponentModel.DataAnnotations;

namespace Poc.Application.ViewModel
{
    public class AddEventoViewModel
    {
        [Required(ErrorMessage = "Titulo precisa ser informado.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Descrição precisa ser informada.")]
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        public string DataInicio { get; set; }

        [DataType(DataType.Date)]
        public string DataFim { get; set; }

        public int CategoriaId { get; set; }
    }
}