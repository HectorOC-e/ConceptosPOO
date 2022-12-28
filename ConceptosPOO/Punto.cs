using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class Punto
    {
        private int x, y;
        private static int contadorDeObjetos = 0;

        public Punto()
        {
            this.x = 0;
            this.y = 0;

            contadorDeObjetos++;
            //Console.WriteLine("Este es el constructor por defecto");
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            
            contadorDeObjetos++;
            //Console.WriteLine($"Coordenada X: {x}\nCoordena Y: {y}");
        }

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int ydif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(ydif, 2));
            
            return distanciaPuntos;

        }

        public static int ContadorDeObjetos() => contadorDeObjetos;    }
}
