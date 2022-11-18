using Poc.Domain.Dtos;

namespace dev_events_domain.Interfaces;

public interface IPatrocinadorRepository
{
    Task<IEnumerable<PatrocinadorDto>> GetAll();

    Task<int> AddAsync(PatrocinadorDto dto);

    Task<string> RemoveAsync(int id);

    Task<PatrocinadorDto> SponsorExists(int id);

    bool NameSponsorExists(string name);
}
