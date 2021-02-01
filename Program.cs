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
            Console.WriteLine(ProblemTwo().ToString());
            Console.ReadLine();
        }

        public static int ProblemOne()
        {
            return Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
        }
        public static int ProblemTwo()
        {
            int total = 0;

            int fibonacciFirst = 1, fibonacciSecond = 1;

            while (fibonacciFirst <= 4000000)
            {
                if (fibonacciFirst % 2 ==0)
                {
                    total += fibonacciFirst;
                }
                int fibonacci_2_next = fibonacciFirst;
                fibonacciFirst = fibonacciSecond + fibonacciFirst;
                fibonacciSecond = fibonacci_2_next;
            }
            return total;


        }
    }
}
