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
    public partial class FrmSeleccion : MaterialForm
    {
        public FrmSeleccion()
        {
            InitializeComponent();
        }

        //seccion de declaracion de variables globales
        public static string[,] Admin = new string[500, 500];
        public static int ContaAdmin = 0;

        //variables de acceso
        public static int opcion;

        public static int ayudmod;
        private void btnInstalar_Click(object sender, EventArgs e)
        {
            FrmPrincipalInstalar Frm = new FrmPrincipalInstalar();
            Frm.Show();
            this.Hide();
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            FrmPrincipalGestionar Frm = new FrmPrincipalGestionar();
            Frm.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin Frm = new FrmLogin();
            Frm.Show();
            this.Hide();
        }
    }
}
