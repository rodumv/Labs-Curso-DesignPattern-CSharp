using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public interface ITeamPlayer : IPlayer
    {
        void AssignTeam(Team team);
        string GetTeam();
    }
}
