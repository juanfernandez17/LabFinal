using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBibliotecaGeneric
{
    public class Auto
    {
        private string color;
        private string marca;

        public Auto(string color, string marca)
        {
            this.color = color;
            this.marca = marca;
        }

        public string Color { get => this.color; }
        public string Marca { get => this.marca; }

        public static bool operator ==(Auto a, Auto b)
        {
            return (a.Marca == b.Marca) && (a.Color == b.Color);
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            bool returnAux;
            returnAux = false;

            if (obj is not null)
            {
                if (obj is Auto)
                {
                    returnAux = this == ((Auto)obj);
                }
            }
            return returnAux;
        }
        public override string ToString()
        {
            return $"Marca: {this.Marca} - Color: {this.Color}";
        }
    }
}
