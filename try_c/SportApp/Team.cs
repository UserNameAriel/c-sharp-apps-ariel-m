using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.SportApp
{
    internal class Team
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

        public Team(string name, string city, string liga, int total_game, int played_game, int win, int lose, bool teiko, int point, int goalsFor, int goalsaGainst, int goalsDiferrencial)
        {
            this.Name = name;
            this.city = city;
            this.CurrentLiga = liga;
            this.sumGamse = total_game;
            this.PlayedGame = played_game;
            this.wins = win;
            this.looses = lose;
            this.teko = teiko;
            this.points = point;
            this.goalsfor = goalsFor;
            this.goalAgainst = goalsaGainst;
            this.goalDifferential = goalsDiferrencial;
        }

    }
}