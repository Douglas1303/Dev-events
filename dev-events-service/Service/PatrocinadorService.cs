using AutoMapper;
using dev_events_domain.Interfaces;
using dev_events_domain.Models;
using dev_events_service.Interface;
using Poc.Application.ViewModel;
using Poc.Domain.Dtos;
using Microsoft.AspNetCore.Http;
using dev_events_service.Core;

namespace dev_events_service.Service;

public class PatrocinadorService : IPatrocinadorService
{
    private readonly IPatrocinadorRepository _patrocinadorRepository;
    private readonly IMapper _mapper;

    public PatrocinadorService(IPatrocinadorRepository patrocinadorRepository, IMapper mapper)
    {
        _patrocinadorRepository = patrocinadorRepository;
        _mapper = mapper;
    }

    public async Task<IResult> AddAsync(AddPatrocinadorVm viewModel)
    {
        var patrocinador = _mapper.Map<PatrocinadorModel>(viewModel);

        return new QueryResult(await _patrocinadorRepository.AddAsync(patrocinador));
    }

    public async Task<IResult> GetAllAsync()
    {
        var resultado = await _patrocinadorRepository.GetAll();
        var patrocinadores = _mapper.Map<List<PatrocinadorDto>>(resultado);

        return new QueryResult(patrocinadores);
    }

    public async Task<IResult> RemoveAsync(int id)
    {
        return new QueryResult(await _patrocinadorRepository.RemoveAsync(id));
    }
}
