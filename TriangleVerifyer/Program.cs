using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TriangleVerifyer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cycle = true;
            while (cycle)
            {
                Console.WriteLine("Ingrese un lado del Triangulo: ");
                double sideA = verifyInput(Console.ReadLine());
                Console.WriteLine("Ingrese un lado del Triangulo: ");
                double sideB = verifyInput(Console.ReadLine());
                Console.WriteLine("Ingrese un lado del Triangulo: ");
                double sideC = verifyInput(Console.ReadLine());

                if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                {
                    Console.WriteLine("Ingrese datos validos");
                }
                else if (((sideA + sideB) <= sideC) || ((sideB + sideC) <= sideA) || ((sideC + sideA) <= sideB))
                {
                    Console.WriteLine("No es un triangulo");
                }
                else
                {
                    Console.WriteLine(verifyTriangle(sideA, sideB, sideC));
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }



        }

        public static double verifyInput(string line)
        {
            //int v;
            double v2;
            if (double.TryParse(line, out v2))
            {
                return Math.Round(Convert.ToDouble(line), 1);
            }
            else
            {
                return 0;
            }
        }

        public static string verifyTriangle(double a, double b, double c)
        {
            if (a == b && a == c && b == c)
            {
                return "Es un triangulo equilatero";
            }
            else if (a != b && a != c && b!=c)
            {
                return "Es un triangulo escaleno";
            }
            else
            {
                return "Es un triangulo isoceles";
            }
        }
    }
}
