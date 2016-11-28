/*
 Desarrolle una aplicación en Java que determine si alguno de los clientes de una tienda de departamentos se ha
excedido del límite de crédito en una cuenta. Para cada cliente se tienen los siguientes datos:
a) El número de cuenta.
b) El saldo al inicio del mes.
c) El total de todos los artículos cargados por el cliente en el mes.
d) El total de todos los créditos aplicados a la cuenta del cliente en el mes.
e) El límite de crédito permitido.
El programa debe recibir como entrada cada uno de estos datos en forma de números enteros, debe calcular el nuevo
saldo (= saldo inicial + cargos – créditos), mostrar el nuevo balance y determinar si éste excede el límite de crédito del
cliente. Para los clientes cuyo límite de crédito sea excedido, el programa debe mostrar el mensaje "Se excedió el
límite de su crédito".
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los siguientes datos:");
            Console.WriteLine("\nEl número de cliente");
            int numeroCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El saldo inicial del mes:");
            int saldoInicial = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El total de todos los artículos cargados por el cliente en el mes:");
            int articulosCargados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El total de todos los créditos aplicados a la cuenta del cliente en el mes:");
            int creditosAplicados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El límite de crédito permitido:");
            int creditoPermitido = Convert.ToInt32(Console.ReadLine());

            Cliente cliente1 = new Cliente(numeroCliente, saldoInicial, articulosCargados, creditosAplicados, creditoPermitido);
            cliente1.Balance();
        }
    }
}
