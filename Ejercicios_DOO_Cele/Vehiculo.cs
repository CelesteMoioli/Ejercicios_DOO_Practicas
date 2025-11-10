using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios_DOO_Cele
{
    internal class Vehiculo
    {
        protected int Id {get; set;}
        protected string Marca { get; set;}
        protected string Modelo {  get; set;}
        protected int Anio { get; set;}


        public int GetIdVehiculo() => Id;
        public void SetIdVehiculo(int id) => Id = id;

        public string GetMarca() => Marca;
        public void SetMarca(string valor) => Marca = valor;

        public string GetModelo() => Modelo;
        public void SetModelo(string valor) => Modelo = valor;

        public int GetAnio() => Anio;
        public void SetAnio(int valor) => Anio = valor;

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
