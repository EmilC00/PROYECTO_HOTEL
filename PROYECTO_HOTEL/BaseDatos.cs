using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROYECTO_HOTEL
{
    public class BaseDatos
    {
        readonly string CADENA = @"Data source=DESKTOP-IGO8Q3K\MSSQLSERVER2; Initial Catalog=Proyecto_Hotel; User ID=sa; Password=1mnbvcxz1";

        public bool ValidarUsuario(string codigo, string clave)
        {
            bool EsUsuarioValido = false;

            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT 1 FROM USUARIOS ");
                consultaSQL.Append(" WHERE CODIGO = @Codigo AND CLAVE = @Clave AND ESTAACTIVO = 1; ");

                using (SqlConnection _conexion = new SqlConnection(CADENA))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = clave;

                        EsUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());

                    }
                }
            }
            catch (Exception)
            {

            }
            return EsUsuarioValido;
        }
        public DataTable CargarTipoHabitacion()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT * FROM TIP_HABITACION ");

                using (SqlConnection _conexion = new SqlConnection(CADENA))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return tabla;

        }

        public bool InsertarReserva(string codigo, string cliente, int id_tip_habitacion, decimal precio, int dias_estadia)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO FROM P_RESERVACION");
                consultaSQL.Append(" VALUES(@Codigo, @Cliente, @id_tip_habitacion, @Precio, @Dias_estadia)");

                using (SqlConnection _conexion = new SqlConnection(CADENA))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Cliente", SqlDbType.NVarChar, 80).Value = cliente;
                        comando.Parameters.Add("@id_tip_habitacion", SqlDbType.Int).Value = id_tip_habitacion;
                        comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                        comando.Parameters.Add("@Dias_estadia", SqlDbType.Int).Value = dias_estadia;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }

            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public DataTable ListarUsuarios()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT ID, CODIGO, NOMBRE FROM USUARIOS ");

                using (SqlConnection _conexion = new SqlConnection(CADENA))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return tabla;
        }

        public DataTable ListarFactura()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT R.CODIGO, R.CLIENTE, TH.DESCRIPCION TIP_HABITACION, R.PRECIO, R.DIAS_ESTADIA, R.PRECIO * R.DIAS_ESTADIA AS 'TOTAL' FROM P_RESERVACION R ");
                consultaSQL.Append(" INNER JOIN TIP_HABITACION TH ON TH.ID = R.ID_TIP_HABITACION; ");

                using (SqlConnection _conexion = new SqlConnection(CADENA))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return tabla;
        }


        public DataTable ListarReserva()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT R.CODIGO, R.CLIENTE, TH.DESCRIPCION TIP_HABITACION, R.PRECIO, R.DIAS_ESTADIA  FROM P_RESERVACION R ");
                consultaSQL.Append(" INNER JOIN TIP_HABITACION TH ON TH.ID = R.ID_TIP_HABITACION; ");

                using (SqlConnection _conexion = new SqlConnection(CADENA))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return tabla;
        }

        public bool EditarReserva(string codigo, string cliente, int id_tip_habitacion, decimal precio, int dias_estadia)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE P_RESERVACION ");
                consultaSQL.Append(" SET CLIENTE = @Cliente, ID_TIP_HABITACION = @Id_tip_habitacion, PRECIO = @Precio, DIAS_ESTADIA = @Dias_estadia");
                consultaSQL.Append(" WHERE CODIGO = @Codigo; ");

                using (SqlConnection _conexion = new SqlConnection(CADENA))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Cliente", SqlDbType.NVarChar, 80).Value = cliente;
                        comando.Parameters.Add("@Id_tip_habitacion", SqlDbType.Int).Value = id_tip_habitacion;
                        comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precio;
                        comando.Parameters.Add("@Dias_estadia", SqlDbType.Int).Value = dias_estadia;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}