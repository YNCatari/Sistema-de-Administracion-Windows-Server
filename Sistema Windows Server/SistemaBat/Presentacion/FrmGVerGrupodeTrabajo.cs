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

namespace SistemaBat.Presentacion
{
    public partial class FrmGVerGrupodeTrabajo : Form
    {
        public FrmGVerGrupodeTrabajo()
        {
            InitializeComponent();
        }

        private void btnVerGrupo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            executeCommand("net view");
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            executeCommand("net config workstation");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmGPpc Frm = new FrmGPpc();
            Frm.Show();
            this.Hide();
        }
    }
    
}
