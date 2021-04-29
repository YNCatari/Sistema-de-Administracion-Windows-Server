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
    public partial class FrmGUsuarios : MaterialForm
    {
        public FrmGUsuarios()
        {
       
            InitializeComponent();
            grpcrear.Enabled = false;
        }

        private void btncrearunidad_Click(object sender, EventArgs e)
        {
            grpcrear.Enabled = false;
            grpeliminar.Enabled = false;
            grpncontra.Enabled = false;
            grpEquip.Enabled = false;
            grpHor.Enabled = false;
            grpsi.Enabled = false;
            txtusuario.Clear();
            txtNom.Clear();
            txtFull.Clear();
            txtCon.Clear();
            txtEquip.Clear();
            txthora.Clear();
            txtHor.Clear();


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
            proc.WaitForExit();
            string fichero = @"C:\PSTools\user.txt";
            string contenido = string.Empty;

            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                richTextBox2.Text = contenido;
            }
            File.Delete(fichero);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFull_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string linea1 = txtNom.Text, linea2 = txtCon.Text;
            if (txtNom.Text == "" || txtFull.Text == "" || txtCon.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"gestion_usuarios.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                };
                Process proc = new Process() { StartInfo = psi };
                proc.Start();
                proc.StandardInput.Write("2");
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtNom.Text));
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtFull.Text));
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtCon.Text));
                proc.WaitForExit(100);
                if (rbtncambiarsi.Checked)
                {
                    proc.StandardInput.Write("si");
                    proc.WaitForExit(100);
                    if (rbtnreisi.Checked)
                    {
                        proc.StandardInput.Write("si");
                    }
                    if (rbtnreino.Checked)
                    {
                        proc.StandardInput.Write("no");
                    }
                    proc.WaitForExit(100);
                    richTextBox2.Text = proc.StandardOutput.ReadToEnd();
                    proc.Close();
                }
                if (rbtncambiarno.Checked)
                {
                    proc.Close();
                    StreamWriter Fichero2;
                    Fichero2 = File.CreateText(@"detallecontra.bat");
                    Fichero2.WriteLine("@echo off");
                    Fichero2.WriteLine("cd C:\\PSTools");
                    Fichero2.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c New-ADUser -Name " + linea1 + " -AccountPassword (ConvertTo-SecureString -AsPlainText '" + linea2 + "'-Force) -CannotChangePassword 1");
                    Fichero2.WriteLine("exit");
                    Fichero2.Close();
                    ProcessStartInfo psi1 = new ProcessStartInfo()
                    {
                        FileName = @"detallecontra.bat",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    Process proc1 = new Process() { StartInfo = psi1 };

                    proc1.Start();
                    proc1.WaitForExit();
                                      proc.Close();
                    MessageBox.Show("Creado");
              
                }

            }


        }

        private void FrmGUsuarios_Load(object sender, EventArgs e)
        {
            grpcrear.Enabled = false;          
            grpeliminar.Enabled = false;
            grpncontra.Enabled = false;
            grpEquip.Enabled = false;
            grpHor.Enabled = false;
            grpsi.Enabled = false;
            txtusuario.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpcrear.Enabled = true;
            grpeliminar.Enabled = false;
            grpncontra.Enabled = false;
            grpEquip.Enabled = false;
            grpHor.Enabled = false;
            txtEquip.Clear();
            txthora.Clear();
            txtHor.Clear();
            txtusuario.Clear();
            richTextBox2.Clear();

        }

        private void grpcrear_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grpcrear.Enabled = false;
            grpeliminar.Enabled = true;
            ProcessStartInfo psi = new ProcessStartInfo(@"gestion_usuarios.bat")
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            Process proc = new Process() { StartInfo = psi };
            proc.Start();            
            proc.StandardInput.Write("1");
            proc.WaitForExit(100);
            richTextBox2.Text = proc.StandardOutput.ReadToEnd();

            proc.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"gestion_usuarios.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                };
                Process proc = new Process() { StartInfo = psi };
                proc.Start();
                proc.StandardInput.Write("3");
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtusuario.Text));
                proc.WaitForExit(100);
                proc.Close();
                MessageBox.Show("Usuario Eliminado");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                grpcrear.Enabled = false;
                grpeliminar.Enabled = false;
                grpncontra.Enabled = true;
                grpEquip.Enabled = false;
                grpHor.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grpsi.Enabled = false;
            grpcrear.Enabled = false;
            grpeliminar.Enabled = true;
            grpncontra.Enabled= false;
            grpEquip.Enabled = false;
            grpHor.Enabled = false;
            txtNom.Clear();
            txtFull.Clear();
            txtCon.Clear();
            txtEquip.Clear();
            txthora.Clear();
            txtHor.Clear();
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
                richTextBox2.Text = contenido;
            }
            File.Delete(fichero);
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                StreamWriter Fichero1;
                Fichero1 = File.CreateText(@"detalleusur.bat");
                Fichero1.WriteLine("@echo off");
                Fichero1.WriteLine("cd C:\\PSTools");
                Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 net user " + txtusuario.Text + " > user.txt");
                Fichero1.WriteLine("exit");
                Fichero1.Close();
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = @"detalleusur.bat",
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
                    richTextBox2.Text = contenido;
                }
                File.Delete(fichero);
                  
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"gestion_usuarios.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                };
                Process proc = new Process() { StartInfo = psi };
                proc.Start();
                proc.StandardInput.Write("5");
                proc.WaitForExit(100);
                proc.StandardInput.Write("1");
                proc.StandardInput.Write(Convert.ToString(txtusuario.Text));
                proc.WaitForExit(100);
               
                proc.Close();
                MessageBox.Show("Usuario Habilitado");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"gestion_usuarios.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                };
                Process proc = new Process() { StartInfo = psi };
                proc.Start();
                proc.StandardInput.Write("5");
                proc.WaitForExit(100);
                proc.StandardInput.Write("2");
                proc.StandardInput.Write(Convert.ToString(txtusuario.Text));
                proc.WaitForExit(100);
               
                proc.Close();
                MessageBox.Show("Usuario Deshabilitado");
            }
        }

        private void txtNcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnncontra_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" || txtNcontra.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"gestion_usuarios.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                };
                Process proc = new Process() { StartInfo = psi };
                proc.Start();
                proc.StandardInput.Write("6");
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtusuario.Text));
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtNcontra.Text));
                proc.WaitForExit(100);
              
                proc.Close();
                MessageBox.Show("Contraseña cambiada");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                grpcrear.Enabled = false;
                grpeliminar.Enabled = false;
                grpncontra.Enabled = false;
                grpEquip.Enabled = true;
                grpHor.Enabled = false;
            }
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" || txtEquip.Text == "")

            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"gestion_usuarios.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                };
                Process proc = new Process() { StartInfo = psi };
                proc.Start();
                proc.StandardInput.Write("7");
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtusuario.Text));
                proc.WaitForExit(100);
                proc.StandardInput.Write("1");
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtEquip.Text));
                proc.WaitForExit(100);
                richTextBox2.Text = proc.StandardOutput.ReadToEnd();
                proc.Close();
                MessageBox.Show("Equipo Asignado");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {
                grpcrear.Enabled = false;
                grpeliminar.Enabled = false;
                grpncontra.Enabled = false;
                grpEquip.Enabled = false;
                grpHor.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnHor_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" || txtHor.Text == "" || txthora.Text == "")
            {
                MessageBox.Show("Campo vacío");
            }
            else
            {


                ProcessStartInfo psi = new ProcessStartInfo(@"gestion_usuarios.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                };
                Process proc = new Process() { StartInfo = psi };
                proc.Start();
                proc.StandardInput.Write("8");
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtusuario.Text));
                proc.WaitForExit(100);
                proc.StandardInput.Write("no");
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txtHor.Text));
                proc.WaitForExit(100);
                proc.StandardInput.Write(Convert.ToString(txthora.Text));
                proc.WaitForExit(100);
                richTextBox2.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();
            }
        }

        private void rbtnreino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnreisi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rbtncambiarsi_CheckedChanged(object sender, EventArgs e)
        {
            grpsi.Enabled = true;
        }

        private void rbtncambiarno_CheckedChanged(object sender, EventArgs e)
        {
            grpsi.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Marque empiezo y fin e dias, ejemplo: L - V");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Marque empiezo y fin de dias, ejemplo: L-M | J-Do");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void grpHor_Enter(object sender, EventArgs e)
        {

        }
    }
}
