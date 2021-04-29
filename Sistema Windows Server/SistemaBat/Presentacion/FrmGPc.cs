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
using SistemaBat.Presentacion;
namespace SistemaBat.Presentacion
{
    public partial class FrmGPc : MaterialForm
    {


        public FrmGPc()
        {
            InitializeComponent();
        }


        private void btnNetwork_Click(object sender, EventArgs e)
        {
            FrmGPnetwork Frm = new FrmGPnetwork();
            Frm.Show();
            this.Hide();

        }


        private void btnPC_Click(object sender, EventArgs e)
        {
            FrmGPpc Frm = new FrmGPpc();
            Frm.Show();
            this.Hide();

        }

    }
}
