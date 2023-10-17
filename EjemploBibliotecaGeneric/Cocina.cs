using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBibliotecaGeneric
{
    public class Cocina
    {
        private int codigo;
        private bool esIndustrial;
        private double precio;

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this.codigo = codigo;
            this.precio = precio;
            this.esIndustrial = esIndustrial;
        }
        public int Codigo { get => this.codigo; }
        public bool EsIndustrial { get => this.esIndustrial; }
        public double Precio { get => this.precio; }

        public static bool operator ==(Cocina a, Cocina b)
        {
            return a.Codigo == b.Codigo;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            bool returnAux;
            returnAux = false;

            if (obj is not null)
            {
                if (obj is Cocina)
                {
                    returnAux = this == ((Cocina)obj);
                }
            }
            return returnAux;
        }
        public override string ToString()
        {
            return $"Código: {this.Codigo} - Precio: {this.Precio} - Es industrial? {this.EsIndustrial}";
        }
    }
}
