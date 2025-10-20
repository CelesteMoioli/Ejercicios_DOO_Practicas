using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Auto : Vehiculo
    {
        protected int cantidadPuertas {  get; set; }
        protected string color {  get; set; }

        public Auto() { }
        public Auto(int id, string marca, string modelo,int anio, int cantPuertas, string color) : base (id, marca, modelo, anio)
        {
            this.cantidadPuertas = cantPuertas;
            this.color = color;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Cantidad de puertas: {this.cantidadPuertas}, Color: {this.color}");
        }
    }
}
