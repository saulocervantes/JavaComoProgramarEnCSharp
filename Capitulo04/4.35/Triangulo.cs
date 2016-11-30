using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35
{
    class Triangulo
    {
        public float Lado1 { get; set; }
        public float Lado2 { get; set; }
        public float Lado3 { get; set; }

        public Triangulo( float l1, float l2, float l3)
        {
            Lado1 = l1;
            Lado2 = l2;
            Lado3 = l3;
        }

        public void VerificarTriangulo()
        {
            //lado1+lado2>lado3 y lado2+lado3>lado1 y lado1+lado3>lado
            Console.WriteLine(Lado1 + Lado2 > Lado3 & Lado2 + Lado3 > Lado1 & Lado1 + Lado3 > Lado2 ?
                "SI es un triángulo" : "NO es un triángulo");
        }
    }
}
