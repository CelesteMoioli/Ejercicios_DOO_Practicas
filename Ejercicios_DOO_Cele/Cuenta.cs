using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Cuenta
    {
        protected int NumCuenta { get; set; }
        protected string titular { get; set; }
        protected double saldo { get; set; } = 0.00;
        public Cuenta()
        {
        }
        public Cuenta(int numCuenta, string titular)
        {
            this.NumCuenta = numCuenta;
            this.titular = titular;
        }
        public virtual void mostrarInfo()
        {
            Console.WriteLine($"Cuenta N°: {NumCuenta}, Titular: {titular}, Saldo: {saldo}");
        }
        public virtual void depositar(double deposito)
        {
            if (deposito > 0)
            {
                this.saldo += deposito;
            }
            else
            {
                Console.WriteLine("El monto a depositar debe ser mayor a cero");
            }
        }

        public virtual void Extraccion(double monto)
        {
            if (monto > 0 && monto <= this.saldo)
            {
                this.saldo -= monto;
            }
            else
            {
                Console.WriteLine("El monto a retirar debe ser mayor a cero y no puede exceder el saldo disponible.");
            }

        }
        public virtual void ActualizarSaldo() { }
    }



}
