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
using MaterialSkin.Controls;

namespace SistemaBat.Presentacion
{
    public partial class FrmGDhcpServer : MaterialForm

    {
        public FrmGDhcpServer()
        {
            InitializeComponent();
        }

        private void btnConfigurarAdaptador_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = false;



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

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            if (txtNomServidor.Text == ""|| txtIPservidor.Text=="")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Actv_Desactv_DHCP.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                if (rdbAutorizar.Checked)
                {
                    proc.StandardInput.Write("1");

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtNomServidor.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtIPservidor.Text));

                    proc.WaitForExit(100);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                if (rdbDesautorizar.Checked)
                {
                    proc.StandardInput.Write("2");

                    proc.WaitForExit(100);


                    proc.StandardInput.Write(Convert.ToString(txtNomServidor.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtIPservidor.Text));

                    proc.WaitForExit(100);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                proc.Close();

            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtIPAmbito.Text == "" || txtMascara.Text == ""||txtNombreAmbito.Text==""||txtDescAmbito.Text==""||txtRangoInicial.Text==""||txtRangoFinal.Text==""||txtEnrutador.Text==""||txtDNS.Text==""||txtDominio.Text=="")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Crear_Ambito.bat")
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

                    proc.StandardInput.Write(Convert.ToString(txtIPAmbito.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtMascara.Text));

                    proc.WaitForExit(100);
                    proc.StandardInput.Write(Convert.ToString(txtNombreAmbito.Text));

                    proc.WaitForExit(100);
                    proc.StandardInput.Write(Convert.ToString(txtDescAmbito.Text));

                    proc.WaitForExit(100);
                    proc.StandardInput.Write(Convert.ToString(txtRangoInicial.Text));

                    proc.WaitForExit(100);
                    proc.StandardInput.Write(Convert.ToString(txtRangoFinal.Text));

                    proc.WaitForExit(100);
                    proc.StandardInput.Write(Convert.ToString(txtEnrutador.Text));

                    proc.WaitForExit(100);
                    proc.StandardInput.Write(Convert.ToString(txtDNS.Text));

                    proc.WaitForExit(100);
                    proc.StandardInput.Write(Convert.ToString(txtDominio.Text));

                    proc.WaitForExit(100);

