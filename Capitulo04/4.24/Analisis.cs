using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._24
{
    class Analisis
    {
        public void ProcesarResultadosExamen()
        {
            // inicialización de las variables en declaraciones
            int aprobados = 0; // número de aprobados
            int reprobados = 0; // número de reprobados
            int contadorEstudiantes = 1; // contador de estudiantes
            int resultado; // un resultado del examen (obtiene el valor del usuario)

            // procesa 10 estudiantes, usando ciclo controlado por contador
            while (contadorEstudiantes <= 10)
            {
                // pide al usuario la entrada y obtiene el valor
                Console.WriteLine("Escriba el resultado (1 = aprobado, 2 = reprobado): ");
                resultado = int.Parse(Console.ReadLine());

                while (resultado != 1 && resultado != 2)
                {
                    Console.WriteLine("Escriba el resultado (1 = aprobado, 2 = reprobado): ");
                    resultado = int.Parse(Console.ReadLine());
                }

                // if...else anidado en while
                if (resultado == 1) // si resultado 1,
                    aprobados = aprobados + 1; // incrementa aprobados;
                else // de lo contrario, resultado no es 1, por lo que
                    reprobados = reprobados + 1; // incrementa reprobados

                // incrementa contadorEstudiantes, para que el ciclo termine en un momento dado
                contadorEstudiantes = contadorEstudiantes + 1;
            } // fin de while

            // fase de terminación; prepara y muestra los resultados
            Console.WriteLine("Aprobados: {0}\nReprobados: {1}\n", aprobados, reprobados);

            // determina si más de 8 estudiantes aprobaron
            if (aprobados > 8)
                Console.WriteLine("Aumentar colegiatura");
        } // fin del método procesarResultadosExamen

    }
}
