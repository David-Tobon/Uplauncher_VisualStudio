using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation.Formularios.FormularioLogin
{
    public partial class PanelRecuperarClave : Form
    {
        public PanelRecuperarClave()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            PanelLogin panelLogin = new PanelLogin();
            panelLogin.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            

            if (txtCorreo.Text != null)
            {
                var user = new UserModel();
                var result = user.recordarClave(txtCorreo.Text);
                lblResultado.Visible = true;
                lblResultado.Text = result;
            }
            lblResultado.Text = "Ingresa un Usuario ó Correo";







        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            PanelLogin panelLogin = new PanelLogin();
            panelLogin.Show();
        }
    }
}
