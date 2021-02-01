using System;
using System.Collections.Generic;
using System.Linq;

namespace project_euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var answer = ProblemOne();
            Console.WriteLine(answer.ToString());
            Console.WriteLine();
            Console.ReadLine();
        }

        public static int ProblemOne()
        {
            return Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
        }
        public static int ProblemTwo()
        {
            for (int i = 1; i < 4000000; i++)
            {
                for (int j = 2; j < 4000000; j += i)
                {
                    Console.WriteLine(i,j);
                }
            }
            
        }
    }
}
