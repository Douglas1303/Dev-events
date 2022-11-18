using dev_events_domain.Interfaces;
using dev_events_domain.Models;

namespace dev_events_repository.Repository
{
    public class PatrocinadorRepository : IPatrocinadorRepository
    {
        public Task<int> AddAsync(PatrocinadorModel dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatrocinadorModel>> GetAll()
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

        public Task<PatrocinadorModel> SponsorExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
