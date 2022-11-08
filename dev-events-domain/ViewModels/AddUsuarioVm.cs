using System.ComponentModel.DataAnnotations;

namespace Poc.Application.ViewModel
{
    public class AddUsuarioVm
    {
        [Required(ErrorMessage = "Nome não pode ser vazio.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Cpf não pode ser vazio.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Data de nascimento não pode ser vazia.")]
        public string DataNascimento { get; set; }

        public string Cep { get; set; }
    }
}