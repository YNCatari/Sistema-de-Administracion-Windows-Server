using MaterialSkin.Controls;
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
    public partial class FrmArchivos : MaterialForm
    {
        public FrmArchivos()
        {
            InitializeComponent();
        }

        private void FrmArchivos_Load(object sender, EventArgs e)
        {

        }

        private void btncreararchivo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            grpnuevo.Enabled = true;
            grpmodificar.Enabled = false;

            grpeliminar.Enabled = false;
        }

        private void btnremonbrararchivo_Click(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = true;

            grpeliminar.Enabled = false;
        }

        private void btneliminararchivo_Click(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = false;

            grpeliminar.Enabled = true;
        }

        private void btnlistararchvio_Click(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = false;

            grpeliminar.Enabled = false;
        }

        private void btnmoverarchivo_Click(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = false;

            grpeliminar.Enabled = false;
        }

        private void btncopiarchivo_Click(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = false;

            grpeliminar.Enabled = false;
        }

        private void btncompartirarchivo_Click(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = false;

            grpeliminar.Enabled = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtarchivo.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"crear_archivo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtarchivo.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtarchivoactual.Text == "" || txtarchivomodificado.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Modificar_archivo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtarchivoactual.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtarchivomodificado.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void bnteliminar_Click(object sender, EventArgs e)
        {
            if (txteliminarchivo.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Eliminar_archivo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txteliminarchivo.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnlistararc_Click(object sender, EventArgs e)
        {
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Listar_archivos.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };

                proc.Start();

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnsesionabierta_Click(object sender, EventArgs e)
        {
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"session_abierta.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };

                proc.Start();

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btndesconectada_Click(object sender, EventArgs e)
        {
            if (txtdesco.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"desconectar_session.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtdesco.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"abierto_archivo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };

                proc.Start();

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            if (txtfile.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"archivo_cerrado.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtfile.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnliscomp_Click(object sender, EventArgs e)
        {
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"listar_compartir.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };

                proc.Start();

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btncompartir_Click(object sender, EventArgs e)
        {
            if (txtruta.Text == "" || txtccompart.Text == "" || txtcompart1.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"compartir_archivo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,

                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtruta.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtccompart.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtcompart1.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnnocompartir_Click(object sender, EventArgs e)
        {
            if (txtcancelarcompart.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"nocompartir_archivo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                   
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtcancelarcompart.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }
    }
}
