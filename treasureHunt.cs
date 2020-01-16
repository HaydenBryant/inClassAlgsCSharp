using System;
using System.Collections.Generic;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new int[2] { 23, 10 };
            var traps = new int[1];

            List<string> instructions = new List<string>() { "N3", "E2", "S5", "W10" };

            foreach (var step in instructions)
            {
                step.Split("");

                if(step[0] == 'N')
                {
                    start[1] = start[1] + Convert.ToInt32(step[1]);
                }
                else if(step[0] == 'S')
                {
                    start[1] = start[1] - Convert.ToInt32(step[1]);
                }
                else if(step[0] == 'E')
                {
                    start[0] = start[0] + Convert.ToInt32(step[1]);
                }
                else if(step[0] == 'W')
                {
                    start[0] = start[0] - Convert.ToInt32(step[1]);
                }
            }

            foreach (var coordinate in start)
                Console.WriteLine(coordinate);
        }
    }
}
