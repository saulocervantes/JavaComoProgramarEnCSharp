using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11
{
    class PruebaLibroCalificaciones
    {
        static void Main(string[] args)
        {
            LibroCalificaciones libroCalificaciones1 = new LibroCalificaciones( 
                "CS101 Introducción a la programación en Java", "Deitel & Deitel" );

            LibroCalificaciones libroCalificaciones2 = new LibroCalificaciones(
                "CS102 Introducción a la programación en C#", "Tributo Multimedia");

            Console.WriteLine("El nombre del curso de librocaCalificaciones1 es: {0}",
                libroCalificaciones1.obtenerNombreDelCurso());

            Console.WriteLine("El nombre del curso de librocaCalificaciones1 es: {0}", 
                libroCalificaciones2.obtenerNombreDelCurso());

            //

            libroCalificaciones1.mostrarMensaje();
            libroCalificaciones2.mostrarMensaje();

        }
    }
}
