using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._18
{
    class Cliente
    {
        public int NumeroDeCuenta { get; set; }
        public decimal SaldoInicioMes { get; set; }
        public int TotalArticulosEnElMes { get; set; }
        public decimal TotalCreditosAplicadosEnElMes { get; set; }
        public decimal LimiteDeCredito { get; set; }

        public Cliente(int cuenta, int saldoInicial, int totalArticulos, int totalCreditos, decimal credito)
        {
            NumeroDeCuenta = cuenta;
            SaldoInicioMes = saldoInicial;
            TotalArticulosEnElMes = totalArticulos;
            TotalCreditosAplicadosEnElMes = totalCreditos;
            LimiteDeCredito = credito;
        }

        //Método que imprime todas las variables
        public void Balance()
        {
            Console.WriteLine("\nCliente: {0,13:D2}\nSaldo: {1,18:C}\nArtículos cargados: {2:C}\nCréditos aplicados: {3:C}\nLímite de crédito: {4,4:C}",
                NumeroDeCuenta,SaldoInicioMes, TotalArticulosEnElMes, TotalCreditosAplicadosEnElMes, LimiteDeCredito);

            CreditoExcedido();
        }

        //Método que indica si el cliente se exedió
        public void CreditoExcedido()
        {
            SaldoInicioMes = SaldoInicioMes + TotalArticulosEnElMes - TotalCreditosAplicadosEnElMes;

            if (LimiteDeCredito < SaldoInicioMes)
            {
                Console.WriteLine("Se excedió el limite de su crédito.");
            }

        }
    }
}
