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

        //----Insertar Concepto
        public OdbcDataReader InsertarConcepto(string sCodigo, string sNombre, string sEfecto, string sEstado)
        {
            return sn.InsertarConceptos(sCodigo, sNombre, sEfecto, sEstado);
        }

        //----Modificar Concepto
        public OdbcDataReader ModificarConceptos(string sCodigo, string sNombre, string sEfecto, string sEstado)
        {
            return sn.modificarConceptos(sCodigo, sNombre, sEfecto, sEstado);
        }

        //----Eliminar Concepto
        public OdbcDataReader eliminarConcepto(string sCodigo)
        {
            return sn.eliminarConceptos(sCodigo);
        }

        //-----Consultar Concepto
        public OdbcDataReader consultarConcepto()
        {
            return sn.consultaConcepto();
        }

        //----Insertar Puesto
        public OdbcDataReader InsertarPuesto(string sCodigo, string sNombre, string sEstado)
        {
            return sn.InsertarPuesto(sCodigo, sNombre, sEstado);
        }

        //----Modificar Puesto
        public OdbcDataReader modificarPuesto(string sCodigo, string sNombre, string sEstado)
        {
            return sn.modificarPuesto(sCodigo, sNombre, sEstado);
        }

        //----Eliminar Puesto
        public OdbcDataReader eliminarPuesto(string sCodigo)
        {
            return sn.eliminarPuesto(sCodigo);
        }

        //-----Consultar Puesto
        public OdbcDataReader consultarPuesto()
        {
            return sn.consultaPuesto();
        }

        //----Insertar Empleado
        public OdbcDataReader InsertarEmpleado(string sCodigo, string sNombre, string sCP, string sCD, string sSueldo, string sEstatus)
        {
            return sn.InsertarEmpleados(sCodigo, sNombre, sCP, sCD, sSueldo,sEstatus);
        }

        //----Modificar Empleado
        public OdbcDataReader modificarEmpleado(string sCodigo, string sNombre, string sCP, string sCD, string sSueldo, string sEstatus)
        {
            return sn.modificarEmpleados(sCodigo, sNombre, sCP, sCD, sSueldo, sEstatus);
        }

        //----Eliminar Empleado
        public OdbcDataReader eliminarEmpleado(string sCodigo)
        {
            return sn.eliminarEmpleados(sCodigo);
        }

        //-----Consultar Empleado
        public OdbcDataReader consultarEmpleado()
        {
            return sn.consultaEmpleados();
        }

        //-----UPDATE DEPARTAMENTO
        public OdbcDataReader modificarDepartamento(string sCodigo, string sNombre, string sEstado)
        {
            return sn.modificarDepartamento(sCodigo, sNombre, sEstado);
        }
        
        //-----INSERTAR DEPARTAMENTO
        public OdbcDataReader insertarDepartamento(string sCodigo, string sNombre, string sEstado)
        {
            return sn.insertarDepartamento(sCodigo, sNombre, sEstado);
        }
        
        //----ELIMINAR DEPARTAMENTO
        public OdbcDataReader eliminarDepartamento(string sCodigo)
        {
            return sn.eliminarDepartamento(sCodigo);
        }
        
        //----CONSULTA DEPARTAMENTO
        public OdbcDataReader consultaDepartamento()
        {
            return sn.consultaDepartamento();
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
