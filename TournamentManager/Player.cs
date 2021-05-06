using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager
{
    class Player
    {
        
        public string Name { get; set; }
        public int Number { get; set; }
        public string Role { get; set; }
        public int PlayerGoals { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
