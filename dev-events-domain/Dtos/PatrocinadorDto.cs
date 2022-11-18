namespace Poc.Domain.Dtos;

public class PatrocinadorDto : DtoBase
{
    public string NomePatrocinador { get; set; }
    public string Documento { get; set; }
    public string Telefone { get; set; }
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Localidade { get; set; }
    public string UF { get; set; }
    public int DDD { get; set; }
}