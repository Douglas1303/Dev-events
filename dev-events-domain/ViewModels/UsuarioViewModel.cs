using System;

namespace Poc.Application.ViewModel
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}