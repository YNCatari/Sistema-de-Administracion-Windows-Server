namespace SistemaBat.Presentacion
{
    partial class FrmGNfs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGNfs));
            this.btnNfsServidor = new System.Windows.Forms.Button();
            this.btnNfsCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNfsServidor
            // 
            this.btnNfsServidor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNfsServidor.FlatAppearance.BorderSize = 0;
            this.btnNfsServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNfsServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNfsServidor.ForeColor = System.Drawing.Color.White;
            this.btnNfsServidor.Image = ((System.Drawing.Image)(resources.GetObject("btnNfsServidor.Image")));
            this.btnNfsServidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNfsServidor.Location = new System.Drawing.Point(318, 137);
            this.btnNfsServidor.Name = "btnNfsServidor";
            this.btnNfsServidor.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNfsServidor.Size = new System.Drawing.Size(251, 92);
            this.btnNfsServidor.TabIndex = 82;
            this.btnNfsServidor.Text = "Servidor";
            this.btnNfsServidor.UseVisualStyleBackColor = false;
            this.btnNfsServidor.Click += new System.EventHandler(this.btnNfsServidor_Click);
            // 
            // btnNfsCliente
            // 
            this.btnNfsCliente.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNfsCliente.FlatAppearance.BorderSize = 0;
            this.btnNfsCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNfsCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNfsCliente.ForeColor = System.Drawing.Color.White;
            this.btnNfsCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNfsCliente.Image")));
            this.btnNfsCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNfsCliente.Location = new System.Drawing.Point(32, 137);
            this.btnNfsCliente.Name = "btnNfsCliente";
            this.btnNfsCliente.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNfsCliente.Size = new System.Drawing.Size(251, 92);
            this.btnNfsCliente.TabIndex = 81;
            this.btnNfsCliente.Text = "Cliente";
            this.btnNfsCliente.UseVisualStyleBackColor = false;
            this.btnNfsCliente.Click += new System.EventHandler(this.btnNfsCliente_Click);
            // 
            // FrmGNfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnNfsServidor);
            this.Controls.Add(this.btnNfsCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGNfs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión NFS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNfsServidor;
        private System.Windows.Forms.Button btnNfsCliente;
    }
}