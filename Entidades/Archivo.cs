using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Archivo
    {
        public static string path;
        public delegate bool GuardarDatos(Veterinaria v, string path);
        

        static Archivo()
        {
            Archivo.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Archivo.path += @"/Test/";
        }

        // Leer archivo txt
        public string LeerArchivo(string path)
        {
            string aux = "";

            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(Archivo.path + path))
                    {
                        aux = reader.ReadToEnd();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return aux;
        }

        // Escribir archivo txt
        public bool EscribirArchivo(Veterinaria veterinaria, string path)
        {
            bool aux;
            try
            {
                using (StreamWriter sw = new StreamWriter(Archivo.path + path, false)) // Append false
                {
                    sw.Write($"Veterinaria: {veterinaria.Nombre}\n");
                    sw.Write("Lista de clientes:\n\n");

                    foreach (Persona item in veterinaria.ListaClientes)
                    {
                        sw.Write("----------------------------\n");
                        sw.Write($"ID: {item.Id}");
                        sw.Write($"\nNombre: {item.Nombre}");
                        sw.Write($"\nApellido: {item.Apellido}");
                        sw.Write($"\nDNI: {item.Dni}");
                        sw.Write($"\nLista de mascotas:\n\n");

                        foreach (Mascota mascota in item.ListaMascotas)
                        {
                            sw.Write($"\tID: {mascota.Id}");
                            sw.Write($"\n\tNombre: {mascota.Nombre}");
                            sw.Write($"\n\tEdad: {mascota.Edad}");
                            sw.Write($"\n\tVacunado: ");

                            if (mascota.Vacuna)
                            {
                                sw.Write("si");
                            }
                            else
                            {
                                sw.Write("no");
                            }
                            sw.Write("\n\n");
                        }
                    }                                                               
                    aux = true;
                }
            }
            catch (Exception)
            {
                aux = false;
                throw;
            }
            return aux;
        }

        // Serializar JSON
        public bool SerializarJSON(Veterinaria v, string path)
        {
            bool aux;

            try
            {
                using (StreamWriter sw = new StreamWriter(Archivo.path + path))
                {
                    string jsonString = JsonSerializer.Serialize(v);
                    sw.WriteLine(jsonString);
                    aux = true;
                }
            }
            catch (Exception)
            {
                aux = false;
                throw;
            }
            return aux;
        }

        // Deserializar JSON
        public Veterinaria DeserializarJSON(string path)
        {
            Veterinaria v;
            v = default(Veterinaria);

            try
            {
                using (StreamReader reader = new StreamReader(Archivo.path + path))
                {
                    string json_str = reader.ReadToEnd();
                    v = (Veterinaria)JsonSerializer.Deserialize(json_str, typeof(Veterinaria));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return v;
        }

        // Serializar XML
        public bool SerializarXML(Veterinaria v, string path)
        {
            bool aux;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(Archivo.path + path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Veterinaria));
                    ser.Serialize(writer, v);
                    aux = true;
                }
            }
            catch (Exception)
            {
                aux = false;
                throw;
            }
            return aux;
        }

        // Deserializar XML
        public Veterinaria DeserializarXML(string path)
        {
            Veterinaria v;
            v = default(Veterinaria);

            try
            {
                using(XmlTextReader reader = new XmlTextReader(Archivo.path + path))
                {
                    XmlSerializer ser = new XmlSerializer (typeof(Veterinaria));
                    v = (Veterinaria)ser.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return v;
        }
    }
}