using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._16
{
    class Program
    {
        static void Main(string[] args)
        {
            var comparar = new Comparar();

            Console.WriteLine("Escriba un entero:");
            comparar.valorA = int.Parse( Console.ReadLine() );

            Console.WriteLine("Escriba otro entero:");
            comparar.valorB = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine(comparar.comparar() );
        }
    }
}
