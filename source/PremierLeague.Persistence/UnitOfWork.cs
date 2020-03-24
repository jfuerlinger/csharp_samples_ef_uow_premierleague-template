using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PremierLeague.Core.Contracts;
using Serilog;
using Utils;

namespace PremierLeague.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _dbContext;

        /// <summary>
        /// ConnectionString kommt aus den appsettings.json
        /// </summary>
        public UnitOfWork()
        {
            _dbContext = new ApplicationDbContext();
            Teams = new TeamRepository(_dbContext);
            Games = new GameRepository(_dbContext);

            MyLogger.InitializeLogger();

            var serviceProvider = _dbContext.GetInfrastructure();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddSerilog();
        }

        public ITeamRepository Teams { get; }
        public IGameRepository Games { get; }


        public void DeleteDatabase()
        {
            _dbContext.Database.EnsureDeleted();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void MigrateDatabase()
        {
            _dbContext.Database.Migrate();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

    }
}
