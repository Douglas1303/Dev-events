namespace Poc.Domain.Dtos
{
    public class ArquivoDto : DtoBase
    {
        public int TipoArquivoId { get; private set; }
        public string NomeDeOrigem { get; private set; }
        public string NomeParaSalvar { get; private set; }
        public bool Ativo { get; private set; }

        private ArquivoDto(){}

        public ArquivoDto(int tipoArquivoId, string nomeDeOrigem, string nomeParaSalvar)
        {
            TipoArquivoId = tipoArquivoId;
            NomeDeOrigem = nomeDeOrigem;
            NomeParaSalvar = nomeParaSalvar;
            Ativo = true;
        }


    }
}