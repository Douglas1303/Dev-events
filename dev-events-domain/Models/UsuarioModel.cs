namespace dev_events_domain.Models
{
    public class UsuarioModel : BaseModel
    {
        public Guid UsuarioId { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Email { get; private set; }
        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public IEnumerable<EventoModel> Eventos { get; private set; }
        public IEnumerable<InscricaoModel> Inscricoes { get; private set; }

        //ctor protected para EF
        protected UsuarioModel() { }

        public UsuarioModel(Guid usuarioId, string nomeCompleto, string cpf, DateTime dataNascimento, string email)
        {
            UsuarioId = usuarioId;
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Email = email;
            Ativo = true;
            DataCadastro = DateTime.Now;
        }


    }
}
