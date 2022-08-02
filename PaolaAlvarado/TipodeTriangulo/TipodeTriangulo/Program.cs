using System;

namespace TipodeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verificador de triangulo

            Console.WriteLine("Ingrese el lado a del triangulo");
            bool isA = double.TryParse(Console.ReadLine(),out double a);

            Console.WriteLine("Ingrese el lado b del triangulo");
            bool isB= double.TryParse(Console.ReadLine(),out double b);

            Console.WriteLine("Ingrese el lado c del triangulo");
            bool isC =double.TryParse(Console.ReadLine(),out double c);

            if(isA && isB && isC)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triangulo equilatero");
                }
                else if (c == a || c == b || a == b)
                {
                    Console.WriteLine("Triangulo isosceles");
                }
                else
                {
                    Console.WriteLine("Triangulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Los lados del triangulo deben ser valores numericos");
            }
            
        }
    }
}
