using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Producto
    {
        protected int Id { get; set; }
        protected string Nombre { get; set; }
        protected double PrecioBase { get; set; }


        public int GetId() => Id;
        public string GetNombre() => Nombre;

        public double GetPrecioBase() => PrecioBase;

        public void SetId(int id) => Id = id;
        public void SetNombre(string NNombre) => Nombre = NNombre;

        public void SetPrecioBase(double PBASE) => PrecioBase = PBASE;

        public Producto() { }
        public Producto (int id, string nombre, double precioBase)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.PrecioBase = precioBase;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Datos del producto:\nId: {Id}, Nombre: {Nombre}, Precio base: ${PrecioBase}");
        }
    }
}
