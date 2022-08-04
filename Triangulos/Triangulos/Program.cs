using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string consultar = "s";
            string triangulo = "";
            double A;
            double B;
            double C;
            while (consultar == "s")
            {
                Console.WriteLine("\nIngrese el valor del lado A del triangulo: ");
                bool verifyA = double.TryParse(Console.ReadLine(), out A);
                Console.WriteLine("\nIngrese el valor del lado B del triangulo: ");
                bool verifyB = double.TryParse(Console.ReadLine(), out B);
                Console.WriteLine("\nIngrese el valor del lado C del triangulo: ");
                bool verifyC = double.TryParse(Console.ReadLine(), out C);

                if (!verifyA || ! verifyB || !verifyC ||
                    (A <= 0) || (B <= 0) || (C <= 0))
                {
                    Console.WriteLine("Error al ingresar valor/es\n " +
                                      "*Es posible que haya ingresado algun valor negativo, igual a 0 o no numerico");
                }
                else
                {
                    if ((A == B) && (B == C))
                    {
                        triangulo = " equilatero, todos los lados iguales";
                    }
                    else if ((A == B) || (B == C) || (A == C))
                    {
                        triangulo = " isosceles, 2 lados iguales";
                    }
                    else
                    { 
                        triangulo = " escaleno, todos los lados desiguales";
                    }
                    Console.WriteLine("Es un triangulo" + triangulo);
                }
                Console.WriteLine("\nDesea consultar otra vez? s/n");
                consultar = Console.ReadLine();
            }
        }

        
    }
}
