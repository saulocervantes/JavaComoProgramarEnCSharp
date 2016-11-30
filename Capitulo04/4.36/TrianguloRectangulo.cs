using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._36
{
    class TrianguloRectangulo
    {
        public int Cateto1 { get; set; }
        public int Cateto2 { get; set; }
        public int Hipotenusa { get; set; }

        public TrianguloRectangulo(int cat1, int cat2, int hip)
        {
            Cateto1 = cat1;
            Cateto2 = cat2;
            Hipotenusa = hip;
        }

        public void VerificarTriangulo()
        {
            Console.WriteLine(Math.Pow(Hipotenusa, 2) == Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2) ?
                "SI es un triángulo rectángulo" : "NO es un triángulo rectángulo");
        }
    }
}
