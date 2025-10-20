using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class ProductoElectronico : Producto
    {
        protected int MesesGarantia { get; set; }
        public ProductoElectronico() { }
        public ProductoElectronico(int id, string nombre, double precioBase,int MesesGarantia) : base(id, nombre, precioBase)
        {
            this.MesesGarantia = MesesGarantia; 
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Meses de Garantia: {MesesGarantia}");
        }
        
    }
}
