namespace dev_events_domain.Models;

public sealed class PatrocinadorModel : BaseModel
{
    public string NomePatrocinador { get; private set; }
    public string Documento { get; private set; }
    public string Telefone { get; private set; }
    public string Cep { get; private set; }
    public string Logradouro { get; private set; }
    public string Complemento { get; private set; }
    public string Bairro { get; private set; }
    public string Localidade { get; private set; }
    public string UF { get; private set; }
    public int DDD { get; private set; }

    private PatrocinadorModel() { }

    public PatrocinadorModel(string nomePatrocinador, string document, string telefone, string cep, string logradouro, string complemento, string bairro, string localidade, string uf, int ddd)
    {
        NomePatrocinador = nomePatrocinador;
        Documento = document;
        Telefone = telefone;
        Cep = cep;
        Logradouro = logradouro;
        Complemento = complemento;
        Bairro = bairro;
        Localidade = localidade;
        UF = uf;
        DDD = ddd;
    }

    public PatrocinadorModel(int id, string nomePatrocinador, string document, string telefone, string cep, string logradouro, string complemento, string bairro, string localidade, string uf, int ddd)
    {
        Id = id;
        NomePatrocinador = nomePatrocinador;
        Documento = document;
        Telefone = telefone;
        Cep = cep;
        Logradouro = logradouro;
        Complemento = complemento;
        Bairro = bairro;
        Localidade = localidade;
        UF = uf;
        DDD = ddd;
    }

    public string ChangeComplement(string complemento)
    {
        Complemento = complemento;

        return Complemento;
    }
}
