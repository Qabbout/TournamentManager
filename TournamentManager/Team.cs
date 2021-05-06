using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager
{
    class Team
    {
        public string Name { get; set; }
        public string currentState { get; set; }
        public List<Player> Players { get; set; }

       public int PoleResult { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
