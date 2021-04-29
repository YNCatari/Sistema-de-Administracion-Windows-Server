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
    public partial class FrmGEquipos : MaterialForm
    {
        public FrmGEquipos()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
                    
         ProcessStartInfo psi = new ProcessStartInfo(@"Agregar_Equipo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                if (rdbdefecto.Checked)
                {
                    proc.StandardInput.Write("1");

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtnombreEquipo.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtDominio.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtExtension.Text));

                    proc.WaitForExit();

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                }

                if (rdbasignar.Checked)
                {
                    proc.StandardInput.Write("2");

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtnombreEquipo.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtDirectorio.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtDominio.Text));

                    proc.WaitForExit(100);

                    proc.StandardInput.Write(Convert.ToString(txtExtension.Text));

                    proc.WaitForExit();

                  

                    richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                }

                proc.Close();

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombreEquipo2.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Eliminar_Equipo.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    //CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtNombreEquipo2.Text));

                proc.WaitForExit(400);
                             
                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtNombreEquipo3.Text == "" || txtDominio2.Text == "" || txtExtension2.Text == "" || txtDirectorio2.Text == "" )
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {

                string linea = txtNombreEquipo3.Text, linea2 = txtDominio2.Text, linea3 = txtExtension2.Text, linea4 = txtDirectorio2.Text;

                StreamWriter Fichero1;
                Fichero1 = File.CreateText(@"detalle_equipoprop.bat");
                Fichero1.WriteLine("@echo off");
                Fichero1.WriteLine("cd C:\\PSTools");
                Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 dsget computer \"CN="+linea+",CN="+linea4+",DC="+linea2+",DC="+linea3+"\" -desc -dn -samid -sid -loc > user.txt");
                Fichero1.WriteLine("exit");
                Fichero1.Close();
                ProcessStartInfo psi = new ProcessStartInfo()
                {
                    FileName = @"detalle_equipoprop.bat",
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

        private void btnlistar_Click(object sender, EventArgs e)
        {


            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("cd C:\\PSTools");
            Fichero1.WriteLine("psexec \\\\192.170.30.1 -u Administrador -p Sistemas.123 dsquery computer > user.txt");
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

        private void btngrpañadir_Click(object sender, EventArgs e)
        {
            grpañadir.Enabled = true;
            grpEliminar.Enabled = false;
            grppropiedades.Enabled = false;
       
        }

        private void btngrpeliminar_Click(object sender, EventArgs e)
        {
            grpañadir.Enabled = false;
            grpEliminar.Enabled = true;
            grppropiedades.Enabled = false;
        }

        private void btngrpmodificar_Click(object sender, EventArgs e)
        {
            grpañadir.Enabled = false;
            grpEliminar.Enabled = false;
            grppropiedades.Enabled = false;
        }

        private void btngrppropiedades_Click(object sender, EventArgs e)
        {
            grpañadir.Enabled = false;
            grpEliminar.Enabled = false;
            grppropiedades.Enabled = true;
        }

        private void FrmGEquipos_Load(object sender, EventArgs e)
        {
            grpañadir.Enabled = false;
            grpEliminar.Enabled = false;
            grppropiedades.Enabled = false;
        }

        private void grppropiedades_Enter(object sender, EventArgs e)
        {

        }

        private void txtnombreEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDirectorio.Enabled = false;
        }

        private void rdbasignar_CheckedChanged(object sender, EventArgs e)
        {
            txtDirectorio.Enabled = true;
        }
    }
}
