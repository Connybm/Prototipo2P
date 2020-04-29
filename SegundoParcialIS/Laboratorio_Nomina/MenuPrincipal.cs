using Laboratorio_Nomina.Mantenimientos;
using Laboratorio_Nomina.Procesos;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio_Nomina
{
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        bool ventanaMaestro = false;
        Frm_Mant_Maestro maestro = new Frm_Mant_Maestro();
        
        private void DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Maestro);
            if (ventanaMaestro == false || frmC == null)
            {
                if (frmC == null)
                {
                    maestro = new Frm_Mant_Maestro();
                }

                maestro.MdiParent = this;
                maestro.Show();
                Application.DoEvents();
                ventanaMaestro = true;
            }
            else
            {
                maestro.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaFacultad = false;
        Frm_Mant_Facultad facultad = new Frm_Mant_Facultad();
        private void PuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Facultad);
            if (ventanaFacultad == false || frmC == null)
            {
                if (frmC == null)
                {
                    facultad = new Frm_Mant_Facultad();
                }

                facultad.MdiParent = this;
                facultad.Show();
                Application.DoEvents();
                ventanaFacultad = true;
            }
            else
            {
                facultad.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCarrera = false;
        Frm_Mant_Carreras carrera = new Frm_Mant_Carreras();
        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Carreras);
            if (ventanaCarrera == false || frmC == null)
            {
                if (frmC == null)
                {
                    carrera = new Frm_Mant_Carreras();
                }

                carrera.MdiParent = this;
                carrera.Show();
                Application.DoEvents();
                ventanaCarrera = true;
            }
            else
            {
                carrera.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaAlumnos = false;
        Frm_Mant_Alumnos alumno = new Frm_Mant_Alumnos();
        private void ConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Alumnos);
            if (ventanaAlumnos == false || frmC == null)
            {
                if (frmC == null)
                {
                    alumno = new Frm_Mant_Alumnos();
                }

                alumno.MdiParent = this;
                alumno.Show();
                Application.DoEvents();
                ventanaAlumnos = true;
            }
            else
            {
                alumno.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        
        bool ventanaCursos = false;
        Frm_Mant_Cursos curso = new Frm_Mant_Cursos();
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Cursos);
            if (ventanaCursos == false || frmC == null)
            {
                if (frmC == null)
                {
                    curso = new Frm_Mant_Cursos();
                }

                curso.MdiParent = this;
                curso.Show();
                Application.DoEvents();
                ventanaCursos = true;
            }
            else
            {
                curso.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaSecciones = false;
        Frm_Mant_Secciones seccion = new Frm_Mant_Secciones();
        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Secciones);
            if (ventanaSecciones == false || frmC == null)
            {
                if (frmC == null)
                {
                    seccion = new Frm_Mant_Secciones();
                }

                seccion.MdiParent = this;
                seccion.Show();
                Application.DoEvents();
                ventanaSecciones = true;
            }
            else
            {
                seccion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaSedes = false;
        Frm_Mant_Sedes sede = new Frm_Mant_Sedes();
        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Sedes);
            if (ventanaSedes == false || frmC == null)
            {
                if (frmC == null)
                {
                    sede = new Frm_Mant_Sedes();
                }

                sede.MdiParent = this;
                sede.Show();
                Application.DoEvents();
                ventanaSedes = true;
            }
            else
            {
                sede.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaAulas = false;
        Frm_Mant_Aulas aula = new Frm_Mant_Aulas();
        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Aulas);
            if (ventanaAulas == false || frmC == null)
            {
                if (frmC == null)
                {
                    aula = new Frm_Mant_Aulas();
                }

                aula.MdiParent = this;
                aula.Show();
                Application.DoEvents();
                ventanaAulas = true;
            }
            else
            {
                aula.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaJornadas = false;
        Frm_Mant_Jornadas jornada = new Frm_Mant_Jornadas();
        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Jornadas);
            if (ventanaJornadas == false || frmC == null)
            {
                if (frmC == null)
                {
                    jornada = new Frm_Mant_Jornadas();
                }

                jornada.MdiParent = this;
                jornada.Show();
                Application.DoEvents();
                ventanaJornadas = true;
            }
            else
            {
                jornada.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCA = false;
        Frm_AsignacionCursosAlumno ca = new Frm_AsignacionCursosAlumno();
        private void asignacionDeCursosAlAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_AsignacionCursosAlumno);
            if (ventanaCA == false || frmC == null)
            {
                if (frmC == null)
                {
                    ca = new Frm_AsignacionCursosAlumno();
                }

                ca.MdiParent = this;
                ca.Show();
                Application.DoEvents();
                ventanaCA = true;
            }
            else
            {
                ca.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCM = false;
        Frm_AsignacionCursosMaestros cm = new Frm_AsignacionCursosMaestros();
        private void asignacionDeCursosAlMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_AsignacionCursosMaestros);
            if (ventanaCM == false || frmC == null)
            {
                if (frmC == null)
                {
                    cm = new Frm_AsignacionCursosMaestros();
                }

                cm.MdiParent = this;
                cm.Show();
                Application.DoEvents();
                ventanaCM = true;
            }
            else
            {
                cm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
