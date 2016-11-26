/*
Los conductores se preocupan acerca del kilometraje de sus automóviles. Un conductor ha llevado el registro de
varios reabastecimientos de gasolina, registrando los kilómetros conducidos y los litros usados en cada reabastecimiento.
Desarrolle una aplicación en Java que reciba como entrada los kilómetros conducidos y los litros usados (ambos como
enteros) por cada reabastecimiento.El programa debe calcular y mostrar los kilómetros por litro obtenidos en cada
reabastecimiento, y debe imprimir el total de kilómetros por litro obtenidos en todos los reabastecimientos hasta este
punto.Todos los cálculos del promedio deben producir resultados en números de punto flotante.Use la clase Scanner
y la repetición controlada por centinela para obtener los datos del usuario.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Rebastecimientos rebastecimientos = new Rebastecimientos();

            rebastecimientos.pedirDatos();
        }
    }
}
