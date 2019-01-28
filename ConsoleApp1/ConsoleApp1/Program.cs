using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                long Num1 = long.Parse(space[0]);
                if (Num1 > 0)
                {
                    Console.WriteLine("Case {0}: {1} is a valid result",t,Num1);
                }
                else
                {
                    Console.WriteLine("Case {0}: {1} is not a valid result", t, Num1);
                }
            }
        }
    }
}
