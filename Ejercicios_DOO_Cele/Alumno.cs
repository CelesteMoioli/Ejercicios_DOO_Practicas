using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Alumno : Persona
    {
        protected int Legajo { get; set; }
        protected double Promedio { get; set; }

        public int Getlegajo() => Legajo;
        public double Getpromedio() => Promedio;

        public void Setlegajo(int Legajo) => Legajo = Legajo;
        public void Setpromedio(int PPromedio) => Promedio = PPromedio;
        public Alumno() { }
        public Alumno(int id, string nombre, int edad, int legajo, double promedio) : base(id, nombre, edad)
        {
            this.Legajo = legajo;
            this.Promedio = promedio;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Legajo N°: {Legajo}, PROMEDIO: {Promedio}");
        }
    }
}
