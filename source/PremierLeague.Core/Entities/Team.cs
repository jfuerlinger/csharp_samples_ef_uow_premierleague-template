using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremierLeague.Core.Entities
{
    public class Team : EntityObject
    {
        [Required]
        public string Name { get; set; }

        [InverseProperty("HomeTeam")]
        public ICollection<Game> HomeGames { get; set; }

        [InverseProperty("GuestTeam")]
        public ICollection<Game> AwayGames { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
