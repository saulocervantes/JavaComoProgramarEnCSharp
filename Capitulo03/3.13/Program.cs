using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13
{
    class PruebaFactura
    {
        static void Main(string[] args)
        {
            Factura factura1 = new Factura("005", "celular samsung", 2, 3700);
            // La cantidad debe ser positiva o si no se hace 0
            Factura factura2 = new Factura("032", "laptop asus chida", 4, 14000);

            Console.WriteLine("Datos de la factura 1 del artículo '{0}':\nNúmero de pieza: {1,12}\nDescripción del artículo: {0}\nCantidad de artículos: {2,4}\nPrecio por artículo: {3,14:C}\nTotal: {4,28:C}\n",
                factura1.descripcionDeLaPieza, factura1.numeroDePieza, factura1.CantidadDeArticulos, factura1.PrecioPorArticulo, factura1.obtenerFactura());

            Console.WriteLine("Datos de la factura 1 del artículo '{0}':\nNúmero de pieza: {1,12}\nDescripción del artículo: {0}\nCantidad de artículos: {2,4}\nPrecio por artículo: {3,14:C}\nTotal: {4,28:C}\n",
                factura2.descripcionDeLaPieza, factura2.numeroDePieza, factura2.CantidadDeArticulos, factura2.PrecioPorArticulo, factura2.obtenerFactura());
        }
    }
}
