using dev_events_domain.Models;
using Bogus;
using Bogus.Extensions.Brazil;
using Poc.Domain.Enum;

namespace dev_events_tests.ObjectsFaker.Models;

public static class PatrocinadorModelFakers
{
    public static List<PatrocinadorModel> GerarListaPatrocinadorModelFaker(int quant)
    {
        return new Faker<PatrocinadorModel>("pt_BR")
            .CustomInstantiator(f => new PatrocinadorModel(
                    f.Person.FullName,
                    f.Person.Cpf().Replace("-", "").Replace(".", ""),
                    f.Person.Phone,
                    f.Address.ZipCode(),
                    f.Address.StreetName(),
                    f.Address.StreetSuffix(),
                    f.Lorem.Sentence(2),
                    f.Address.City(),
                    f.PickRandom<Eestados>().ToString(),
                    f.Random.Number(10, 60)
                    )).Generate(quant);
    }

    public static PatrocinadorModel GerarPatrocinadorModelFaker()
    {
        return new Faker<PatrocinadorModel>("pt_BR")
            .CustomInstantiator(f => new PatrocinadorModel(
                    f.Person.FullName,
                    f.Person.Cpf().Replace("-", "").Replace(".", ""),
                    f.Person.Phone,
                    f.Address.ZipCode(),
                    f.Address.StreetName(),
                    f.Address.StreetSuffix(),
                    f.Lorem.Sentence(2),
                    f.Address.City(),
                    f.PickRandom<Eestados>().ToString(),
                    f.Random.Number(10, 60)
                    )).Generate();
    }
}
