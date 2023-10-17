using System.Text;

namespace EjemploBibliotecaGeneric
{
    public class Deposito<T>
    {
        private int capacidadMaxima;
        private List<T> lista;

        public Deposito(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this.lista = new List<T>();
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool returnAux;
            returnAux = false;

            if (d.capacidadMaxima > d.lista.Count)
            {
                d.lista.Add(a);
                returnAux = true;
            }
            return returnAux;
        }

        private int GetIndice(T a)
        {
            int returnAux;
            returnAux = -1;

            for (int i = 0; i < this.lista.Count; i++)
            {
                if (this.lista[i].Equals(a))
                {
                    returnAux = i;
                }
            }
            return returnAux;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            bool returnAux;
            int indice;
            returnAux = false;
            indice = d.GetIndice(a);

            if (indice != -1)
            {
                d.lista.Remove(a);
                returnAux = true;
            }
            return returnAux;
        }
        public bool Agregar(T a)
        {
            return this + a;
        }
        public bool Remover(T a)
        {
            return this - a;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad máxima: {this.capacidadMaxima}");
            sb.AppendLine($"Listado de {typeof(T).Name}");

            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}