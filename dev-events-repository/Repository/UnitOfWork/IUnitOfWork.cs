using System.Data.Common;
using System.Transactions;

namespace dev_events_repository.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        DbConnection Connection { get; }
        TransactionScope Transaction { get; }
        void Begin();
        void Commit();
        void Rollback();
    }
}
