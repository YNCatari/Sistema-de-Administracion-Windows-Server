using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SistemaBat.Presentacion
{
    public partial class FrmGNfsCliente : MaterialForm
    {
        public FrmGNfsCliente()
        {
            InitializeComponent();
        }

        private void FrmGNfsCliente_Load(object sender, EventArgs e)
        {
            
            grpMontar.Enabled = false;
            grpDesmostar.Enabled = false;
        }

        private void btnMostrarCarpetas_Click(object sender, EventArgs e)
        {
            grpMontar.Enabled = false;
            grpDesmostar.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Cliente\\mostrar_carpetas.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Cliente\\mostrar_carpetas.bat",
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

        private void btnMostrarEquipos_Click(object sender, EventArgs e)
        {
            grpMontar.Enabled = false;
            grpDesmostar.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Cliente\\mostrar_equipos_que_compartieron_unidades.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 showmount -a 192.170.30.1 > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Cliente\\mostrar_equipos_que_compartieron_unidades.bat",
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

        private void btnMostrarEquipoCompartido_Click(object sender, EventArgs e)
        {
            grpMontar.Enabled = false;
            grpDesmostar.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Cliente\\mostrar_con_que_equipo_compartieron_unidades.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 showmount -e 192.170.30.1 > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Cliente\\mostrar_con_que_equipo_compartieron_unidades.bat",
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

        private void btnUnidadesMontadas_Click(object sender, EventArgs e)
        {
            grpMontar.Enabled = false;
            grpDesmostar.Enabled = false;
            txtNombreArchivo.Clear();
            txtNombreDesmostrar.Clear();
            txtUnidad.Clear();
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Cliente\\mostrar_unidades_montadas.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.15 mount > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Cliente\\mostrar_unidades_montadas.bat",
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

        private void btnMontarUnidadCompartida_Click(object sender, EventArgs e)
        {

            grpMontar.Enabled = true;
            grpDesmostar.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Cliente\\detallemostrarnfs.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 nfsshare > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Cliente\\detallemostrarnfs.bat",
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

        private void btnMontar_Click(object sender, EventArgs e)
        {


            string nombre = txtNombreArchivo.Text;
            string unidad = txtUnidad.Text;
            grpMontar.Enabled = true;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Cliente\\montar_unidades.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.15 mount \\\\192.170.30.1\\"+nombre+" "+unidad+":> user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Cliente\\montar_unidades.bat",
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

        private void btnIniciarDetener_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\\Cliente\\\mostrar_carpetas.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd %WINDIR%\\System32\\Dism");
            Fichero1.WriteLine("DISM /online /enable-feature /all /featurename:ClientForNFS-Infrastructure");
            Fichero1.WriteLine("DISM /online /enable-feature /all /featurename:NFS-Administration");
            Fichero1.WriteLine("pause");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\Cliente\mostrar_carpetas.bat",
                UseShellExecute = false
                //CreateNoWindow = 
            };
            Process proc = new Process() { StartInfo = psi };


            proc.Start();
            proc.WaitForExit();
            MessageBox.Show("Completado");


        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            
            
            
            //ProcessStartInfo psi = new ProcessStartInfo()
            //{
            //    FileName = @"gestion_nfs_cliente.bat",
            //    UseShellExecute = false,
            //    RedirectStandardInput = true,
            //    RedirectStandardOutput = true,
            //    CreateNoWindow = true
            //};
            //Process proc = new Process() { StartInfo = psi };


            //proc.Start();
            //proc.StandardInput.Write("1");
            //proc.WaitForExit(2000);
            //proc.StandardInput.Write("2");
            //proc.WaitForExit(2000);
            //nfsContenedor.Text = proc.StandardOutput.ReadToEnd();
            //proc.Close();
        }

        private void txtIpServidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDesmontar_Click(object sender, EventArgs e)
        {

            string unidad_desmontar = txtNombreDesmostrar.Text;
            grpMontar.Enabled = true;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Cliente\\desmontar_unidades.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.15 umount " + unidad_desmontar + ":> user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Cliente\\desmontar_unidades.bat",
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

        private void btnDesmontarUnidadCompartida_Click(object sender, EventArgs e)
        {
            grpMontar.Enabled = false;
            grpDesmostar.Enabled = true;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"Gestion_Nfs\\Cliente\\mostrar_unidades_montadas.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.15 mount > user.txt");
            Fichero1.WriteLine("exit");
            Fichero1.Close();
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = @"Gestion_Nfs\\Cliente\\mostrar_unidades_montadas.bat",
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
    }
}
