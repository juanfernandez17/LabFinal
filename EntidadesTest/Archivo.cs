using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace EntidadesTest
{
    public class Archivo<T> : JSON<T>, XML<T>
    {
        public static string path;
        public delegate bool DelegadoSerializarDatos(T dato, string path);
        public delegate T DelegadoDeserializarDatos(string path);
        public DelegadoSerializarDatos delegadoSerializarDatos;
        public DelegadoDeserializarDatos delegadoDeserializarDatos;

        static Archivo()
        {
            Archivo<T>.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Archivo<T>.path += @"/NuevoTest/";
        }
        public Archivo()
        {
            delegadoSerializarDatos = new DelegadoSerializarDatos(SerializarGeneric);
            delegadoSerializarDatos += ((XML<T>)this).SerializarGeneric;
            delegadoDeserializarDatos = new DelegadoDeserializarDatos(DeserializarGeneric);
            delegadoDeserializarDatos += ((XML<T>)this).DeserializarGeneric;
        }
        public bool SerializarGeneric(T dato, string path)
        {
            bool aux;
            try
            {
                using (StreamWriter sw = new StreamWriter(Archivo<T>.path + path + ".json"))
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
        public T DeserializarGeneric(string path)
        {
            T obj = default(T);

            try
            {
                using (StreamReader sr = new StreamReader(Archivo<T>.path + path + ".json"))
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
        bool XML<T>.SerializarGeneric(T dato, string path)
        {
            bool aux;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(Archivo<T>.path + path + ".xml", System.Text.Encoding.UTF8))
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
                using (XmlTextReader reader = new XmlTextReader(Archivo<T>.path + path + ".xml"))
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
