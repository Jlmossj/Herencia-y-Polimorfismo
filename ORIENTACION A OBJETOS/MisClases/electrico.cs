using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Electrico : Vehiculo
    {
    
        private int bateria;
        public Electrico(int año, string elColor, string elModelo) : base (año, elColor, elModelo)
        {
        bateria = 50;
        }
        public int cargarBateria()
        { return bateria; }
        public void cargarBateria(int cuanto)
        {
            bateria += cuanto;
            if (bateria > 100)
            {
                bateria = 100;
            }
            Console.WriteLine("Bateria cargada al " + cuanto + "%");
        }
    
    public override void acelerar(int cuanto)

        {
          base.acelerar(cuanto);
            cargarBateria(-1);
        }

    }
}
