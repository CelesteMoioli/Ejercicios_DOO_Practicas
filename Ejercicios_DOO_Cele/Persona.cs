using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Persona
    {
        protected int Id {  get; set; }
        protected string Nombre { get; set; }
        protected int Edad { get; set; }
        public Persona() { }
        public Persona(int id, string nombre, int edad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Datos personales:\nId: {Id}, Nombre: {Nombre}, Edad: {Edad}");
        }
    }
    
}
