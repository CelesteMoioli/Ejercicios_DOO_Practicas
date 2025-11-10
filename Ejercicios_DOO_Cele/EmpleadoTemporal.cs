using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class EmpleadoTemporal : Empleado
    {
        protected int DiasTrabajados { get; set; }
        protected double PagoxHora { get; set; } = 500000.00;

        public int GethorasTrabajadas() => DiasTrabajados;
        public void SethorasTrabajadas(int DDiasTrabajados) => DiasTrabajados = DDiasTrabajados;

        public EmpleadoTemporal() { }
        public EmpleadoTemporal(int id, string nombre, string Apellido, double sueldo, int DiasTrabajados, double pagoxhora) : base (id, nombre, Apellido, sueldo)
        {
            this.DiasTrabajados = DiasTrabajados;
            this.PagoxHora = pagoxhora;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Dias Trabajados: {DiasTrabajados},Valor de la hora: ${PagoxHora}");
        }
        public override double CalculoSueldo()
        {
            return DiasTrabajados * PagoxHora;
        }
    }
}
