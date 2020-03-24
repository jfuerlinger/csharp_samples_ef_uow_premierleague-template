namespace PremierLeague.Core.DataTransferObjects
{
    /// <summary>
    /// Fast div. statistische Informationen eines Teams zusammen.
    /// </summary>
    public class TeamStatisticDto
    {
        /// <summary>
        /// Name des Teams
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Durchschnittliche Anzahl der geschossenen Heimtore pro Spiel
        /// </summary>
        public double AvgGoalsShotAtHome { get; set; }

        /// <summary>
        /// Durchschnittliche Anzahl der geschossenen Auswärtstore pro Spiel
        /// </summary>
        public double AvgGoalsShotOutwards { get; set; }

        /// <summary>
        /// Durchschnittliche Anzahl der geschossenen Tore pro Spiel
        /// </summary>
        public double AvgGoalsShotInTotal { get; set; }


        /// <summary>
        /// Durchschnittliche Anzahl der erhaltenen Heimtore pro Spiel
        /// </summary>
        public double AvgGoalsGotAtHome { get; set; }

        /// <summary>
        /// Durchschnittliche Anzahl der erhaltenen Auswärtstore pro Spiel
        /// </summary>
        public double AvgGoalsGotOutwards { get; set; }

        /// <summary>
        /// Durchschnittliche Anzahl der erhaltenen Tore pro Spiel
        /// </summary>
        public double AvgGoalsGotInTotal { get; set; }
    }
}
