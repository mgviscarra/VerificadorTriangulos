using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificador
{
    public class Exercise14
    {
        public static void Main()
        {
            int lado1, lado2, lado3;
            string l1, l2, l3;
            Console.Write("\n\n");
            Console.Write("verificar si un triangulo es equilatero, isoceles o escaleno:\n");
            Console.Write("===============================================");
            Console.Write("\n\n");



            Console.Write("Lado 1 del triangulo ");
            lado1 = Convert.ToInt32(Console.ReadLine());
            


            Console.Write("Lado 2 del triangulo ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 3 del triangulo ");
            lado3 = Convert.ToInt32(Console.ReadLine());



            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.Write("Triangulo equilatero.\n");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.Write("Triangulo isoceles.\n");
            }
            else
            {
                Console.Write("Triangulo escaleno.\n");
            }
            Console.ReadKey();
        }
    }
}
