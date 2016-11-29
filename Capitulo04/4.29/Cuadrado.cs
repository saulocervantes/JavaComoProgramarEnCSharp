using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._29
{
    class Cuadrado
    {
        public int Lado { get; set; }

        public void Dibujar()
        {
            int i = 1;
            int j = 1;
            int k = 1;

            while (i <= Lado)
            {
                // Código para la primera y última línea
                if (i == 1 || i == Lado)
                {
                    while (j <= Lado)
                    {
                        Console.Write( j == Lado ? "*\n" : "*");
                        j++;
                    }

                    j = 1;
                }
                else // Código para las líneas del centro
                {
                    while (k <= Lado)
                    {
                        Console.Write( k == 1 ? "*" : "");
                        Console.Write(k != 1 && k != Lado ? " " : "");
                        Console.Write( k == Lado ? "*\n" : "");
                        ++k;
                    }

                    k = 1;
                }

                i++;
            }// Fin del While

        }
    }
}
