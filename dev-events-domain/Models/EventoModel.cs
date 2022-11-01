namespace dev_events_domain.Models
{
    public class EventoModel : BaseModel
    {
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Ativo { get; private set; }
        public int? CategoriaId { get; private set; }
        public CategoriaModel Categoria { get; private set; }
        public IEnumerable<UsuarioModel> Usuarios { get; private set; }
        public IEnumerable<InscricaoModel> Inscricoes { get; private set; }

        public EventoModel(string titulo, string descricao, DateTime dataInicio, DateTime dataFim, int? categoriaId)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Ativo = true;
            CategoriaId = categoriaId;
        }

        public EventoModel(int id, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, int? categoriaId)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            CategoriaId = categoriaId;
        }

        //ctor protected para EF
        protected EventoModel() { }


        public bool DisableStatus()
        {
            Ativo = false;

            return Ativo;
        }
    }
}
