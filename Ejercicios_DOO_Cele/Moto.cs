using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Moto : Vehiculo
    {
        protected int cilindrada { get; set; }

        public int GetCilindrada() => cilindrada;
        public void SetCilindrada(int CILINDRADA) => cilindrada = CILINDRADA;

        public Moto() { }
        public Moto(int id, string marca, string modelo, int anio, int cilindrada) : base (id, marca, modelo, anio)
        {
            this.cilindrada = cilindrada;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Cilindrada: {this.cilindrada}");
        }
    }
}
