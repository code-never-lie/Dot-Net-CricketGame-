using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class PlayerScore
    {

        public PlayerScore() { }

        int _pScore;

        public int PScore
        {
            get { return _pScore; }
            set { _pScore = value; }
        }
        int _pBalls;

        public int PBalls
        {
            get { return _pBalls; }
            set { _pBalls = value; }
        }

      

    }
}
