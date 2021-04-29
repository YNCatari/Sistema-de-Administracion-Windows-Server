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
using System.IO;

namespace SistemaBat.Presentacion
{
    public partial class FrmGGrupos : MaterialForm
    {
        public FrmGGrupos()
        {
            InitializeComponent();
        }

        private void btnListarGrupo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            grpCrearGrupo.Enabled = false;
            grpEliminarGrupo.Enabled = false;
            grpVisualizar.Enabled = false;
            grpQuitarObjetos.Enabled = false;
            
            if(radioButton1.Checked)
            {
                StreamWriter Fichero1;
                Fichero1 = File.CreateText(@"listargrupolocal.bat");
                Fichero1.WriteLine("@echo off");
                Fichero1.WriteLine("cd C:\\PSTools");
                Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 net localgroup > user1.txt");
                Fichero1.WriteLine("exit");
                Fichero1.Close();
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = @"listargrupolocal.bat",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();
                proc.WaitForExit(3000);
                string fichero = @"C:\PSTools\user1.txt";
                string contenido = string.Empty;

                if (File.Exists(fichero))
                {
                    contenido = File.ReadAllText(fichero);
                    richTextBox1.Text = contenido;
                }
                File.Delete(fichero);
                proc.Close();
            }
            if(radioButton2.Checked)
            {
                StreamWriter Fichero1;
                Fichero1 = File.CreateText(@"listargrupoglobal.bat");
                Fichero1.WriteLine("@echo off");
                Fichero1.WriteLine("cd C:\\PSTools");
                Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 net group > user1.txt");
                Fichero1.WriteLine("exit");
                Fichero1.Close();
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = @"listargrupoglobal.bat",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();
                proc.WaitForExit(3000);
                string fichero = @"C:\PSTools\user1.txt";
                string contenido = string.Empty;

                if (File.Exists(fichero))
                {
                    contenido = File.ReadAllText(fichero);
                    richTextBox1.Text = contenido;
                }
                File.Delete(fichero);
                proc.Close();
            }
            


        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (txtnombreGrupo1.Text == "" )
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                string linea1=txtnombreGrupo1.Text;               

                StreamWriter Fichero1;
                Fichero1 = File.CreateText(@"listargrupos.bat");
                Fichero1.WriteLine("@echo off");
                Fichero1.WriteLine("cd C:\\PSTools");
                if (radioButton3.Checked)
                {
                    Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 net localgroup " + linea1 + " > user1.txt");
                }
                if (radioButton4.Checked)
                {
                    Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 net group " + linea1 + " > user1.txt");
                }                
                Fichero1.WriteLine("exit");
                Fichero1.Close();
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = @"listargrupos.bat",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();
                proc.WaitForExit(3000);
                string fichero = @"C:\PSTools\user1.txt";
                string contenido = string.Empty;

                if (File.Exists(fichero))
                {
                    contenido = File.ReadAllText(fichero);
                    richTextBox1.Text = contenido;
                }
                File.Delete(fichero);
                proc.Close();

            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtnombreGrupo2.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Crear_Grupo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                if (rdbLocal.Checked)
                {
                    proc.StandardInput.Write("1");

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtnombreGrupo2.Text));

