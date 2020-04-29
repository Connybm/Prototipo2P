﻿using CapaLogica;
using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Laboratorio_Nomina.Consultas
{
    public partial class Consulta_Secciones : Form
    {
        Logica logic = new Logica();
        public Consulta_Secciones()
        {
            InitializeComponent();
        }

        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultarfacultad();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consulta.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consulta.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consulta.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
