using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._19
{
    class Vendedor
    {
        public decimal ComisionPorSemana { get; set; }
        public decimal Pago { get; set; }
        const int SUELDOBASE = 200;
        const decimal ARTICULO1 = 239.99m, ARTICULO2 = 129.75m, ARTICULO3 = 99.95m, ARTICULO4 = 350.89m;

        public void ObtenerPago()
        {
            Pago = ComisionPorSemana * 0.09m + SUELDOBASE;
        }

        public void TotalVentas()
        {
            Console.WriteLine("Ingrese la cantidad entera de los productos que vendio en esta semana:");

            Console.WriteLine("Artículo1:");
            ComisionPorSemana += (Convert.ToInt32(Console.ReadLine()) * ARTICULO1);

            Console.WriteLine("Artículo2:");
            ComisionPorSemana += (Convert.ToInt32(Console.ReadLine()) * ARTICULO2);

            Console.WriteLine("Artículo3:");
            ComisionPorSemana += (Convert.ToInt32(Console.ReadLine()) * ARTICULO3);

            Console.WriteLine("Artículo4:");
            ComisionPorSemana += (Convert.ToInt32(Console.ReadLine()) * ARTICULO4);

            ObtenerPago();
        }

    }
}
