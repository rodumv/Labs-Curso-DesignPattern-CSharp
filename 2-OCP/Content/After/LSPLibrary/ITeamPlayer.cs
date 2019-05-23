using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public interface ITeamPlayer: IPlayer
    {
        string GetTeam();
        void AssignTeam(Team team);
    }
}
