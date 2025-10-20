namespace Ejercicios_DOO_Cele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                List<Vehiculo> vehiculoss = new List<Vehiculo>();

                vehiculoss.Add(new Auto(1, "Ford", "208", 2015, 4, "rojo"));
                vehiculoss.Add(new Moto(2, "Ford", "208", 2015, 4, "rojo"));
                vehiculoss.Add(new Camion(3, "Ford", "208", 2015, 4, "rojo"));


                foreach (Vehiculo e in vehiculoss)
                {
                    e.MostrarInfo();
                }


            }
        }
    }
}
