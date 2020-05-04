using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Torres_Anibal_Parcial
{
    class ConexionDB
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet bs = new DataSet();

        public ConexionDB()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sistema_peliculas.mdf;Integrated Security=True";
            Conexion.ConnectionString = cadena;
            Conexion.Open();
        }
        public DataSet Obtener_datos()
        {
            bs.Clear();
            comandosSQL.Connection = Conexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(bs, "clientes");

            comandosSQL.CommandText = "select * from peliculas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(bs,"peliculas");

            comandosSQL.CommandText = "select * from alquiler";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(bs, "alquiler");

            return bs;
        }

        public void movimiento_clientes(String[] datos , String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                sql ="insert into clientes(nombre,direccion,telefono,dui) values (" +
                    "'"+ datos[1]+"',"+
                    "'"+ datos[2]+"',"+
                    "'"+ datos[3]+"',"+
                    "'"+ datos[4]+"'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "update clientes set " +
                    "nombre ='"             + datos[1] + "'," +
                    "direccion='"           + datos[2] + "'," +
                    "telefono='"            + datos[3] + "'," +
                    "dui='"                 + datos[4] + "'" +
                    "where idcliente ='"    + datos[0] + "'";
            }
            else if (accion== "Eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE idcliente='" + datos[0] + "'";
            } 
            procesarSQL(sql);
        }
        public void movimiento_peliculas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                sql = "insert into peliculas(descripcion,sinopsis,genero,duracion) values (" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "update peliculas set " +
                    "descripcion ='" + datos[1] + "'," +
                    "sinopsis='" + datos[2] + "'," +
                    "genero='" + datos[3] + "'," +
                    "duracion='" + datos[4] + "'" +
                    "where idpelicula ='" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE peliculas FROM peliculas WHERE idpelicula='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void movimiento_alquiler(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "Nuevo")
            {
                sql = "insert into alquiler(idcliente,idpelicula,fechaprestamo,fechadevolucion,valor) values (" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "Modificar")
            {
                sql = "update alquiler set " +
                    "idcliente ='" + datos[1] + "'," +
                    "idpelicula='" + datos[2] + "'," +
                    "fechaprestamo='" + datos[3] + "'," +
                    "fechadevolucion='" + datos[4] + "'," +
                    "valor='" + datos[5] + "'" +
                    "where idalquiler ='" + datos[0] + "'";
            }
            else if (accion == "Eliminar")
            {
                sql = "DELETE alquiler FROM alquiler WHERE idalquiler='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        void procesarSQL(String sql)
        {
            comandosSQL.Connection = Conexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
    }

}
