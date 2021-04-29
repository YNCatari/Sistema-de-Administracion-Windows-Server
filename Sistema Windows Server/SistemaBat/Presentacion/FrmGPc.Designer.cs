namespace SistemaBat.Presentacion
{
    partial class FrmGPc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGPc));
            this.btnPC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNetwork = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPC
            // 
            this.btnPC.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPC.BackgroundImage")));
            this.btnPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPC.Location = new System.Drawing.Point(221, 136);
            this.btnPC.Name = "btnPC";
            this.btnPC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPC.Size = new System.Drawing.Size(203, 202);
            this.btnPC.TabIndex = 1;
            this.btnPC.UseVisualStyleBackColor = false;
            this.btnPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(130, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Qué desea Gestionar?";
            // 
            // btnNetwork
            // 
            this.btnNetwork.BackColor = System.Drawing.Color.SkyBlue;
            this.btnNetwork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNetwork.BackgroundImage")));
            this.btnNetwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNetwork.Location = new System.Drawing.Point(12, 136);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNetwork.Size = new System.Drawing.Size(203, 202);
            this.btnNetwork.TabIndex = 5;
            this.btnNetwork.UseVisualStyleBackColor = false;
            this.btnNetwork.Click += new System.EventHandler(this.btnNetwork_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(304, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "PC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(75, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "NETWORK";
            // 
            // FrmGPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 424);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNetwork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPC);
            this.Name = "FrmGPc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de PC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNetwork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}