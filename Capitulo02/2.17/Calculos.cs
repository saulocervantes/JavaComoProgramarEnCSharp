using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._17
{
    class Calculos
    {
        private int a, b, c;

        public int valorA { get; set; }

        public int valorB { get; set; }

        public int valorC { get; set; }

        public int suma()
        {
            return valorA + valorB + valorC;
        }

        public int promedio()
        {
            return ( valorA + valorB + valorC ) / 3;
        }

        public int producto()
        {
            return valorA * valorB * valorC;
        }

        public string menor()
        {
            string menor = valorA + " es el menor";

            if (valorB < valorA)
            {
                menor = valorB + " es el menor";
            }

            if (valorC < valorB)
            {
                menor = valorC + " es el menor";
            }

            return menor;
        }

        public string mayor()
        {
            string mayor = valorA + " es el mayor";

            if (valorB > valorA)
            {
                mayor = valorB + " es el mayor";
            }

            if (valorC > valorB)
            {
                mayor = valorC + " es el mayor";
            }

            return mayor;
        }
    }
}
