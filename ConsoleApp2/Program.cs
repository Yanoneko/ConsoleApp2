using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = getFigure();
            Console.WriteLine(x);
            Console.WriteLine("работу выполнила Петрова");
            Console.ReadKey();
        }
        static string getFigure() //доп. метод
        {
            double a, b, c, sqrt;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            sqrt = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            if (sqrt < 0)
            {
                return "корней нет"; //возвращение значения и выход из метода
            }
            else if (sqrt == 0)
            {
                return "1 корень"; //возвращение значения и выход из метода
            }
            else
            {
                return "2 корня"; //возвращение значения и выход из метода
            }
        }
    }
}
