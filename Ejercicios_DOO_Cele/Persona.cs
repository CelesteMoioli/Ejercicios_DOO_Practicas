using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios_DOO_Cele
{
    internal class Persona
    {
        protected int Id {  get; set; }
        protected string Nombre { get; set; }
        protected int Edad { get; set; }


        public int GetId() => Id;
        public string GetNombre() => Nombre;
        public int GetEdad() => Edad;

        public void SetNombre(string NNombre) => Nombre = NNombre;
        public void SetEdad(int EEdad) => Edad = EEdad;


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
