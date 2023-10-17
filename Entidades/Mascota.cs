using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascota
    {
        private int id;
        private int idVeterinaria;
        private int idDuenio;
        private string nombre;
        private bool vacuna;
        private int edad;

        public Mascota()
        {

        }
        public Mascota(int id, int idDuenio, string nombre, bool vacuna, int edad)
        {
            this.id = id;
            this.idDuenio = idDuenio;
            this.nombre = nombre;
            this.vacuna = vacuna;
            this.edad = edad;
        }
        public int Id { get => this.id; set => this.id = value; }
        public int IdDuenio { get => this.idDuenio; set => this.idDuenio = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public bool Vacuna { get => this.vacuna; set => this.vacuna = value; }
        public int Edad { get => this.edad; set => this.edad = value; }

    }
}
