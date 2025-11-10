using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class ProductoAlimenticio : Producto
    {
        protected DateTime FechaVencimiento {  get; set; }
        public ProductoAlimenticio() { }
        public ProductoAlimenticio(int id, string nombre, double precioBase, DateTime fechavencimiento) : base(id, nombre, precioBase)
        {
            this.FechaVencimiento = fechavencimiento;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Fecha de Vencimiento: {FechaVencimiento}");
        }
    }
}
