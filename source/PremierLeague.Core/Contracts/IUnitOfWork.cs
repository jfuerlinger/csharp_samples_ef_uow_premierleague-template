using System;

namespace PremierLeague.Core.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IGameRepository Games { get; }
        ITeamRepository Teams { get; }

        void SaveChanges();

        void DeleteDatabase();
        void MigrateDatabase();
    }
}
