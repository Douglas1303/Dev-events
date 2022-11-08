using dev_events_service.Core;
using dev_events_service.Interface;
using Poc.Application.ViewModel;

namespace dev_events_service.Service;

public class PatrocinadorService : IPatrocinadorService
{
    public Task<IResult> AddAsync(AddPatrocinadorVM viewModel)
    {
        throw new NotImplementedException();
    }

    public Task<IResult> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IResult> RemoveAsync(int id)
    {
        throw new NotImplementedException();
    }
}
