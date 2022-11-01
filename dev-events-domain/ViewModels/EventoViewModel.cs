using System;

namespace Poc.Application.ViewModel
{
    public class EventoViewModel
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }
        public int? CategoriaId { get; set; }
    }
}