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
            Console.WriteLine(ProblemThree().ToString());
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

        public static int ProblemThree()
        {
            long num = 600851475143;
            int count = 3;
            
            while (num > 1)
            {
                if (num % count == 0)
                {
                    num /= count;
                }
                else
                {
                    count += 2;
                }
            }
           
            return count;
        }
        public static int ProblemFour()
        {
            int x, y;
            string product = "", res = "";

            for (x = 100; x <= 999; x++)//lowest to highest 3 digit numbers
            {
                for (y = 100; y <= 999; y++)
                {
                    product = Convert.ToString(x * y);

                    if (product == new String(product.Reverse().ToArray()))
                    {
                        Console.WriteLine("X=" + x + " Y=" + y);
                        res = product;

                        Console.WriteLine("Polindrome is: " + res);
                    }

                    else { continue; }
                }
            }

            return 1;
        }
    }
}
