using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Camion : Vehiculo
    {
        protected int CapacidadCarga { get; set; }

        public Camion() { }
        public Camion(int id, string marca, string modelo, int anio, int capacidadcarga) : base (id, marca, modelo, anio)
        {
            this.CapacidadCarga = capacidadcarga;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga}");
        }
    }
}
