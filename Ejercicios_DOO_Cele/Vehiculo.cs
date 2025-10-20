using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Vehiculo
    {
        protected int Id {get; set;}
        protected string Marca { get; set;}
        protected string Modelo {  get; set;}
        protected int Anio { get; set;}

        public Vehiculo() { }
        public Vehiculo (int id, string marca, string modelo, int anio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
        }
        
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Datos del vehiculo:\nId: {Id}, Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}");
        }
    }
}
