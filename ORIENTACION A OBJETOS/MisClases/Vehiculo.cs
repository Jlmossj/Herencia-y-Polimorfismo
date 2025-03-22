using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }
        private int velocidad = 0;

        public Vehiculo(int año, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = año;
        }
      
        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
        }

        public string encender()
        {
            if (piloto == null)
            {
                return "No se puede encender el vehiculo sin un piloto";
            }
            
           
            if (estadovehiculo == 0)
            {
                estadovehiculo = 1;
                return "Vehiculo encendido";
            }
            return "Vehiculo ya encendido";



        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a " + cuanto + " km/h");
        }
        
        protected List<string> TiposDeLicenciaAceptados = new List<string> { "A", "B", "C" };
        private chofer piloto = null;
        private int estadovehiculo = 0; 
        public string AsignarPiloto (chofer elPiloto)
        {
            if (piloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (!TiposDeLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene la licencia adecuada";
            }
            if (piloto != null)
            {
                return "Piloto ya asignado";
            }
            piloto = elPiloto;
            {
                
                return "Piloto asignado exitosamente";
            }
        }

    }
}