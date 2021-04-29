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
    public partial class FrmPrincipalInstalar : Form
    {
        Button Activo;
        Color dark = Color.FromArgb(1, 87, 155);
        public FrmPrincipalInstalar()
        {
            InitializeComponent();
        }

        //Carga MaterialSkin
        public void loadForm(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            Grupo.Controls.Clear();
            Grupo.Controls.Add(form);
            form.Show();
        }

        public void setActiveForm(Button btn)
        {
            if (btn != Activo)
            {
                btn.BackColor = Color.FromArgb(0, 0, 60);
                if (Activo != null) { Activo.BackColor = Color.FromArgb(1, 87, 155); }
                Activo = btn;
            }

        }


        private void FrmPrincipalInstalar_Load(object sender, EventArgs e)
        {
            btnIactivedirectory.BackColor = dark;
            btnIdhcp.BackColor = dark;
            btnIdns.BackColor = dark;
            btnInfs.BackColor = dark;
            btnIiis.BackColor = dark;
            btnIftp.BackColor = dark;
            btnIsql.BackColor = dark;
            btnCerrar.BackColor = dark;
            PanelIzquierdo.BackColor = Color.FromArgb(1, 87, 155);
            if (FrmSeleccion.opcion.Equals(1))
            {
                lblNombre.Text = FrmSeleccion.Admin[0, 1];

            }
        }


        private void btnIactivedirectory_Click(object sender, EventArgs e)
        {
            setActiveForm(btnIactivedirectory);
            loadForm(new FrmIActiveDirectory());
        }

        private void btnIdhcp_Click(object sender, EventArgs e)
        {
            setActiveForm(btnIdhcp);
            loadForm(new FrmIDhcp());
        }

        private void btnIdns_Click(object sender, EventArgs e)
        {
            setActiveForm(btnIdns);
            loadForm(new FrmIDns());
        }

        private void btnInfs_Click(object sender, EventArgs e)
        {
            setActiveForm(btnInfs);
            loadForm(new FrmINfs());
        }

        private void btnIiis_Click(object sender, EventArgs e)
        {
            setActiveForm(btnIiis);
            loadForm(new FrmIIis());
        }

        private void btnIftp_Click(object sender, EventArgs e)
        {
            setActiveForm(btnIftp);
            loadForm(new FrmIFtp());
        }

        private void btnIsql_Click(object sender, EventArgs e)
        {
            setActiveForm(btnIsql);
            loadForm(new FrmISqlServer());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmSeleccion Frm = new FrmSeleccion();
            Frm.Show();
            this.Hide();
        }
    }
}
