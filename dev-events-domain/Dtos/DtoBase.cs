using System;

namespace Poc.Domain.Dtos
{
    public abstract class DtoBase
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }

        public DtoBase()
        {
            DataCadastro = DateTime.Now;
        }
    }
}