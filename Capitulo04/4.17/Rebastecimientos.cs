using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._17
{
    class Rebastecimientos
    {
        public int Kilometros { get; set; }
        public int Litros { get; set; }
        public int TotalKm { get; set; }
        public int TotalLt { get; set; }

        public void pedirDatos()
        {
            string centinela = "continuar";
            int contador = 0;

            while ( centinela == "continuar")
            {
                contador++;
                Console.WriteLine("Ingrese el número de kilometros en el rebastecimiento {0}", contador);
                Kilometros = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el número de litros en el rebastecimiento {0}", contador);
                Litros = Convert.ToInt32(Console.ReadLine());

                TotalKm += Kilometros;
                TotalLt += Litros;

                Console.WriteLine("Los kilometros por litro  en el rebastecimiento {1} son: {0}", KilometrosPorLitro(Kilometros, Litros), contador);
                Console.WriteLine("Total de kilómetros por litro: {0}", KilometrosPorLitro(TotalKm, TotalLt));

                centinela = Console.ReadLine();
            }
            
        }

        public float KilometrosPorLitro( int k, int l)
        {
            return (float)k / l;
        }
    }
}
