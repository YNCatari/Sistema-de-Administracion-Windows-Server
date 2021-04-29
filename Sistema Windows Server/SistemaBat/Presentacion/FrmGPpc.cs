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

namespace SistemaBat.Presentacion
{
    public partial class FrmGPpc : MaterialForm
    {
        public FrmGPpc()
        {
            InitializeComponent();
        }

        private void btnVisualizarEquipo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            executeCommand("hostname");
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

        private void btnVerGrupo_Click(object sender, EventArgs e)
        {
            FrmGVerGrupodeTrabajo Frm = new FrmGVerGrupodeTrabajo();
            Frm.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiarNombreEquipo_Click(object sender, EventArgs e)
        {
            FrmGCambiarNombreEquipo frm = new FrmGCambiarNombreEquipo();
            frm.Show();
            this.Hide();

        }

        private void btnCambiarNombreGrupo_Click(object sender, EventArgs e)
        {
            FrmGCambiarNombreGrupo Frm = new FrmGCambiarNombreGrupo();
            Frm.Show();
            this.Hide();
        }
    }
}
