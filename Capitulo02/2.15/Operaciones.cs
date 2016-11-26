using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._15
{
    class Operaciones
    {
        private double a, b;

        public double valorA
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

        public double valorB
        {
            get
            {
                return b;
            }

            set
            {
                if ( value == 0)
                {
                    b = 1;
                }
                else
                {
                    b = value;
                }
                
            }
        }

        public double sumar()
        {
            return valorA + valorB;
        }

        public double restar()
        {
            return valorA - valorB;
        }

        public double multiplicar()
        {
            return valorA * valorB;
        }

        public double dividir()
        {
            return valorA / valorB;
        }
    }
}
