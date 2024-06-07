using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_App_ArielM.SportApp
{
    public class Season
    {
        private int year;
        private string type;
        private string Leaguename;
        private string RoundAmount;
        Round nextRound;
        Team[] team;
        private int numOfGrups;
        private bool IsActive;

        public Season(int year, string SportType, string league, Team[] teams)
        {
            this.year = year;
            this.type = SportType;
            this.Leaguename = league;
            this.team = teams;
        }
        public void DisplayTable()
        {

            for (int i = 0; i < team.Length; i++)
            {
                Console.WriteLine($"{i} - {team[i].GetName()} - {team[i].GetPoints()}");
            }


        }
    }
}
