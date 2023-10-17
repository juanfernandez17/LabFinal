using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Persona
    {
        private string usuario;
        private string contrasenia;
        static ADO baseDeDatos;

        static Administrador()
        {
            Administrador.baseDeDatos = new ADO();
        }
        public Administrador()
        {

        }
        public Administrador(int id, int idVeterinaria, string nombre, string apellido, int dni, string usuario, string contrasenia) : base(id, idVeterinaria, nombre, apellido, dni)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }
        public string Usuario { get => this.usuario; set => this.usuario = value; }
        public string Contrasenia { get => this.contrasenia; set => this.contrasenia = value; }

        public static bool operator ==(Administrador a, Administrador b)
        {
            return ((Persona)a).Id == b.Id;
        }
        public static bool operator !=(Administrador a, Administrador b)
        {
            return !(a == b);
        }
       

    }
}
