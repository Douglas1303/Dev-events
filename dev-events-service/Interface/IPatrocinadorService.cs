using dev_events_service.Core;
using Poc.Application.ViewModel;

namespace dev_events_service.Interface
{
    public interface IPatrocinadorService
    {
        Task<IResult> GetAllAsync();
        Task<IResult> AddAsync(AddPatrocinadorViewModel viewModel);
        Task<IResult> RemoveAsync(int id);
    }
}
