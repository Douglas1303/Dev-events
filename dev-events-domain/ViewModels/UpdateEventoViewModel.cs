using System.ComponentModel.DataAnnotations;

namespace Poc.Application.ViewModel
{
    public class UpdateEventoViewModel
    {
        [Required(ErrorMessage = "Id não pode ser vazio.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo não pode ser vazio.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Descrição não pode ser vazio.")]
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        public string DataInicio { get; set; }

        [DataType(DataType.Date)]
        public string DataFim { get; set; }

        public bool Ativo { get; set; }

        [Required]
        public int CategoriaId { get; set; }
    }
}