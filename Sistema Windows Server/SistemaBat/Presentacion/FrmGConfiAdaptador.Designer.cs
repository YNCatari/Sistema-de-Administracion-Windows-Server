namespace SistemaBat.Presentacion
{
    partial class FrmGConfiAdaptador
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfigurarAdaptador = new System.Windows.Forms.Button();
            this.txtip = new System.Windows.Forms.TextBox();
            this.txtdnss = new System.Windows.Forms.TextBox();
            this.txtdnsp = new System.Windows.Forms.TextBox();
            this.txtenlace = new System.Windows.Forms.TextBox();
            this.txtmascara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtadaptador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnewAdaptador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = " IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Ver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(263, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(507, 316);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(52, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 69);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cambiar Nombre Adaptador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(52, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 55);
            this.button1.TabIndex = 23;
            this.button1.Text = "Asignar Dinamicamente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfigurarAdaptador
            // 
            this.btnConfigurarAdaptador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarAdaptador.ForeColor = System.Drawing.Color.Blue;
            this.btnConfigurarAdaptador.Location = new System.Drawing.Point(52, 12);
            this.btnConfigurarAdaptador.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigurarAdaptador.Name = "btnConfigurarAdaptador";
            this.btnConfigurarAdaptador.Size = new System.Drawing.Size(149, 55);
            this.btnConfigurarAdaptador.TabIndex = 22;
            this.btnConfigurarAdaptador.Text = "Asignar Manualmente";
            this.btnConfigurarAdaptador.UseVisualStyleBackColor = true;
            this.btnConfigurarAdaptador.Click += new System.EventHandler(this.btnConfigurarAdaptador_Click);
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(101, 272);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(100, 20);
            this.txtip.TabIndex = 30;
            this.txtip.TextChanged += new System.EventHandler(this.txtip_TextChanged);
            // 
            // txtdnss
            // 
            this.txtdnss.Location = new System.Drawing.Point(101, 376);
            this.txtdnss.Name = "txtdnss";
            this.txtdnss.Size = new System.Drawing.Size(100, 20);
            this.txtdnss.TabIndex = 31;
            this.txtdnss.TextChanged += new System.EventHandler(this.txtdnss_TextChanged);
            // 
            // txtdnsp
            // 
            this.txtdnsp.Location = new System.Drawing.Point(101, 350);
            this.txtdnsp.Name = "txtdnsp";
            this.txtdnsp.Size = new System.Drawing.Size(100, 20);
            this.txtdnsp.TabIndex = 32;
            this.txtdnsp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtenlace
            // 
            this.txtenlace.Location = new System.Drawing.Point(101, 324);
            this.txtenlace.Name = "txtenlace";
            this.txtenlace.Size = new System.Drawing.Size(100, 20);
            this.txtenlace.TabIndex = 33;
            this.txtenlace.TextChanged += new System.EventHandler(this.txtenlace_TextChanged);
            // 
            // txtmascara
            // 
            this.txtmascara.Location = new System.Drawing.Point(101, 298);
            this.txtmascara.Name = "txtmascara";
            this.txtmascara.Size = new System.Drawing.Size(100, 20);
            this.txtmascara.TabIndex = 34;
            this.txtmascara.TextChanged += new System.EventHandler(this.txtmascara_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mascara";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = " P. Enlace";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = " DNS Primario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "DNS Secundario";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtadaptador
            // 
            this.txtadaptador.Location = new System.Drawing.Point(101, 246);
            this.txtadaptador.Name = "txtadaptador";
            this.txtadaptador.Size = new System.Drawing.Size(100, 20);
            this.txtadaptador.TabIndex = 40;
            this.txtadaptador.TextChanged += new System.EventHandler(this.txtadaptador_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Adaptador";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtnewAdaptador
            // 
            this.txtnewAdaptador.Location = new System.Drawing.Point(101, 402);
            this.txtnewAdaptador.Name = "txtnewAdaptador";
            this.txtnewAdaptador.Size = new System.Drawing.Size(100, 20);
            this.txtnewAdaptador.TabIndex = 42;
            this.txtnewAdaptador.TextChanged += new System.EventHandler(this.txtnewAdaptador_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nuevo Adaptador";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(523, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmGConfiAdaptador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtnewAdaptador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtadaptador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmascara);
            this.Controls.Add(this.txtenlace);
            this.Controls.Add(this.txtdnsp);
            this.Controls.Add(this.txtdnss);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfigurarAdaptador);
            this.Name = "FrmGConfiAdaptador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGConfiAdaptador";
            this.Load += new System.EventHandler(this.FrmGConfiAdaptador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfigurarAdaptador;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.TextBox txtdnss;
        private System.Windows.Forms.TextBox txtdnsp;
        private System.Windows.Forms.TextBox txtenlace;
        private System.Windows.Forms.TextBox txtmascara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtadaptador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnewAdaptador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
    }
}