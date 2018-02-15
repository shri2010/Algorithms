using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FibonacciUsingDP
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(number));

        }

        private static UInt64 Fibonacci(int number)
        {
            UInt64[] fibData = new UInt64[number];
            fibData[0] = 0;
            fibData[1] = 1;
            for (int i = 2; i < number; i++)
            {
                fibData[i] = fibData[i - 1] + fibData[i - 2];
            }
            return fibData[number-1];
        }
    }
}
