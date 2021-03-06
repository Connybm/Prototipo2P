﻿using CapaLogica;
using Laboratorio_Nomina.Consultas;
using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Laboratorio_Nomina.Mantenimientos
{
    public partial class Frm_Mant_Facultad : Form

    {
        Logica logic = new Logica();
        string scampo;
        public Frm_Mant_Facultad()
        {
            InitializeComponent();
            scampo = logic.siguiente("facultades", "codigo_facultad");
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
        }

        public void limpiar()
        {
            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            txt_Estatus.Text = "";

            scampo = logic.siguiente("facultades", "codigo_facultad");
            Txt_Cod.Text = scampo;
        }
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader ejectuar = logic.Modificarfacultad(Txt_Cod.Text, Txt_nombre.Text, txt_Estatus.Text);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Insertarfacultad(Txt_Cod.Text, Txt_nombre.Text, txt_Estatus.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarfacultad(Txt_Cod.Text);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Consulta_Facultad puesto = new Consulta_Facultad();
            puesto.ShowDialog();

            if (puesto.DialogResult == DialogResult.OK)
            {
                Txt_Cod.Text = puesto.Dgv_consulta.Rows[puesto.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = puesto.Dgv_consulta.Rows[puesto.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
            }
        }

        private void Pnl_nombreForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gpb_datos_Enter(object sender, EventArgs e)
        {

        }
    }
}
