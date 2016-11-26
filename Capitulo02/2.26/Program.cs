using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer entero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el primer entero:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine("{0} es múltiplo de {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} no es múltiplo de {1}", num1, num2);
            }
        }
    }
}
