using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._38
{
    class ConstanteE
    {
        public double Resultado { get; set; }

        Factorial factorial = new Factorial();

        public double Calcular()
        {
            int i = 0;

            while (i<13)
            {
                Resultado += (double)i / factorial.CalcularFactorial(i);
                ++i;
            }

            return Resultado;
        }
    }
}
