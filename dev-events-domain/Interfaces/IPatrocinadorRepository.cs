using dev_events_domain.Models;

namespace dev_events_domain.Interfaces;

public interface IPatrocinadorRepository
{
    Task<IEnumerable<PatrocinadorModel>> GetAll();

    Task<int> AddAsync(PatrocinadorModel patrocinador);

    Task<string> RemoveAsync(int id);

    Task<PatrocinadorModel> SponsorExists(int id);

    bool NameSponsorExists(string nome);
}
