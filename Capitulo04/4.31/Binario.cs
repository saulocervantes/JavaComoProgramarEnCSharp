using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._31
{
    class Binario
    {
        public int Digitos { get; set; }
        public int Numero { get; set; }
        public int Decimal { get; set; }

        public void ContarDigitos()
        {
            int contador = 0;
            int aproximacion = 0;

            while (aproximacion != Numero)
            {
                contador++;
                aproximacion = Numero % (int)Math.Pow(10,contador);
            }

            Digitos = contador;
        }

        public void ConvertirDecimal()
        {
            int contador = 0;

            while (contador < Digitos)
            {
                
                Decimal += (Numero / (int)Math.Pow(10, contador) % 10) * (int)Math.Pow(2,contador);
                contador++;
            }

            Console.WriteLine("El número {0} en decimal es {1}", Numero, Decimal);
        }
    }
}
