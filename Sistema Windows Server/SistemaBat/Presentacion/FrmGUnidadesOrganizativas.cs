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
    public partial class FrmGUnidadesOrganizativas : MaterialForm
    {
        public FrmGUnidadesOrganizativas()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtdominio1.Text == ""||txtnuevaunidad.Text=="")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Nueva_UnidadO.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtdominio1.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtnuevaunidad.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtunidadMod.Text == ""|| txtnuevonombre.Text=="")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Modificar_UnidadO.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtdireccion.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtunidadMod.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtnuevonombre.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void bnteliminar_Click(object sender, EventArgs e)
        {
            if (txtdominio2.Text == "" || txtactualunidad.Text == "" )
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Eliminar_UnidadO.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtdominio2.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtactualunidad.Text));

                proc.WaitForExit(100);
               
                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            if (txtdominio3.Text == "" || txtunidadO.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Listar_UnidadO.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtdominio3.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtunidadO.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnvisualizarunidad_Click(object sender, EventArgs e)
        {

        }

        private void btncrearunidad_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            grpnuevo.Enabled = true;
            grpmodificar.Enabled = false;
            grplistar.Enabled = false;
            grpeliminar.Enabled = false;
        }

        private void btnmodificarunidad_Click(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = true;
            grplistar.Enabled = false;
            grpeliminar.Enabled = false;
        }

        private void btneliminarunidad_Click(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = false;
            grplistar.Enabled = false;
            grpeliminar.Enabled = true;
        }

        private void btnlistarunidad_Click(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = false;
            grplistar.Enabled = true;
            grpeliminar.Enabled = false;
        }

        private void FrmGUnidadesOrganizativas_Load(object sender, EventArgs e)
        {
            grpnuevo.Enabled = false;
            grpmodificar.Enabled = false;
            grplistar.Enabled = false;
            grpeliminar.Enabled = false;
        }
    }
}
