using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._35
{
    class Triangulo
    {
        public float Cateto1 { get; set; }
        public float Cateto2 { get; set; }
        public float Hipotenusa { get; set; }

        public Triangulo( float cat1, float cat2, float hip)
        {
            Cateto1 = cat1;
            Cateto2 = cat2;
            Hipotenusa = hip;
        }

        public void VerificarTriangulo()
        {
            int j = 0;

            Console.WriteLine(Math.Pow(Hipotenusa, 2) == Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2) ?
                "SI es un triángulo" : "NO es un triángulo");
        }
    }
}
