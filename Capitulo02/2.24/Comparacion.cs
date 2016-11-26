using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._24
{
    class Comparacion
    {
        public Comparacion(int a, int b, int c, int d, int e)
        {
            valorA = a;
            valorB = b;
            valorC = c;
            valorD = d;
            valorE = e;
        }

        private int a, b, c, d, e;

        public int valorA { get; set; }

        public int valorB { get; set; }

        public int valorC { get; set; }

        public int valorD { get; set; }

        public int valorE { get; set; }

        public int mayor()
        {
            int mayor = valorA;

            if (valorB > valorA)
            {
                mayor = valorB;
            }

            if (valorC > valorB)
            {
                mayor = valorC;
            }

            if (valorD > valorC)
            {
                mayor = valorD;
            }

            if (valorE > valorD)
            {
                mayor = valorE;
            }

            return mayor;
        }

        public int menor()
        {
            int menor = valorA;

            if (valorB < valorA)
            {
                menor = valorB;
            }

            if (valorC < valorB)
            {
                menor = valorC;
            }

            if (valorD < valorC)
            {
                menor = valorD;
            }

            if (valorE < valorD)
            {
                menor = valorE;
            }

            return menor;
        }

    }
}
