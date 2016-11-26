using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12
{
    class PruebaCuenta
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta( 50.00 );
            Cuenta cuenta2 = new Cuenta( -7.53 );

            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.obtenerSaldo());
            Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.obtenerSaldo());

            double montoDeposito;

            Console.WriteLine("Escriba el monto a depositar para cuenta1: ");
            montoDeposito = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nsumando {0:f2} al saldo de cuenta1\n\n", montoDeposito);

            cuenta1.abonar(montoDeposito);

            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.obtenerSaldo());
            Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.obtenerSaldo());

            Console.WriteLine("Escriba el monto a depositar para cuenta2: ");
            montoDeposito = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nsumando {0:f2} al saldo de cuenta2\n\n", montoDeposito);

            cuenta2.abonar(montoDeposito);

            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.obtenerSaldo());
            Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.obtenerSaldo());

            double montoCargo;

            Console.WriteLine("Escriba el monto a cargar para cuenta1: ");
            montoCargo = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nrestando {0:f2} al saldo de cuenta1\n\n", montoCargo);
            cuenta1.cargar(montoCargo);

            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.obtenerSaldo());
            Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.obtenerSaldo());

            Console.WriteLine("Escriba el monto a cargar para cuenta2: ");
            montoCargo = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nrestando {0:f2} al saldo de cuenta2\n\n", montoCargo);
            cuenta2.cargar(montoCargo);

            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.obtenerSaldo());
            Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.obtenerSaldo());

        }
    }
}
