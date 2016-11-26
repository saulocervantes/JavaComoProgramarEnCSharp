using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16
{
    class Comparar
    {
        private int a, b;

        public int valorA
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public int valorB
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public string comparar()
        {
            string resultado;

            resultado = "Estos números son iguales.";

            if ( valorA > valorB )
            {
                resultado = valorA + " es más grande";
            }

            if ( valorA < valorB )
            {
                resultado = valorB + " es más grande";
            }

            return resultado;
        }
    }
}
