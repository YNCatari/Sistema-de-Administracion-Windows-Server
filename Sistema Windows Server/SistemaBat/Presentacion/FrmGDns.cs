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
    public partial class FrmGDns : MaterialForm
    {
        public FrmGDns()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grpCrearZonaPrincipales.Enabled = false;
            grpCrearZona.Enabled = false;
            grpEliminarZona.Enabled = false;
            grpCrearEliminarDominios.Enabled = true;
            grpCrearEliminarSubDominios.Enabled = false;
            grpVisualizarDominiosSubDominios.Enabled = false;
            grpProbarDominiosSubDminios.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-DnsServerZone > user.txt");
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
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {

            if (txtNombreIPservidor.Text == "" || txtNombreNuevaZona.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Crear_Zona_Principales.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();


                proc.StandardInput.Write(Convert.ToString(txtNombreIPservidor.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtNombreNuevaZona.Text));

                proc.WaitForExit(100);
                              
                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            if (txtNombreIPservidor2.Text == "" || txtNombreNuevaZona2.Text == "" || txtIPoDNS.Text=="")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Crear_Zona.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                if (rdbZonaSecundaria.Checked)
                {
                    proc.StandardInput.Write("1");

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtNombreIPservidor2.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtNombreNuevaZona2.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtIPoDNS.Text));

                    proc.WaitForExit(100);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                if (rdbZonaBusquedaInversa.Checked)
                {
                    proc.StandardInput.Write("2");

                    proc.WaitForExit(100);


                    proc.StandardInput.Write(Convert.ToString(txtNombreIPservidor2.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtNombreNuevaZona2.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtIPoDNS.Text));

                    proc.WaitForExit(100);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                proc.Close();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombreZona.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                string linea = txtNombreZona.Text;
                StreamWriter Fichero1;
                Fichero1 = File.CreateText(@"detalle_eliminar_dns.bat");
                Fichero1.WriteLine("@echo off");
                Fichero1.WriteLine("cd C:\\PSTools");
                Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Remove-DnsServerZone '"+linea+"' -PassThru -Verbose");
                Fichero1.WriteLine("exit");
                Fichero1.Close();
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = @"detalle_eliminar_dns.bat",
                    UseShellExecute = false,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();
                proc.WaitForExit();
                string fichero = @"C:\PSTools\user.txt";
                File.Delete(fichero);
                proc.Close();
                MessageBox.Show("Eliminado con éxito");

            }
        }
        
        private void btnAplicarCoE_Click(object sender, EventArgs e)
        {
            if (txtNombreDominio.Text == "" || txtNombreZona2.Text == "" || txtIPdominio.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                string linea = txtNombreDominio.Text, linea2 = txtNombreZona2.Text, linea3 = txtIPdominio.Text;                      
               

                if (rdbCrear.Checked)
                {
                    StreamWriter Fichero1;
                    Fichero1 = File.CreateText(@"detalle_crear_dns.bat");
                    Fichero1.WriteLine("@echo off");
                    Fichero1.WriteLine("cd C:\\PSTools");
                    Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Add-DnsServerResourceRecordA -Name '"+linea+"' -ZoneName '"+linea2+"' -AllowUpdateAny -IPv4Address '"+linea3+"' > user.txt");
                    Fichero1.WriteLine("exit");
                    Fichero1.Close();
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = @"detalle_crear_dns.bat",
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
                    proc.Close();
                    MessageBox.Show("Creado");
                }

                if (rdbEliminar.Checked)
                {
                    StreamWriter Fichero1;
                    Fichero1 = File.CreateText(@"detalle_eliminar_zona_dns.bat");
                    Fichero1.WriteLine("@echo off");
                    Fichero1.WriteLine("cd C:\\PSTools");
                    Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Remove-DnsServerResourceRecord -ZoneName '"+linea2+"' -Force -RRType 'A' -Name '"+linea+"' -RecordData '"+linea3+ "' > user.txt");
                    Fichero1.WriteLine("exit");
                    Fichero1.Close();
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = @"detalle_eliminar_zona_dns.bat",
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
                    proc.Close();
                    MessageBox.Show("Eliminado");
                }

                

            }
        }

        private void btnAplicarCoESubDom_Click(object sender, EventArgs e)
        {

            if (txtNombreDominio2.Text == "" || txtNombreZona3.Text == "" || txtIPdominio3.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                string linea = txtNombreDominio2.Text, linea2 = txtNombreZona3.Text, linea3 = txtIPdominio3.Text;


                if (rdbCrear.Checked)
                {
                    StreamWriter Fichero1;
                    Fichero1 = File.CreateText(@"detalle_crear_dns.bat");
                    Fichero1.WriteLine("@echo off");
                    Fichero1.WriteLine("cd C:\\PSTools");
                    Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Add-DnsServerResourceRecordA -Name '" + linea + "' -ZoneName '" + linea2 + "' -AllowUpdateAny -IPv4Address '" + linea3 + "' > user.txt");
                    Fichero1.WriteLine("exit");
                    Fichero1.Close();
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = @"detalle_crear_dns.bat",
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
                    proc.Close();
                    MessageBox.Show("Creado");
                }

                if (rdbEliminar.Checked)
                {
                    StreamWriter Fichero1;
                    Fichero1 = File.CreateText(@"detalle_eliminar_zona_dns.bat");
                    Fichero1.WriteLine("@echo off");
                    Fichero1.WriteLine("cd C:\\PSTools");
                    Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Remove-DnsServerResourceRecord -ZoneName '" + linea2 + "' -Force -RRType 'A' -Name '" + linea + "' -RecordData '" + linea3 + "' > user.txt");
                    Fichero1.WriteLine("exit");
                    Fichero1.Close();
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = @"detalle_eliminar_zona_dns.bat",
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
                    proc.Close();
                    MessageBox.Show("Eliminado");
                }

            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            if (txtNombreZona4.Text == "" )
            {
                MessageBox.Show("el campo esta vacio");
            }
            
            else
            {
                string linea = txtNombreZona4.Text;                

                if (rdbDominio.Checked)
                {
                    StreamWriter Fichero1;
                    Fichero1 = File.CreateText(@"detalle_visualizar_zona_dns.bat");
                    Fichero1.WriteLine("@echo off");
                    Fichero1.WriteLine("cd C:\\PSTools");
                    Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-DnsServerResourceRecord -ZoneName '"+linea+"' -RRType 'A' > user.txt");
                    Fichero1.WriteLine("exit");
                    Fichero1.Close();
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = @"detalle_visualizar_zona_dns.bat",
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
                    proc.Close();
                }

                if (rdbSubDominio.Checked)
                {
                    StreamWriter Fichero1;
                    Fichero1 = File.CreateText(@"detalle_visualizar_zona_dns.bat");
                    Fichero1.WriteLine("@echo off");
                    Fichero1.WriteLine("cd C:\\PSTools");
                    Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-DnsServerResourceRecord -ZoneName '" + linea + "' -RRType 'A' > user.txt");
                    Fichero1.WriteLine("exit");
                    Fichero1.Close();
                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = @"detalle_visualizar_zona_dns.bat",
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
                    proc.Close();
                }

               

            }
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            if (txtDireccionIPservidor2.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Probar_Dominio_SubDominio.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();
                proc.StandardInput.Write(Convert.ToString(txtDireccionIPservidor2.Text));
                proc.WaitForExit();                               
                richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                proc.Close();

            }
        }

        private void btnVisualizarZonas_Click(object sender, EventArgs e)
        {


            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-DnsServerZone > user.txt");
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
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();


        }

        private void btnCreateZonasPrincipales_Click(object sender, EventArgs e)
        {
            grpCrearZonaPrincipales.Enabled = true;
            grpCrearZona.Enabled = false;
            grpEliminarZona.Enabled = false;
            grpCrearEliminarDominios.Enabled = false;
            grpCrearEliminarSubDominios.Enabled = false;
            grpVisualizarDominiosSubDominios.Enabled = false;
            grpProbarDominiosSubDminios.Enabled = false;


        }

        private void FrmGDns_Load(object sender, EventArgs e)
        {
            grpCrearZonaPrincipales.Enabled = false;
            grpCrearZona.Enabled = false;
            grpEliminarZona.Enabled = false;
            grpCrearEliminarDominios.Enabled = false;
            grpCrearEliminarSubDominios.Enabled = false;
            grpVisualizarDominiosSubDominios.Enabled = false;
            grpProbarDominiosSubDminios.Enabled = false;
        }

        private void btnCrearZona_Click(object sender, EventArgs e)
        {
            grpCrearZonaPrincipales.Enabled = false;
            grpCrearZona.Enabled = true;
            grpEliminarZona.Enabled = false;
            grpCrearEliminarDominios.Enabled = false;
            grpCrearEliminarSubDominios.Enabled = false;
            grpVisualizarDominiosSubDominios.Enabled = false;
            grpProbarDominiosSubDminios.Enabled = false;
        }

        private void btnEliminarZona_Click(object sender, EventArgs e)
        {
            grpCrearZonaPrincipales.Enabled = false;
            grpCrearZona.Enabled = false;
            grpEliminarZona.Enabled = true;
            grpCrearEliminarDominios.Enabled = false;
            grpCrearEliminarSubDominios.Enabled = false;
            grpVisualizarDominiosSubDominios.Enabled = false;
            grpProbarDominiosSubDminios.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-DnsServerZone > user.txt");
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
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnCrearEliminarSubdominio_Click(object sender, EventArgs e)
        {
            grpCrearZonaPrincipales.Enabled = false;
            grpCrearZona.Enabled = false;
            grpEliminarZona.Enabled = false;
            grpCrearEliminarDominios.Enabled = false;
            grpCrearEliminarSubDominios.Enabled = true;
            grpVisualizarDominiosSubDominios.Enabled = false;
            grpProbarDominiosSubDminios.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-DnsServerZone > user.txt");
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
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void btnVisualizarDominiosySubDominios_Click(object sender, EventArgs e)
        {
            grpCrearZonaPrincipales.Enabled = false;
            grpCrearZona.Enabled = false;
            grpEliminarZona.Enabled = false;
            grpCrearEliminarDominios.Enabled = false;
            grpCrearEliminarSubDominios.Enabled = false;
            grpVisualizarDominiosSubDominios.Enabled = true;
            grpProbarDominiosSubDminios.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-DnsServerZone > user.txt");
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
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();

        }

        private void btnProbarDominioYSubDominio_Click(object sender, EventArgs e)
        {
            grpCrearZonaPrincipales.Enabled = false;
            grpCrearZona.Enabled = false;
            grpEliminarZona.Enabled = false;
            grpCrearEliminarDominios.Enabled = false;
            grpCrearEliminarSubDominios.Enabled = false;
            grpVisualizarDominiosSubDominios.Enabled = false;
            grpProbarDominiosSubDminios.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 netsh dhcp show server > user.txt");
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
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
            proc.Close();
        }

        private void txtNombreZona3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtIPdominio3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
