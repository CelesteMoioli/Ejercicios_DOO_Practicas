using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Empleado
    {
        protected int Id {  get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected double SueldoBase { get; set; }

        public Empleado() { }
        public Empleado (int id, string nombre, string Apellido, double sueldo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = Apellido;
            this.SueldoBase = sueldo;
        }
        public virtual double CalculoSueldo()
        {
            return SueldoBase;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Los datos del empleado son:\nId: {Id}, Nombre y apellido: {Nombre} {Apellido}, Sueldo base: ${CalculoSueldo}");
        }
    }
}
