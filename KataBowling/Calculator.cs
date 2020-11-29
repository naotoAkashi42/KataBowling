using System;
using System.Collections.Generic;
using System.Text;

namespace KataBowling
{
    class Calculator
    {
        private readonly int strikeBonus = 10;
        private readonly int doubleBonus = 20;
        private readonly int spareBonus = 10;

        public int CalcScore1To8Round(Round currentRound ,
            Round nextRound ,Round nextNextRound )
        {
            if(Rule.IsDouble(currentRound, nextRound))
            {
                return doubleBonus + nextNextRound.FirstThrowCount + nextNextRound.SecondThrowCount;
            }

            if (currentRound.IsStrike)
            {
                return strikeBonus + nextRound.FirstThrowCount + nextRound.SecondThrowCount;
            }

            if (currentRound.IsSpare)
            {
                return spareBonus + nextRound.FirstThrowCount;
            }

            return currentRound.FirstThrowCount + currentRound.SecondThrowCount;
        }
        
        public int CalcScore9Round(Round round9,  Round finalRound)
        {
            if (round9.IsStrike)
            {
                return strikeBonus + finalRound.FirstThrowCount + finalRound.SecondThrowCount;
            }

            if (round9.IsSpare)
            {
                return spareBonus + finalRound.FirstThrowCount;
            }

            return round9.FirstThrowCount + round9.SecondThrowCount;
        }

        public int CalcScoreFinalRound(Round finalRound)
        {
            return finalRound.TotalHitCount();
        }


    }
}
