using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
   public class ScoreCard
    {
       public ScoreCard(){}

       int _Team_Cscore;

       public int Team_Cscore
       {
           get { return _Team_Cscore; }
           set { _Team_Cscore = value; }
       }
       int _Team_Outs;

       public int Team_Outs
       {
           get { return _Team_Outs; }
           set { _Team_Outs = value; }
       }
       int _TeamA_totalScore;

       public int TeamA_totalScore
       {
           get { return _TeamA_totalScore; }
           set { _TeamA_totalScore = value; }
       }
       int _TeamB_totalScore;

       public int TeamB_totalScore
       {
           get { return _TeamB_totalScore; }
           set { _TeamB_totalScore = value; }
       }
       int _RemainingScore;

       public int RemainingScore
       {
           get { return _RemainingScore; }
           set { _RemainingScore = value; }
       }




    }
}
