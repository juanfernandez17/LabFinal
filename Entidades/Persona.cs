using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private int idVeterinaria;
        private string nombre;
        private string apellido;
        private int dni;
        private List<Mascota> listaMascotas;

        public Persona()
        {

        }
        public Persona(int id, int idVeterinaria, string nombre, string apellido, int dni)
        {
            this.id = id;
            this.idVeterinaria = idVeterinaria;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.listaMascotas = new List<Mascota>();
        }
        public int Id { get => this.id; set => this.id = value; }
        public int IdVeterinaria { get => this.idVeterinaria; set => this.idVeterinaria = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }
        public int Dni { get => this.dni; set => this.dni = value; }
        public List<Mascota> ListaMascotas { get => this.listaMascotas; set => this.listaMascotas = value; }

        public static bool operator ==(Persona a, Persona b)
        {
            return a.Dni == b.Dni;
        }
        public static bool operator !=(Persona a, Persona b)
        {
            return !(a == b);
        }
        public static bool operator ==(Persona p, Mascota m)
        {
            bool aux = false;

            foreach (Mascota item in p.listaMascotas)
            {
                if (item == m)
                {
                    aux = true;
                    break;
                }
            }
            return aux;
        }
        public static bool operator !=(Persona p, Mascota m)
        {
            return !(p == m);
        }

        public static Persona operator +(Persona p, Mascota m)
        {
            if(p != m)
            {
                p.listaMascotas.Add(m);
                Console.WriteLine("Se agrego la mascota a la persona.");
            }
            else
            {
                Console.WriteLine("Error, la mascota ya esta asociada a la persona.");
            }
            return p;
        }
        public static Persona operator -(Persona p, Mascota m)
        {
            if(p == m)
            {
                p.listaMascotas.Remove(m);
                Console.WriteLine("Se desasocio la mascota de la persona");
            }
            else
            {
                Console.WriteLine("Error, la mascota no se encuentra en la lista de la persona.");
            }
            return p;
        }
        private string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"\nId: {this.Id}");
            sb.Append($"\nId veterinaria: {this.IdVeterinaria}");
            sb.Append($"\nNombre: {this.Nombre}");
            sb.Append($"\nApellido: {this.Apellido}");
            sb.Append($"\nDNI: {this.Dni}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Informacion();
        }

    }
}
