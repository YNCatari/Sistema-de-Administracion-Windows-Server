namespace SistemaBat.Presentacion
{
    partial class FrmGIIS
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
            this.btbVerSitiosWeb = new System.Windows.Forms.Button();
            this.IISContenedor = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpCrear = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreSitio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.txtNombreSitio2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarSitio = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpCrearDir = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCarpeta2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreSitio3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreDir = new System.Windows.Forms.TextBox();
            this.btnCrear3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.grpIni = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreSitio4 = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.grpCrear.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            this.grpCrearDir.SuspendLayout();
            this.grpIni.SuspendLayout();
            this.SuspendLayout();
            // 
            // btbVerSitiosWeb
            // 
            this.btbVerSitiosWeb.Location = new System.Drawing.Point(12, 79);
            this.btbVerSitiosWeb.Name = "btbVerSitiosWeb";
            this.btbVerSitiosWeb.Size = new System.Drawing.Size(105, 32);
            this.btbVerSitiosWeb.TabIndex = 0;
            this.btbVerSitiosWeb.Text = "Ver Sitios Web";
            this.btbVerSitiosWeb.UseVisualStyleBackColor = true;
            this.btbVerSitiosWeb.Click += new System.EventHandler(this.button1_Click);
            // 
            // IISContenedor
            // 
            this.IISContenedor.Location = new System.Drawing.Point(334, 86);
            this.IISContenedor.Name = "IISContenedor";
            this.IISContenedor.Size = new System.Drawing.Size(736, 275);
            this.IISContenedor.TabIndex = 1;
            this.IISContenedor.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear Sitios Web";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // grpCrear
            // 
            this.grpCrear.Controls.Add(this.btnCrear);
            this.grpCrear.Controls.Add(this.txtDireccion);
            this.grpCrear.Controls.Add(this.label5);
            this.grpCrear.Controls.Add(this.btnVer);
            this.grpCrear.Controls.Add(this.txtCarpeta);
            this.grpCrear.Controls.Add(this.label4);
            this.grpCrear.Controls.Add(this.txtPuerto);
            this.grpCrear.Controls.Add(this.label3);
            this.grpCrear.Controls.Add(this.txtIP);
            this.grpCrear.Controls.Add(this.label2);
            this.grpCrear.Controls.Add(this.txtNombreSitio);
            this.grpCrear.Controls.Add(this.label1);
            this.grpCrear.Location = new System.Drawing.Point(128, 79);
            this.grpCrear.Name = "grpCrear";
            this.grpCrear.Size = new System.Drawing.Size(200, 176);
            this.grpCrear.TabIndex = 3;
            this.grpCrear.TabStop = false;
            this.grpCrear.Text = "Crear Sitios Web";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Sitio:";
            // 
            // txtNombreSitio
            // 
            this.txtNombreSitio.Location = new System.Drawing.Point(94, 17);
            this.txtNombreSitio.Name = "txtNombreSitio";
            this.txtNombreSitio.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSitio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(94, 41);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(94, 64);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(45, 20);
            this.txtPuerto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Carpeta: ";
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(94, 86);
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.Size = new System.Drawing.Size(59, 20);
            this.txtCarpeta.TabIndex = 7;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(159, 83);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(35, 25);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(94, 111);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(83, 145);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(56, 25);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Eliminar Sitio web";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.btnEliminarSitio);
            this.grpEliminar.Controls.Add(this.txtNombreSitio2);
            this.grpEliminar.Controls.Add(this.label6);
            this.grpEliminar.Location = new System.Drawing.Point(128, 261);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(200, 100);
            this.grpEliminar.TabIndex = 5;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "Eliminar Sitio Web";
            // 
            // txtNombreSitio2
            // 
            this.txtNombreSitio2.Location = new System.Drawing.Point(94, 22);
            this.txtNombreSitio2.Name = "txtNombreSitio2";
            this.txtNombreSitio2.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSitio2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre del Sitio:";
            // 
            // btnEliminarSitio
            // 
            this.btnEliminarSitio.Location = new System.Drawing.Point(71, 59);
            this.btnEliminarSitio.Name = "btnEliminarSitio";
            this.btnEliminarSitio.Size = new System.Drawing.Size(56, 25);
            this.btnEliminarSitio.TabIndex = 11;
            this.btnEliminarSitio.Text = "Eliminar";
            this.btnEliminarSitio.UseVisualStyleBackColor = true;
            this.btnEliminarSitio.Click += new System.EventHandler(this.btnEliminarSitio_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Crear Dir. Virtual";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grpCrearDir
            // 
            this.grpCrearDir.Controls.Add(this.btnCrear3);
            this.grpCrearDir.Controls.Add(this.label9);
            this.grpCrearDir.Controls.Add(this.txtNombreDir);
            this.grpCrearDir.Controls.Add(this.button4);
            this.grpCrearDir.Controls.Add(this.label8);
            this.grpCrearDir.Controls.Add(this.txtCarpeta2);
            this.grpCrearDir.Controls.Add(this.txtNombreSitio3);
            this.grpCrearDir.Controls.Add(this.label7);
            this.grpCrearDir.Location = new System.Drawing.Point(128, 367);
            this.grpCrearDir.Name = "grpCrearDir";
            this.grpCrearDir.Size = new System.Drawing.Size(200, 137);
            this.grpCrearDir.TabIndex = 7;
            this.grpCrearDir.TabStop = false;
            this.grpCrearDir.Text = "Crear Dir Virutal";
            this.grpCrearDir.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 25);
            this.button4.TabIndex = 13;
            this.button4.Text = "Ver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtCarpeta2
            // 
            this.txtCarpeta2.Location = new System.Drawing.Point(94, 73);
            this.txtCarpeta2.Name = "txtCarpeta2";
            this.txtCarpeta2.Size = new System.Drawing.Size(59, 20);
            this.txtCarpeta2.TabIndex = 15;
            this.txtCarpeta2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Carpeta: ";
            // 
            // txtNombreSitio3
            // 
            this.txtNombreSitio3.Location = new System.Drawing.Point(94, 24);
            this.txtNombreSitio3.Name = "txtNombreSitio3";
            this.txtNombreSitio3.Size = new System.Drawing.Size(100, 20);
            this.txtNombreSitio3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre del Sitio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nombre del Dir";
            // 
            // txtNombreDir
            // 
            this.txtNombreDir.Location = new System.Drawing.Point(94, 49);
            this.txtNombreDir.Name = "txtNombreDir";
            this.txtNombreDir.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDir.TabIndex = 17;
            this.txtNombreDir.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnCrear3
            // 
            this.btnCrear3.Location = new System.Drawing.Point(71, 106);
            this.btnCrear3.Name = "btnCrear3";
            this.btnCrear3.Size = new System.Drawing.Size(56, 25);
            this.btnCrear3.TabIndex = 11;
            this.btnCrear3.Text = "Crear";
            this.btnCrear3.UseVisualStyleBackColor = true;
            this.btnCrear3.Click += new System.EventHandler(this.button5_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "Iniciar/Detener";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // grpIni
            // 
            this.grpIni.Controls.Add(this.btnReiniciar);
            this.grpIni.Controls.Add(this.btnDetener);
            this.grpIni.Controls.Add(this.btnIniciar);
            this.grpIni.Controls.Add(this.label10);
            this.grpIni.Controls.Add(this.txtNombreSitio4);
            this.grpIni.Location = new System.Drawing.Point(334, 367);
            this.grpIni.Name = "grpIni";
            this.grpIni.Size = new System.Drawing.Size(264, 100);
            this.grpIni.TabIndex = 9;
            this.grpIni.TabStop = false;
            this.grpIni.Text = "Iniciar/Detener/reiniciar";
            this.grpIni.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nombre del Sitio:";
            // 
            // txtNombreSitio4
            // 
            this.txtNombreSitio4.Location = new System.Drawing.Point(99, 21);
            this.txtNombreSitio4.Name = "txtNombreSitio4";
            this.txtNombreSitio4.Size = new System.Drawing.Size(107, 20);
            this.txtNombreSitio4.TabIndex = 19;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(37, 67);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(56, 25);
            this.btnIniciar.TabIndex = 18;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(115, 67);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(56, 25);
            this.btnDetener.TabIndex = 20;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(189, 67);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(56, 25);
            this.btnReiniciar.TabIndex = 21;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // FrmGIIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 521);
            this.Controls.Add(this.grpIni);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.grpCrearDir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grpCrear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IISContenedor);
            this.Controls.Add(this.btbVerSitiosWeb);
            this.Name = "FrmGIIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGIIS";
            this.grpCrear.ResumeLayout(false);
            this.grpCrear.PerformLayout();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            this.grpCrearDir.ResumeLayout(false);
            this.grpCrearDir.PerformLayout();
            this.grpIni.ResumeLayout(false);
            this.grpIni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btbVerSitiosWeb;
        private System.Windows.Forms.RichTextBox IISContenedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCrear;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreSitio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Button btnEliminarSitio;
        private System.Windows.Forms.TextBox txtNombreSitio2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grpCrearDir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCarpeta2;
        private System.Windows.Forms.TextBox txtNombreSitio3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCrear3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreDir;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox grpIni;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreSitio4;
    }
}