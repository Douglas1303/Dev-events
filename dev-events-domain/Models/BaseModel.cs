namespace dev_events_domain.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; } = null;
    }
}
