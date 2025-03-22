using System;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        
        private string tipo; 
        private bool tieneMaletas;

        public Motocicleta(int año, string elColor, string elModelo, string tipo, bool tieneMaletas)
            : base(año, elColor, elModelo)
        {
            this.tipo = tipo;
            this.tieneMaletas = tieneMaletas;
        }

        public string ObtenerTipo()
        {
            return tipo;
        }

        public bool TieneMaletas()
        {
            return tieneMaletas;
        }

        public void HacerCaballito()
        {
            Console.WriteLine("La motocicleta está haciendo un caballito");
        }

       
        public new void InformacionVehiculo()
        {
            base.InformacionVehiculo();
            Console.WriteLine($"Tipo de manillar: {tipo}, Tiene maletas: {(tieneMaletas ? "Sí" : "No")}");
        }

       
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            Console.WriteLine("La motocicleta acelera rápidamente.");
        }
    }
}