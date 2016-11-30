using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._37
{
    class Entero
    {
        int digito1;
        int digito2;
        int digito3;
        int digito4;
        public int Numero { get; set; }

        public void Cifrar()
        {
            //Método para cifrar el entero de 4 digitos
            digito1 = (digito1 + 7) % 10;
            digito2 = (digito2 + 7) % 10;
            digito3 = (digito3 + 7) % 10;
            digito4 = (digito4 + 7) % 10;

            Numero = Convert.ToInt32(digito3 + "" + digito4 + "" + digito1 + "" + digito2);
            Console.WriteLine("El número cifrado es {0:D4}", Numero);
        }

        public void Descifrar()
        {
            //Método para descifrar el entero de 4 dígitos
            digito1 = (digito1 + 3) % 10;
            digito2 = (digito2 + 3) % 10;
            digito3 = (digito3 + 3) % 10;
            digito4 = (digito4 + 3) % 10;

            Numero = Convert.ToInt32(digito3 + "" + digito4 + "" + digito1 + "" + digito2);
            Console.WriteLine("El número descifrado es {0:D4}", Numero);
        }

        public void SepararDigitos(int numero)
        {
            digito1 = numero / 1000 % 10;
            digito2 = numero / 100 % 10;
            digito3 = numero / 10 % 10;
            digito4 = numero / 1 % 10;
        }
    }
}
