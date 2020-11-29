using System;
using System.Collections.Generic;
using System.Linq;

namespace KataBowling
{
    class Game
    {
        private List<Round> _rounds;
        private List<int> _AddedScore;
        private List<int> _dispScore;

        public Game()
        {
            Initialize();
        }

        private void Initialize()
        {
            _rounds = new List<Round>();
        }

        public void AddRound(Round round)
        {
            _rounds.Add(round);
        }

        public int GetTotalScore()
        {
            var calculator = new Calculator();
            _AddedScore = new List<int>();
            foreach(var r in _rounds)
            {
                
                if (r.Is1To8Round)
                {
                    var nextRound = _rounds[r.Num + 1];
                    var nextNextRound = _rounds[nextRound.Num + 1];
                    _AddedScore.Add(calculator.CalcScore1To8Round(r, nextRound, nextNextRound));
                }

                if (r.Is9Round)
                {
                    var nextRound = _rounds[r.Num + 1];
                    _AddedScore.Add(calculator.CalcScore9Round(r, nextRound));
                }

                if (r.IsFinalRound)
                {
                    _AddedScore.Add(calculator.CalcScoreFinalRound(r));
                }
            }
            return _AddedScore.Sum();
        }

        public List<int> GetDispScore()
        {
            _dispScore = new List<int>();
            for(var i = 0; i < _rounds.Count; i++)
            {
                _dispScore.Add(_AddedScore.GetRange(0, i + 1).Sum());
            }
            return _dispScore;
        }
    }
}

