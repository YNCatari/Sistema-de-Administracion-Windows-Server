using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.IO;

namespace SistemaBat.Presentacion
{
    public partial class FrmGIIS : MaterialForm
    {
        public FrmGIIS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpCrear.Enabled = false;
            grpEliminar.Enabled = false;
            grpCrearDir.Enabled = false;
            grpIni.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\detalle_sitios_web.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-WebSite > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\detalle_sitios_web.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\elegir_directorios_IIS.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 cmd /c dir C:\\inetpub\\wwwroot > user.txt");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\elegir_directorios_IIS.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string linea = txtNombreSitio.Text, linea2 = txtIP.Text, linea3 = txtPuerto.Text, linea4 = txtCarpeta.Text, linea5 = txtDireccion.Text; 
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\crear_sitio_iis.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c New-WebSite -Name "+linea+" -Port "+linea3+" -HostHeader "+linea5+ " -PhysicalPath 'C:\\inetpub\\wwwroot\\"+linea4+"' -IPAddress "+linea2+" -ApplicationPool ''-Force > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\crear_sitio_iis.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
           


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            grpCrear.Enabled = false;
            grpCrearDir.Enabled = false;
            grpIni.Enabled = false;
            grpEliminar.Enabled = true;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\detalle_sitios_web.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-WebSite > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\detalle_sitios_web.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnEliminarSitio_Click(object sender, EventArgs e)
        {

            string linea = txtNombreSitio2.Text;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\eliminar_sitio_iis.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Remove-WebSite -Name "+linea+" > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\eliminar_sitio_iis.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grpEliminar.Enabled = false;
            grpCrearDir.Enabled = false;
            grpIni.Enabled = false;
            grpCrear.Enabled = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\elegir_directorios_IIS.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 cmd /c dir C:\\inetpub\\wwwroot > user.txt");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\elegir_directorios_IIS.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string linea = txtNombreSitio3.Text, linea2 = txtNombreDir.Text, linea3 = txtCarpeta2.Text;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\crear_dir_iis.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c New-WebVirtualDirectory -Site '"+linea+"' -Name "+linea2+ " -PhysicalPath  C:\\inetpub\\wwwroot\\" + linea3+" > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\crear_dir_iis.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();



            StreamWriter Fichero2;
            Fichero2 = File.CreateText(@"C:\"+ linea2 + ".bat");
            Fichero2.WriteLine("@echo off");
            Fichero2.WriteLine("cd C:\\Windows\\System32\\inetsrv");
            Fichero2.WriteLine("appcmd.exe set config " + linea + " -section:system.webServer/directoryBrowse /enabled:\"True\" /showFlags:\"Date, Time, Size, Extension\"");
            Fichero2.WriteLine("exit");
            Fichero2.Close();
            
            StreamWriter Fichero3;
            Fichero3 = File.CreateText(@"copiar2.bat");
            Fichero3.WriteLine("@echo off");
            Fichero3.WriteLine("cd C:\\PSTools");
            Fichero3.WriteLine("PsExec.exe -d -c \\\\192.170.30.1 -u Administrador -p Sistemas.123 C:\\"+ linea2 + ".bat");
            Fichero3.WriteLine("exit");
            Fichero3.Close();

            ProcessStartInfo psi2 = new ProcessStartInfo()
            {
                FileName = @"copiar2.bat",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process proc2 = new Process() { StartInfo = psi2 };

            proc2.Start();
            proc2.WaitForExit();
            proc2.Close();

            StreamWriter Fichero4;
            Fichero4 = File.CreateText(@"copiar3.bat");
            Fichero4.WriteLine("@echo off");
            Fichero4.WriteLine("cd C:\\PSTools");
            Fichero4.WriteLine("PsExec.exe \\\\192.170.30.1 -u Administrador -p Sistemas.123 cmd /c C:\\Windows\\"+ linea2 + ".bat");
            Fichero4.WriteLine("exit");
            Fichero4.Close();

            ProcessStartInfo psi3 = new ProcessStartInfo()
            {
                FileName = @"copiar3.bat",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            Process proc3 = new Process() { StartInfo = psi3 };

            proc3.Start();
            proc3.WaitForExit();
            proc3.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string linea = txtNombreSitio4.Text;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\iniciar_sitio_iis.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Start-WebSite -Name '"+linea+"' > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\iniciar_sitio_iis.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            string linea = txtNombreSitio4.Text;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\detener_sitio_iis.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Stop-WebSite -Name '" + linea + "' > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\detener_sitio_iis.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            string linea = txtNombreSitio4.Text;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"IIS\\reiniciar_sitio_iis.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Start-WebSite -Name '" + linea + "' > user.txt");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Stop-WebSite -Name '" + linea + "' > user.txt");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Start-WebSite -Name '" + linea + "' > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"IIS\\reiniciar_sitio_iis.bat",
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
                IISContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grpCrear.Enabled = false;
            grpIni.Enabled = false;
            grpEliminar.Enabled = false;
            grpCrearDir.Enabled = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            grpCrear.Enabled = false;
            grpIni.Enabled = true;
            grpEliminar.Enabled = false;
            grpCrearDir.Enabled = false;
        }
    }
}
