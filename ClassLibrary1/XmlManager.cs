using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using ClassLibrary1;

public class XmlManager : IArchivos
{
    public bool Guardar(List<Barco> barcos, string ruta)
    {
        try
        {
            Console.WriteLine($"Intentando guardar en la ruta: {ruta}");

            if (string.IsNullOrEmpty(ruta))
            {
                Console.WriteLine("La ruta es nula o está vacía.");
                return false;
            }

            string directory = Path.GetDirectoryName(ruta);
            Console.WriteLine($"Nombre del directorio obtenido: {directory}");

            if (directory == null)
            {
                Console.WriteLine("El directorio es nulo.");
                return false;
            }

            if (!Directory.Exists(directory))
            {
                Console.WriteLine($"Directorio no existe, creando: {directory}");
                Directory.CreateDirectory(directory);
            }

            // Leer la lista existente de barcos
            List<Barco> barcosExistentes = Leer(ruta);

            // Agregar los nuevos barcos a la lista existente
            barcosExistentes.AddRange(barcos);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Barco>));
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                serializer.Serialize(writer, barcosExistentes);
                writer.Close();
            }

            Console.WriteLine($"Archivo XML guardado en: {ruta}"); // Mensaje de depuración
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar XML: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            return false;
        }
    }

    public List<Barco> Leer(string ruta)
    {
        try
        {
            if (!File.Exists(ruta))
            {
                Console.WriteLine("El archivo no existe.");
                return new List<Barco>();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Barco>));
            using (StreamReader reader = new StreamReader(ruta))
            {
                return (List<Barco>)serializer.Deserialize(reader);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el archivo XML: {ex.Message}");
            return new List<Barco>();
        }
    }
}
