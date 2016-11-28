/*
 Una empresa grande paga a sus vendedores mediante comisiones. Los vendedores reciben $200 por semana,
más el 9% de sus ventas brutas durante esa semana. Por ejemplo, un vendedor que vende $5000 de mercancía en una
semana, recibe $200 más el 9% de 5000, o un total de $650. Usted acaba de recibir una lista de los artículos vendidos
por cada vendedor. Los valores de estos artículos son los siguientes:
Artículo    Valor
    1       239.99
    2       129.75
    3        99.95
    4       350.89
Desarrolle una aplicación en Java que reciba como entrada los artículos vendidos por un vendedor durante la última
semana, y que calcule y muestre los ingresos de ese vendedor. No hay límite en cuanto al número de artículos que un
vendedor puede vender.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();

            vendedor.TotalVentas();

            Console.WriteLine("Los ingresos del vendedor son de: {0}", vendedor.Pago);
        }
    }
}
