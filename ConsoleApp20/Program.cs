using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int, double> average = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3.0;
            };

            int num1 = 10, num2 = 20, num3 = 30;
            double result = average(num1, num2, num3);

            Console.WriteLine($"Середнє арифметичне {num1}, {num2}, {num3} = {result}");

            Console.ReadLine();
        }
    }
}
