namespace SistemaBat.Presentacion
{
    partial class FrmSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccion));
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.btnInstalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(591, 456);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(192, 44);
            this.btnSalir.TabIndex = 73;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(511, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "GESTIONAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(172, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "INSTALAR";
            // 
            // btnGestionar
            // 
            this.btnGestionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGestionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGestionar.BackgroundImage")));
            this.btnGestionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGestionar.Location = new System.Drawing.Point(430, 123);
            this.btnGestionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGestionar.Size = new System.Drawing.Size(271, 248);
            this.btnGestionar.TabIndex = 75;
            this.btnGestionar.UseVisualStyleBackColor = false;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // btnInstalar
            // 
            this.btnInstalar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInstalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstalar.BackgroundImage")));
            this.btnInstalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstalar.Location = new System.Drawing.Point(90, 123);
            this.btnInstalar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInstalar.Size = new System.Drawing.Size(271, 248);
            this.btnInstalar.TabIndex = 74;
            this.btnInstalar.UseVisualStyleBackColor = false;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // FrmSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGestionar);
            this.Controls.Add(this.btnInstalar);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Selección";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Button btnInstalar;
    }
}