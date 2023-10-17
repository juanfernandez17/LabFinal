using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Veterinaria
    {
        private int id;
        private string nombre;
        private static int capacidad;
        private List<Persona> listaClientes;
        private List<Mascota> listaMascotas;

        static Veterinaria()
        {
            Veterinaria.capacidad = 500;
        }
        public Veterinaria()
        {
            this.listaMascotas = new List<Mascota>();
            this.listaClientes = new List<Persona>();
        }
        public Veterinaria(string nombre, int id) : this()
        {
            this.nombre = nombre;
            this.id = id;
        }
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public int Capacidad { get => Veterinaria.capacidad; set => Veterinaria.capacidad = value; }
        public List<Persona> ListaClientes { get => this.listaClientes; set => this.listaClientes = value; }
        public List<Mascota> ListaMascotas { get => this.listaMascotas; set => this.listaMascotas = value; }

        public static bool operator ==(Veterinaria a, Veterinaria b)
        {
            return a.id == b.id;
        }
        public static bool operator !=(Veterinaria a, Veterinaria b)
        {
            return !(a == b);
        }
        public static bool operator ==(Veterinaria v, Persona p)
        {
            bool aux = false;

            foreach (Persona item in v.listaClientes)
            {
                if (item == p)
                {
                    aux = true;
                    break;
                }
            }
            return aux;
        }
        public static bool operator !=(Veterinaria v, Persona p)
        {
            return !(v == p);
        }

        public static Veterinaria operator +(Veterinaria v, Persona p)
        {
            if (v != p)
            {
                v.listaClientes.Add(p);
            }
            else
            {
                Console.WriteLine("Error, el cliente ya esta asociada a la veterinaria.");
            }
            return v;
        }
        public static Veterinaria operator -(Veterinaria v, Persona p)
        {
            if (v == p)
            {
                v.listaClientes.Remove(p);
            }
            else
            {
                Console.WriteLine("Error, el cliente no se encuentra en la lista de la veterinari.");
            }
            return v;
        }
        public static bool operator ==(Veterinaria v, Mascota m)
        {
            bool aux = false;

            foreach (Mascota item in v.listaMascotas)
            {
                if (item == m)
                {
                    aux = true;
                    break;
                }
            }
            return aux;
        }
        public static bool operator !=(Veterinaria v, Mascota m)
        {
            return !(v == m);
        }

        public static Veterinaria operator +(Veterinaria v, Mascota m)
        {
            if (v != m)
            {
                v.listaMascotas.Add(m);
            }
            else
            {
                Console.WriteLine("Error, la mascota ya esta asociada a la veterinaria.");
            }
            return v;
        }
        public static Veterinaria operator -(Veterinaria v, Mascota m)
        {
            if (v == m)
            {
                v.listaMascotas.Remove(m);
            }
            else
            {
                Console.WriteLine("Error, la mascota no se encuentra en la lista de la veterinari.");
            }
            return v;
        }

        public string InformacionCompleta()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Veterinaria: {this.Nombre}");
            sb.Append($"\nCapacidad: {this.Capacidad}");
            sb.Append($"\nLista clientes: \n\n");

            foreach (Persona item in this.ListaClientes)
            {
                sb.Append("----------------------------\n");
                sb.Append($"ID: {item.Id}");
                sb.Append($"\nNombre: {item.Nombre}");
                sb.Append($"\nApellido: {item.Apellido}");
                sb.Append($"\nDNI: {item.Dni}");
                sb.Append($"\nLista de mascotas:\n\n");

                foreach (Mascota mascota in item.ListaMascotas)
                {
                    sb.Append($"\tID: {mascota.Id}");
                    sb.Append($"\n\tNombre: {mascota.Nombre}");
                    sb.Append($"\n\tEdad: {mascota.Edad}");
                    sb.Append($"\n\tVacunado: ");

                    if (mascota.Vacuna)
                    {
                        sb.Append("si");
                    }
                    else
                    {
                        sb.Append("no");
                    }
                    sb.Append("\n\n");
                }
            }
            return sb.ToString();
        }

        public string MostrarMascotas()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Mascota mascota in this.ListaMascotas)
            {
                sb.Append($"\tID: {mascota.Id}");
                sb.Append($"\n\tNombre: {mascota.Nombre}");
                sb.Append($"\n\tEdad: {mascota.Edad}");
                sb.Append($"\n\tVacunado: ");

                if (mascota.Vacuna)
                {
                    sb.Append("si");
                }
                else
                {
                    sb.Append("no");
                }
                sb.Append("\n\n");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return InformacionCompleta();
        }
        public static explicit operator int(Veterinaria v)
        {
            return v.Capacidad;
        }
        public static implicit operator string(Veterinaria v)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Veterinaria: {v.Nombre}");
            
            return sb.ToString();
        }

        public int BuscarClientePorId(int id)
        {
            int aux = -1;

            for(int i = 0; i < this.listaClientes.Count; i++)
            {
                if (this.listaClientes[i].Id == id)
                {
                    aux = i;
                    break;
                }
            }
            return aux;
        }
    }
}
