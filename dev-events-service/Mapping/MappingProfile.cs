using AutoMapper;
using dev_events_domain.Models;
using dev_events_service.ExternalServices.Cep;
using Poc.Application.ViewModel;
using Poc.Domain.Dtos;

namespace dev_events_service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CepModel, CepViewModel>().ReverseMap();

            CreateMap<AddPatrocinadorVm, PatrocinadorModel>().ReverseMap();

            CreateMap<PatrocinadorDto, PatrocinadorModel>().ReverseMap();
        }
    }
}
