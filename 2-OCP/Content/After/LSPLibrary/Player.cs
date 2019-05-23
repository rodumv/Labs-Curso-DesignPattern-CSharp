using System;

namespace LSPLibrary
{
    public class Player : IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private Team Team { get; set; }
        public PlayerCategory Category { get; set; }
      
        public virtual void SetCategory(PlayerCategory category)
        {
            Category = category;
        }


    }

    public class Team
    {
        public string Name { get; set; }
    }
}
