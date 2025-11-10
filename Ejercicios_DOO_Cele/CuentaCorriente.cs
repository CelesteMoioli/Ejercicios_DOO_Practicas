using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class CuentaCorriente : Cuenta
    {
        private double limiteDescubierto;

        public double GetLimiteDescubierto() => limiteDescubierto;
        public void SetLimiteDescubierto(double limite) => limiteDescubierto = limite;

        public CuentaCorriente(int numeroCuenta, string titular, double limiteDescubierto): base(numeroCuenta, titular)
        {
            this.limiteDescubierto = limiteDescubierto;
        }

        public override void Extraccion(double monto)
        {
            if (monto > 0 && saldo - monto >= -limiteDescubierto)
            {
                saldo -= monto;
                Console.WriteLine($"Extraccion realizada - Nuevo saldo: ${saldo}");
            }
            else
            {
                Console.WriteLine("No se puede realizar la extraccion. Supera el limite de descubierto");
            }
        }

        public override void mostrarInfo()
        {
            Console.WriteLine($"Cuenta Corriente N°: {NumCuenta}, Titular: {titular}, Saldo: ${saldo}, Limite descubierto: ${limiteDescubierto}");
        }

    }
}
