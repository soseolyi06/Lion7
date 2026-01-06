using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;

            Console.WriteLine("합계 : " + (a + b));
            a = 5;
            Console.WriteLine("합계2 : " + a);

            a = 5;
            a = 4 - 5;
            Console.WriteLine("합계3 : " + a);

            Console.WriteLine("합계4 : " + a);

            a = 5;
            Console.WriteLine("합계5 : " + (a / b));


        }
    }
}
