/*
 * Modifique el programa de la figura 4.12 para validar sus entradas. Para cualquier entrada, si el valor introducido
es distinto de 1 o 2, debe seguir iterando hasta que el usuario introduzca un valor correcto.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._24
{
    class PruebaAnalisis
    {
        static void Main(string[] args)
        {
            Analisis aplicacion = new Analisis(); // crea objeto Analisis
            aplicacion.ProcesarResultadosExamen(); // llama al método para procesar los resultados
        } // fin de main
    } // fin de la clase PruebaAnalisis
}
