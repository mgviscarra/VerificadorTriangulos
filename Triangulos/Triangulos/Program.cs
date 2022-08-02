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
            while (true)
            {
                double l1, l2, l3;
                Console.WriteLine("Ingrese el primer lado: ");
                l1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo lado: ");
                l2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer lado: ");
                l3 = Convert.ToDouble(Console.ReadLine());

                if (l1 == l2 && l1 == l3)
                {
                    Console.WriteLine("Equilatero");
                }
                else
                {
                    if (l1 == l2 || l1 == l3 || l2 == l3)
                    {
                        Console.WriteLine("Isoceles");

                    }
                    else
                    {
                        if (l1 != l2 && l2 != l3 && l3 != l2)
                        {
                            Console.WriteLine("Escaleno");
                        }
                    }
                }
            }

        }
    }
}
