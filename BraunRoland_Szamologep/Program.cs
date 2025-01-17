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

        static void Szazalek(int a, int b)
        {
            Console.WriteLine($"{a} % {b} = {a%b}");
        }

        static void Kivalasztas(string operátor, int a, int b)
        {
            switch(operátor)
            {
                case "+":
                    Osszeadas(a, b);
                    break;
                case "-":
                    Kivonas(a, b);
                    break;
                case "/":
                    Osztas(a, b);
                    break;
                case "*":
                    Szorzas(a, b);
                    break;
                case "%":
                    Szazalek(a,b);
                    break;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
