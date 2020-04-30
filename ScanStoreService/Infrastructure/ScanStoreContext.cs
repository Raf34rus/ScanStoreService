using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using ScanStoreService.Domain;

namespace ScanStoreService.Domain
{
    /// <summary>
    /// Увеличивает время ожидания команд во время миграции изменений в БД. На большой БД требуется увеличить TimeOut. Класс не нужно вызвать, достаточно наследования от IDesignTimeDbContextFactory
    /// https://stackoverflow.com/questions/39006847/how-to-set-entity-framework-core-migration-timeout
    /// </summary>
    public class ScanStoreContextFactory : IDesignTimeDbContextFactory<ScanStoreContext>
    {
        public ScanStoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ScanStoreContext>();
            optionsBuilder.UseSqlServer(@"Server=Priserv8074;Database=ScanStoreRaf;Trusted_Connection=True;", opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));

            return new ScanStoreContext(optionsBuilder.Options);
        }
    }
    /// <summary>
    /// Расширение ScanStoreContext 
    /// </summary>
    public partial class ScanStoreContext : DbContext
    {
        private IDbContextTransaction _currentTransaction;

        #region Transaction
        public void BeginTransaction()
        {
            if (_currentTransaction != null)
            {
                return;
            }

            if (!Database.IsInMemory())
            {
                _currentTransaction = Database.BeginTransaction(IsolationLevel.ReadCommitted);
            }
        }
        public void CommitTransaction()
        {
            try
            {
                _currentTransaction?.Commit();
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                _currentTransaction?.Rollback();
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }
        #endregion
   
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
