using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class CajaAhorro : Cuenta
    {
        private double tasaInteres;

        public CajaAhorro(int numeroCuenta, string titular, double tasaInteres): base(numeroCuenta, titular)
        {
            this.tasaInteres = tasaInteres;
        }

        public override void ActualizarSaldo()
        {
            double interes = saldo * (tasaInteres / 100);
            saldo += interes;
            Console.WriteLine($"Interes aplicado: ${interes} - Nuevo saldo: ${saldo}");
        }

        public override void mostrarInfo()
        {
            Console.WriteLine($"Caja de Ahorro N°: {NumCuenta}, Titular: {titular}, Saldo: ${saldo:F2}, Tasa de interes: %{tasaInteres}");
        }

    }
}
