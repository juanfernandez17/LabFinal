using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Transactions;

namespace Entidades
{
    public class ADO
    {
        private static string cadenaConexion;
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader lector;

        static ADO()
        {
            /* SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
             {
                 UserID = "sa",
                 Password = "alumno"
             };*/
            ADO.cadenaConexion = @"Server=.;Database=veterinaria;Trusted_Connection=True;TrustServerCertificate=true;";
            //  ADO.cadenaConexion += builder.ToString();
        }
        public ADO()
        {
            this.conexion = new SqlConnection(ADO.cadenaConexion);
        }
        public bool ProbarConexion()
        {
            bool aux;
            aux = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                aux = false;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return aux;
        }
        public List<Persona> ObtenerClientes()
        {
            List<Persona> lista = new List<Persona>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT id, idVeterinaria, nombre, apellido, dni FROM personas";
                this.comando.Connection = this.conexion;
                this.conexion.Open();
                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Persona item = new Persona();
                    item.Id = (int)lector[0];
                    item.IdVeterinaria = (int)lector[1];
                    item.Nombre = lector[2].ToString();
                    item.Apellido = lector[3].ToString();
                    item.Dni = (int)lector[4];
                    lista.Add(item);
                }
                lector.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }
        public bool AgregarCliente(Persona persona)
        {
            bool aux;
            aux = true;

            try
            {
                string sql = "INSERT INTO personas (idVeterinaria, nombre, apellido, dni) VALUES(";
                sql += $"{persona.IdVeterinaria}, '{persona.Nombre}', '{persona.Apellido}', {persona.Dni})";

                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;
                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    aux = false;
                }
            }
            catch (Exception)
            {
                aux = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return aux;
        }
        public bool ModificarCliente(Persona persona)
        {
            bool aux;
            aux = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", persona.Id);
                this.comando.Parameters.AddWithValue("@idVeterinaria", persona.IdVeterinaria);
                this.comando.Parameters.AddWithValue("@nombre", persona.Nombre);
                this.comando.Parameters.AddWithValue("@apellido", persona.Apellido);
                this.comando.Parameters.AddWithValue("@dni", persona.Dni);

                string sql = "UPDATE personas";
                sql += " SET idVeterinaria = @idVeterinaria, nombre = @nombre, apellido = @apellido, dni = @dni";
                sql += " WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;
                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    aux = false;
                }
            }
            catch (Exception)
            {
                aux = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return aux;
        }
        public bool EliminarCliente(int id)
        {
            bool aux;
            aux = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM personas ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;
                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    aux = false;
                }
            }
            catch (Exception)
            {
                aux = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return aux;
        }

        public Administrador VerificarInicioSesion(string usuario, string contrasenia)
        {
            Administrador administrador = null;

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"SELECT id, idVeterinaria, nombre, apellido, dni, usuario, contrasenia FROM administradores" +
                    $" WHERE administradores.usuario = '{usuario}' and administradores.contrasenia = '{contrasenia}'";
                this.comando.Connection = this.conexion;
                this.conexion.Open();
                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Administrador item = new Administrador();
                    item.Id = (int)lector[0];
                    item.IdVeterinaria = (int)lector[1];
                    item.Nombre = lector[2].ToString();
                    item.Apellido = lector[3].ToString();
                    item.Dni = (int)lector[4];
                    item.Usuario = lector[5].ToString();
                    item.Contrasenia = lector[6].ToString();
                    administrador = item;
                }
                lector.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return administrador;
        }
        public List<Persona> ObtenerClientesPorVeterinaria(int idVeterinaria)
        {
            List<Persona> lista = new List<Persona>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@idVeterinaria", idVeterinaria);
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"SELECT id, idVeterinaria, nombre, apellido, dni FROM personas WHERE idVeterinaria = @idVeterinaria";
                this.comando.Connection = this.conexion;
                this.conexion.Open();
                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Persona item = new Persona();
                    item.Id = (int)lector[0];
                    item.IdVeterinaria = (int)lector[1];
                    item.Nombre = lector[2].ToString();
                    item.Apellido = lector[3].ToString();
                    item.Dni = (int)lector[4];
                    lista.Add(item);
                }
                lector.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }
    }
}