                    proc.WaitForExit(100);                  

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                if (rdbGlobal.Checked)
                {
                    proc.StandardInput.Write("2");

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtnombreGrupo2.Text));

                    proc.WaitForExit(100);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                proc.Close();

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtnombreGrupo3.Text == ""|| txtUsuarioAgregar.Text=="")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Agregar_Objetos_Grupo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                if (rdbLocal1.Checked)
                {
                    proc.StandardInput.Write("1");

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtnombreGrupo3.Text));

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtUsuarioAgregar.Text));

                    proc.WaitForExit(400);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                if (rdbGlobal1.Checked)
                {
                    proc.StandardInput.Write("2");

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtnombreGrupo3.Text));

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtUsuarioAgregar.Text));

                    proc.WaitForExit(400);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                proc.Close();

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (txtnombreGrupo4.Text == "" || txtUsuarioQuitar.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Quitar_Objetos_Grupo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                if (rdbLocal2.Checked)
                {
                    proc.StandardInput.Write("1");

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtnombreGrupo4.Text));

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtUsuarioQuitar.Text));

                    proc.WaitForExit(400);
                  

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                if (rdbGlobal2.Checked)
                {
                    proc.StandardInput.Write("2");

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtnombreGrupo4.Text));

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtUsuarioQuitar.Text));

                    proc.WaitForExit(400);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                proc.Close();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtnombreGrupo5.Text == "" )
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Eliminar_Grupo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                if (rdbLocal3.Checked)
                {
                    proc.StandardInput.Write("1");

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtnombreGrupo5.Text));

                    proc.WaitForExit(400);                                        
                  

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                if (rdbGlobal3.Checked)
                {
                    proc.StandardInput.Write("2");

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtnombreGrupo5.Text));

                    proc.WaitForExit(400);                                       

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                proc.Close();

            }
        }

        private void btnObjetosdeGrupo_Click(object sender, EventArgs e)
        {
            grpAgregarObjetos.Enabled = false;
            grpCrearGrupo.Enabled = false;
            grpEliminarGrupo.Enabled = false;
            grpQuitarObjetos.Enabled = false;
            grpVisualizar.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void FrmGGrupos_Load(object sender, EventArgs e)
        {
            grpAgregarObjetos.Enabled = false;
            grpCrearGrupo.Enabled = false;
            grpEliminarGrupo.Enabled = false;
            grpQuitarObjetos.Enabled = false;
            grpVisualizar.Enabled = false;
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            grpAgregarObjetos.Enabled = false;
            grpCrearGrupo.Enabled = true;
            grpEliminarGrupo.Enabled = false;
            grpQuitarObjetos.Enabled = false;
            grpVisualizar.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnAgregarObjetos_Click(object sender, EventArgs e)
        {
            grpAgregarObjetos.Enabled = true;
            grpCrearGrupo.Enabled = false;
            grpEliminarGrupo.Enabled = false;
            grpQuitarObjetos.Enabled = false;
            grpVisualizar.Enabled = false;
            groupBox1.Enabled = false;

        }

        private void btnQuitarObjetos_Click(object sender, EventArgs e)
        {
            grpAgregarObjetos.Enabled = false;
            grpCrearGrupo.Enabled = false;
            grpEliminarGrupo.Enabled = false;
            grpQuitarObjetos.Enabled = true;
            grpVisualizar.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnEliminarGrupos_Click(object sender, EventArgs e)
        {
            grpAgregarObjetos.Enabled = false;
            grpCrearGrupo.Enabled = false;
            grpEliminarGrupo.Enabled = true;
            grpQuitarObjetos.Enabled = false;
            groupBox1.Enabled = false;
            grpVisualizar.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRenombrarGrupo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void rdbLocal1_CheckedChanged(object sender, EventArgs e)
        {
            
         
        }

        private void rdbGlobal1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbLocal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 net user > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"detalle.bat",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process proc = new Process() { StartInfo = psi };


            proc.Start();
            proc.WaitForExit(3000);
            string fichero = @"C:\PSTools\user.txt";
            string contenido = string.Empty;

            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string linea1 = txtnombreGrupo4.Text;

            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"listargrupos2.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            if (rdbLocal2.Checked)
            {
                Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 net localgroup " + linea1 + " > user1.txt");
            }
            if (rdbGlobal2.Checked)
            {
                Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 net group " + linea1 + " > user1.txt");
            }
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"listargrupos2.bat",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process proc = new Process() { StartInfo = psi };


            proc.Start();
            proc.WaitForExit(3000);
            string fichero = @"C:\PSTools\user1.txt";
            string contenido = string.Empty;

            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void rdbGlobal3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
