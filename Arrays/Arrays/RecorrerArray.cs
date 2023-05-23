using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class RecorrerArray
    {
        public static void Main(string[] args)
        {
            int[] arrayDatos = leerDatos();

            Console.WriteLine("Imprimiendo desde el main");

            foreach (int item in arrayDatos)
            {
                Console.WriteLine(item);
            }

        }

        public static int[] leerDatos()
        {
            Console.WriteLine("¿Cuántos elementos quieres que tenga el array?");
            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++) 
            {
                Console.WriteLine($"Ingrese el valor de la posicion {i}: ");
                respuesta = Console.ReadLine();
                int datosElemento = int.Parse(respuesta);
                datos[i] = datosElemento;
            }
            return datos;
        }
    }
}
