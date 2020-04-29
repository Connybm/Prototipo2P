using CapaDatos;
using System.Data.Odbc;

namespace CapaLogica
{
   public class Logica
    {
        Sentencias sn = new Sentencias();

        //----OBTENER COD SIGUIENTE
        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }

        //----Insertar Alumno
        public OdbcDataReader InsertarAlumno(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sEmail, string sEstatus)
        {
            return sn.InsertarAlumnos(sCodigo, sNombre, sDireccion, sTelefono, sEmail, sEstatus);
        }

        //----Modificar 
        public OdbcDataReader ModificarAlumno(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sEmail, string sEstatus)
        {
            return sn.modificarAlumnos(sCodigo, sNombre, sDireccion, sTelefono, sEmail, sEstatus);
        }

        //----Eliminar 
        public OdbcDataReader eliminarAlumno(string sCodigo)
        {
            return sn.eliminarAlumnos(sCodigo);
        }

        //-----Consultar 
        public OdbcDataReader consultarAlumno()
        {
            return sn.consultaAlumnos();
        }

        //----Insertar Maestro
        public OdbcDataReader InsertarMaestro(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sEmail, string sEstatus)
        {
            return sn.InsertarMaestros(sCodigo, sNombre, sDireccion, sTelefono, sEmail, sEstatus);
        }

        //----Modificar 
        public OdbcDataReader ModificarMaestro(string sCodigo, string sNombre, string sDireccion, string sTelefono, string sEmail, string sEstatus)
        {
            return sn.modificarMaestros(sCodigo, sNombre, sDireccion, sTelefono, sEmail, sEstatus);
        }

        //----Eliminar 
        public OdbcDataReader eliminarMaestro(string sCodigo)
        {
            return sn.eliminarMaestros(sCodigo);
        }

        //-----Consultar 
        public OdbcDataReader consultarMaestro()
        {
            return sn.consultaMaestros();
        }

        //----Insertar Facultad
        public OdbcDataReader Insertarfacultad(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.InsertarFacultades(sCodigo, sNombre, sEstatus);
        }

        //----Modificar 
        public OdbcDataReader Modificarfacultad(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.modificarFacultades(sCodigo, sNombre, sEstatus);
        }

        //----Eliminar 
        public OdbcDataReader eliminarfacultad(string sCodigo)
        {
            return sn.eliminarFacultades(sCodigo);
        }

        //-----Consultar 
        public OdbcDataReader consultarfacultad()
        {
            return sn.consultaFacultades();
        }

        //----Insertar Carrera
        public OdbcDataReader Insertarcarrera(string sCodigo, string sNombre, string sCC, string sEstatus)
        {
            return sn.InsertarCarreras(sCodigo, sNombre, sCC, sEstatus);
        }

        //----Modificar 
        public OdbcDataReader Modificarcarrera(string sCodigo, string sNombre, string sCC, string sEstatus)
        {
            return sn.modificarCarreras(sCodigo, sNombre, sCC, sEstatus);
        }

        //----Eliminar 
        public OdbcDataReader eliminarcarrera(string sCodigo)
        {
            return sn.eliminarCarreras(sCodigo);
        }

        //-----Consultar 
        public OdbcDataReader consultarcarrera()
        {
            return sn.consultaCarreras();
        }

        //----Insertar Cursos
        public OdbcDataReader InsertarCursos(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.Insertarcursos(sCodigo, sNombre, sEstatus);
        }

        //----Modificar 
        public OdbcDataReader ModificarCursos(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.modificarcursos(sCodigo, sNombre, sEstatus);
        }

        //----Eliminar 
        public OdbcDataReader eliminarCursos(string sCodigo)
        {
            return sn.eliminarcursos(sCodigo);
        }

        //-----Consultar 
        public OdbcDataReader consultarCursos()
        {
            return sn.consultacursos();
        }

        //----Insertar Secciones
        public OdbcDataReader InsertarSecciones(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.Insertarsecciones(sCodigo, sNombre, sEstatus);
        }

        //----Modificar 
        public OdbcDataReader ModificarSecciones(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.modificarsecciones(sCodigo, sNombre, sEstatus);
        }

        //----Eliminar 
        public OdbcDataReader eliminarSecciones(string sCodigo)
        {
            return sn.eliminarsecciones(sCodigo);
        }

        //-----Consultar 
        public OdbcDataReader consultarSecciones()
        {
            return sn.consultasecciones();
        }

        //----Insertar Sedes
        public OdbcDataReader InsertarSedes(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.Insertarsedes(sCodigo, sNombre, sEstatus);
        }

        //----Modificar 
        public OdbcDataReader ModificarSedes(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.modificarsedes(sCodigo, sNombre, sEstatus);
        }

        //----Eliminar 
        public OdbcDataReader eliminarSedes(string sCodigo)
        {
            return sn.eliminarsedes(sCodigo);
        }

        //-----Consultar 
        public OdbcDataReader consultarSedes()
        {
            return sn.consultasedes();
        }

        //----Insertar Aulas
        public OdbcDataReader InsertarAulas(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.Insertaraulas(sCodigo, sNombre, sEstatus);
        }

        //----Modificar 
        public OdbcDataReader ModificarAulas(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.modificaraulas(sCodigo, sNombre, sEstatus);
        }

        //----Eliminar 
        public OdbcDataReader eliminarAulas(string sCodigo)
        {
            return sn.eliminaraulas(sCodigo);
        }

        //-----Consultar 
        public OdbcDataReader consultarAulas()
        {
            return sn.consultaaulas();
        }

        //----Insertar Jornadas
        public OdbcDataReader InsertarJornadas(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.Insertarjornadas(sCodigo, sNombre, sEstatus);
        }

        //----Modificar 
        public OdbcDataReader ModificarJornadas(string sCodigo, string sNombre, string sEstatus)
        {
            return sn.modificarjornadas(sCodigo, sNombre, sEstatus);
        }

        //----Eliminar 
        public OdbcDataReader eliminarJornadas(string sCodigo)
        {
            return sn.eliminarjornadas(sCodigo);
        }

        //-----Consultar 
        public OdbcDataReader consultarJornadas()
        {
            return sn.consultajornadas();
        }


        //----------INSERTAR ENCABEZADO
        public OdbcDataReader insertarEncabezadoNomina(string sCodigo, string sFechaI, string sFechaF)
        {
            return sn.InsertarNominaEncabezado(sCodigo, sFechaI, sFechaF);
        }

        //----------INSERTAR DETALLE
        public OdbcDataReader insertarDetalleNomina(string sCodigo, string sEmpleado, string sConcepto, string sValor)
        {
            return sn.InsertarNominaDetalle(sCodigo, sEmpleado, sConcepto, sValor);
        }
    }
}
