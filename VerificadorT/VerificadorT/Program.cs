using System;

namespace VerificadorT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tipotriangulo();
        }
        public static void tipotriangulo() 
        {
            try
            {
                double a = 0, b = 0, c = 0;

                Console.WriteLine("Ingrese lado a ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese lado b ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese lado c ");
                c = Convert.ToDouble(Console.ReadLine());

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Todos los valores ingresados deben ser mayores a 0");
                    tipotriangulo();
                }
                else { 
                    if (a == b && b == c)
                        Console.WriteLine("Triangulo equilatero");
                    else if (a == b || b == c || a == c)
                        Console.WriteLine("Triangulo isoceles ");
                    else
                        Console.WriteLine("Triangulo escaleno ");

                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Intente nuevamente, solo se admiten números");
                tipotriangulo();
            }
        }
    }
}
