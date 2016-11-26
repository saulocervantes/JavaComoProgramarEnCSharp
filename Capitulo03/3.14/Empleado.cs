using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14
{
    class Empleado
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        private double salarioMensual;

        public Empleado(string nombre, string apellidoPaterno, double salarioMensual)
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            SalarioMensual = salarioMensual;
        }

        public double SalarioMensual
        {
            get
            {
                return salarioMensual;
            }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                salarioMensual = value;
            }
        }


    }
}
