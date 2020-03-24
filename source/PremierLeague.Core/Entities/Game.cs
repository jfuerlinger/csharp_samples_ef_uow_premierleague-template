using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremierLeague.Core.Entities
{
    public class Game : EntityObject
    {
        [Required]
        public int Round { get; set; }

        public int HomeTeamId { get; set; }
        [ForeignKey(nameof(HomeTeamId))]
        [InverseProperty("HomeGames")]
        public Team HomeTeam { get; set; }

        public int GuestTeamId { get; set; }
        [ForeignKey(nameof(GuestTeamId))]
        [InverseProperty("AwayGames")]
        public Team GuestTeam { get; set; }

        public int HomeGoals { get; set; }
        public int GuestGoals { get; set; }


    }
}

