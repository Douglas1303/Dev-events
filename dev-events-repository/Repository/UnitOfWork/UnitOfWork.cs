using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace dev_events_repository.Repository.UnitOfWork
{
    [ExcludeFromCodeCoverage]
    public sealed class UnitOfWork : IUnitOfWork
    {
        private TransactionScope _transaction;
        private readonly DbConnection _connection;

        public UnitOfWork(DbConnection dbConnection)
        {
            _connection = dbConnection;
        }

        public DbConnection Connection => _connection;
        public TransactionScope Transaction => _transaction;

        public void Begin()
        {
            _transaction = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
            {
                Timeout = TimeSpan.FromMinutes(1)
            }, TransactionScopeAsyncFlowOption.Enabled);
        }

        public void Commit()
        {
            _transaction.Complete();
            Dispose();
        }

        public void Dispose()
        {
            if (_transaction != null)
                _transaction.Dispose();

            _transaction = null;
        }

        public void Rollback()
        {
            Dispose();
        }
    }
}
