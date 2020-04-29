namespace Laboratorio_Nomina.Procesos
{
    partial class Frm_AsignacionCursosAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AsignacionCursosAlumno));
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.Dgv_MovIntDetalles = new System.Windows.Forms.DataGridView();
            this.CodigoCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoJornada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarnetAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Nota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_aula = new System.Windows.Forms.TextBox();
            this.btn_buscarAula = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_carrera = new System.Windows.Forms.TextBox();
            this.txt_seccion = new System.Windows.Forms.TextBox();
            this.btn_buscarSeccion = new System.Windows.Forms.Button();
            this.btn_buscarCarrera = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_jornada = new System.Windows.Forms.TextBox();
            this.txt_sede = new System.Windows.Forms.TextBox();
            this.btn_buscarSede = new System.Windows.Forms.Button();
            this.btn_buscarJornada = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Curso = new System.Windows.Forms.TextBox();
            this.txt_Alumno = new System.Windows.Forms.TextBox();
            this.btn_buscarAlumno = new System.Windows.Forms.Button();
            this.btn_BuscarCurso = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovIntDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Pnl_nombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(572, 136);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(88, 26);
            this.btn_Guardar.TabIndex = 135;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Dgv_MovIntDetalles
            // 
            this.Dgv_MovIntDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_MovIntDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCarrera,
            this.CodigoSede,
            this.CodigoJornada,
            this.CodigoSeccion,
            this.CodigoAula,
            this.CodigoCurso,
            this.CarnetAlumno,
            this.Nota});
            this.Dgv_MovIntDetalles.Location = new System.Drawing.Point(12, 256);
            this.Dgv_MovIntDetalles.Name = "Dgv_MovIntDetalles";
            this.Dgv_MovIntDetalles.RowHeadersVisible = false;
            this.Dgv_MovIntDetalles.RowHeadersWidth = 51;
            this.Dgv_MovIntDetalles.Size = new System.Drawing.Size(803, 176);
            this.Dgv_MovIntDetalles.TabIndex = 134;
            // 
            // CodigoCarrera
            // 
            this.CodigoCarrera.HeaderText = "Codigo Carrera";
            this.CodigoCarrera.Name = "CodigoCarrera";
            // 
            // CodigoSede
            // 
            this.CodigoSede.HeaderText = "Codigo Sede";
            this.CodigoSede.Name = "CodigoSede";
            // 
            // CodigoJornada
            // 
            this.CodigoJornada.HeaderText = "Codigo Jornada";
            this.CodigoJornada.Name = "CodigoJornada";
            // 
            // CodigoSeccion
            // 
            this.CodigoSeccion.HeaderText = "Codigo Seccion";
            this.CodigoSeccion.Name = "CodigoSeccion";
            // 
            // CodigoAula
            // 
            this.CodigoAula.HeaderText = "Codigo Aula";
            this.CodigoAula.Name = "CodigoAula";
            // 
            // CodigoCurso
            // 
            this.CodigoCurso.HeaderText = "Codigo Curso";
            this.CodigoCurso.Name = "CodigoCurso";
            // 
            // CarnetAlumno
            // 
            this.CarnetAlumno.HeaderText = "Carnet Alumno";
            this.CarnetAlumno.Name = "CarnetAlumno";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Nota);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_aula);
            this.groupBox1.Controls.Add(this.btn_buscarAula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_carrera);
            this.groupBox1.Controls.Add(this.txt_seccion);
            this.groupBox1.Controls.Add(this.btn_buscarSeccion);
            this.groupBox1.Controls.Add(this.btn_buscarCarrera);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_jornada);
            this.groupBox1.Controls.Add(this.txt_sede);
            this.groupBox1.Controls.Add(this.btn_buscarSede);
            this.groupBox1.Controls.Add(this.btn_buscarJornada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Curso);
            this.groupBox1.Controls.Add(this.txt_Alumno);
            this.groupBox1.Controls.Add(this.btn_buscarAlumno);
            this.groupBox1.Controls.Add(this.btn_BuscarCurso);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 174);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(271, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 128;
            this.label9.Text = "Nota";
            // 
            // txt_Nota
            // 
            this.txt_Nota.Location = new System.Drawing.Point(337, 134);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(131, 20);
            this.txt_Nota.TabIndex = 127;
            this.txt_Nota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nota_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 125;
            this.label8.Text = "Aula";
            // 
            // txt_aula
            // 
            this.txt_aula.Enabled = false;
            this.txt_aula.Location = new System.Drawing.Point(78, 131);
            this.txt_aula.Name = "txt_aula";
            this.txt_aula.Size = new System.Drawing.Size(131, 20);
            this.txt_aula.TabIndex = 124;
            // 
            // btn_buscarAula
            // 
            this.btn_buscarAula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarAula.BackgroundImage")));
            this.btn_buscarAula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarAula.Location = new System.Drawing.Point(214, 124);
            this.btn_buscarAula.Name = "btn_buscarAula";
            this.btn_buscarAula.Size = new System.Drawing.Size(32, 32);
            this.btn_buscarAula.TabIndex = 126;
            this.btn_buscarAula.UseVisualStyleBackColor = true;
            this.btn_buscarAula.Click += new System.EventHandler(this.btn_buscarAula_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(534, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 119;
            this.label6.Text = "Seccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(534, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 123;
            this.label7.Text = "Carrera";
            // 
            // txt_carrera
            // 
            this.txt_carrera.Enabled = false;
            this.txt_carrera.Location = new System.Drawing.Point(600, 34);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.Size = new System.Drawing.Size(131, 20);
            this.txt_carrera.TabIndex = 121;
            // 
            // txt_seccion
            // 
            this.txt_seccion.Enabled = false;
            this.txt_seccion.Location = new System.Drawing.Point(600, 87);
            this.txt_seccion.Name = "txt_seccion";
            this.txt_seccion.Size = new System.Drawing.Size(131, 20);
            this.txt_seccion.TabIndex = 118;
            // 
            // btn_buscarSeccion
            // 
            this.btn_buscarSeccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarSeccion.BackgroundImage")));
            this.btn_buscarSeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarSeccion.Location = new System.Drawing.Point(745, 80);
            this.btn_buscarSeccion.Name = "btn_buscarSeccion";
            this.btn_buscarSeccion.Size = new System.Drawing.Size(32, 32);
            this.btn_buscarSeccion.TabIndex = 120;
            this.btn_buscarSeccion.UseVisualStyleBackColor = true;
            this.btn_buscarSeccion.Click += new System.EventHandler(this.btn_buscarSeccion_Click);
            // 
            // btn_buscarCarrera
            // 
            this.btn_buscarCarrera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarCarrera.BackgroundImage")));
            this.btn_buscarCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarCarrera.Location = new System.Drawing.Point(744, 27);
            this.btn_buscarCarrera.Name = "btn_buscarCarrera";
            this.btn_buscarCarrera.Size = new System.Drawing.Size(32, 32);
            this.btn_buscarCarrera.TabIndex = 122;
            this.btn_buscarCarrera.UseVisualStyleBackColor = true;
            this.btn_buscarCarrera.Click += new System.EventHandler(this.btn_buscarCarrera_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 113;
            this.label3.Text = "Sede";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(271, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 117;
            this.label5.Text = "Jornada";
            // 
            // txt_jornada
            // 
            this.txt_jornada.Enabled = false;
            this.txt_jornada.Location = new System.Drawing.Point(337, 84);
            this.txt_jornada.Name = "txt_jornada";
            this.txt_jornada.Size = new System.Drawing.Size(131, 20);
            this.txt_jornada.TabIndex = 115;
            // 
            // txt_sede
            // 
            this.txt_sede.Enabled = false;
            this.txt_sede.Location = new System.Drawing.Point(78, 84);
            this.txt_sede.Name = "txt_sede";
            this.txt_sede.Size = new System.Drawing.Size(131, 20);
            this.txt_sede.TabIndex = 112;
            // 
            // btn_buscarSede
            // 
            this.btn_buscarSede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarSede.BackgroundImage")));
            this.btn_buscarSede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarSede.Location = new System.Drawing.Point(214, 77);
            this.btn_buscarSede.Name = "btn_buscarSede";
            this.btn_buscarSede.Size = new System.Drawing.Size(32, 32);
            this.btn_buscarSede.TabIndex = 114;
            this.btn_buscarSede.UseVisualStyleBackColor = true;
            this.btn_buscarSede.Click += new System.EventHandler(this.btn_buscarSede_Click);
            // 
            // btn_buscarJornada
            // 
            this.btn_buscarJornada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarJornada.BackgroundImage")));
            this.btn_buscarJornada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarJornada.Location = new System.Drawing.Point(481, 77);
            this.btn_buscarJornada.Name = "btn_buscarJornada";
            this.btn_buscarJornada.Size = new System.Drawing.Size(32, 32);
            this.btn_buscarJornada.TabIndex = 116;
            this.btn_buscarJornada.UseVisualStyleBackColor = true;
            this.btn_buscarJornada.Click += new System.EventHandler(this.btn_buscarJornada_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 107;
            this.label2.Text = "Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(271, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 111;
            this.label1.Text = "Curso";
            // 
            // txt_Curso
            // 
            this.txt_Curso.Enabled = false;
            this.txt_Curso.Location = new System.Drawing.Point(337, 34);
            this.txt_Curso.Name = "txt_Curso";
            this.txt_Curso.Size = new System.Drawing.Size(131, 20);
            this.txt_Curso.TabIndex = 110;
            // 
            // txt_Alumno
            // 
            this.txt_Alumno.Enabled = false;
            this.txt_Alumno.Location = new System.Drawing.Point(78, 34);
            this.txt_Alumno.Name = "txt_Alumno";
            this.txt_Alumno.Size = new System.Drawing.Size(131, 20);
            this.txt_Alumno.TabIndex = 7;
            // 
            // btn_buscarAlumno
            // 
            this.btn_buscarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarAlumno.BackgroundImage")));
            this.btn_buscarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarAlumno.Location = new System.Drawing.Point(214, 27);
            this.btn_buscarAlumno.Name = "btn_buscarAlumno";
            this.btn_buscarAlumno.Size = new System.Drawing.Size(32, 32);
            this.btn_buscarAlumno.TabIndex = 109;
            this.btn_buscarAlumno.UseVisualStyleBackColor = true;
            this.btn_buscarAlumno.Click += new System.EventHandler(this.btn_buscarAlumno_Click);
            // 
            // btn_BuscarCurso
            // 
            this.btn_BuscarCurso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BuscarCurso.BackgroundImage")));
            this.btn_BuscarCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarCurso.Location = new System.Drawing.Point(481, 27);
            this.btn_BuscarCurso.Name = "btn_BuscarCurso";
            this.btn_BuscarCurso.Size = new System.Drawing.Size(32, 32);
            this.btn_BuscarCurso.TabIndex = 110;
            this.btn_BuscarCurso.UseVisualStyleBackColor = true;
            this.btn_BuscarCurso.Click += new System.EventHandler(this.btn_BuscarCurso_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(489, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 19);
            this.label4.TabIndex = 133;
            this.label4.Text = "Conny María Barrios Moreno - 0901 15 4555";
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
            this.Pnl_nombreForm.TabIndex = 132;
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(23, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ASIGNACIÓN DE CURSOS A ALUMNOS";
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
            // Frm_AsignacionCursosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 479);
            this.Controls.Add(this.Dgv_MovIntDetalles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AsignacionCursosAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AsignacionCursosAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovIntDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView Dgv_MovIntDetalles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_aula;
        private System.Windows.Forms.Button btn_buscarAula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_carrera;
        private System.Windows.Forms.TextBox txt_seccion;
        private System.Windows.Forms.Button btn_buscarSeccion;
        private System.Windows.Forms.Button btn_buscarCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_jornada;
        private System.Windows.Forms.TextBox txt_sede;
        private System.Windows.Forms.Button btn_buscarSede;
        private System.Windows.Forms.Button btn_buscarJornada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Curso;
        private System.Windows.Forms.TextBox txt_Alumno;
        private System.Windows.Forms.Button btn_buscarAlumno;
        private System.Windows.Forms.Button btn_BuscarCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoJornada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarnetAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}