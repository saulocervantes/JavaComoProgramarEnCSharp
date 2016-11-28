/*
 Desarrolle una aplicación en Java que determine el sueldo bruto para cada uno de tres empleados. La empresa
paga la cuota normal en las primeras 40 horas de trabajo de cada empleado, y paga cuota y media en todas las horas
trabajadas que excedan de 40. Usted recibe una lista de los empleados de la empresa, el número de horas que trabajó
cada empleado la semana pasada y la tarifa por horas de cada empleado. Su programa debe recibir como entrada esta
información para cada empleado, debe determinar y mostrar el sueldo bruto de cada empleado. Utilice la clase Scanner
para introducir los datos.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while(i < 4)
            {
                //Creamos las variables apropiadas para crear los objetos
                Console.WriteLine("Ingrese el nombre del empleado {0}", i);
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese las horas trabajadas:");
                int horas = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la tarifa por hora");
                decimal tarifa = Decimal.Parse(Console.ReadLine());

                //Creamos 3 objetos de empleado
                Empleado empleado = new Empleado(nombre, tarifa, horas);

                Console.WriteLine("El sueldo bruto de {0} es de {1:C2}", empleado.Nombre, empleado.SueldoBruto);

                ++i;
            }
        }
    }
}
