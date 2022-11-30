using Refit;

namespace dev_events_service.ExternalServices.Cep.Service
{
    public interface ICepExternalService
    {
        [Get("/ws/{cep}/json")]
        Task<CepModel> GetAddressAsync(string cep);
    }
}
