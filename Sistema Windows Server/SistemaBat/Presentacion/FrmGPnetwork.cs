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
    public partial class FrmGPnetwork : MaterialForm
    {
        public FrmGPnetwork()
        {
            InitializeComponent();
        }

        private void btnConfigurarAdaptador_Click(object sender, EventArgs e)
        {
            FrmGConfiAdaptador frm = new FrmGConfiAdaptador();
            frm.Show();
            this.Hide();
        }

        private void btnVerAdaptador_Click(object sender, EventArgs e)
        {
            FrmGPropAdaptador Frm = new FrmGPropAdaptador();
            Frm.Show();
            this.Hide();
        }
    }
}
