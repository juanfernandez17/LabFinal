using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static Entidades.Archivo;

namespace Entidades
{
    public class ArchivoGeneric<T> : JSON<T>, XML<T>
    {
        private static string path;
        public delegate bool SerializarDatos(T dato, string path);
        public delegate T DeserializarDatos(string path);

        static ArchivoGeneric()
        {
            ArchivoGeneric<T>.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ArchivoGeneric<T>.path += @"/TestGeneric/";
        }
        public ArchivoGeneric()
        {
            SerializarDatos delegadoSerializarDatos = new SerializarDatos(SerializarGeneric);
            delegadoSerializarDatos += ((XML<T>)this).SerializarGeneric;
            DeserializarDatos delegadoDeserializarDatos = new DeserializarDatos(DeserializarGeneric);
            delegadoDeserializarDatos += ((XML<T>)this).DeserializarGeneric;
        }
        // Lectura archivo generic TXT
        public string LeerArchivoGeneric(string path)
        {
            string aux = "";

            try
            {
                using (StreamReader reader = new StreamReader(ArchivoGeneric<T>.path + path))
                {
                    aux = reader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return aux;
        }
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

        // Serializacion JSON Generic
        public bool SerializarGeneric(T dato, string path)
        {
            bool aux;
            try
            {
                using (StreamWriter sw = new StreamWriter(ArchivoGeneric<T>.path + path + ".json"))
                {
                    string jsonString = JsonSerializer.Serialize(dato);
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

        // Deserializacion JSON Generic
        public T DeserializarGeneric(string path)
        {
            T obj = default(T);

            try
            {
                using (StreamReader sr = new StreamReader(ArchivoGeneric<T>.path + path + ".json"))
                {
                    string json_str = sr.ReadToEnd();
                    obj = (T)JsonSerializer.Deserialize(json_str, typeof(T));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }

        // Serializacion XML Generic - Interface 
        bool XML<T>.SerializarGeneric(T dato, string path)
        {
            bool aux;
            try
            {
                using(XmlTextWriter writer = new XmlTextWriter(ArchivoGeneric<T>.path + path + ".json", System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, dato);
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

        // Deserializacion XML Generic - Interface
        T XML<T>.DeserializarGeneric(string path)
        {
            T obj = default(T);

            try
            {
                using(XmlTextReader reader = new XmlTextReader(ArchivoGeneric<T>.path + path + ".json"))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    obj = (T)ser.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }
    }

    
}
