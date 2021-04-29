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

    public partial class FrmPrincipalGestionar : Form
    {
        Button Activo;
        Color dark = Color.FromArgb(0, 128, 254);

        public FrmPrincipalGestionar()
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
                if (Activo != null) { Activo.BackColor = Color.FromArgb(0, 128, 254); }
                Activo = btn;
            }

        }


        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {
            btnGpc.BackColor = dark;
            btnGunidadesorganizativas.BackColor = dark;
            btnGusuarios.BackColor = dark;
            btnGequipos.BackColor = dark;
            btnGgrupos.BackColor = dark;
            btnGarchivos.BackColor = dark;
            btnGdhcp.BackColor = dark;
            btnGnfs.BackColor = dark;
            btnGdns.BackColor = dark;
            btnGiss.BackColor = dark;
            btnGdirectivas.BackColor = dark;
            btnCerrar.BackColor = dark;
            PanelIzquierdo.BackColor = Color.FromArgb(0, 128, 254);
            if (FrmSeleccion.opcion.Equals(1))
            {
                lblNombre.Text = FrmSeleccion.Admin[0, 1];

            }
        }

        private void btnGestionPC_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGpc);
            loadForm(new FrmGPc());
        }

        private void btnGunidadesorganizativas_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGunidadesorganizativas);
            loadForm(new FrmGUnidadesOrganizativas());
        }

        private void btnGusuarios_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGusuarios);
            loadForm(new FrmGUsuarios());
        }

        private void btnGequipos_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGequipos);
            loadForm(new FrmGEquipos());
        }

        private void btnGgrupos_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGgrupos);
            loadForm(new FrmGGrupos());
        }

        private void btnGarchivos_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGarchivos);
            loadForm(new FrmArchivos());
        }

        private void btnGdhcp_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGdhcp);
            loadForm(new FrmGDhcp());
        }

        private void btnGnfs_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGnfs);
            loadForm(new FrmGNfs());
        }

        private void btnGdns_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGdns);
            loadForm(new FrmGDns());
        }

        private void btnGiss_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGiss);
            loadForm(new FrmGIIS());
        }

        private void btnGdirectivas_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGdirectivas);
            loadForm(new FrmGDirectivas());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmSeleccion Frm = new FrmSeleccion();
            Frm.Show();
            this.Hide();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }
    }
}
