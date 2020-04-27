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

        bool ventanaDepartamento = false;
        Frm_Mant_Departamento departamento = new Frm_Mant_Departamento();
        
        private void DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Departamento);
            if (ventanaDepartamento == false || frmC == null)
            {
                if (frmC == null)
                {
                    departamento = new Frm_Mant_Departamento();
                }

                departamento.MdiParent = this;
                departamento.Show();
                Application.DoEvents();
                ventanaDepartamento = true;
            }
            else
            {
                departamento.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaPuestos = false;
        Frm_Mant_Puesto puesto = new Frm_Mant_Puesto();
        private void PuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Puesto);
            if (ventanaPuestos == false || frmC == null)
            {
                if (frmC == null)
                {
                    puesto = new Frm_Mant_Puesto();
                }

                puesto.MdiParent = this;
                puesto.Show();
                Application.DoEvents();
                ventanaPuestos = true;
            }
            else
            {
                puesto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaEmpleado = false;
        Frm_Mant_Empleado emp = new Frm_Mant_Empleado();
        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Empleado);
            if (ventanaEmpleado == false || frmC == null)
            {
                if (frmC == null)
                {
                    emp = new Frm_Mant_Empleado();
                }

                emp.MdiParent = this;
                emp.Show();
                Application.DoEvents();
                ventanaEmpleado = true;
            }
            else
            {
                emp.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaConcepto = false;
        Frm_Mant_Concepto concep = new Frm_Mant_Concepto();
        private void ConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Concepto);
            if (ventanaConcepto == false || frmC == null)
            {
                if (frmC == null)
                {
                    concep = new Frm_Mant_Concepto();
                }

                concep.MdiParent = this;
                concep.Show();
                Application.DoEvents();
                ventanaConcepto = true;
            }
            else
            {
                concep.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaNomina = false;
        Frm_Nomina nomina = new Frm_Nomina();
        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Nomina);
            if (ventanaNomina == false || frmC == null)
            {
                if (frmC == null)
                {
                    nomina = new Frm_Nomina();
                }

                nomina.MdiParent = this;
                nomina.Show();
                Application.DoEvents();
                ventanaNomina = true;
            }
            else
            {
                nomina.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
