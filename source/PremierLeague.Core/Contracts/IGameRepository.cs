using System.Collections.Generic;
using PremierLeague.Core.Entities;

namespace PremierLeague.Core.Contracts
{
    public interface IGameRepository
    {
        void AddRange(IEnumerable<Game> games);
        IEnumerable<Game> GetAllWithTeams();
        void Add(Game game);
    }
}