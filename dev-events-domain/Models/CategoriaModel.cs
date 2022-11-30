namespace dev_events_domain.Models
{
    public class CategoriaModel : BaseModel
    {
        public string Descricao { get; private set; }

        private CategoriaModel() { }

        public CategoriaModel(string descricao)
        {
            Descricao = descricao;
        }


    }
}
