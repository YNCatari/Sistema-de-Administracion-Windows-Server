namespace SistemaBat.Presentacion
{
    partial class FrmGNfsServidor
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
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminarCarpeta = new System.Windows.Forms.Button();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMostrarUnidadesMontadas = new System.Windows.Forms.Button();
            this.btnMostrarEquiposCompartidos = new System.Windows.Forms.Button();
            this.btnMostrarEquiposMontados = new System.Windows.Forms.Button();
            this.btnMostrarCarpetas = new System.Windows.Forms.Button();
            this.btnEliminarCarpetas = new System.Windows.Forms.Button();
            this.btnCompartirAsignar = new System.Windows.Forms.Button();
            this.grpCompartirAsignar = new System.Windows.Forms.GroupBox();
            this.grpCompartirDetalle = new System.Windows.Forms.GroupBox();
            this.txtNombreCompartir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnviarLetra = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nfsContenedor = new System.Windows.Forms.RichTextBox();
            this.grpElegirLetra = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.grpPermisos = new System.Windows.Forms.GroupBox();
            this.rbNegarAcceso = new System.Windows.Forms.RadioButton();
            this.rbLecturaEscritura = new System.Windows.Forms.RadioButton();
            this.rbSoloLectura = new System.Windows.Forms.RadioButton();
            this.btnEnviarCompartir = new System.Windows.Forms.Button();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.grpAsignar = new System.Windows.Forms.GroupBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpEliminar.SuspendLayout();
            this.grpCompartirAsignar.SuspendLayout();
            this.grpCompartirDetalle.SuspendLayout();
            this.grpElegirLetra.SuspendLayout();
            this.grpPermisos.SuspendLayout();
            this.grpAsignar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.btnEliminarCarpeta);
            this.grpEliminar.Controls.Add(this.txtNombreEliminar);
            this.grpEliminar.Controls.Add(this.label6);
            this.grpEliminar.Location = new System.Drawing.Point(718, 583);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(480, 161);
            this.grpEliminar.TabIndex = 99;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Eliminar Carpetas";
            // 
            // btnEliminarCarpeta
            // 
            this.btnEliminarCarpeta.Location = new System.Drawing.Point(211, 115);
            this.btnEliminarCarpeta.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCarpeta.Name = "btnEliminarCarpeta";
            this.btnEliminarCarpeta.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarCarpeta.TabIndex = 72;
            this.btnEliminarCarpeta.Text = "Eliminar";
            this.btnEliminarCarpeta.UseVisualStyleBackColor = true;
            this.btnEliminarCarpeta.Click += new System.EventHandler(this.btnEliminarCarpeta_Click);
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Location = new System.Drawing.Point(211, 60);
            this.txtNombreEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(154, 22);
            this.txtNombreEliminar.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Nombre a eliminar:";
            // 
            // btnMostrarUnidadesMontadas
            // 
            this.btnMostrarUnidadesMontadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUnidadesMontadas.ForeColor = System.Drawing.Color.Blue;
            this.btnMostrarUnidadesMontadas.Location = new System.Drawing.Point(21, 570);
            this.btnMostrarUnidadesMontadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarUnidadesMontadas.Name = "btnMostrarUnidadesMontadas";
            this.btnMostrarUnidadesMontadas.Size = new System.Drawing.Size(221, 85);
            this.btnMostrarUnidadesMontadas.TabIndex = 97;
            this.btnMostrarUnidadesMontadas.Text = "Mostrar Unidades Montadas";
            this.btnMostrarUnidadesMontadas.UseVisualStyleBackColor = true;
            this.btnMostrarUnidadesMontadas.Click += new System.EventHandler(this.btnMostrarUnidadesMontadas_Click);
            // 
            // btnMostrarEquiposCompartidos
            // 
            this.btnMostrarEquiposCompartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEquiposCompartidos.ForeColor = System.Drawing.Color.Blue;
            this.btnMostrarEquiposCompartidos.Location = new System.Drawing.Point(20, 478);
            this.btnMostrarEquiposCompartidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarEquiposCompartidos.Name = "btnMostrarEquiposCompartidos";
            this.btnMostrarEquiposCompartidos.Size = new System.Drawing.Size(221, 85);
            this.btnMostrarEquiposCompartidos.TabIndex = 96;
            this.btnMostrarEquiposCompartidos.Text = "Mostrar Equipos Compartidos";
            this.btnMostrarEquiposCompartidos.UseVisualStyleBackColor = true;
            this.btnMostrarEquiposCompartidos.Click += new System.EventHandler(this.btnMostrarEquiposCompartidos_Click);
            // 
            // btnMostrarEquiposMontados
            // 
            this.btnMostrarEquiposMontados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEquiposMontados.ForeColor = System.Drawing.Color.Blue;
            this.btnMostrarEquiposMontados.Location = new System.Drawing.Point(20, 386);
            this.btnMostrarEquiposMontados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarEquiposMontados.Name = "btnMostrarEquiposMontados";
            this.btnMostrarEquiposMontados.Size = new System.Drawing.Size(221, 85);
            this.btnMostrarEquiposMontados.TabIndex = 95;
            this.btnMostrarEquiposMontados.Text = "Mostrar Equipos Montados";
            this.btnMostrarEquiposMontados.UseVisualStyleBackColor = true;
            this.btnMostrarEquiposMontados.Click += new System.EventHandler(this.btnMostrarEquiposMontados_Click);
            // 
            // btnMostrarCarpetas
            // 
            this.btnMostrarCarpetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCarpetas.ForeColor = System.Drawing.Color.Blue;
            this.btnMostrarCarpetas.Location = new System.Drawing.Point(21, 293);
            this.btnMostrarCarpetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarCarpetas.Name = "btnMostrarCarpetas";
            this.btnMostrarCarpetas.Size = new System.Drawing.Size(221, 85);
            this.btnMostrarCarpetas.TabIndex = 94;
            this.btnMostrarCarpetas.Text = "Mostrar Carpetas Compartidas";
            this.btnMostrarCarpetas.UseVisualStyleBackColor = true;
            this.btnMostrarCarpetas.Click += new System.EventHandler(this.btnMostrarCarpetas_Click);
            // 
            // btnEliminarCarpetas
            // 
            this.btnEliminarCarpetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCarpetas.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminarCarpetas.Location = new System.Drawing.Point(21, 201);
            this.btnEliminarCarpetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarCarpetas.Name = "btnEliminarCarpetas";
            this.btnEliminarCarpetas.Size = new System.Drawing.Size(221, 85);
            this.btnEliminarCarpetas.TabIndex = 93;
            this.btnEliminarCarpetas.Text = "Eliminar Carpetas ";
            this.btnEliminarCarpetas.UseVisualStyleBackColor = true;
            this.btnEliminarCarpetas.Click += new System.EventHandler(this.btnEliminarCarpetas_Click);
            // 
            // btnCompartirAsignar
            // 
            this.btnCompartirAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompartirAsignar.ForeColor = System.Drawing.Color.Blue;
            this.btnCompartirAsignar.Location = new System.Drawing.Point(21, 108);
            this.btnCompartirAsignar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompartirAsignar.Name = "btnCompartirAsignar";
            this.btnCompartirAsignar.Size = new System.Drawing.Size(221, 85);
            this.btnCompartirAsignar.TabIndex = 92;
            this.btnCompartirAsignar.Text = "Compartir / Asignar permisos con NFS";
            this.btnCompartirAsignar.UseVisualStyleBackColor = true;
            this.btnCompartirAsignar.Click += new System.EventHandler(this.btnCompartirAsignar_Click);
            // 
            // grpCompartirAsignar
            // 
            this.grpCompartirAsignar.Controls.Add(this.grpCompartirDetalle);
            this.grpCompartirAsignar.Location = new System.Drawing.Point(261, 247);
            this.grpCompartirAsignar.Margin = new System.Windows.Forms.Padding(4);
            this.grpCompartirAsignar.Name = "grpCompartirAsignar";
            this.grpCompartirAsignar.Padding = new System.Windows.Forms.Padding(4);
            this.grpCompartirAsignar.Size = new System.Drawing.Size(428, 143);
            this.grpCompartirAsignar.TabIndex = 91;
            this.grpCompartirAsignar.TabStop = false;
            this.grpCompartirAsignar.Text = "Compartir / Asignar";
            // 
            // grpCompartirDetalle
            // 
            this.grpCompartirDetalle.Controls.Add(this.txtNombreCompartir);
            this.grpCompartirDetalle.Controls.Add(this.label2);
            this.grpCompartirDetalle.Controls.Add(this.txtDirectorio);
            this.grpCompartirDetalle.Controls.Add(this.label3);
            this.grpCompartirDetalle.Location = new System.Drawing.Point(30, 22);
            this.grpCompartirDetalle.Name = "grpCompartirDetalle";
            this.grpCompartirDetalle.Size = new System.Drawing.Size(363, 100);
            this.grpCompartirDetalle.TabIndex = 102;
            this.grpCompartirDetalle.TabStop = false;
            // 
            // txtNombreCompartir
            // 
            this.txtNombreCompartir.Location = new System.Drawing.Point(204, 59);
            this.txtNombreCompartir.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCompartir.Name = "txtNombreCompartir";
            this.txtNombreCompartir.Size = new System.Drawing.Size(132, 22);
            this.txtNombreCompartir.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Directorio a compartir:";
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(204, 29);
            this.txtDirectorio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(132, 22);
            this.txtDirectorio.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nombre a compartir:";
            // 
            // btnEnviarLetra
            // 
            this.btnEnviarLetra.Location = new System.Drawing.Point(147, 67);
            this.btnEnviarLetra.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviarLetra.Name = "btnEnviarLetra";
            this.btnEnviarLetra.Size = new System.Drawing.Size(100, 28);
            this.btnEnviarLetra.TabIndex = 58;
            this.btnEnviarLetra.Text = "Aceptar";
            this.btnEnviarLetra.UseVisualStyleBackColor = true;
            this.btnEnviarLetra.Click += new System.EventHandler(this.btnEnviarLetra_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(210, 27);
            this.txtLetra.Margin = new System.Windows.Forms.Padding(4);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(132, 22);
            this.txtLetra.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ingrese Letra:";
            // 
            // nfsContenedor
            // 
            this.nfsContenedor.Location = new System.Drawing.Point(718, 86);
            this.nfsContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.nfsContenedor.Name = "nfsContenedor";
            this.nfsContenedor.Size = new System.Drawing.Size(480, 474);
            this.nfsContenedor.TabIndex = 89;
            this.nfsContenedor.Text = "";
            // 
            // grpElegirLetra
            // 
            this.grpElegirLetra.Controls.Add(this.txtLetra);
            this.grpElegirLetra.Controls.Add(this.label1);
            this.grpElegirLetra.Controls.Add(this.btnEnviarLetra);
            this.grpElegirLetra.Location = new System.Drawing.Point(261, 108);
            this.grpElegirLetra.Name = "grpElegirLetra";
            this.grpElegirLetra.Size = new System.Drawing.Size(429, 115);
            this.grpElegirLetra.TabIndex = 64;
            this.grpElegirLetra.TabStop = false;
            this.grpElegirLetra.Text = "Elegir Letra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(378, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Asignar Equipos Especificos?";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.BackColor = System.Drawing.Color.Transparent;
            this.rdbNo.Location = new System.Drawing.Point(486, 447);
            this.rdbNo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(45, 21);
            this.rdbNo.TabIndex = 103;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "no";
            this.rdbNo.UseVisualStyleBackColor = false;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // grpPermisos
            // 
            this.grpPermisos.Controls.Add(this.rbNegarAcceso);
            this.grpPermisos.Controls.Add(this.rbLecturaEscritura);
            this.grpPermisos.Controls.Add(this.rbSoloLectura);
            this.grpPermisos.Controls.Add(this.btnEnviarCompartir);
            this.grpPermisos.Location = new System.Drawing.Point(291, 608);
            this.grpPermisos.Name = "grpPermisos";
            this.grpPermisos.Size = new System.Drawing.Size(379, 118);
            this.grpPermisos.TabIndex = 106;
            this.grpPermisos.TabStop = false;
            this.grpPermisos.Text = "Asignar Permisos";
            // 
            // rbNegarAcceso
            // 
            this.rbNegarAcceso.AutoSize = true;
            this.rbNegarAcceso.BackColor = System.Drawing.Color.Transparent;
            this.rbNegarAcceso.Location = new System.Drawing.Point(261, 43);
            this.rbNegarAcceso.Margin = new System.Windows.Forms.Padding(4);
            this.rbNegarAcceso.Name = "rbNegarAcceso";
            this.rbNegarAcceso.Size = new System.Drawing.Size(118, 21);
            this.rbNegarAcceso.TabIndex = 111;
            this.rbNegarAcceso.TabStop = true;
            this.rbNegarAcceso.Text = "Negar Acceso";
            this.rbNegarAcceso.UseVisualStyleBackColor = false;
            // 
            // rbLecturaEscritura
            // 
            this.rbLecturaEscritura.AutoSize = true;
            this.rbLecturaEscritura.BackColor = System.Drawing.Color.Transparent;
            this.rbLecturaEscritura.Location = new System.Drawing.Point(117, 43);
            this.rbLecturaEscritura.Margin = new System.Windows.Forms.Padding(4);
            this.rbLecturaEscritura.Name = "rbLecturaEscritura";
            this.rbLecturaEscritura.Size = new System.Drawing.Size(148, 21);
            this.rbLecturaEscritura.TabIndex = 110;
            this.rbLecturaEscritura.TabStop = true;
            this.rbLecturaEscritura.Text = "Lectura y Escritura";
            this.rbLecturaEscritura.UseVisualStyleBackColor = false;
            // 
            // rbSoloLectura
            // 
            this.rbSoloLectura.AutoSize = true;
            this.rbSoloLectura.BackColor = System.Drawing.Color.Transparent;
            this.rbSoloLectura.Location = new System.Drawing.Point(7, 44);
            this.rbSoloLectura.Margin = new System.Windows.Forms.Padding(4);
            this.rbSoloLectura.Name = "rbSoloLectura";
            this.rbSoloLectura.Size = new System.Drawing.Size(109, 21);
            this.rbSoloLectura.TabIndex = 109;
            this.rbSoloLectura.TabStop = true;
            this.rbSoloLectura.Text = "Solo Lectura";
            this.rbSoloLectura.UseVisualStyleBackColor = false;
            // 
            // btnEnviarCompartir
            // 
            this.btnEnviarCompartir.Location = new System.Drawing.Point(121, 79);
            this.btnEnviarCompartir.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviarCompartir.Name = "btnEnviarCompartir";
            this.btnEnviarCompartir.Size = new System.Drawing.Size(100, 28);
            this.btnEnviarCompartir.TabIndex = 69;
            this.btnEnviarCompartir.Text = "Enviar";
            this.btnEnviarCompartir.UseVisualStyleBackColor = true;
            this.btnEnviarCompartir.Click += new System.EventHandler(this.btnEnviarCompartir_Click);
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.BackColor = System.Drawing.Color.Transparent;
            this.rdbSi.Location = new System.Drawing.Point(395, 447);
            this.rdbSi.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(39, 21);
            this.rdbSi.TabIndex = 102;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "si";
            this.rdbSi.UseVisualStyleBackColor = false;
            this.rdbSi.CheckedChanged += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // grpAsignar
            // 
            this.grpAsignar.Controls.Add(this.txtNombreEquipo);
            this.grpAsignar.Controls.Add(this.label5);
            this.grpAsignar.Location = new System.Drawing.Point(291, 475);
            this.grpAsignar.Name = "grpAsignar";
            this.grpAsignar.Size = new System.Drawing.Size(379, 89);
            this.grpAsignar.TabIndex = 104;
            this.grpAsignar.TabStop = false;
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(183, 37);
            this.txtNombreEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(132, 22);
            this.txtNombreEquipo.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "Nombre del equipo";
            // 
            // FrmGNfsServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 786);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.grpPermisos);
            this.Controls.Add(this.rdbSi);
            this.Controls.Add(this.grpAsignar);
            this.Controls.Add(this.grpElegirLetra);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.btnMostrarUnidadesMontadas);
            this.Controls.Add(this.btnMostrarEquiposCompartidos);
            this.Controls.Add(this.btnMostrarEquiposMontados);
            this.Controls.Add(this.btnMostrarCarpetas);
            this.Controls.Add(this.btnEliminarCarpetas);
            this.Controls.Add(this.btnCompartirAsignar);
            this.Controls.Add(this.grpCompartirAsignar);
            this.Controls.Add(this.nfsContenedor);
            this.Name = "FrmGNfsServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGNfsServidor";
            this.Load += new System.EventHandler(this.FrmGNfsServidor_Load);
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            this.grpCompartirAsignar.ResumeLayout(false);
            this.grpCompartirDetalle.ResumeLayout(false);
            this.grpCompartirDetalle.PerformLayout();
            this.grpElegirLetra.ResumeLayout(false);
            this.grpElegirLetra.PerformLayout();
            this.grpPermisos.ResumeLayout(false);
            this.grpPermisos.PerformLayout();
            this.grpAsignar.ResumeLayout(false);
            this.grpAsignar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Button btnEliminarCarpeta;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMostrarUnidadesMontadas;
        private System.Windows.Forms.Button btnMostrarEquiposCompartidos;
        private System.Windows.Forms.Button btnMostrarEquiposMontados;
        private System.Windows.Forms.Button btnMostrarCarpetas;
        private System.Windows.Forms.Button btnEliminarCarpetas;
        private System.Windows.Forms.Button btnCompartirAsignar;
        private System.Windows.Forms.GroupBox grpCompartirAsignar;
        private System.Windows.Forms.TextBox txtNombreCompartir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviarLetra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox nfsContenedor;
        private System.Windows.Forms.GroupBox grpCompartirDetalle;
        private System.Windows.Forms.GroupBox grpElegirLetra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.GroupBox grpPermisos;
        private System.Windows.Forms.Button btnEnviarCompartir;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.GroupBox grpAsignar;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbNegarAcceso;
        private System.Windows.Forms.RadioButton rbLecturaEscritura;
        private System.Windows.Forms.RadioButton rbSoloLectura;
    }
}