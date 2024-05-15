using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EstructuraDeDatos.Ej01.Archivos
{
    public static class ArchivoPersonas // no puedo crear instancias de esta clase, es estática
                                        // maneja al archivo en su conjunto
    {
        public static ReadOnlyCollection<Persona> Personas => personas.AsReadOnly(); // para mostrar la lista
        
        private static List<Persona> personas; // tiene una lista de personas

        static ArchivoPersonas()
        {
            if (File.Exists(@"Datos\personas.json")) // si existe este archivo
            {
                // lee y transforma el contenido del archivo personas.json en objetos
                var contenido = File.ReadAllText(@"Datos\personas.json");
                personas = JsonConvert.DeserializeObject<List<Persona>>(contenido);
            }
            else
            {
                personas = new List<Persona>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(personas);
            File.WriteAllText(@"Datos\personas.json", contenido); // 2 parámetros: dónde lo quiero escribir, qué quiero escribir
        }

        // TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA a través de métodos

        public static void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public static void EliminarPersona(int documento)
        {
            Persona personaABorrar = null;
            foreach (var persona in personas)
            {
                if (persona.Documento == documento)
                {
                    personaABorrar = persona;
                    break;
                }
            }

            personas.Remove(personaABorrar);
        }

        public static void ModificarPersona(Persona personaAModificar, Persona nuevosDatos)
        {
            personaAModificar.Documento = nuevosDatos.Documento;
        }
    }
}
