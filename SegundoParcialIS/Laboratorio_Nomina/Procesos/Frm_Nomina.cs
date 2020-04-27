using System;
using System.Windows.Forms;
using CapaLogica;
using System.Data.Odbc;
using Laboratorio_Nomina.Consultas;

namespace Laboratorio_Nomina.Procesos
{
    public partial class Frm_Nomina : Form
    {
        Logica logic = new Logica();
        string scampo;

        public Frm_Nomina()
        {
            InitializeComponent();
            scampo = logic.siguiente("nominaE", "codigo_nomina");
            dtp_fechaI.Format = DateTimePickerFormat.Custom;
            dtp_fechaI.CustomFormat = "yyyy/MM/dd";

            dtp_FechaF.Format = DateTimePickerFormat.Custom;
            dtp_FechaF.CustomFormat = "yyyy/MM/dd";
            txt_Codigo1.Text = scampo;
            txt_Codigo2.Text = scampo;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_buscarE_Click(object sender, EventArgs e)
        {
            Consulta_Empleado memb = new Consulta_Empleado();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_empleado.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_BuscarC_Click(object sender, EventArgs e)
        {
            Consulta_Conceptos mem = new Consulta_Conceptos();
            mem.ShowDialog();

            if (mem.DialogResult == DialogResult.OK)
            {
                txt_concepto.Text = mem.Dgv_consulta.Rows[mem.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //------ ENCABEZADO
            OdbcDataReader encabezado = logic.insertarEncabezadoNomina(txt_Codigo1.Text, dtp_fechaI.Text, dtp_FechaF.Text);
            MessageBox.Show("Datos registrados.");
            //------ DETALLE
            OdbcDataReader detalle = logic.insertarDetalleNomina(txt_Codigo1.Text, txt_empleado.Text, txt_concepto.Text, txt_valor.Text);
            MessageBox.Show("Datos registrados.");

            txt_Codigo1.Text = logic.siguiente("nominaE", "codigo_nomina");
            txt_Codigo2.Text = logic.siguiente("nominaD", "codigo_nomina");
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
