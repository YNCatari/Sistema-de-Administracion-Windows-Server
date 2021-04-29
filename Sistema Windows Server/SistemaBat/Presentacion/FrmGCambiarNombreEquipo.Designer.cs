namespace SistemaBat.Presentacion
{
    partial class FrmGCambiarNombreEquipo
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnConfigurarAdaptador = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.rdbSI = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(288, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(507, 225);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            // 
            // btnConfigurarAdaptador
            // 
            this.btnConfigurarAdaptador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarAdaptador.ForeColor = System.Drawing.Color.Blue;
            this.btnConfigurarAdaptador.Location = new System.Drawing.Point(41, 199);
            this.btnConfigurarAdaptador.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigurarAdaptador.Name = "btnConfigurarAdaptador";
            this.btnConfigurarAdaptador.Size = new System.Drawing.Size(149, 55);
            this.btnConfigurarAdaptador.TabIndex = 43;
            this.btnConfigurarAdaptador.Text = "Cambiar Nombre";
            this.btnConfigurarAdaptador.UseVisualStyleBackColor = true;
            this.btnConfigurarAdaptador.Click += new System.EventHandler(this.btnConfigurarAdaptador_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nuevo Nombre de Equipo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(151, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 59;
            // 
            // rdbSI
            // 
            this.rdbSI.AutoSize = true;
            this.rdbSI.Location = new System.Drawing.Point(28, 135);
            this.rdbSI.Name = "rdbSI";
            this.rdbSI.Size = new System.Drawing.Size(32, 17);
            this.rdbSI.TabIndex = 61;
            this.rdbSI.TabStop = true;
            this.rdbSI.Text = "si";
            this.rdbSI.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Reiniciar";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(117, 135);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(37, 17);
            this.rdbNo.TabIndex = 64;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "no";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGCambiarNombreEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbSI);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnConfigurarAdaptador);
            this.Name = "FrmGCambiarNombreEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGCambiarNombreEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnConfigurarAdaptador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.RadioButton rdbSI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.Button button1;
    }
}