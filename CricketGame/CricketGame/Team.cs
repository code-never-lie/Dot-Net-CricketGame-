using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Team
    {
        private List<Team> TeamA;
        private List<Team> TeamB;



        public Team()        // Default Constructor to intialize Objects
        {

            TeamA = new List<Team>();
            TeamB = new List<Team>();

        }


        public List<Team> TeamA_prop
        {
            get { return TeamA; }
            set { TeamA = value; }
        }


        public List<Team> TeamB_prop
        {
            get { return TeamB; }
            set { TeamB = value; }
        }



        public void AddPlayers()
        {
            Player TeamA_P1 = new Player("Hafeez", "Batsman");
            Player TeamA_P2 = new Player("Fakher", "Batsman");
            Player TeamA_P3 = new Player("BabarA", "Batsman");
            Player TeamA_P4 = new Player("Hassan", "Bowler");
            Player TeamA_P5 = new Player("Shahen", "Bowler");


            TeamA_prop.Add(TeamA_P1);
            TeamA_prop.Add(TeamA_P2);
            TeamA_prop.Add(TeamA_P3);
            TeamA_prop.Add(TeamA_P4);
            TeamA_prop.Add(TeamA_P5);



            Player TeamB_P1 = new Player("Kohli", "Batsman");
            Player TeamB_P2 = new Player("Rohit", "Batsman");
            Player TeamB_P3 = new Player("Bumra", "Batsman");
            Player TeamB_P4 = new Player("Gemja", "Bowler");
            Player TeamB_P5 = new Player("panda", "Bowler");

            TeamB_prop.Add(TeamB_P1);
            TeamB_prop.Add(TeamB_P2);
            TeamB_prop.Add(TeamB_P3);
            TeamB_prop.Add(TeamB_P4);
            TeamB_prop.Add(TeamB_P5);
        }



    }
}
