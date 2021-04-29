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
using MaterialSkin.Controls;

namespace SistemaBat.Presentacion
{
    public partial class FormGDhcpCliente : MaterialForm
    {
        public FormGDhcpCliente()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
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
            proc.WaitForExit(100);
            proc.StandardInput.Write("2");
            proc.WaitForExit(100);
            proc.StandardInput.Write("2");
            proc.WaitForExit(100);            
            proc.StandardInput.Write("Ethernet");
            proc.WaitForExit(100);
            richTextBox1.Text = proc.StandardOutput.ReadToEnd();
            proc.Close();            
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo(@"gestion_dhcp_cliente.bat")
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
            proc.WaitForExit(100);           
            richTextBox1.Text = proc.StandardOutput.ReadToEnd();
            proc.Close();
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo(@"gestion_dhcp_cliente.bat")
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Verb = "runas"
            };
            Process proc = new Process() { StartInfo = psi };
            proc.Start();
            proc.StandardInput.Write("2");
            proc.WaitForExit(100);
            richTextBox1.Text = proc.StandardOutput.ReadToEnd();
            proc.Close();
        }
    }
}
