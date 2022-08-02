using System;

namespace VerifTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double lado1 = 0;
                double lado2 = 0;
                double lado3 = 0;

                Console.WriteLine("Ingrese el largo del lado 1:");
                bool num1 = double.TryParse(Console.ReadLine(), out lado1);
                Console.WriteLine("Ingrese el largo del lado 2:");
                bool num2 = double.TryParse(Console.ReadLine(), out lado2);
                Console.WriteLine("Ingrese el largo del lado 3:");
                bool num3 = double.TryParse(Console.ReadLine(), out lado3);
                if (!(num1 && num2 && num3) || !((lado1 > 0) && (lado2 > 0) && (lado3 > 0)))
                {
                    Console.WriteLine("Alguno de los valores ingresados no es un número o es <= 0");
                    continue;
                }
                else
                {
                    string res = "";
                    if ((lado1 == lado2) && (lado2 == lado3))
                    {
                        res = "Equilatero";   
                    }
                    else if ((lado1 == lado2) || (lado2 == lado3) || (lado3 == lado1))
                    {
                        res = "Isoceles";
                    }
                    else
                    {
                        res = "Escaleno";
                    }
                    Console.WriteLine(String.Format("El triangulo es de tipo: {0}", res));
                }
            }
        }
    }
}
