using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ej01.Archivos
{
    internal class ArchivoOrdenes
    {
        public static ReadOnlyCollection<Orden> Ordenes => ordenes.AsReadOnly(); // para mostrar la lista

        private static List<Orden> ordenes; // tiene una lista de personas

        static ArchivoOrdenes()
        {
            if (File.Exists(@"Datos\ordenes.json")) // si existe este archivo
            {
                // lee y transforma el contenido del archivo personas.json en objetos
                var contenido = File.ReadAllText(@"Datos\ordenes.json");
                ordenes = JsonConvert.DeserializeObject<List<Orden>>(contenido);
            }
            else
            {
                ordenes = new List<Orden>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenes);
            File.WriteAllText(@"Datos\ordenes.json", contenido); // 2 parámetros: dónde lo quiero escribir, qué quiero escribir
        }

        // TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA a través de métodos
    }
}
