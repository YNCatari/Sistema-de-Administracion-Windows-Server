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
    public partial class FrmGPropAdaptador : Form
    {
        public FrmGPropAdaptador()
        {
            InitializeComponent();

        }

        private void btnConfigurarAdaptador_Click(object sender, EventArgs e)
        {
            
            label1.Visible = true;
            richTextBox1.Visible = false;
            listBox1.Items.Clear();
            executeCommand("ipconfig");

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            label1.Visible = true;
            richTextBox1.Visible = false;
            listBox1.Items.Clear();
            executeCommand("ipconfig /all");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            richTextBox1.Visible = true;
            txttexto.Visible = true;
            label1.Visible = true;
            button3.Visible = true;

        }

        private void executeCommand(String commandR)
        {
            try
            {
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = "/c " + commandR,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                //updateStatusExecution("***COMMAND RECEIVED: " + commandR);
                //updateStatusExecution("***ANSWER:");
                proc.Start();
                while (!proc.StandardOutput.EndOfStream)
                {
                    string line = proc.StandardOutput.ReadLine();
                    updateStatusExecution(line);
                }
            }
            catch (Exception e)
            {
                updateStatusExecution("***Error while executing '" + commandR + "'");
                updateStatusExecution("***Exception: '" + e.ToString());
                updateStatusExecution("***Stack Trace: '" + e.StackTrace.ToString());
            }
        }
        private void updateStatusExecution(String textR)
        {
          
            listBox1.Items.Add(textR);
          
        }

        private void FrmGPropAdaptador_Load(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            txttexto.Visible = false;
            label1.Visible = false;
            button3.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (txttexto.Text == "")
            {
                MessageBox.Show("el campo esta vacio");
            }
            else {
                ProcessStartInfo psi = new ProcessStartInfo(@"gestion.bat")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                Process proc = new Process() { StartInfo = psi };


                proc.Start();


                //proc.StandardInput.Write("1");
                //proc.WaitForExit(100);
                //proc.StandardInput.Write("1");
                //proc.WaitForExit(100);
                //proc.StandardInput.Write("3");
                //proc.WaitForExit(100);
                /*proc.StandardInput.Write("Ethernet");*/
                proc.StandardInput.Write(Convert.ToString(txttexto.Text));

                proc.WaitForExit(100);

                richTextBox1.Text = proc.StandardOutput.ReadToEnd();

                proc.Close();

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmGPnetwork Frm = new FrmGPnetwork();
            Frm.Show();
            this.Hide();
        }
    }
    
    
}
