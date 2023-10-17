using System.Runtime.CompilerServices;
using System.Text;

namespace EntidadesTest
{
    public class Almacen<T>
    {
        private List<T> lista;
        private int capacidad;

        public Almacen()
        {

        }
        public Almacen(int capacidad)
        {
            this.lista = new List<T>();
            this.capacidad = capacidad;
        }
        public List<T> Lista { get => this.lista; set => this.lista = value; }
        public int Capacidad { get => this.capacidad; set => this.capacidad = value; }

        public static bool operator +(Almacen<T> a, T d)
        {
            bool returnAux;
            returnAux = false;

            if (a.Capacidad > a.Lista.Count)
            {
                a.Lista.Add(d);
                returnAux = true;
            }
            return returnAux;
        }
        private int GetIndice(T d)
        {
            int returnAux;
            returnAux = -1;

            for (int i = 0; i < this.lista.Count; i++)
            {
                if (this.lista[i].Equals(d))
                {
                    returnAux = i;
                }
            }
            return returnAux;
        }
        public static bool operator -(Almacen<T> a, T d)
        {
            bool returnAux;
            int indice;
            returnAux = false;
            indice = a.GetIndice(d);

            if (indice != -1)
            {
                a.Lista.Remove(d);
                returnAux = true;
            }
            return returnAux;
        }

        public bool Agregar(T d)
        {
            bool returnAux;
            int indice;
            returnAux = false;
            indice = this.GetIndice(d);

            if (indice == -1)
            {
                returnAux = this + d;
            }
            return returnAux;
        }
        public bool Remover(T d)
        {
            bool returnAux;
            int indice;
            returnAux = false;
            indice = this.GetIndice(d);

            if (indice != -1)
            {
                returnAux = this - d;
            }
            return returnAux;
        }  
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad máxima: {this.capacidad}");
            sb.AppendLine($"Listado de {typeof(T).Name}");

            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }


    }
}