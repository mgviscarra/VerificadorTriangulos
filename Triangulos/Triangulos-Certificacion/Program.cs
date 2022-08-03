using System;

namespace Triangulos_Certificacion
{
    class Program
    {
        int lado1;
        int lado2;
        int lado3;

        string respuesta;

        Triangulo triangulo;

        static void Main(string[] args)

        {
            Console.WriteLine("¡Bienvenid@! Ingresa los tres lados de tu triangulo:");
            Console.WriteLine("Ingresa la longitud del lado A");
            lado1 = Console.ReadLine();
            Console.WriteLine("Ingresa la longitud del lado B");
            lado2 = Console.ReadLine();
            Console.WriteLine("Ingresa la longitud del lado C");
            lado3 = Console.ReadLine();

            triangulo = new Triangulo(lado1, lado2, lado3);
            respuesta = triangulo.definirTipo(lado1, lado2, lado3);

            Console.WriteLine("Este triangulo es"+respuesta);
        }
    }
}
