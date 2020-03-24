using Microsoft.EntityFrameworkCore;
using PremierLeague.Core.Contracts;
using PremierLeague.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PremierLeague.Persistence
{
    public class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public GameRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddRange(IEnumerable<Game> games)
        {
            _dbContext.Games.AddRange(games);
        }

        public IEnumerable<Game> GetAllWithTeams()
        {
            return _dbContext.Games.Include(g => g.HomeTeam).Include(g => g.GuestTeam).ToList();
        }

        public void Add(Game game)
        {
            _dbContext.Games.Add(game);
        }
    }
}