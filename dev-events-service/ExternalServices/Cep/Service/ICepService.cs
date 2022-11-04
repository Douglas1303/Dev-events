using Refit;

namespace dev_events_service.ExternalServices.Cep.Service
{
    public interface ICepService
    {
        [Get("/ws/{cep}/json")]
        Task<CepModel> GetAddressAsync(string cep);
    }
}
