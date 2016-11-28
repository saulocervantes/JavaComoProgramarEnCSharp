using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._20
{
    class Empleado
    {
        public decimal TarifaPorHora { get; set; }
        public string Nombre { get; set; }
        public decimal SueldoBruto { get; set; }

        public Empleado(string nombre, decimal tarifaporhora, int horas)
        {
            Nombre = nombre;
            TarifaPorHora = tarifaporhora;
            CalcularSueldo(horas);
        }

        public void CalcularSueldo(int horasTrabajadas)
        {
            if (horasTrabajadas <= 40)
                SueldoBruto = horasTrabajadas * TarifaPorHora;

            else
                SueldoBruto = (horasTrabajadas - 40) * (TarifaPorHora * 1.5m) + (40 * TarifaPorHora);            
        }
    }
}
