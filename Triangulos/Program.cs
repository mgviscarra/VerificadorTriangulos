using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double x1, y1, x2, y2, x3, y3;
                Console.WriteLine("TIPOS DE TRIANGULO");
                Console.WriteLine("Para ver que tipo de triangulo tiene, por favor ingrese las coordenadas: ");
                Console.WriteLine("Primera coordenada x: ");
                x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Primera coordenada y: ");
                y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Segunda coordenada x: ");
                x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Segunda coordenada y: ");
                y2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Tercera coordenada x: ");
                x3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Tercera coordenada y: ");
                y3 = double.Parse(Console.ReadLine());

                Punto[] Esqunas = new Punto[3];
                Esqunas[0] = new Punto(x1, y1);
                Esqunas[1] = new Punto(x2, y2);
                Esqunas[2] = new Punto(x3, y3);

                Lado[] Lados = new Lado[3];
                Lados[0] = new Lado(Esqunas[0], Esqunas[1]);
                Lados[1] = new Lado(Esqunas[1], Esqunas[2]);
                Lados[2] = new Lado(Esqunas[2], Esqunas[0]);

                Triangulo triangulo = new Triangulo(Lados);
                Console.WriteLine("El triangulo es " + triangulo.AnalizarTipo() + "\n\n");
            }
        }
    }
}
