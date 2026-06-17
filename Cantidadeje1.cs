using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edadesPersonas = new int[7];
            int cantidadMayoresEdad = 0;

            for (int indice = 0; indice < 7; indice++)
            {
                Console.Write("Ingrese la edad de la persona " + (indice + 1) + ": ");
                edadesPersonas[indice] = int.Parse(Console.ReadLine());

                if (edadesPersonas[indice] >= 18)
                {
                    cantidadMayoresEdad++;
                }
            }

            Console.WriteLine("Cantidad de personas mayores de edad: " + cantidadMayoresEdad);
            Console.ReadKey();
        }
    }
}
