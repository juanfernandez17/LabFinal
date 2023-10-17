using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;

namespace EntidadesTest
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
            ADO.cadenaConexion = @"Server=.;Database=Almacen;Trusted_Connection=True;TrustServerCertificate=true;";
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
        public List<Moto> ObtenerMotos()
        {
            List<Moto> lista = new List<Moto>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT id, modelo, cilindrada, estado FROM motos";
                this.comando.Connection = this.conexion;
                this.conexion.Open();
                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Moto item = new Moto();
                    item.Id = (int)lector[0];
                    item.Modelo = lector[1].ToString();
                    item.Cilindrada = (double)lector[2];
                    item.Estado = lector[3].ToString();                    
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
        public List<Auto> ObtenerAutos()
        {
            List<Auto> lista = new List<Auto>();

            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = "SELECT id, marca, precio, fechaElaboracion FROM autos1";
                this.comando.Connection = this.conexion;
                this.conexion.Open();
                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Auto item = new Auto();
                    item.Id = (int)lector[0];
                    item.Marca = lector[1].ToString();
                    item.Precio = (double)lector[2];
                    item.FechaElaboracion = lector[3].ToString();
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
        public bool AgregarMoto(Moto moto)
        {
            bool aux;
            aux = true;

            try
            {
                string sql = "INSERT INTO motos (modelo, cilindrada, estado) VALUES(";
                sql += $"'{moto.Modelo}', {moto.Cilindrada}, '{moto.Estado}')";

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
        public bool AgregarAuto(Auto auto)
        {
            bool aux;
            aux = true;

            try
            {
                string sql = "INSERT INTO autos1 (marca, precio, fechaElaboracion) VALUES(";
                sql += $"'{auto.Marca}', {auto.Precio}, '{auto.FechaElaboracion}')";

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
        public bool ModificarMoto(Moto moto)
        {
            bool aux;
            aux = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", moto.Id);
                this.comando.Parameters.AddWithValue("@modelo", moto.Modelo);
                this.comando.Parameters.AddWithValue("@cilindrada", moto.Cilindrada);
                this.comando.Parameters.AddWithValue("@estado", moto.Estado);

                string sql = "UPDATE motos";
                sql += " SET modelo = @modelo, cilindrada = @cilindrada, estado = @estado";
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
        public bool ModificarAuto(Auto auto)
        {
            bool aux;
            aux = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", auto.Id);
                this.comando.Parameters.AddWithValue("@marca", auto.Marca);
                this.comando.Parameters.AddWithValue("@precio", auto.Precio);
                this.comando.Parameters.AddWithValue("@fechaElaboracion", auto.FechaElaboracion);

                string sql = "UPDATE autos1";
                sql += " SET marca = @marca, precio = @precio, fechaElaboracion = @fechaElaboracion";
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
        public bool EliminarMotos(int id)
        {
            bool aux;
            aux = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM motos ";
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
        public bool EliminarAutos(int id)
        {
            bool aux;
            aux = true;

            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM autos1 ";
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

    }
}
