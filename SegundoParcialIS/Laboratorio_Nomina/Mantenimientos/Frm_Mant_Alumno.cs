using CapaLogica;
using System;
using System.Data.Odbc;
using System.Windows.Forms;
using Laboratorio_Nomina.Consultas;


namespace Laboratorio_Nomina.Mantenimientos
{
    public partial class Frm_Mant_Alumnos : Form
    {
        Logica logic = new Logica();
        string scampo;

        public Frm_Mant_Alumnos()
        {
            InitializeComponent();
            scampo = logic.siguiente("alumnos", "carnet_alumno");
            bloqueartxt();
            this.Text = "ALUMNOS";
            Txt_Cod.Text = scampo;
            txt_direccion.Enabled = false;
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void desbloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            /*------------------------*/
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = true;
            txt_direccion.Enabled = true;
            txt_email.Enabled = true;
            txt_Telefono.Enabled = true;
            Txt_Estatus.Enabled = true;
        }
        public void bloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            /*------------------------*/
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            txt_direccion.Enabled = false;
            txt_email.Enabled = false;
            txt_Telefono.Enabled = false;
            Txt_Estatus.Enabled = false;
        }

        public void limpiar()
        {
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            txt_direccion.Enabled = false;
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            txt_direccion.Text = "";
            scampo = logic.siguiente("alumnos", "carnet_alumno");
            Txt_Cod.Text = scampo;
        }
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.ModificarAlumno(Txt_Cod.Text, Txt_nombre.Text, txt_direccion.Text, txt_Telefono.Text, txt_email.Text, Txt_Estatus.Text);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarAlumno(Txt_Cod.Text, Txt_nombre.Text, txt_direccion.Text, txt_Telefono.Text, txt_email.Text, Txt_Estatus.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarAlumno(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Consulta_Alumnos concep = new Consulta_Alumnos();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_direccion.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                txt_Telefono.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
                txt_email.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Txt_Estatus.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[5].Value.ToString();
            }
        }
    }
}
