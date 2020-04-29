using System;
using System.Data.Odbc;

namespace CapaDatos
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;

        //---------------OBTENER COD SIGUIENTE
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

        //---------------Insertar Alumnos
        public OdbcDataReader InsertarAlumnos(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sEmail, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into alumnos values(" + sCodigo + ", '" + sNombre + "' ,'" + sDireccion + "','" + sTelefono + "','" + sEmail + "','" + sEstatus + "')';";
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

        //---------------Modificar
        public OdbcDataReader modificarAlumnos(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sEmail, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE alumnos set nombre_alumno='" + sNombre + "', direccion_alumno='" + sDireccion + "'" + "', telefono_alumno='" + sTelefono + "'"
                    + "', email_alumno='" + sEmail + "'" + ", estatus_concepto = " + sEstatus + " where carnet_alumnoo = " + sCodigo + ";";
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

        //---------------Eliminar
        public OdbcDataReader eliminarAlumnos(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE alumnos set estatus_alumno='0' where carnet_alumno='" + sCodigo + "';";
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

        //----------Consultar
        public OdbcDataReader consultaAlumnos()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM alumnos WHERE estatus_alumno = 1 ;";
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

        //---------------Insertar Maestros
        public OdbcDataReader InsertarMaestros(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sEmail, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into maestros values(" + sCodigo + ", '" + sNombre + "' ,'" + sDireccion + "','" + sTelefono + "','" + sEmail + "','" + sEstatus + "')';";
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

        //---------------Modificar
        public OdbcDataReader modificarMaestros(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sEmail, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE maestros set nombre_maestro='" + sNombre + "', direccion_maestro='" + sDireccion + "'" + "', telefono_maestro='" + sTelefono + "'"
                    + "', email_maestro='" + sEmail + "'" + ", estatus_maestro = " + sEstatus + " where codigo_maestro = " + sCodigo + ";";
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

        //---------------Eliminar
        public OdbcDataReader eliminarMaestros(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE maestros set estatus_maestro='0' where codigo_maestro='" + sCodigo + "';";
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

        //----------Consultar
        public OdbcDataReader consultaMaestros()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM maestros WHERE estatus_maestro = 1 ;";
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

        //---------------Insertar Facultades
        public OdbcDataReader InsertarFacultades(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into facultades values(" + sCodigo + ", '" + sNombre + "' ,'" + sEstatus + "')';";
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

        //---------------Modificar
        public OdbcDataReader modificarFacultades(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE facultades set nombre_facultad='" + sNombre + ", estatus_facultad = " + sEstatus + " where codigo_facultad = " + sCodigo + ";";
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

        //---------------Eliminar
        public OdbcDataReader eliminarFacultades(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE facultades set estatus_facultad='0' where codigo_facultad='" + sCodigo + "';";
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

        //----------Consultar
        public OdbcDataReader consultaFacultades()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM facultades WHERE estatus_facultad = 1 ;";
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

        //---------------Insertar Carreras
        public OdbcDataReader InsertarCarreras(string sCodigo, string sNombre, string sCC, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into carreras values(" + sCodigo + ", '" + sNombre + "' ,'" + sCC + "' ,'" + sEstatus + "')';";
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

        //---------------Modificar
        public OdbcDataReader modificarCarreras(string sCodigo, string sNombre, string sCC, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE carreras set nombre_carrera='" + sNombre + ", codigo_facultad = " + sCC + ", estatus_carrera = " + sEstatus +
                    " where codigo_carrera = " + sCodigo + ";";
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

        //---------------Eliminar
        public OdbcDataReader eliminarCarreras(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE carreras set estatus_carrera='0' where codigo_carrera='" + sCodigo + "';";
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

        //----------Consultar
        public OdbcDataReader consultaCarreras()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM carreras WHERE estatus_carrera = 1 ;";
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

        //---------------Insertar Cursos
        public OdbcDataReader Insertarcursos(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into cursos values(" + sCodigo + ", '" + sNombre + "' ,'" + sEstatus + "')';";
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

        //---------------Modificar
        public OdbcDataReader modificarcursos(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE cursos set nombre_curso='" + sNombre + ", estatus_curso = " + sEstatus + " where codigo_curso = " + sCodigo + ";";
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

        //---------------Eliminar
        public OdbcDataReader eliminarcursos(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE cursos set estatus_curso='0' where codigo_curso='" + sCodigo + "';";
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

        //----------Consultar
        public OdbcDataReader consultacursos()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM cursos WHERE estatus_curso = 1 ;";
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

        //---------------Insertar Secciones
        public OdbcDataReader Insertarsecciones(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into secciones values(" + sCodigo + ", '" + sNombre + "' ,'" + sEstatus + "')';";
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

        //---------------Modificar
        public OdbcDataReader modificarsecciones(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE secciones set nombre_seccion='" + sNombre + ", estatus_seccion = " + sEstatus + " where codigo_seccion = " + sCodigo + ";";
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

        //---------------Eliminar
        public OdbcDataReader eliminarsecciones(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE secciones set estatus_seccion='0' where codigo_seccion='" + sCodigo + "';";
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

        //----------Consultar
        public OdbcDataReader consultasecciones()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM secciones WHERE estatus_seccion = 1 ;";
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

        //---------------Insertar Sedes
        public OdbcDataReader Insertarsedes(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into sedes values(" + sCodigo + ", '" + sNombre + "' ,'" + sEstatus + "')';";
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

        //---------------Modificar
        public OdbcDataReader modificarsedes(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE sedes set nombre_sede='" + sNombre + ", estatus_sede = " + sEstatus + " where codigo_sede = " + sCodigo + ";";
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

        //---------------Eliminar
        public OdbcDataReader eliminarsedes(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE sedes set estatus_sede='0' where codigo_sede='" + sCodigo + "';";
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

        //----------Consultar
        public OdbcDataReader consultasedes()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM sedes WHERE estatus_sede = 1 ;";
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

        //---------------Insertar Aulas
        public OdbcDataReader Insertaraulas(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into aulas values(" + sCodigo + ", '" + sNombre + "' ,'" + sEstatus + "')';";
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

        //---------------Modificar
        public OdbcDataReader modificaraulas(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE aulas set nombre_aula='" + sNombre + ", estatus_aula = " + sEstatus + " where codigo_aula = " + sCodigo + ";";
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

        //---------------Eliminar
        public OdbcDataReader eliminaraulas(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE aulas set estatus_aula='0' where codigo_aula='" + sCodigo + "';";
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

        //----------Consultar
        public OdbcDataReader consultaaulas()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM aulas WHERE estatus_aula = 1 ;";
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

        //---------------Insertar Jornadas
        public OdbcDataReader Insertarjornadas(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into jornadas values(" + sCodigo + ", '" + sNombre + "' ,'" + sEstatus + "')';";
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

        //---------------Modificar
        public OdbcDataReader modificarjornadas(string sCodigo, string sNombre, string sEstatus)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE jornadas set nombre_jornada='" + sNombre + ", estatus_jornada = " + sEstatus + " where codigo_jornada = " + sCodigo + ";";
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

        //---------------Eliminar
        public OdbcDataReader eliminarjornadas(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE jornadas set estatus_jornada='0' where codigo_jornada='" + sCodigo + "';";
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

        //----------Consultar
        public OdbcDataReader consultajornadas()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM jornadas WHERE estatus_jornada = 1 ;";
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
