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
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.LightBlue900, MaterialSkin.Primary.Cyan900, MaterialSkin.Accent.Pink100, MaterialSkin.TextShade.WHITE);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //FrmSeleccion Frm = new FrmSeleccion();
            //Frm.Show();
            //this.Hide();
            if (FrmSeleccion.ContaAdmin == 0)
            {
                if (FrmSeleccion.Admin[0, 0].Equals(txtTipos.Text))//en caso que sea administrador
                {
                    if (FrmSeleccion.Admin[0, 1].Equals(txtUsuario.Text))
                    {
                        if (FrmSeleccion.Admin[0, 8].Equals(txtContrasena.Text))
                        {
                            FrmSeleccion.opcion = 1;//opcion de administrador y tiene derecho a todo
                            FrmSeleccion frm = new FrmSeleccion();
                            frm.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < FrmSeleccion.ContaAdmin; i++)
                {
                    if (txtTipos.Text.Equals(FrmSeleccion.Admin[i, 0]))
                    {
                        if (txtUsuario.Text.Equals(FrmSeleccion.Admin[i, 1]))
                        {
                            if (txtContrasena.Text.Equals(FrmSeleccion.Admin[i, 8]))
                            {
                                if (txtTipos.Text.Equals("Administrador"))
                                {
                                    FrmSeleccion.opcion = 1;
                                }
                                FrmSeleccion frm = new FrmSeleccion();
                                frm.Show();
                                this.Hide();

                            }
                        }
                    }
                }
            }
        }

        private void mdLinea_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FrmSeleccion.Admin[0, 0] = "Administrador";
            FrmSeleccion.Admin[0, 1] = "Admin";
            FrmSeleccion.Admin[0, 2] = "Admin";
            FrmSeleccion.Admin[0, 8] = "123";
        }
    }
}
