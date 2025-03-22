using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class AutoCombustion : Vehiculo
    {
        private int combustible; 

        public AutoCombustion(int año, string elColor, string elModelo) : base(año, elColor, elModelo)
        {
            combustible = 100; 
        }

   
        public int ObtenerCombustible()
        {
            return combustible;
        }

        public void ConsumirCombustible(int cuanto)
        {
            combustible -= cuanto;
            if (combustible < 0)
            {
                combustible = 0; 
            }
            Console.WriteLine("Combustible consumido. Nivel actual: " + combustible + "%");
        }

       
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto); 
            ConsumirCombustible(5); 
        }
    }
}