﻿using CapaLogica;
using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Laboratorio_Nomina.Consultas
{
    public partial class Consulta_Facultad : Form
    {
        Logica logic = new Logica();
        public Consulta_Facultad()
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

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
