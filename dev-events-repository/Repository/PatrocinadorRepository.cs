using dev_events_domain.Interfaces;
using Poc.Domain.Dtos;

namespace dev_events_repository.Repository
{
    public class PatrocinadorRepository : IPatrocinadorRepository
    {
        public Task<int> AddAsync(PatrocinadorDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatrocinadorDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool NameSponsorExists(string name)
        {
            throw new NotImplementedException();
        }

        public Task<string> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PatrocinadorDto> SponsorExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
