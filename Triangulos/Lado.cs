using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    internal class Lado
    {
        public Punto Coordenada1, Coordenada2;
        public double tamano;
        public Lado(Punto coordenada1, Punto coordenada2)
        {
            Coordenada1 = coordenada1;
            Coordenada2 = coordenada2;
            tamano = 0;
        }

        public double CalcularTamano()
        {
            tamano = Math.Sqrt(Math.Pow(Coordenada2.x - Coordenada1.x, 2) + Math.Pow(Coordenada2.y - Coordenada1.y, 2));
            return tamano;
        }

        public Lado Max(Lado l)
        {
            if (tamano >= l.tamano)
            {
                return this;
            }
            else
            {
                return l;
            }
        }

        public Lado Min(Lado l)
        {
            if(tamano <= l.tamano)
            {
                return this;
            }
            else
            {
                return l;
            }
        }
    }
}
