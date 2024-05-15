using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ej01.Archivos
{
    public class Orden // si tengo una clase orden tengo que tener un archivo ordenes
    {
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        // algún dato que identifique unívocamente al cliente
        public string ClienteCUIT { get; set; }
    }
}