                if (rdbSI.Checked)
                {
                    proc.StandardInput.Write("si");

                    proc.WaitForExit(100);
                    proc.StandardInput.Write(Convert.ToString(txtRango1.Text));

                    proc.WaitForExit(100);
                    proc.StandardInput.Write(Convert.ToString(txtRango2.Text));

                    proc.WaitForExit(100);
                }
                else
                {
                    proc.StandardInput.Write("no");

                    proc.WaitForExit(100);
                }

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                               
                proc.Close();

            }
        }

        private void btnCrear2_Click(object sender, EventArgs e)
        {
            if (txtambito.Text == "" || txtrangoInicial2.Text == "" || txtRangofinal2.Text == "" )
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Crear_Exclusion.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();


                proc.StandardInput.Write(Convert.ToString(txtambito.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtrangoInicial2.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtRangofinal2.Text));

                proc.WaitForExit(100);
                
                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnCrear3_Click(object sender, EventArgs e)
        {
            if (txtAmbitoRed.Text == "" || txtIPReserva.Text == "" || txtMAC.Text == ""|| txtNombreReserva.Text==""||txtDescripcion.Text=="")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Crear_Reserva.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();


                proc.StandardInput.Write(Convert.ToString(txtAmbitoRed.Text));

                proc.WaitForExit(400);

                proc.StandardInput.Write(Convert.ToString(txtIPReserva.Text));

                proc.WaitForExit(400);

                proc.StandardInput.Write(Convert.ToString(txtMAC.Text));

                proc.WaitForExit(400);
                proc.StandardInput.Write(Convert.ToString(txtNombreReserva.Text));

                proc.WaitForExit(400);

                proc.StandardInput.Write(Convert.ToString(txtDescripcion.Text));

                if (rdbDHCP.Checked)
                {
                    proc.StandardInput.Write(rdbDHCP.Text);
                    proc.WaitForExit(400);
                }
                if (rdbBOOTP.Checked)
                {
                    proc.StandardInput.Write(rdbDHCP.Text);
                    proc.WaitForExit(400);
                }
                if (rdbBOTH.Checked)
                {
                    proc.StandardInput.Write(rdbDHCP.Text);
                    proc.WaitForExit(400);
                }
                proc.WaitForExit(400);


                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtAmbito3.Text == "" || txtIPEliminar.Text == "" || txtMAC2.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Eliminar_Reserva.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();


                proc.StandardInput.Write(Convert.ToString(txtAmbito3.Text));

                proc.WaitForExit(400);

                proc.StandardInput.Write(Convert.ToString(txtIPEliminar.Text));

                proc.WaitForExit(400);

                proc.StandardInput.Write(Convert.ToString(txtMAC2.Text));

                proc.WaitForExit(400);
                              
                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnAgregarConcecion_Click(object sender, EventArgs e)
        {
            string linea = txtAmbitoConcecion.Text;
            if (txtAmbitoConcecion.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                StreamWriter Fichero1;
                Fichero1 = File.CreateText(@"detalle.bat");
                Fichero1.WriteLine("@echo off");
                Fichero1.WriteLine("cd C:\\PSTools");
                Fichero1.WriteLine("psexec \\\\192.170.30.1 -u upt30.com\\Administrador -p Sistemas.123 netsh dhcp server scope "+linea+" show clients 1 > user.txt");
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
        }

        private void btnAplicarAD_Click(object sender, EventArgs e)
        {
            if (txtNomAmbito.Text == "" || txtIPservidor2.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"ActivarDesactivar_Ambito.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                if (rdbActivar.Checked)
                {
                    proc.StandardInput.Write("1");

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtNomAmbito.Text));

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtIPservidor2.Text));

                    proc.WaitForExit(400);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                if (rdbDesactivar.Checked)
                {
                    proc.StandardInput.Write("2");

                    proc.WaitForExit(400);


                    proc.StandardInput.Write(Convert.ToString(txtNomAmbito.Text));

                    proc.WaitForExit(400);

                    proc.StandardInput.Write(Convert.ToString(txtIPservidor2.Text));

                    proc.WaitForExit(400);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                proc.Close();

            }
        }

        private void btnEliminarAmbito_Click(object sender, EventArgs e)
        {
            if (txtIngreseAmbito.Text == "" )
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Eliminar_Ambito.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

             
                    proc.StandardInput.Write(Convert.ToString(txtIngreseAmbito.Text));

                    proc.WaitForExit(400);

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
              
                proc.Close();

            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            if (txtIPambitoDetalle.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Detalle_Ambito.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();


                proc.StandardInput.Write(Convert.ToString(txtIPambitoDetalle.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnVisualizarAmbitos_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 netsh dhcp server v4 show scope > user.txt");
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

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 powershell /c Get-DhcpServerv4Statistics > user.txt");
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

        
        private void FrmGDhcpServer_Load(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = false;
        }

        private void btnAutorDesautoDHCP_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = true;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = false;

        }

        private void btnCrearAmbito_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = true;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = false;
        }

        private void btnCrearExclusiones_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = true;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 netsh dhcp server v4 show scope > user.txt");
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
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = true;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 netsh dhcp server v4 show scope > user.txt");
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
        }

        private void btnEliminaReserva_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = true;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 netsh dhcp server v4 show scope > user.txt");
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
        }

        private void btnHabilitarDeshabilitarAmbito_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = true;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 netsh dhcp server v4 show scope > user.txt");
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

        private void btnEliminaAmbito_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = true;
            grpDetallesAmbito.Enabled = false;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 netsh dhcp server v4 show scope > user.txt");
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

        private void btnVisualizaDetallesAmbito_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = false;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = true;
        }

        private void btnConcecionesIP_Click(object sender, EventArgs e)
        {
            grpAutorizarDesautorizarDHCP.Enabled = false;
            grpCrearAmbito.Enabled = false;
            grpCrearExclusiones.Enabled = false;
            grpCrearReserva.Enabled = false;
            grpEliminarReserva.Enabled = false;
            grpConcecionesIP.Enabled = true;
            grpActivarDesactivarAmbito.Enabled = false;
            grpEliminarAmbito.Enabled = false;
            grpDetallesAmbito.Enabled = false;

            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 netsh dhcp server v4 show scope > user.txt");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string linea = txtAmbito3.Text;
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 netsh dhcp server scope "+ linea +" show reservedip > user.txt");
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

        private void txtRangoInicial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
