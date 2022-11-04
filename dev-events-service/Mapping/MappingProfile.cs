using AutoMapper;
using dev_events_service.ExternalServices.Cep;

namespace dev_events_service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CepModel, CepViewModel>().ReverseMap();
        }
    }
}
