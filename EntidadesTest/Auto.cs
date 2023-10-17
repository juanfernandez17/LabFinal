using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTest
{
    public class Auto
    {
        private int id;
        private string marca;
        private double precio;
        private DateTime fechaElaboracion;

        public Auto()
        {

        }
        public Auto(int id, string marca, double precio, DateTime fechaElaboracion)
        {
            this.id = id;
            this.marca = marca;
            this.precio = precio;
            this.fechaElaboracion = fechaElaboracion;
        }
        public int Id { get => this.id; set => this.id = value; }
        public string Marca { get => this.marca;  set => this.marca = value; }
        public double Precio { get => this.precio; set => this.precio = value; }
        public string FechaElaboracion
        {
            get
            {
                return this.fechaElaboracion.ToShortDateString();
            }
            set
            {
                this.fechaElaboracion = DateTime.Parse(value);
            }
        }
        public static bool operator ==(Auto a, Auto b)
        {
            return a.Id == b.Id;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        public override bool Equals(object? obj)
        {
            bool returnAux;
            returnAux = false;

            if(obj is not null)
            {
                if(obj is Auto)
                {
                    returnAux = this == ((Auto)obj);
                }
            }
            return returnAux;
        }
        public override string ToString()
        {
            return $"Id: {this.Id}\nMarca: {this.Marca}\nPrecio: {this.Precio}\nFecha de elaboración: {this.FechaElaboracion}";
        }
        public override int GetHashCode()
        {
            return this.Id;
        }

    }
}
