using Dapper;
using dev_events_domain.Interfaces;
using dev_events_domain.Models;
using dev_events_repository.Repository.Base;
using dev_events_repository.Repository.UnitOfWork;
using System.Data;

namespace dev_events_repository.Repository
{
    public class PatrocinadorRepository : BaseRepository, IPatrocinadorRepository
    {
        public PatrocinadorRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<int> AddAsync(PatrocinadorModel patrocinador)
        {
            return (int)await _unitOfWork.Connection.ExecuteScalarAsync($"pRocedure", patrocinador, commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<PatrocinadorModel>> GetAll()
        {
            return (await _unitOfWork.Connection.QueryAsync<PatrocinadorModel>($"PRocedure", commandType: CommandType.StoredProcedure)).ToList();
        }

        public bool NameSponsorExists(string nome)
        {
            var resultado = (int)_unitOfWork.Connection.ExecuteScalar($"procedure", new { nome }, commandType: CommandType.StoredProcedure);


            return resultado > 0;
        }

        public async Task<int> RemoveAsync(int id)
        {
            return (int)await _unitOfWork.Connection.ExecuteScalarAsync($"Procedure", new { id }, commandType: CommandType.StoredProcedure);
        }

        public async Task<PatrocinadorModel> SponsorExists(int id)
        {
            return await _unitOfWork.Connection.ExecuteScalarAsync<PatrocinadorModel>($"procedure", new { id }, commandType: CommandType.StoredProcedure);
        }
    }
}
