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
    public partial class FrmINfs : MaterialForm
    {
        public FrmINfs()
        {
            InitializeComponent();
        }

        private void FrmINfs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detallenfs.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-WindowsFeature -Name *nfs* > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"detallenfs.bat",
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
            Fichero1 = File.CreateText(@"detalleinstanfs.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Install-WindowsFeature DNS -IncludeManagementTools");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"detalleinstanfs.bat",
                UseShellExecute = false
                //CreateNoWindow = true
            };
            Process proc = new Process() { StartInfo = psi };


            proc.Start();
            proc.WaitForExit();            

            StreamWriter Fichero2;
            Fichero2 = File.CreateText(@"detalleinstanfs1.bat");
            Fichero2.WriteLine("@echo off");
            Fichero2.WriteLine("cd C:\\PSTools");
            Fichero2.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Install-WindowsFeature -Name NFS-Client > user.txt");
            Fichero2.WriteLine("exit");
            Fichero2.Close();
            ProcessStartInfo psi1 = new ProcessStartInfo()
            {
                FileName = @"detalleinstanfs1.bat",
                UseShellExecute = false
                //CreateNoWindow = true
            };
            Process proc1 = new Process() { StartInfo = psi1 };


            proc1.Start();
            proc1.WaitForExit();


            string fichero = @"C:\PSTools\user.txt";
            string contenido = string.Empty;

            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
        }
    }
}
