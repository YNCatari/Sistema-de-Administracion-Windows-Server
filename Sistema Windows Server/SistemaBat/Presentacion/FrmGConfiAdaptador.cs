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
    public partial class FrmGConfiAdaptador : Form
    {
        public FrmGConfiAdaptador()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfigurarAdaptador_Click(object sender, EventArgs e)
        {
            if (txtip.Text == ""||txtdnsp.Text ==""||txtenlace.Text==""||txtmascara.Text==""||txtadaptador.Text=="")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Asignar_Manualmente.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtadaptador.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtip.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtmascara.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtenlace.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtdnsp.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtdnss.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();
                MessageBox.Show("Cambiado");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtadaptador.Text == "" || txtnewAdaptador.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"Cambiar_Nombre_Adaptador.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();

                proc.StandardInput.Write(Convert.ToString(txtadaptador.Text));

                proc.WaitForExit(100);

                proc.StandardInput.Write(Convert.ToString(txtnewAdaptador.Text));

                proc.WaitForExit(100);


                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtadaptador.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else
            {
                ProcessStartInfo psi = new ProcessStartInfo(@"gestion_pc_w8-w10.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                };
                Process proc = new Process() { StartInfo = psi };
                proc.Start();
                proc.StandardInput.Write("1");
                proc.WaitForExit(400);
                proc.StandardInput.Write("2");
                proc.WaitForExit(400);
                proc.StandardInput.Write("2");
                proc.WaitForExit(400);
                proc.StandardInput.Write("Ethernet");
                proc.WaitForExit(400);
                richTextBox1.Text = proc.StandardOutput.ReadToEnd();
                proc.Close();
                MessageBox.Show("Cambiado");
            }
        }

        private void FrmGConfiAdaptador_Load(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("ipconfig > user.txt");
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
            string fichero = @"user.txt";
            string contenido = string.Empty;

            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnewAdaptador_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtadaptador_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtmascara_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtenlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdnss_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtip_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter Fichero1;
            Fichero1 = File.CreateText(@"detalle.bat");
            Fichero1.WriteLine("@echo off");
            Fichero1.WriteLine("ipconfig > user.txt");
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
            string fichero = @"user.txt";
            string contenido = string.Empty;

            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                richTextBox1.Text = contenido;
            }
            File.Delete(fichero);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGPnetwork Frm = new FrmGPnetwork();
            Frm.Show();
            this.Hide();
        }
    }
}
