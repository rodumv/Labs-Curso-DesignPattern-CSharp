using LSPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new TennisPlayer();
            player.FirstName = "Walter";
            player.LastName = "Olivares";
           // player.AssignTeam(new Team { Name = "Santos" });
            player.SetCategory(PlayerCategory.Amateur);

            Console.Write($"{player.FirstName} {player.LastName}  categoria  {player.Category}");
            Console.ReadLine();
        }
    }
}
