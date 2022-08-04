namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3;
            Console.WriteLine("Ingrese el lado 1: ");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2: ");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3: ");
            l3 = Convert.ToDouble(Console.ReadLine());

            if (l1 == l2 && l1 == l2 && l2 == l3)
            {
                Console.WriteLine("El triángulo es equilatero");
            }
            else if ((l1 != l2) && (l1 != l3) && (l2 != l3))
            {
                Console.WriteLine("El triángulo es escaleno");
            }
            else
            {
                Console.WriteLine("El triángulo es isósceles");
            }

            Console.Read();
        }
    }
}