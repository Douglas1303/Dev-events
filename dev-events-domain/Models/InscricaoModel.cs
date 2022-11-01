namespace dev_events_domain.Models
{
    public class InscricaoModel : BaseModel
    {
        public Guid UsuarioId { get; private set; }
        public UsuarioModel Usuario { get; private set; }
        public int EventoId { get; private set; }
        public EventoModel Evento { get; private set; }

        protected InscricaoModel() { }

        public InscricaoModel(Guid usuarioId, int eventoId)
        {
            UsuarioId = usuarioId;
            EventoId = eventoId;
            DataCadastro = DateTime.Now;
        }
    }
}
