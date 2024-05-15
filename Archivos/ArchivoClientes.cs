using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ej01.Archivos
{
    internal class ArchivoClientes
    {
        public static ReadOnlyCollection<Cliente> Clientes => clientes.AsReadOnly(); // para mostrar la lista

        private static List<Cliente> clientes; // tiene una lista de personas

        static ArchivoClientes()
        {
            if (File.Exists(@"Datos\clientes.json")) // si existe este archivo
            {
                // lee y transforma el contenido del archivo personas.json en objetos
                var contenido = File.ReadAllText(@"Datos\clientes.json");
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(contenido);
            }
            else
            {
                clientes = new List<Cliente>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(clientes);
            File.WriteAllText(@"Datos\clientes.json", contenido); // 2 parámetros: dónde lo quiero escribir, qué quiero escribir
        }

        // TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA a través de métodos
    }
}
