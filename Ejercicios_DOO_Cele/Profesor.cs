using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Profesor: Persona
    {
        protected string Materia { get; set; }
        protected double Sueldo { get; set; }
        public Profesor() { }
        public Profesor(int id, string nombre, int edad, string Materia, double sueldo, double promedio) : base(id, nombre, edad)
        {
            this.Materia = Materia;
            this.Sueldo = sueldo;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Materia a cargo: {Materia}, Sueldo: {Sueldo}");
        }
    }
}
