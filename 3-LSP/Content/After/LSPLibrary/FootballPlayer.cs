using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class FootballPlayer : Player, ITeamPlayer
    {
        private Team Team { get; set; }
        public void AssignTeam(Team team)
        {
            Team = team;
        }

        public string GetMarketValue(PlayerCategory category)
        {
            string marketValue = "";
            switch (category)
            {
                case PlayerCategory.Amateur:
                    marketValue = "100";
                    break;
                case PlayerCategory.Professional:
                    marketValue = "1000";
                    break;
            }
            return marketValue;
        }

        public string GetTeam()
        {
            return Team.Name;
        }
    }
}