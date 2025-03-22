using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORIENTACION_A_OBJETOS.Interfaz
{
    internal interface IPiloto
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        string TipoLicencia { get; set; }
        void MostrarInfo();
    }
}
