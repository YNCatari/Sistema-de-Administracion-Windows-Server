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
    public partial class FrmIActiveDirectory : MaterialForm
    {
        public FrmIActiveDirectory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Instalacion\\detalleAD.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-WindowsFeature -Name *ad-domain* > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Instalacion\\detalleAD.bat",
                UseShellExecute = false,
                //CreateNoWindow = false
            };
            Process proc = new Process() { StartInfo = psi };


            proc.Start();
            proc.WaitForExit();
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
            groupBox1.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Instalacion\\instalacionAD.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c install-windowsfeature -name AD-Domain-Services -includemanagementtools > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Instalacion\\instalacionAD.bat",
                UseShellExecute = false,
                //CreateNoWindow = false
            };
            Process proc = new Process() { StartInfo = psi };


            proc.Start();
            proc.WaitForExit();
            string fichero = @"C:\PSTools\user.txt";
            string contenido = string.Empty;

            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string linea = textBox4.Text, linea2 = textBox3.Text, linea3 = textBox1.Text, linea4 = textBox2.Text;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Instalacion\\instalacionAD_go.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Install-ADDSForest -DomainName "+linea+" -DomainMode "+linea4+" -DomainNetbiosName "+linea2+" -ForestMode "+linea3+" > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Instalacion\\instalacionAD_go.bat",
                UseShellExecute = false,
                //CreateNoWindow = false
            };
            Process proc = new Process() { StartInfo = psi };


            proc.Start();
            proc.WaitForExit();
            string fichero = @"C:\PSTools\user.txt";
            string contenido = string.Empty;

            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
