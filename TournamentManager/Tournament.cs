using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TournamentManager
{
    class Tournament
    {
    
        public string Name { get; set; }
        public List<Team> Teams { get; set; }
        public List<Matches> Matches { get; set; }
      
        public int NbOfTeams { get; set; }

        public override string ToString()
        {
            return Name + "/" + NbOfTeams;
        }
    }
}
