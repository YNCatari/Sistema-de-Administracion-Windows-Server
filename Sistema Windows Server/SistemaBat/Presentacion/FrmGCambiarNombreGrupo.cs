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
    public partial class FrmGCambiarNombreGrupo : Form
    {
        public FrmGCambiarNombreGrupo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtgrupo.Text == "" )
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Cambiar_Workgroup")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtgrupo.Text));

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
            if (rdbwin7.Checked)
            {
                if (txtdominio.Text == "" || txtusuario.Text=="")
                {
                    MessageBox.Show("el campo esta vacio");
                }
                else
                {
                    ProcessStartInfo psi = new ProcessStartInfo(@"Win7_Dominio.bat")
                    {
                        UseShellExecute = false,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        //CreateNoWindow = true
                    };
                    Process proc = new Process() { StartInfo = psi };


                    proc.Start();

                    proc.StandardInput.Write(Convert.ToString(txtdominio.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtusuario.Text));

                    proc.WaitForExit(100);

                    if (rdbSI.Checked)
                    {
                        proc.StandardInput.Write(rdbsii.Text);
                    }
                    if (rdbNo.Checked)
                    {
                        proc.StandardInput.Write(rdbnoo.Text);
                    }

                    proc.WaitForExit(100);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                    proc.Close();

                }
            }
            if (rdbwin8y10.Checked)
            {
                if (txtdominio.Text == "")
                {
                    MessageBox.Show("el campo esta vacio");
                }
                else
                {
                    ProcessStartInfo psi = new ProcessStartInfo(@"Win8y10_Dominio.bat")
                    {
                        UseShellExecute = false,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        //CreateNoWindow = true
                    };
                    Process proc = new Process() { StartInfo = psi };


                    proc.Start();

                    proc.StandardInput.Write(Convert.ToString(txtdominio.Text));

                    proc.WaitForExit(100);
                                        
                    if (rdbSI.Checked)
                    {
                        proc.StandardInput.Write(rdbsii.Text);
                    }
                    if (rdbNo.Checked)
                    {
                        proc.StandardInput.Write(rdbnoo.Text);
                    }

                    proc.WaitForExit(100);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                    proc.Close();

                }
            }

            if (rdbwinxp.Checked)
            {
                if (txtdominio.Text == "" || txtusuario.Text == ""||txtnombrePC.Text==""||txtcontraseña.Text=="")
                {
                    MessageBox.Show("el campo esta vacio");
                }
                else
                {
                    ProcessStartInfo psi = new ProcessStartInfo(@"Winxp_Dominio.bat")
                    {
                        UseShellExecute = false,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        //CreateNoWindow = true
                    };
                    Process proc = new Process() { StartInfo = psi };


                    proc.Start();

                    proc.StandardInput.Write(Convert.ToString(txtnombrePC.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtdominio.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtusuario.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtcontraseña.Text));

                    proc.WaitForExit(100);


                    if (rdbSI.Checked)
                    {
                        proc.StandardInput.Write(rdbsii.Text);
                    }
                    if (rdbNo.Checked)
                    {
                        proc.StandardInput.Write(rdbnoo.Text);
                    }

                    proc.WaitForExit(100);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                    proc.Close();

                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmGPpc Frm = new FrmGPpc();
            Frm.Show();
            this.Hide();
        }
    }
}
