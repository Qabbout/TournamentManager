using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager
{
    class Matches
    {
        Team t1;
        Team t2;
        
        public Matches(Team t1 , Team t2)
        {
            this.t1 = t1;
            this.t2 = t2;
        }
        public DateTime Date { get; set; }
        public string Loser { get; set; }
        
       
        public override string ToString()
        {
            return t1.Name + " VS " + t2.Name;
        }
    }
    
    }

