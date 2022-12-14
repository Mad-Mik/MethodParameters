using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 5;
            int d = 6;
            Console.WriteLine($"Initial Value z = {z}");
            AdditionVal(z, d);
            Console.WriteLine($"After AdditionVal z = {z}");
            AdditionRef(ref z, d);
            Console.WriteLine($"After AdditionRef z = {z}");

            Console.ReadLine();
        }
        static void AdditionRef(ref int x, int y)
        {
            x = x + y;
            Console.WriteLine($"AdditionalRef x = {x}");
        }
        static void AdditionVal(int x, int y)
        {
            x = x + y;
            Console.WriteLine($"AdditionalVal x = {x}");
        }

        static int Sum(int x, int y)
        {
            return (x + y);
        }
    }
}
