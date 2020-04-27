using System;
using System.Data.Odbc;

namespace CapaDatos
{
    public class Conexion
    {
        public OdbcConnection conexionbd()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=nomina");// creacion de la conexion via ODBC

            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No se pudo realizar la conexión", ex);
            }
            return conn;
        }
    }
}
