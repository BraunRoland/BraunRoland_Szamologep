using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraunRoland_Szamologep
{
    internal class Program
    {
        static void Osszeadas(int a, int b)
        {
            Console.WriteLine($"{a} +  {b} = {a+b}");
        }

        static void Kivonas(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a-b}");
        }

        static void Osztas(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {a/b}");
        }

        static void Szorzas(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a*b}");
        }

        static void Main(string[] args)
        {
        }
    }
}
