using System;

namespace inClassStringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "8 - 2";

            string[] math = str.Split(' ');

            var final = 0;

            for(int i = 0; i < 3; i++)
            {
                if(math[i] == "+")
                {
                    final = Convert.ToInt32(math[0]) + Convert.ToInt32(math[2]);
                }
                else if (math[i] == "-")
                {
                    final = Convert.ToInt32(math[0]) - Convert.ToInt32(math[2]);
                }
                else if (math[i] == "/")
                {
                    final = Convert.ToInt32(math[0]) / Convert.ToInt32(math[2]);
                }
                else if (math[i] == "*")
                {
                    final = Convert.ToInt32(math[0]) * Convert.ToInt32(math[2]);
                }
            }
            Console.WriteLine(final);
        }
    }
}
