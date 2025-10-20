using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class EmpleadoPermanente : Empleado
    {
        protected int Antiguedad { get; set; }
        protected double Extra { get; set; }

        public EmpleadoPermanente() { }
        public EmpleadoPermanente(int id, string nombre, string Apellido, double sueldo, int Antiguedad, double extra): base (id, nombre, Apellido, sueldo)
        {
            this.Antiguedad = Antiguedad;
            this.Extra = extra;

        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Años de antiguedad: {Antiguedad}");
        }
        public override double CalculoSueldo()
        {
            return this.Extra * this.Antiguedad + base.CalculoSueldo();
        }
    }
}
