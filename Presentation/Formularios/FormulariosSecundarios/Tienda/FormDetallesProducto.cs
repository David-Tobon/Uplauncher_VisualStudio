using Presentation.Extra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Formularios.FormulariosRecursos.Tienda
{
    public partial class FormDetallesProducto : Form
    {
        public FormDetallesProducto()
        {
            InitializeComponent();
        }

        AbrirLinks abrirLinks = new AbrirLinks();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirWhatsappDavid();

        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirFacebook();
        }

        private void btnWhatsappDavid_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirWhatsappDavid();
        }

        private void btnWhatsappGrupo_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirGrupoWhatsapp();

        }

        private void btnWhatsappTrejos_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirWhatsappTrejos();
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirDiscord();
        }
    }
















}
