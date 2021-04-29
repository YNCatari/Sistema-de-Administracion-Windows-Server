namespace SistemaBat.Presentacion
{
    partial class FrmGNfsCliente
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grpDesmostar = new System.Windows.Forms.GroupBox();
            this.txtNombreDesmostrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesmontar = new System.Windows.Forms.Button();
            this.btnDesmontarUnidadCompartida = new System.Windows.Forms.Button();
            this.btnMontarUnidadCompartida = new System.Windows.Forms.Button();
            this.btnUnidadesMontadas = new System.Windows.Forms.Button();
            this.btnMostrarEquipoCompartido = new System.Windows.Forms.Button();
            this.btnMostrarEquipos = new System.Windows.Forms.Button();
            this.btnMostrarCarpetas = new System.Windows.Forms.Button();
            this.nfsContenedor = new System.Windows.Forms.RichTextBox();
            this.grpMontar = new System.Windows.Forms.GroupBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMontar = new System.Windows.Forms.Button();
            this.grpDesmostar.SuspendLayout();
            this.grpMontar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(944, 754);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(118, 28);
            this.btnRegresar.TabIndex = 99;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // grpDesmostar
            // 
            this.grpDesmostar.Controls.Add(this.txtNombreDesmostrar);
            this.grpDesmostar.Controls.Add(this.label3);
            this.grpDesmostar.Controls.Add(this.btnDesmontar);
            this.grpDesmostar.Location = new System.Drawing.Point(254, 368);
            this.grpDesmostar.Margin = new System.Windows.Forms.Padding(4);
            this.grpDesmostar.Name = "grpDesmostar";
            this.grpDesmostar.Padding = new System.Windows.Forms.Padding(4);
            this.grpDesmostar.Size = new System.Drawing.Size(327, 160);
            this.grpDesmostar.TabIndex = 97;
            this.grpDesmostar.TabStop = false;
            this.grpDesmostar.Text = "Desmontar";
            // 
            // txtNombreDesmostrar
            // 
            this.txtNombreDesmostrar.Location = new System.Drawing.Point(90, 75);
            this.txtNombreDesmostrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDesmostrar.Name = "txtNombreDesmostrar";
            this.txtNombreDesmostrar.Size = new System.Drawing.Size(132, 22);
            this.txtNombreDesmostrar.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Nombre letra de Unidad a desmontar:";
            // 
            // btnDesmontar
            // 
            this.btnDesmontar.Location = new System.Drawing.Point(90, 119);
            this.btnDesmontar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesmontar.Name = "btnDesmontar";
            this.btnDesmontar.Size = new System.Drawing.Size(119, 28);
            this.btnDesmontar.TabIndex = 58;
            this.btnDesmontar.Text = "Desmontar";
            this.btnDesmontar.UseVisualStyleBackColor = true;
            this.btnDesmontar.Click += new System.EventHandler(this.btnDesmontar_Click);
            // 
            // btnDesmontarUnidadCompartida
            // 
            this.btnDesmontarUnidadCompartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmontarUnidadCompartida.ForeColor = System.Drawing.Color.Blue;
            this.btnDesmontarUnidadCompartida.Location = new System.Drawing.Point(12, 598);
            this.btnDesmontarUnidadCompartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesmontarUnidadCompartida.Name = "btnDesmontarUnidadCompartida";
            this.btnDesmontarUnidadCompartida.Size = new System.Drawing.Size(221, 85);
            this.btnDesmontarUnidadCompartida.TabIndex = 95;
            this.btnDesmontarUnidadCompartida.Text = "Desmontar Unidad compartida";
            this.btnDesmontarUnidadCompartida.UseVisualStyleBackColor = true;
            this.btnDesmontarUnidadCompartida.Click += new System.EventHandler(this.btnDesmontarUnidadCompartida_Click);
            // 
            // btnMontarUnidadCompartida
            // 
            this.btnMontarUnidadCompartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontarUnidadCompartida.ForeColor = System.Drawing.Color.Blue;
            this.btnMontarUnidadCompartida.Location = new System.Drawing.Point(11, 506);
            this.btnMontarUnidadCompartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMontarUnidadCompartida.Name = "btnMontarUnidadCompartida";
            this.btnMontarUnidadCompartida.Size = new System.Drawing.Size(221, 85);
            this.btnMontarUnidadCompartida.TabIndex = 94;
            this.btnMontarUnidadCompartida.Text = "Montar Unidad compartida";
            this.btnMontarUnidadCompartida.UseVisualStyleBackColor = true;
            this.btnMontarUnidadCompartida.Click += new System.EventHandler(this.btnMontarUnidadCompartida_Click);
            // 
            // btnUnidadesMontadas
            // 
            this.btnUnidadesMontadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidadesMontadas.ForeColor = System.Drawing.Color.Blue;
            this.btnUnidadesMontadas.Location = new System.Drawing.Point(11, 414);
            this.btnUnidadesMontadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnidadesMontadas.Name = "btnUnidadesMontadas";
            this.btnUnidadesMontadas.Size = new System.Drawing.Size(221, 85);
            this.btnUnidadesMontadas.TabIndex = 93;
            this.btnUnidadesMontadas.Text = "Mostrar Unidades montadas";
            this.btnUnidadesMontadas.UseVisualStyleBackColor = true;
            this.btnUnidadesMontadas.Click += new System.EventHandler(this.btnUnidadesMontadas_Click);
            // 
            // btnMostrarEquipoCompartido
            // 
            this.btnMostrarEquipoCompartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEquipoCompartido.ForeColor = System.Drawing.Color.Blue;
            this.btnMostrarEquipoCompartido.Location = new System.Drawing.Point(12, 296);
            this.btnMostrarEquipoCompartido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarEquipoCompartido.Name = "btnMostrarEquipoCompartido";
            this.btnMostrarEquipoCompartido.Size = new System.Drawing.Size(221, 109);
            this.btnMostrarEquipoCompartido.TabIndex = 92;
            this.btnMostrarEquipoCompartido.Text = "Mostrar con que Equipos que han compartido las Unidades ";
            this.btnMostrarEquipoCompartido.UseVisualStyleBackColor = true;
            this.btnMostrarEquipoCompartido.Click += new System.EventHandler(this.btnMostrarEquipoCompartido_Click);
            // 
            // btnMostrarEquipos
            // 
            this.btnMostrarEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEquipos.ForeColor = System.Drawing.Color.Blue;
            this.btnMostrarEquipos.Location = new System.Drawing.Point(12, 204);
            this.btnMostrarEquipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarEquipos.Name = "btnMostrarEquipos";
            this.btnMostrarEquipos.Size = new System.Drawing.Size(221, 85);
            this.btnMostrarEquipos.TabIndex = 91;
            this.btnMostrarEquipos.Text = "Mostrar Equipos que han montado las Unidades Compartidas ";
            this.btnMostrarEquipos.UseVisualStyleBackColor = true;
            this.btnMostrarEquipos.Click += new System.EventHandler(this.btnMostrarEquipos_Click);
            // 
            // btnMostrarCarpetas
            // 
            this.btnMostrarCarpetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCarpetas.ForeColor = System.Drawing.Color.Blue;
            this.btnMostrarCarpetas.Location = new System.Drawing.Point(12, 111);
            this.btnMostrarCarpetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarCarpetas.Name = "btnMostrarCarpetas";
            this.btnMostrarCarpetas.Size = new System.Drawing.Size(221, 85);
            this.btnMostrarCarpetas.TabIndex = 90;
            this.btnMostrarCarpetas.Text = "Mostrar Carpetas compartidas";
            this.btnMostrarCarpetas.UseVisualStyleBackColor = true;
            this.btnMostrarCarpetas.Click += new System.EventHandler(this.btnMostrarCarpetas_Click);
            // 
            // nfsContenedor
            // 
            this.nfsContenedor.Location = new System.Drawing.Point(589, 89);
            this.nfsContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.nfsContenedor.Name = "nfsContenedor";
            this.nfsContenedor.Size = new System.Drawing.Size(473, 658);
            this.nfsContenedor.TabIndex = 88;
            this.nfsContenedor.Text = "";
            // 
            // grpMontar
            // 
            this.grpMontar.Controls.Add(this.txtUnidad);
            this.grpMontar.Controls.Add(this.label2);
            this.grpMontar.Controls.Add(this.txtNombreArchivo);
            this.grpMontar.Controls.Add(this.label1);
            this.grpMontar.Controls.Add(this.btnMontar);
            this.grpMontar.Location = new System.Drawing.Point(254, 111);
            this.grpMontar.Margin = new System.Windows.Forms.Padding(4);
            this.grpMontar.Name = "grpMontar";
            this.grpMontar.Padding = new System.Windows.Forms.Padding(4);
            this.grpMontar.Size = new System.Drawing.Size(327, 240);
            this.grpMontar.TabIndex = 100;
            this.grpMontar.TabStop = false;
            this.grpMontar.Text = "Montar";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(220, 106);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(65, 22);
            this.txtUnidad.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Ingrese letra de Unidad:";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(42, 76);
            this.txtNombreArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(247, 22);
            this.txtNombreArchivo.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Ingrese Nombre del archivo a montar:";
            // 
            // btnMontar
            // 
            this.btnMontar.Location = new System.Drawing.Point(103, 147);
            this.btnMontar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMontar.Name = "btnMontar";
            this.btnMontar.Size = new System.Drawing.Size(119, 28);
            this.btnMontar.TabIndex = 58;
            this.btnMontar.Text = "Montar";
            this.btnMontar.UseVisualStyleBackColor = true;
            this.btnMontar.Click += new System.EventHandler(this.btnMontar_Click);
            // 
            // FrmGNfsCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 815);
            this.Controls.Add(this.grpMontar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.grpDesmostar);
            this.Controls.Add(this.btnDesmontarUnidadCompartida);
            this.Controls.Add(this.btnMontarUnidadCompartida);
            this.Controls.Add(this.btnUnidadesMontadas);
            this.Controls.Add(this.btnMostrarEquipoCompartido);
            this.Controls.Add(this.btnMostrarEquipos);
            this.Controls.Add(this.btnMostrarCarpetas);
            this.Controls.Add(this.nfsContenedor);
            this.Name = "FrmGNfsCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGNfsCliente";
            this.Load += new System.EventHandler(this.FrmGNfsCliente_Load);
            this.grpDesmostar.ResumeLayout(false);
            this.grpDesmostar.PerformLayout();
            this.grpMontar.ResumeLayout(false);
            this.grpMontar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox grpDesmostar;
        private System.Windows.Forms.TextBox txtNombreDesmostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesmontar;
        private System.Windows.Forms.Button btnDesmontarUnidadCompartida;
        private System.Windows.Forms.Button btnMontarUnidadCompartida;
        private System.Windows.Forms.Button btnUnidadesMontadas;
        private System.Windows.Forms.Button btnMostrarEquipoCompartido;
        private System.Windows.Forms.Button btnMostrarEquipos;
        private System.Windows.Forms.Button btnMostrarCarpetas;
        private System.Windows.Forms.RichTextBox nfsContenedor;
        private System.Windows.Forms.GroupBox grpMontar;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMontar;
    }
}