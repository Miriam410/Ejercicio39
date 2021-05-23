using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class Program
    {
        //39. Solicite el ingreso de una serie de números y los presente en orden inverso
        static void Main(string[] args)
        {
            int[] Ingresos = new int[5];
            Console.WriteLine("Usted tiene que ingresar 5 números \n");
            // ingresa 5 numeros para el array y las incorpora al array
            for (int indice= 0; indice < Ingresos.Length; indice++)
            {
                Console.WriteLine($"Ingrese el número para la posición [{indice}] : ");
                bool estaBien = false;

                while (!estaBien)
                {
                    string ingreso = Console.ReadLine();
                    estaBien = int.TryParse(ingreso, out Ingresos[indice]);
                }
            }
            Console.WriteLine("-------------------------------------------------------------");

           
            // array reverso con los elementos
            Console.WriteLine("Los elementos reversos son: ");
            Array.Reverse(Ingresos);
            foreach (var elemento in Ingresos)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadKey();
        }
    }
}
