using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class FootballPlayer : Player, ITeamPlayer
    {
        public void AssignTeam(Team team)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}