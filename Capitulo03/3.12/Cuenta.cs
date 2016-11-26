using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12
{
    class Cuenta
    {
        private double saldo;

        public Cuenta( double saldoInicial )
        {
            if ( saldoInicial > 0.0 )
            {
                saldo = saldoInicial;
            }
        }

        public void abonar( double monto )
        {
            saldo += monto;
        }

        public void cargar( double monto )
        {
            if (monto > saldo)
            {
                Console.WriteLine("El monto a cargar excede el saldo de la cuenta");
            }
            else
            {
                saldo -= monto;
            }
            
        }

        public double obtenerSaldo()
        {
            return saldo;
        }
    }
}
