using System;
using System.Threading;

namespace Lab2Sol
{
    class Program
    {
        /// <summary>
        /// simple test
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum is " + sum);
            Thread.Sleep(5000);
        }
    }
}
