using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio del círculo");
            int radio = int.Parse(Console.ReadLine());

            int diametro = 2 * radio;
            double circunferencia = 2 * Math.PI * radio;
            double area = Math.PI * radio * radio;

            Console.WriteLine("El diámetro es {0}, la circunferencia {1} y el área {2}", 2 * radio, 2 * Math.PI * radio, Math.PI * radio * radio);

            Console.WriteLine("El diámetro es {0}, la circunferencia {1} y el área {2}", diametro, circunferencia, area);
        }
    }
}
