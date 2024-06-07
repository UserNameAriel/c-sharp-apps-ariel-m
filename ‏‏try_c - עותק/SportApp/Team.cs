using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.SportApp
{
    public class Team
    {
        public string Name { get; set; }
        public string city { get; set; }
        public string CurrentLiga { get; set; }
        public int sumGamse { get; set; }
        public int PlayedGame { get; set; }
        public int wins { get; set; }
        public int looses { get; set; }
        public bool teko { get; set; }
        public int points { get; set; }
        public int goalsfor { get; set; }
        public int goalAgainst { get; set; }
        public int goalDifferential { get; set; }

        public Team(string name, string city)
        {
            this.Name = name;
            this.city = city;
           
          
        }
        public string GetName()
        {
            return this.Name;
        }
        public string GetCity()
        {
            return this.city;
        }
        public int GetPoints()
        {
            return this.points;
        }
    }
}