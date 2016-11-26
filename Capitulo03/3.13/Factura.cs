using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._13
{
    class Factura
    {
        private int cantidadDeArticulos;
        private double precioPorArticulo;

        public Factura(string numero, string descripcion, int cantidad, double precio)
        {
            numeroDePieza = numero;
            descripcionDeLaPieza = descripcion;
            CantidadDeArticulos = cantidad;
            PrecioPorArticulo = precio;
        }

        public string numeroDePieza { get; set; }
        public string descripcionDeLaPieza { get; set; }

        public int CantidadDeArticulos
        {
            get
            {
                return cantidadDeArticulos;
            }

            set
            {
                if (value < 0)
                {
                    cantidadDeArticulos = 0;
                }
                else
                {
                    cantidadDeArticulos = value;
                }
            }
        }

        public double PrecioPorArticulo
        {
            get
            {
                return precioPorArticulo;
            }

            set
            {
                if (value < 0)
                {
                    precioPorArticulo = 0;
                }
                else
                {
                    precioPorArticulo = value;
                }
            }
        }

        public double obtenerFactura()
        {
            double montoDeLaFactura = cantidadDeArticulos * precioPorArticulo;

            return montoDeLaFactura;
        }
    }
}
