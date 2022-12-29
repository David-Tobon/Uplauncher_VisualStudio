using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using Presentation.Extra;

namespace Presentation.Formularios.FormulariosRecursos.Contacto
{
    public partial class FormContacto : Form
    {
        public FormContacto()
        {
            InitializeComponent();
        }

        AbrirLinks abrirLinks = new AbrirLinks();
        

       
        private void lblDiscord_Click(object sender, EventArgs e)
        {

            abrirLinks.AbrirDiscord();

        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirDiscord();

        }

        private void lblWhatsapp_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirGrupoWhatsapp();
        }
        private void btnWhatsapp_Click(object sender, EventArgs e)
        {

            abrirLinks.AbrirGrupoWhatsapp();

        }
        private void lblFacebook_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirFacebook();

        }
        private void btnFacebook_Click(object sender, EventArgs e)
        {
            abrirLinks.AbrirFacebook();
        }



    }
}
