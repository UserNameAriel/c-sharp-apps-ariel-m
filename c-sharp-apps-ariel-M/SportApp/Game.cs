using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.SportApp
{
    public class Game
    {
        private Team groupA;
        private Team groupB;
        private int groupANumGoals;
        private int groupBNumGoals;
        private int currentMinute;
        private bool isActiveGame;

        public Game(Team groupA , Team groupB, int groupANumGoals, int groupBNumGoals, int currentMinute, bool isActiveGame)
        {
            this.groupA = groupA;
            this.groupB = groupB;
            this.groupANumGoals = groupANumGoals;
            this.groupBNumGoals = groupBNumGoals;
            this.currentMinute = currentMinute;
            this.isActiveGame = isActiveGame;
        }
    }
    
}
