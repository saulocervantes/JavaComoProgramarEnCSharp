using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._38
{
    class Factorial
    {

        public int CalcularFactorial(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            //n! = n · (n – 1) · (n – 2)
            return numero * CalcularFactorial(numero - 1);
        }
    }
}
