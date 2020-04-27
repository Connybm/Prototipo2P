namespace Laboratorio_Nomina.Procesos
{
    partial class Frm_Nomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Nomina));
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dtp_FechaF = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fechaMov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.btn_BuscarC = new System.Windows.Forms.Button();
            this.txt_Codigo1 = new System.Windows.Forms.TextBox();
            this.btn_buscarE = new System.Windows.Forms.Button();
            this.Lbl_estadoMov = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.dtp_fechaI = new System.Windows.Forms.DateTimePicker();
            this.Lbl_codigoMov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txt_Codigo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.Dgv_MovIntDetalles = new System.Windows.Forms.DataGridView();
            this.Codigo_Nomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_Encabezado = new System.Windows.Forms.GroupBox();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovIntDetalles)).BeginInit();
            this.Gpb_Encabezado.SuspendLayout();
            this.Pnl_nombreForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(719, 4);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(794, 4);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dtp_FechaF
            // 
            this.dtp_FechaF.Location = new System.Drawing.Point(586, 23);
            this.dtp_FechaF.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_FechaF.Name = "dtp_FechaF";
            this.dtp_FechaF.Size = new System.Drawing.Size(207, 20);
            this.dtp_FechaF.TabIndex = 109;
            // 
            // Lbl_fechaMov
            // 
            this.Lbl_fechaMov.AutoSize = true;
            this.Lbl_fechaMov.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaMov.ForeColor = System.Drawing.Color.Black;
            this.Lbl_fechaMov.Location = new System.Drawing.Point(509, 26);
            this.Lbl_fechaMov.Name = "Lbl_fechaMov";
            this.Lbl_fechaMov.Size = new System.Drawing.Size(70, 15);
            this.Lbl_fechaMov.TabIndex = 3;
            this.Lbl_fechaMov.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(467, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 111;
            this.label1.Text = "Concepto";
            // 
            // txt_concepto
            // 
            this.txt_concepto.Enabled = false;
            this.txt_concepto.Location = new System.Drawing.Point(533, 31);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(131, 20);
            this.txt_concepto.TabIndex = 110;
            // 
            // btn_BuscarC
            // 
            this.btn_BuscarC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuscarC.BackgroundImage")));
            this.btn_BuscarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarC.Location = new System.Drawing.Point(677, 24);
            this.btn_BuscarC.Name = "btn_BuscarC";
            this.btn_BuscarC.Size = new System.Drawing.Size(32, 32);
            this.btn_BuscarC.TabIndex = 110;
            this.btn_BuscarC.UseVisualStyleBackColor = true;
            this.btn_BuscarC.Click += new System.EventHandler(this.btn_BuscarC_Click);
            // 
            // txt_Codigo1
            // 
            this.txt_Codigo1.Location = new System.Drawing.Point(64, 23);
            this.txt_Codigo1.Name = "txt_Codigo1";
            this.txt_Codigo1.Size = new System.Drawing.Size(131, 20);
            this.txt_Codigo1.TabIndex = 11;
            // 
            // btn_buscarE
            // 
            this.btn_buscarE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarE.BackgroundImage")));
            this.btn_buscarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarE.Location = new System.Drawing.Point(414, 24);
            this.btn_buscarE.Name = "btn_buscarE";
            this.btn_buscarE.Size = new System.Drawing.Size(32, 32);
            this.btn_buscarE.TabIndex = 109;
            this.btn_buscarE.UseVisualStyleBackColor = true;
            this.btn_buscarE.Click += new System.EventHandler(this.btn_buscarE_Click);
            // 
            // Lbl_estadoMov
            // 
            this.Lbl_estadoMov.AutoSize = true;
            this.Lbl_estadoMov.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estadoMov.ForeColor = System.Drawing.Color.Black;
            this.Lbl_estadoMov.Location = new System.Drawing.Point(12, 23);
            this.Lbl_estadoMov.Name = "Lbl_estadoMov";
            this.Lbl_estadoMov.Size = new System.Drawing.Size(46, 15);
            this.Lbl_estadoMov.TabIndex = 4;
            this.Lbl_estadoMov.Text = "Codigo";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(363, 69);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(106, 20);
            this.txt_valor.TabIndex = 116;
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(309, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 115;
            this.label5.Text = "Valor";
            // 
            // txt_empleado
            // 
            this.txt_empleado.Enabled = false;
            this.txt_empleado.Location = new System.Drawing.Point(278, 31);
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Size = new System.Drawing.Size(131, 20);
            this.txt_empleado.TabIndex = 7;
            // 
            // dtp_fechaI
            // 
            this.dtp_fechaI.Location = new System.Drawing.Point(295, 23);
            this.dtp_fechaI.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fechaI.Name = "dtp_fechaI";
            this.dtp_fechaI.Size = new System.Drawing.Size(207, 20);
            this.dtp_fechaI.TabIndex = 108;
            // 
            // Lbl_codigoMov
            // 
            this.Lbl_codigoMov.AutoSize = true;
            this.Lbl_codigoMov.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoMov.ForeColor = System.Drawing.Color.Black;
            this.Lbl_codigoMov.Location = new System.Drawing.Point(212, 26);
            this.Lbl_codigoMov.Name = "Lbl_codigoMov";
            this.Lbl_codigoMov.Size = new System.Drawing.Size(76, 15);
            this.Lbl_codigoMov.TabIndex = 0;
            this.Lbl_codigoMov.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(212, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 107;
            this.label2.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 113;
            this.label3.Text = "Codigo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(23, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(81, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RENTAR";
            // 
            // txt_Codigo2
            // 
            this.txt_Codigo2.Enabled = false;
            this.txt_Codigo2.Location = new System.Drawing.Point(64, 33);
            this.txt_Codigo2.Name = "txt_Codigo2";
            this.txt_Codigo2.Size = new System.Drawing.Size(131, 20);
            this.txt_Codigo2.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(488, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 19);
            this.label4.TabIndex = 122;
            this.label4.Text = "Conny María Barrios Moreno - 0901 15 4555";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(662, 292);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(88, 26);
            this.btn_Guardar.TabIndex = 121;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Dgv_MovIntDetalles
            // 
            this.Dgv_MovIntDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_MovIntDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Nomina,
            this.FechaInicial,
            this.FechaFinal,
            this.Empleado,
            this.Concepto,
            this.Valor});
            this.Dgv_MovIntDetalles.Location = new System.Drawing.Point(27, 265);
            this.Dgv_MovIntDetalles.Name = "Dgv_MovIntDetalles";
            this.Dgv_MovIntDetalles.RowHeadersVisible = false;
            this.Dgv_MovIntDetalles.RowHeadersWidth = 51;
            this.Dgv_MovIntDetalles.Size = new System.Drawing.Size(607, 176);
            this.Dgv_MovIntDetalles.TabIndex = 120;
            // 
            // Codigo_Nomina
            // 
            this.Codigo_Nomina.HeaderText = "Codigo Nomina";
            this.Codigo_Nomina.Name = "Codigo_Nomina";
            // 
            // FechaInicial
            // 
            this.FechaInicial.HeaderText = "Fecha Inicial";
            this.FechaInicial.Name = "FechaInicial";
            // 
            // FechaFinal
            // 
            this.FechaFinal.HeaderText = "FechaFinal";
            this.FechaFinal.Name = "FechaFinal";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Gpb_Encabezado
            // 
            this.Gpb_Encabezado.Controls.Add(this.dtp_FechaF);
            this.Gpb_Encabezado.Controls.Add(this.dtp_fechaI);
            this.Gpb_Encabezado.Controls.Add(this.txt_Codigo1);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_estadoMov);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_fechaMov);
            this.Gpb_Encabezado.Controls.Add(this.Lbl_codigoMov);
            this.Gpb_Encabezado.Location = new System.Drawing.Point(12, 59);
            this.Gpb_Encabezado.Name = "Gpb_Encabezado";
            this.Gpb_Encabezado.Size = new System.Drawing.Size(815, 65);
            this.Gpb_Encabezado.TabIndex = 119;
            this.Gpb_Encabezado.TabStop = false;
            this.Gpb_Encabezado.Text = "Encabezado";
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.lblTitulo);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(851, 41);
            this.Pnl_nombreForm.TabIndex = 118;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(757, 4);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_concepto);
            this.groupBox1.Controls.Add(this.txt_empleado);
            this.groupBox1.Controls.Add(this.btn_buscarE);
            this.groupBox1.Controls.Add(this.txt_Codigo2);
            this.groupBox1.Controls.Add(this.btn_BuscarC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 106);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // Frm_Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.Dgv_MovIntDetalles);
            this.Controls.Add(this.Gpb_Encabezado);
            this.Controls.Add(this.Pnl_nombreForm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Nomina";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovIntDetalles)).EndInit();
            this.Gpb_Encabezado.ResumeLayout(false);
            this.Gpb_Encabezado.PerformLayout();
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DateTimePicker dtp_FechaF;
        private System.Windows.Forms.Label Lbl_fechaMov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Button btn_BuscarC;
        private System.Windows.Forms.TextBox txt_Codigo1;
        private System.Windows.Forms.Button btn_buscarE;
        private System.Windows.Forms.Label Lbl_estadoMov;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.DateTimePicker dtp_fechaI;
        private System.Windows.Forms.Label Lbl_codigoMov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txt_Codigo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView Dgv_MovIntDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Nomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.GroupBox Gpb_Encabezado;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}