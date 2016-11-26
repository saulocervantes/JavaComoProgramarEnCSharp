using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15
{
    class Fecha
    {
        public int Mes { get; set; }
        public int Dia { get; set; }
        public int Anio { get; set; }

        public Fecha(int mes, int dia, int anio)
        {
            Mes = mes;
            Dia = dia;
            Anio = anio;
        }

        public void mostrarFecha()
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2:D4}", Mes, Dia, Anio);
        }
    }
}
