using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insercion_Consola_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[100];
            Random rnd = new Random();
            int numero = rnd.Next(1, 100);
            Console.WriteLine("Numeros a ordenar");
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(1, 100);
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }


            insercion(vector);


            Console.WriteLine("Vector ordenado");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.ReadKey();
        }

        private static void insercion(int[] vector)
        {
            for (int j = 1; j < vector.Length; j++)
            {
                int actual = vector[j];

                int i = j - 1;
                while (i >= 0 && vector[i] > actual)
                {
                    vector[i + 1] = vector[i];
                    i--;
                }
                vector[i + 1] = actual;
            }


        }
    }
}