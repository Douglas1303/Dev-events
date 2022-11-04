using AutoMapper;
using dev_events_service.ExternalServices.Cep;
using dev_events_service.ExternalServices.Cep.Service;
using dev_events_service.Interface;

namespace dev_events_service.Service
{
    public class CepService : ICepService
    {
        private readonly ICepExternalService _cepExternalService;
        private readonly IMapper _mapper;

        public CepService(ICepExternalService cepExternalService, IMapper mapper)
        {
            _cepExternalService = cepExternalService;
            _mapper = mapper;
        }

        public async Task<object> GetCepAsync(string cep)
        {
            try
            {
                var address = _mapper.Map<CepViewModel>(await _cepExternalService.GetAddressAsync(cep));

                if (!address.Cep.Any()) return "Endereço não encontrado";

                return address;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
