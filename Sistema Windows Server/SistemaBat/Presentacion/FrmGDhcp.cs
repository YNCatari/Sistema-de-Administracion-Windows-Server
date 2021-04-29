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

namespace SistemaBat.Presentacion
{
    public partial class FrmGDhcp : MaterialForm
    {
        public FrmGDhcp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGDhcpCliente form = new FormGDhcpCliente();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGDhcpServer form = new FrmGDhcpServer();
            form.Show();
            this.Hide();
        }
    }
}
