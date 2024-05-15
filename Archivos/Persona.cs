using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ej01.Archivos
{
    public class Persona // entidad, es una clase que representa los datos grabados en un archivo
                         // no hace referencia a datos que no posee
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<PersonaTelefono> Telefonos { get; set; } = new(); // un telefono por cada persona
                                                             // no dejar que una lista sea nula

        // abajo van todas las operaciones que involucran los datos de arriba

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
        }
        
        public int Edad() // método que devuelve la edad
        {
            // código que calcula la edad a partir de FechaNacimiento
            return 5;
        }
    }
}
