using dev_events_repository.Repository.UnitOfWork;

namespace dev_events_repository.Repository.Base;

public abstract class BaseRepository
{
    protected readonly IUnitOfWork _unitOfWork;

    public BaseRepository(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
}
