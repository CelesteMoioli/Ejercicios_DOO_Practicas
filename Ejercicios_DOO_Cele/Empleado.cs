using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios_DOO_Cele
{
    internal class Empleado
    {
        protected int Id {  get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected double SueldoBase { get; set; }


        public int GetId() => Id;
        public string GetNombre() => Nombre;
        public string GetApellido() => Apellido;
        public double GetSueldoBase() => SueldoBase;

        public void SetId(int id) => Id = id;
        public void SetNombre(string NNombre) => Nombre = NNombre;
        public void SetApellido(string AApellido) => Apellido = AApellido;
        public void SetSueldoBase(double sueldo) => SueldoBase = sueldo;
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
