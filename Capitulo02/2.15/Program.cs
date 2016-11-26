using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            var operaciones = new Operaciones();

            System.Console.WriteLine("Ingrese el primer número:");
            operaciones.valorA = Convert.ToDouble( System.Console.ReadLine() );

            System.Console.WriteLine("Ingrese el segundo número:");
            operaciones.valorB = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("La sume de los dos números es: {0}", operaciones.sumar());
            System.Console.WriteLine("La resta de los dos números es: {0}", operaciones.restar());
            System.Console.WriteLine("La multiplicación de los dos números es: {0}", operaciones.multiplicar());
            System.Console.WriteLine("El cociente de los don números es: {0:F2}", operaciones.dividir());
            // El especificador de formato F por default da 2 dígitos pero se le pueden especificar cuantos
        }
    }
}
