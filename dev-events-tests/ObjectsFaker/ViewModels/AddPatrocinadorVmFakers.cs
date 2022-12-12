using Poc.Application.ViewModel;
using Bogus;
using Bogus.Extensions.Brazil;
using Poc.Domain.Enum;

namespace dev_events_tests.ObjectsFaker.ViewModels;

public static class AddPatrocinadorVmFakers
{
    public static AddPatrocinadorVm GerarAddPatrocinadorVmFaker()
    {
        return new Faker<AddPatrocinadorVm>("pt_BR")
            .RuleFor(x => x.NomePatrocinador, f => f.Person.FullName)
            .RuleFor(x => x.Documento, f => f.Person.Cpf().Replace("-", "").Replace(".", ""))
            .RuleFor(x => x.Documento, f => f.Person.Phone)
            .RuleFor(x => x.Cep, f => f.Address.ZipCode())
            .RuleFor(x => x.Logradouro, f => f.Address.StreetName())
            .RuleFor(x => x.Complemento, f => f.Address.StreetSuffix())
            .RuleFor(x => x.Bairro, f => f.Lorem.Sentence(2))
            .RuleFor(x => x.Localidade, f => f.Address.City())
            .RuleFor(x => x.UF, f => f.PickRandom<Eestados>().ToString())
            .RuleFor(x => x.DDD, f => f.Random.Number(10, 60))
            .Generate();
    }
}
