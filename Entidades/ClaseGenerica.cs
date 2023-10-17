using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseGenerica<T>
    {
        private List<T> lista;
        private int capacidad;

        public ClaseGenerica(int capacidad)
        {
            this.lista = new List<T>();
            this.capacidad = capacidad;
        }
        public int Capacidad { get => this.capacidad; set => this.capacidad = value; }
        public List<T> Lista { get => this.lista; set => this.lista = value; }

        public bool Agregar(T dato)
        {

            if (this.lista.Count < this.capacidad)
            {
                this.lista.Add(dato);
                return true;
            }
            return false;
        }
       
    }
}
