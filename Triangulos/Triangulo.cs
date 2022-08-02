using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class Triangulo
    {
        public Lado[] Lados = new Lado[3];
        public string TipoTriangulo;
        public Triangulo(Lado[] lados)
        {
            Lados = lados;
            TipoTriangulo = "";
        }

        public string AnalizarTipo()
        {
            double Med1 = Math.Round(Lados[0].CalcularTamano(), 2, MidpointRounding.ToEven);
            double Med2 = Math.Round(Lados[0].CalcularTamano(), 2, MidpointRounding.ToEven);
            double Med3 = Math.Round(Lados[0].CalcularTamano(), 2, MidpointRounding.ToEven);

            if (Med1.Equals(Med2) && Med1.Equals(Med3))
            {
                    TipoTriangulo = "Equilatero";
            }
            else if (Math.Pow(MasGrande().tamano, 2) == Math.Pow(MasPequeno().tamano, 2) + Math.Pow(Medio().tamano, 2))
            {
                TipoTriangulo = "Rectangulo";
            }
            else if (Med1.Equals(Med2) || Med1.Equals(Med3) || Med2.Equals(Med3))
            {
                TipoTriangulo = "Isosceles";
            }
            else
            {
                    TipoTriangulo = "Escaleno";
            }
            return TipoTriangulo;
        }

        public Lado MasGrande()
        {
            return Lados[0].Max(Lados[1].Max(Lados[2]));
        }
        public Lado MasPequeno()
        {
            return Lados[0].Min(Lados[1].Min(Lados[2]));
        }
        public Lado Medio()
        {
            return Lados[0].Max(Lados[1].Min(Lados[2]));
        }
    }
}
