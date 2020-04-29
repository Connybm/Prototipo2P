using System;
using System.Windows.Forms;
using CapaLogica;
using System.Data.Odbc;
using Laboratorio_Nomina.Consultas;

namespace Laboratorio_Nomina.Procesos
{
    public partial class Frm_AsignacionCursosMaestros : Form
    {
        Logica logic = new Logica();
        public Frm_AsignacionCursosMaestros()
        {
            InitializeComponent();                        
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_buscarMaestro_Click(object sender, EventArgs e)
        {
            Consulta_Maestro memb = new Consulta_Maestro();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_Maestro.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_BuscarCurso_Click(object sender, EventArgs e)
        {
            Consulta_Cursos memb = new Consulta_Cursos();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_Curso.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_buscarCarrera_Click(object sender, EventArgs e)
        {
            Consulta_Carreras memb = new Consulta_Carreras();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_carrera.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_buscarSede_Click(object sender, EventArgs e)
        {
            Consulta_Sedes memb = new Consulta_Sedes();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_sede.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_buscarJornada_Click(object sender, EventArgs e)
        {
            Consulta_Jornadas memb = new Consulta_Jornadas();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_jornada.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_buscarSeccion_Click(object sender, EventArgs e)
        {
            Consulta_Secciones memb = new Consulta_Secciones();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_seccion.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_buscarAula_Click(object sender, EventArgs e)
        {
            Consulta_Aulas memb = new Consulta_Aulas();
            memb.ShowDialog();

            if (memb.DialogResult == DialogResult.OK)
            {
                txt_aula.Text = memb.Dgv_consulta.Rows[memb.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader detalle = logic.InsertarAsignacionMaestro(txt_carrera.Text, txt_sede.Text, txt_jornada.Text, txt_seccion.Text, txt_aula.Text, txt_Curso.Text, txt_Maestro.Text);
            MessageBox.Show("Datos registrados.");
        }
    }
}
