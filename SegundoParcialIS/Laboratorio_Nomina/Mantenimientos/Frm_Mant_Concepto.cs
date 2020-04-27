using CapaLogica;
using System;
using System.Data.Odbc;
using System.Windows.Forms;
using Laboratorio_Nomina.Consultas;


namespace Laboratorio_Nomina.Mantenimientos
{
    public partial class Frm_Mant_Concepto : Form
    {
        Logica logic = new Logica();
        string scampo;

        public Frm_Mant_Concepto()
        {
            InitializeComponent();
            scampo = logic.siguiente("concepto", "codigo_concepto");
            bloqueartxt();
            this.Text = "CONCEPTOS";
            Txt_Cod.Text = scampo;
            txt_descripcion.Enabled = false;
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
            txt_descripcion.Enabled = true;
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
            txt_descripcion.Enabled = false;
        }

        public void limpiar()
        {
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            txt_descripcion.Text = "";
            scampo = logic.siguiente("concepto", "codigo_concepto");
            Txt_Cod.Text = scampo;
        }
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.ModificarConceptos(Txt_Cod.Text, Txt_nombre.Text, txt_descripcion.Text, Txt_Estatusc.Text);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarConcepto(Txt_Cod.Text, Txt_nombre.Text, txt_descripcion.Text, Txt_Estatusc.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();

        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarConcepto(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Consulta_Conceptos concep = new Consulta_Conceptos();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_descripcion.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[2].Value.ToString();
            }
        }
    }
}
