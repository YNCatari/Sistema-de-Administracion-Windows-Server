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
    public partial class FrmGIss : MaterialForm
    {
        public FrmGIss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalleiis.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-WindowsFeature -Name *iis* > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"detalleiis.bat",
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
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalleinstaiis.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Install-WindowsFeature -Name Web-Server -IncludeAllSubFeature -IncludeManagementTools > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"detalleinstaiis.bat",
                UseShellExecute = false
                //CreateNoWindow = true
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

            StreamWriter Fichero2;
            Fichero2 = File.CreateText(@"detalleinstaiis1.bat");
            Fichero2.WriteLine("@echo off");
            Fichero2.WriteLine("cd C:\\PSTools");
            Fichero2.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Install-WindowsFeature WinRm-IIS-Ext");
            Fichero2.WriteLine("exit");
            Fichero2.Close();
            ProcessStartInfo psi1 = new ProcessStartInfo()
            {
                FileName = @"detalleinstaiis1.bat",
                UseShellExecute = false
                //CreateNoWindow = true
            };
            Process proc1 = new Process() { StartInfo = psi1 };


            proc1.Start();
            proc1.WaitForExit();

            StreamWriter Fichero3;
            Fichero3 = File.CreateText(@"detalleinstaiis2.bat");
            Fichero3.WriteLine("@echo off");
            Fichero3.WriteLine("cd C:\\PSTools");
            Fichero3.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Install-WindowsFeature BITS-IIS-Ext");
            Fichero3.WriteLine("exit");
            Fichero3.Close();
            ProcessStartInfo psi2 = new ProcessStartInfo()
            {
                FileName = @"detalleinstaiis2.bat",
                UseShellExecute = false
                //CreateNoWindow = true
            };
            Process proc2 = new Process() { StartInfo = psi2 };


            proc2.Start();
            proc2.WaitForExit();



        }
    }
}
