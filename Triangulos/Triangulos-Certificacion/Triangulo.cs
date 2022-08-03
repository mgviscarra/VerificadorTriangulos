
namespace Triangulos_Certificacion
{
    public class Triangulo
    {
        int ladoA;
        int ladoB;
        int ladoC;

        string respuesta = "";

        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            ladoA = this.ladoA;
            ladoB = this.ladoB;
            ladoC = this.ladoC;
        }

        public string definirTipo(int a, int b, int c)
        {
            if(a == b == c)
            {
                respuesta = "Es un Triangulo equilatero";
            }
            else if(a == b || b == c || a == c)
            {
                respuesta = "Es un triangulo escaleno";
            }
            else
            {
                respuesta = "Es un triangulo isoceles";
            }

            return respuesta;
        }
    }
}