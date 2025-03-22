using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORIENTACION_A_OBJETOS.Interfaz;

namespace ORIENTACION_A_OBJETOS.MisClases
{
    internal class chofer : IPiloto 
 {
        
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoLicencia { get; set; }

        public chofer(string nombre, int edad, string tipoLicencia)
        {
            Nombre = nombre;
            Edad = edad;
            TipoLicencia = tipoLicencia;
        }
        public void MostrarInfo()
        {
            Console.WriteLine("El nombre del piloto es: {0}", Nombre);
            Console.WriteLine("La edad del piloto es: {0}", Edad);
            Console.WriteLine("Tipo de Licencia: {0}", TipoLicencia);
        }




    }
}
