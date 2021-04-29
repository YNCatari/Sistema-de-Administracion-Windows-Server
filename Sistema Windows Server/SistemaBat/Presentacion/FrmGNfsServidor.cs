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
    public partial class FrmGNfsServidor : MaterialForm
    {
        public FrmGNfsServidor()
        {
            InitializeComponent();
        }

        private void FrmGNfsServidor_Load(object sender, EventArgs e)
        {
            grpCompartirAsignar.Enabled = false;
            grpEliminar.Enabled = false;
            grpElegirLetra.Enabled = false;
            grpCompartirDetalle.Enabled = false;
            grpAsignar.Enabled = false;
            grpPermisos.Enabled = false;
        }

        private void btnIniciarDetener_Click(object sender, EventArgs e)
        {
            grpCompartirAsignar.Enabled = false;
            grpEliminar.Enabled = false;
            grpElegirLetra.Enabled = false;
            grpCompartirDetalle.Enabled = false;
            grpAsignar.Enabled = false;
            grpPermisos.Enabled = false;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            grpCompartirAsignar.Enabled = false;
            grpEliminar.Enabled = false;
            grpElegirLetra.Enabled = false;
            grpCompartirDetalle.Enabled = false;
            grpAsignar.Enabled = false;
            grpPermisos.Enabled = false;
        }

        private void btnCompartirAsignar_Click(object sender, EventArgs e)
        {
            grpCompartirAsignar.Enabled = false;
            grpEliminar.Enabled = false;
            grpElegirLetra.Enabled = true;
            grpCompartirDetalle.Enabled = false;
            grpAsignar.Enabled = false;
            grpPermisos.Enabled = false;
            txtLetra.Clear();
            txtDirectorio.Clear();
            txtNombreCompartir.Clear();
            txtNombreEquipo.Clear();
            txtNombreEliminar.Clear();

            StreamWriter Fichero1,Fichero2;
            Fichero1 = File.CreateText("C:\\PSTools\\list.txt");
            Fichero1.WriteLine("list volume");
            Fichero1.Close();

            Fichero2 = File.CreateText(@"Gestion_Nfs\\Servidor\\mostrar_directorios.bat");
            Fichero2.WriteLine("@echo off");
            Fichero2.WriteLine("cd C:\\PSTools");
            Fichero2.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 diskpart -s C:\\PSTools\\list.txt > user.txt");
            Fichero2.WriteLine("exit");
            Fichero2.Close();

            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Servidor\\mostrar_directorios.bat",
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
                nfsContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();

        }

        private void btnEliminarCarpetas_Click(object sender, EventArgs e)
        {

            grpCompartirAsignar.Enabled = false;
            grpEliminar.Enabled = true;
            grpElegirLetra.Enabled = false;
            grpCompartirDetalle.Enabled = false;
            grpAsignar.Enabled = false;
            grpPermisos.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Servidor\\mostrar_carpetas.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Servidor\\mostrar_carpetas.bat",
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
                nfsContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnMostrarCarpetas_Click(object sender, EventArgs e)
        {
            grpCompartirAsignar.Enabled = false;
            grpEliminar.Enabled = false;
            grpEliminar.Enabled = false;
            grpElegirLetra.Enabled = false;
            grpCompartirDetalle.Enabled = false;
            grpAsignar.Enabled = false;
            grpPermisos.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Servidor\\mostrar_carpetas.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Servidor\\mostrar_carpetas.bat",
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
                nfsContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnMostrarEquiposMontados_Click(object sender, EventArgs e)
        {
            grpCompartirAsignar.Enabled = false;
            grpEliminar.Enabled = false;
            grpElegirLetra.Enabled = false;
            grpCompartirDetalle.Enabled = false;
            grpAsignar.Enabled = false;
            grpPermisos.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Servidor\\mostrar_equipos_montados.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 showmount -a 192.170.30.1 > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Servidor\\mostrar_equipos_montados.bat",
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
                nfsContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnMostrarEquiposCompartidos_Click(object sender, EventArgs e)
        {
            grpCompartirAsignar.Enabled = false;
            grpEliminar.Enabled = false;
            grpElegirLetra.Enabled = false;
            grpCompartirDetalle.Enabled = false;
            grpAsignar.Enabled = false;
            grpPermisos.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Servidor\\mostrar_con_que_equipo_compartieron_unidades.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 showmount -e 192.170.30.1 > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Servidor\\mostrar_con_que_equipo_compartieron_unidades.bat",
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
                nfsContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnMostrarUnidadesMontadas_Click(object sender, EventArgs e)
        {
            grpCompartirAsignar.Enabled = false;
            grpEliminar.Enabled = false;
            grpElegirLetra.Enabled = false;
            grpCompartirDetalle.Enabled = false;
            grpAsignar.Enabled = false;
            grpPermisos.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Servidor\\mostrar_unidades_montadas.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.15 mount > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Servidor\\mostrar_unidades_montadas.bat",
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
                nfsContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();

        }

        private void btnEnviarLetra_Click(object sender, EventArgs e)
        {
            grpCompartirDetalle.Enabled = true;
            grpPermisos.Enabled = true;
            grpEliminar.Enabled = false;
            grpCompartirAsignar.Enabled = true;
            string linea = txtLetra.Text;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Servidor\\elegir_directorios.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 cmd /c dir "+linea+": > user.txt");
            Fichero1.WriteLine(linea+":");
            Fichero1.WriteLine("dir > user.txt");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Servidor\\elegir_directorios.bat",
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
                nfsContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            grpAsignar.Enabled = true;
            
        }

        private void btnEnviarCompartir_Click(object sender, EventArgs e)
        {

            string letra = txtLetra.Text;
            string directorio = txtDirectorio.Text;
            string nombre = txtNombreCompartir.Text;
            

            ProcessStartInfo psi = new ProcessStartInfo(@"Gestion_Nfs\\Servidor\\compartir_nfs.bat")
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Verb = "runas"
            };
            Process proc = new Process() { StartInfo = psi };
            proc.Start();
            proc.StandardInput.Write(Convert.ToString(txtLetra.Text));
            proc.WaitForExit(100);
            proc.StandardInput.Write(Convert.ToString(txtDirectorio.Text));
            proc.WaitForExit(100);
            proc.StandardInput.Write(Convert.ToString(txtNombreCompartir.Text));
            proc.WaitForExit(100);
            if (rdbSi.Checked)
            {
                proc.StandardInput.Write("si");
                proc.WaitForExit(100);
                proc.StandardInput.Write("1");
                proc.WaitForExit(100);
                proc.StandardInput.Write(txtNombreEquipo.Text);
                proc.WaitForExit(100);
                if (rbSoloLectura.Checked)
                {
                    proc.StandardInput.Write("1");
                }

                if (rbLecturaEscritura.Checked)
                {
                    proc.StandardInput.Write("2");
                
                }
                if (rbNegarAcceso.Checked)
                {
                    proc.StandardInput.Write("1");
                   
                }
            }
            if (rdbNo.Checked)
            {
                proc.StandardInput.Write("no");
                proc.WaitForExit(100);
                if (rbSoloLectura.Checked)
                {
                    proc.StandardInput.Write("1");
                    
                }
                if (rbLecturaEscritura.Checked)
                {
                    proc.StandardInput.Write("2");
                    
                }
                if (rbNegarAcceso.Checked)
                {
                    proc.StandardInput.Write("3");
                   
                }
            }
            proc.WaitForExit(100);
            nfsContenedor.Text = proc.StandardOutput.ReadToEnd();        
            
            proc.Close();

        }

        private void btnEliminarCarpeta_Click(object sender, EventArgs e)
        {


            string eliminar_carpeta = txtNombreEliminar.Text;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Servidor\\eliminar_nfs.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare " + eliminar_carpeta + " /del > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Servidor\\eliminar_nfs.bat",
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
                nfsContenedor.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();

        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            grpAsignar.Enabled = false;
        }
    }
}
