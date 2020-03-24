using System;
using System.Collections.Generic;
using System.Text;

namespace PremierLeague.Core.DataTransferObjects
{
    public class TeamTableRowDto
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public int Matches { get; set; }
        public int Points => Won * 3 + Drawn;
        public int Won { get; set; }
        public int Drawn => Matches - Won - Lost;
        public int Lost { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference => GoalsFor - GoalsAgainst;
    }
}
