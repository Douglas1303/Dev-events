using System.Data;

namespace dev_events_repository.Repository.Base;

public abstract class BaseRepository
{
    protected IDbConnection _dbConnection;

    protected BaseRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
}
