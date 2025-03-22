using System;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Camion : Vehiculo
    {
       
        private double capacidadCarga;
        private int numeroEjes; 
  
        public Camion(int año, string elColor, string elModelo, double capacidadCarga, int numeroEjes)
            : base(año, elColor, elModelo)
        {
            this.capacidadCarga = capacidadCarga;
            this.numeroEjes = numeroEjes;
        }

        
        public double ObtenerCapacidadCarga()
        {
            return capacidadCarga;
        }

        public int ObtenerNumeroEjes()
        {
            return numeroEjes;
        }

        public void CargarMercancia(double peso)
        {
            if (peso <= capacidadCarga)
            {
                Console.WriteLine($"Mercancía cargada: {peso} toneladas.");
            }
            else
            {
                Console.WriteLine($"¡Advertencia! El camión no puede cargar {peso} toneladas. Capacidad máxima: {capacidadCarga} toneladas.");
            }
        }

        public new void InformacionVehiculo()
        {
            base.InformacionVehiculo(); 
            Console.WriteLine($"Capacidad de carga: {capacidadCarga} toneladas, Número de ejes: {numeroEjes}");
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            Console.WriteLine("El camión acelera lentamente debido a su peso.");
        }
    }
}