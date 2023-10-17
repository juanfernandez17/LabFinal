using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTest
{
    public class Moto
    {
        private int id;
        private string modelo;
        private double cilindrada;
        private Estado estado;

        public Moto()
        {

        }

        public Moto(int id, string modelo, double cilindrada, Estado estado)
        {
            this.id = id;
            this.modelo = modelo;
            this.cilindrada = cilindrada;
            this.estado = estado;
        }
        public int Id { get => this.id; set => this.id = value; }
        public string Modelo { get => this.modelo; set => this.modelo = value; }
        public double Cilindrada { get => this.cilindrada; set => this.cilindrada = value; }

        public string Estado
        {
            get
            {
                return this.estado.ToString();
            }
            set
            {
                if (value == "Nuevo")
                {
                    this.estado = global::Estado.Nuevo;
                }
                else
                {
                    if (value == "Seminuevo")
                    {
                        this.estado = global::Estado.Seminuevo;
                    }
                    else
                    {
                        this.estado = global::Estado.Usado;
                    }
                }
            }
        }

        public static bool operator ==(Moto a, Moto b)
        {
            return a.Id == b.Id;
        }
        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }
        public override bool Equals(object? obj)
        {
            bool returnAux;
            returnAux = false;

            if(obj is not null)
            {
                if (obj is Moto)
                {
                    returnAux = this == ((Moto)obj);
                }
            }
            return returnAux;
        }
        public override string ToString()
        {
            return $"Id: {this.Id}\nModelo: {this.Modelo}\nCilindrada: {this.Cilindrada}\nEstado: {this.Estado}";
        }
        public override int GetHashCode()
        {
            return this.Id;
        }

    }
}
