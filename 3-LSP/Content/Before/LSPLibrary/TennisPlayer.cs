using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class TennisPlayer : Player
    {
        public override void AssignTeam(Team team)
        {
            throw new NotImplementedException("Soy jugador de tenis y no necesito un equipo para jugar.");
        }
    }
}
