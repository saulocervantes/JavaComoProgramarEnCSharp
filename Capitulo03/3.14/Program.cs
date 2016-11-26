using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14
{
    class PruebaEmpleado
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Pancho", "Villa", 30015.2);
            var empleado2 = new Empleado("Benito", "Juárez", 50000);

            Console.WriteLine("El salario anual del empleado {0} {1} es de: {2:C}", empleado1.Nombre, empleado1.ApellidoPaterno, empleado1.SalarioMensual * 12);
            Console.WriteLine("El salario anual del empleado {0} {1} es de: {2:C}\n", empleado2.Nombre, empleado2.ApellidoPaterno, empleado2.SalarioMensual * 12);

            Console.WriteLine("Aumentamos el 10% del salario de los empleados\n");

            empleado1.SalarioMensual *= 1.10;
            empleado2.SalarioMensual *= 1.10;

            Console.WriteLine("{3,-29} {0,-6} {1,-7} es de: {2:C}", empleado1.Nombre, empleado1.ApellidoPaterno, empleado1.SalarioMensual * 12, "El salario anual del empleado");
            Console.WriteLine("{3,-29} {0,-6} {1,-7} es de: {2:C}", empleado2.Nombre, empleado2.ApellidoPaterno, empleado2.SalarioMensual * 12, "El salario anual del empleado");
        }
    }
}
