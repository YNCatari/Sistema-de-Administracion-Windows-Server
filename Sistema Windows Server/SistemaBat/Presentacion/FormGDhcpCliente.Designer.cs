namespace SistemaBat.Presentacion
{
    partial class FormGDhcpCliente
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
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCambiar.Location = new System.Drawing.Point(84, 140);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(109, 23);
            this.btnCambiar.TabIndex = 0;
            this.btnCambiar.Text = "Cambiar a Dinamico";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnVaciar.Location = new System.Drawing.Point(84, 180);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(109, 23);
            this.btnVaciar.TabIndex = 1;
            this.btnVaciar.Text = "Vaciar IP";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnRenovar
            // 
            this.btnRenovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRenovar.Location = new System.Drawing.Point(84, 218);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(109, 23);
            this.btnRenovar.TabIndex = 2;
            this.btnRenovar.Text = "Renovar IP";
            this.btnRenovar.UseVisualStyleBackColor = true;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(264, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(336, 316);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // FormGDhcpCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 408);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnCambiar);
            this.Name = "FormGDhcpCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGDhcpCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}