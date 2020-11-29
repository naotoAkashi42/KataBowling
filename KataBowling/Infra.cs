using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataBowling
{
    class Infra
    {
        public int[] RecieveInput()
        {
            var input = (Console.ReadLine()).Split().Select(int.Parse).ToArray();

            return input;
        }

        public void ShowResult(List<int[]> inputList, List<int> dispList)
        {
            WriteFrame();
            WriteThrowRecord(inputList);
            ShowRecoed(dispList);
        }

        private void WriteFrame()
        {
            Console.Write("|");
            for(var i = 0; i < 9; i++)
            {
                var str = string.Concat("    ", i+1, "  ");
                Console.Write(str);
                Console.Write("|");
            }
            var t = string.Concat("    ", 10, "    ");
            Console.Write(t);
            Console.Write("|");
            Console.WriteLine();

            WriteSeparateLine();
        }

        private void WriteThrowRecord(List<int[]> list)
        {
            var temp = new StringBuilder(56);
            temp.Append("|");
            for (var i = 0; i < list.Count; i++)
            {
                if(i < 9)
                {
                    var disp = string.Format("{0, 2}   {1, 2}", list[i][0], list[i][1]);
                    temp.Append(disp + "|");
                }

                if(i == 9)
                {
                    var disp = string.Format("{0, 2}  {1, 2}  {2, 2}", list[i][0], list[i][1], list[i][2]);
                    temp.Append(disp + "|");
                }

            }
            Console.WriteLine(temp);

            WriteSeparateLine();
        }

        private void ShowRecoed(List<int> dispList)
        {
            Console.Write("|");
            for (var i = 0; i < 9; i++)
            {
                var str = string.Format("  {0,3}  ", dispList[i]);
                Console.Write(str);
                Console.Write("|");
            }
            var str2 = string.Concat("   ", dispList[9], "    ");
            Console.Write(str2);
            Console.Write("|");
        }

        private void WriteSeparateLine()
        {
            for (var j = 0; j < 84; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
