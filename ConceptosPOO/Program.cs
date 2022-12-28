using System;


namespace ConceptosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            var miVariable = new { Nombre = "Juan", Edad = 19 };


            var miOtraVariable = new { Nombre = "Ana", Edad = 25 };

            miVariable = miOtraVariable;

            Console.WriteLine($"Nombre: {miVariable.Nombre} Edad: {miVariable.Edad}");
        }
        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(150, 90);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los dos puntos es de : {distancia}");
            Console.WriteLine($"Número de objetos creados: {Punto.ContadorDeObjetos()}");
        }
    }
}
