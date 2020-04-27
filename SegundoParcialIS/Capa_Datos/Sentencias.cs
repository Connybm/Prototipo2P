using System;
using System.Data.Odbc;

namespace CapaDatos
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;

        //---------------Insertar Conceptos
        public OdbcDataReader InsertarConceptos(string sCodigo, string sNombre, string sEfecto, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into concepto values(" + sCodigo + ", '" + sNombre + "' ,'" + sEfecto + "','" + sEstado + "')';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Modificar Conceptos
        public OdbcDataReader modificarConceptos(string sCodigo, string sNombre, string sEfecto, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set nombre_concepto='" + sNombre + "', efecto_concepto='" + sEfecto + "'" 
                    + ", estatus_concepto = " + sEstado + " where codigo_concepto = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Eliminar Conceptos
        public OdbcDataReader eliminarConceptos(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set estatus_concepto='0' where codigo_concepto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //----------Consultar Conceptos
        public OdbcDataReader consultaConcepto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM concepto WHERE estatus_concepto = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Insertar Puesto
        public OdbcDataReader InsertarPuesto(string sCodigo, string sNombre, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into puesto values(" + sCodigo + ", '" + sNombre + "' ,'" + sEstado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Modificar Puesto
        public OdbcDataReader modificarPuesto(string sCodigo, string sNombre, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE puesto set nombre_puesto='" + sNombre + "', estatus_puesto='" + sEstado + "' where codigo_puesto = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Eliminar Puesto
        public OdbcDataReader eliminarPuesto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE puesto set estatus_puesto='0' where codigo_puesto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //----------Consultar Puesto
        public OdbcDataReader consultaPuesto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM puesto WHERE estatus_puesto = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Insertar Empleados
        public OdbcDataReader InsertarEmpleados(string sCodigo, string sNombre, string sCP, string sCD, string sSueldo, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into empleado values(" + sCodigo + ", '" + sNombre + "' ,'" + sCP + "','" + sCD + "'," + sSueldo + ",'"+sEstatus+"');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Modificar Empleados
        public OdbcDataReader modificarEmpleados(string sCodigo, string sNombre, string sCP, string sCD, string sSueldo, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE empleado set nombre_empleado='" + sNombre + "', codigo_puesto='" + sCP + "'" + ", codigo_departamento = '" + sCD
                    + "', sueldo_empleado= " + sSueldo +"', estatus_empleado'" + sEstatus  + " where codigo_empleado = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------Eliminar Empleados
        public OdbcDataReader eliminarEmpleados(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE empleado set estatus_empleado='0' where codigo_empleado='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //----------Consultar Empleados
        public OdbcDataReader consultaEmpleados()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM empleado WHERE estatus_empleado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------------OBTENER COD SIGUIENTE--------------------------------------------------------------------//
        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();

                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }

        //---------------------------------------------------------------UPDATE DEPARTAMENTO-----------------------------------------------------------------------------------------//
        public OdbcDataReader modificarDepartamento(string sCodigo, string sNombre, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE departamento set nombre_departamento='" + sNombre + "estado_departamento" + sEstado + "' where codigo_departamento = " + sCodigo + ";";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------INSERT DEPARTAMENTO------------------------------------------------------------------------------------------//
        public OdbcDataReader insertarDepartamento(string sCodigo, string sNombre, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into departamento values(" + sCodigo + ", '" + sNombre + "' ," + sEstado + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------------------------------------------------------------ELIMINAR DEPARTAMENTO-----------------------------------------------------------------------------------------//
        public OdbcDataReader eliminarDepartamento(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE departamento set estatus_departamento='0' where codigo_departamento ='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //---------------------------------------------------------------CONSULTA DEPARTAMENTO------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaDepartamento()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM departamento WHERE codigo_departamento = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    
        //--------Insertar Encabezado Nomina
        public OdbcDataReader InsertarNominaEncabezado(string sCodigo, string sFechaI, string sFechaF)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into nominaE values(" + sCodigo + ", " + sFechaI + "','" + sFechaF + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        //--------Insertar Detalle Nomina
        public OdbcDataReader InsertarNominaDetalle(string sCodigo, string sEmpleado, string sConcepto, string sValor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into nominaD values(" + sCodigo + ", " + sEmpleado + " ,'" + sConcepto + "','" + sValor + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
