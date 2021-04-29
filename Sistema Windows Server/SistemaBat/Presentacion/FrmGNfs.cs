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
    public partial class FrmGNfs : MaterialForm
    {
        public FrmGNfs()
        {
            InitializeComponent();
        }

        private void btnNfsCliente_Click(object sender, EventArgs e)
        {
            FrmGNfsCliente Frm = new FrmGNfsCliente();
            Frm.Show();
            this.Hide();
        }

        private void btnNfsServidor_Click(object sender, EventArgs e)
        {
            FrmGNfsServidor Frm = new FrmGNfsServidor();
            Frm.Show();
            this.Hide();
        }
    }
}
