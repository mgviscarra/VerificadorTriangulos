using System;

namespace Triangulos1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion de variables
            int a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("Reconoceré el tipo de triangulo segun los lados que ingresaste");

            Console.WriteLine("Ingresa el primer lado");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo lado");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer lado");
            c = int.Parse(Console.ReadLine());

            
            Console.WriteLine(a + b + c);

            Console.WriteLine(nombreMetodo(a, b, c));
        }

        static string nombreMetodo(int a, int b, int c)
        {
            //primero el caso de triangulo isosceles
            if (a == c || a == b || c == b)
            {
                return "El triangulo es isosceles";
            }
            else if (a == c && c == b)
            {
                return "El triangulo es equilatero";
            }
            else if(a != c || a != b || c != b)
            {
                return "El triangulo es escaleno";
            }
            else
            {
                return "algo salio mal";
            }
        }
    }
}
