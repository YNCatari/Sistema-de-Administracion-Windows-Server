using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SistemaBat.Presentacion
{
    public partial class FrmGCambiarNombreEquipo : Form
    {
        public FrmGCambiarNombreEquipo()
        {
            InitializeComponent();
        }

        private void btnConfigurarAdaptador_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Cambiar_Nombre_Equipo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtnombre.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString("si"));

                proc.WaitForExit(100);

                if (rdbSI.Checked)
                {
                    proc.StandardInput.Write(rdbSI.Text);
                }
                if (rdbNo.Checked)
                {
                    proc.StandardInput.Write(rdbNo.Text);
                }

                proc.WaitForExit(100);



                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGPpc Frm = new FrmGPpc();
            Frm.Show();
            this.Hide();
        }
    }
}
