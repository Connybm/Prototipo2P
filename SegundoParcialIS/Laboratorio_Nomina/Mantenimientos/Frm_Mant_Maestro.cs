using CapaLogica;
using System;
using System.Data.Odbc;
using System.Windows.Forms;
using Laboratorio_Nomina.Consultas;

namespace Laboratorio_Nomina.Mantenimientos
{
    public partial class Frm_Mant_Maestro : Form
    {
        Logica logic = new Logica();
        string scampo;
        public Frm_Mant_Maestro()
        {
            InitializeComponent();
            scampo = logic.siguiente("maestros", "codigo_maestro");
            bloqueartxt();
            Txt_Cod.Text = scampo;
            Txt_nombre.Enabled = false;
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
            Txt_direccion.Enabled = false;
            txt_email.Enabled = false;
            txt_telefono.Enabled = false;
            txt_estatus.Enabled = false;
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
            Txt_direccion.Enabled = true;
            txt_email.Enabled = true;
            txt_telefono.Enabled = true;
            txt_estatus.Enabled = true;
        }

        public void limpiar()
        {
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";

            scampo = logic.siguiente("maestros", "codigo_maestro");
            Txt_Cod.Text = scampo;
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader ejectuar = logic.ModificarMaestro(Txt_Cod.Text, Txt_nombre.Text, Txt_direccion.Text, txt_telefono.Text, txt_email.Text, txt_estatus.Text);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarMaestro(Txt_Cod.Text, Txt_nombre.Text, Txt_direccion.Text, txt_telefono.Text, txt_email.Text, txt_estatus.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarMaestro(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Consulta_Maestro depto = new Consulta_Maestro();
            depto.ShowDialog();

            if (depto.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = depto.Dgv_consulta.Rows[depto.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = depto.Dgv_consulta.Rows[depto.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
            }
        }
    }
}
