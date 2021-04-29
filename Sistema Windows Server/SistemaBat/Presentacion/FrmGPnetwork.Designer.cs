namespace SistemaBat.Presentacion
{
    partial class FrmGPnetwork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGPnetwork));
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerAdaptador = new System.Windows.Forms.Button();
            this.btnConfigurarAdaptador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(263, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "NETWORK";
            // 
            // btnVerAdaptador
            // 
            this.btnVerAdaptador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAdaptador.ForeColor = System.Drawing.Color.Blue;
            this.btnVerAdaptador.Location = new System.Drawing.Point(367, 337);
            this.btnVerAdaptador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerAdaptador.Name = "btnVerAdaptador";
            this.btnVerAdaptador.Size = new System.Drawing.Size(133, 55);
            this.btnVerAdaptador.TabIndex = 10;
            this.btnVerAdaptador.Text = "Ver Adaptador";
            this.btnVerAdaptador.UseVisualStyleBackColor = true;
            this.btnVerAdaptador.Click += new System.EventHandler(this.btnVerAdaptador_Click);
            // 
            // btnConfigurarAdaptador
            // 
            this.btnConfigurarAdaptador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarAdaptador.ForeColor = System.Drawing.Color.Blue;
            this.btnConfigurarAdaptador.Location = new System.Drawing.Point(106, 337);
            this.btnConfigurarAdaptador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfigurarAdaptador.Name = "btnConfigurarAdaptador";
            this.btnConfigurarAdaptador.Size = new System.Drawing.Size(133, 55);
            this.btnConfigurarAdaptador.TabIndex = 11;
            this.btnConfigurarAdaptador.Text = "Configurar Adaptador";
            this.btnConfigurarAdaptador.UseVisualStyleBackColor = true;
            this.btnConfigurarAdaptador.Click += new System.EventHandler(this.btnConfigurarAdaptador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGPnetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfigurarAdaptador);
            this.Controls.Add(this.btnVerAdaptador);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGPnetwork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar de Network";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerAdaptador;
        private System.Windows.Forms.Button btnConfigurarAdaptador;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}