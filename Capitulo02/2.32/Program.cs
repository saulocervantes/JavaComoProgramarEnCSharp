using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._32
{
    class Program
    {
        static void Main(string[] args)
        {
            double positivos = 0, negativos = 0, ceros = 0, entrada;


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese un número:");
                entrada = Convert.ToInt32( Console.ReadLine() );

                if (entrada > 0)
                    positivos++;

                if (entrada == 0)
                    ceros++;

                if (entrada < 0)
                    negativos++;
            }

            Console.WriteLine("Positivos: {0}\nNegativos: {1}\nCeros: {2}", positivos, negativos, ceros);
        }
    }
}
