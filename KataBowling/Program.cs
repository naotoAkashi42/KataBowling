using System;
using System.Collections.Generic;

namespace KataBowling
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var infra = new Infra();

            var inputList = new List<int[]>();
            for(var roundNum = 0; roundNum < 10; roundNum++)
            {
                var hitCounts = infra.RecieveInput();
                inputList.Add(hitCounts);

                var round = new Round(roundNum, hitCounts);

                game.AddRound(round);
            }

            game.GetTotalScore();
            var dispScore = game.GetDispScore();

            infra.ShowResult(inputList, dispScore);
            
            Console.ReadKey();
        }
    }
}
