using System;
using System.Globalization;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, NUMBER, SALARY;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            NUMBER = a;
            SALARY = b * c;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2"));



            //Console.ReadLine();
        }
    }
}
