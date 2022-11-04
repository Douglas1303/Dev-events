using Refit;

namespace dev_events_service.ExternalServices.Cep.Service
{
    public class CepExternalService : ICepExternalService
    {
        public async Task<CepModel> GetAddressAsync(string cep)
        {
            var cepClient = RestService.For<ICepExternalService>("http://viacep.com.br");

            var address = await cepClient.GetAddressAsync(cep);

            return address;
        }
    }
}
