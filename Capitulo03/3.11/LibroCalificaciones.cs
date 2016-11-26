using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._11
{
    class LibroCalificaciones
    {
        private string nombreDelCurso;
        private string instructorDelCurso;

        public LibroCalificaciones( String nombre, string instructor )
        {
            nombreDelCurso = nombre;
            InstructorDelCurso = instructor;
        }

        // Esto debería ser echo con propiedades
        public void establecerNombreDelCurso( String nombre )
        {
            nombreDelCurso = nombre;
        }

        // Esta también
        public string obtenerNombreDelCurso()
        {
            return nombreDelCurso;
        }

        public string InstructorDelCurso
        {
            get
            {
                return instructorDelCurso;
            }

            set
            {
                instructorDelCurso = value;
            }
        }

        public void mostrarMensaje()
        {
            Console.WriteLine("Bienvenido al Libro de calificaciones para {0}. Este curso es presentado por: {1}",
                obtenerNombreDelCurso(), InstructorDelCurso);
        }
    }
}
