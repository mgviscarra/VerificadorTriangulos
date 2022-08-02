using System;

namespace Clasificador_de_Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;


            Console.WriteLine("Primer Lado:  ");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Segundo Lado:  ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Tercer Lado:  ");
                n3 = Convert.ToDouble(Console.ReadLine());
                if (n1 == n2 && n1 == n3)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO ");
                }
                else
                {
                    if (n1 == n2 || n1 == n3 || n3 == n2)
                    {
                        Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                    else
                    {
                        if (n1 != n2 || n2 != n3 || n3 != n1)
                        {
                            Console.WriteLine("TRIANGULO ESCALENO");
                        }
                    }
                }
                Console.ReadLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Valor No Valido!!");
 
            }
        }
    }
}
