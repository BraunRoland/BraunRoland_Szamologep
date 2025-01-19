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
                    Szazalek(a, b);
                    break;
            }
        }

        static void MasodFoku(double a, double b, double c)
        {
            double gyok = Math.Pow(b,2)-(4*a*c);
            double osztasAlja = 2 * a;
            if (gyok <= 0)
            {
               Console.WriteLine("Az egyenlet nem megoldható mivel a gyök alatt 0 vagy kisebb a szám.");
            }
            else
            {
                double x1 = ((-b) + (Math.Sqrt(gyok))) / osztasAlja;
                double x2 = ((-b) - (Math.Sqrt(gyok))) / osztasAlja;
                Console.WriteLine($"Első megoldás: {x1} |   Második megoldás: {x2}");
            }
        }

        static void Indít()
        {
            Console.WriteLine("Másodfokú egyenletet szeretnél megoldani? (I/N): ");
            string valasz = Console.ReadLine();
            if (valasz.ToUpper() == "I")
            {
                Console.WriteLine("Add meg az 'a' értékét: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Add meg a 'b' értékét: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Add meg a 'c' értékét: ");
                double c = double.Parse(Console.ReadLine());
                MasodFoku(a, b, c);
            }
            else
            {
                Console.WriteLine("Add meg az első számot: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Add meg a második számot: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("A művelet jele: ");
                string operátor = Console.ReadLine();
                Kivalasztas(operátor, a, b);
            }
        }

        static void Main(string[] args)
        {
            Indít();
        }
    }
}
