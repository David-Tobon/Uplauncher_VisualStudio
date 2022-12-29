using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Formularios.FormulariosRecursos.Guia
{
    public partial class FormGuia : Form
    {
        public FormGuia()
        {
            InitializeComponent();
            LeerTexto();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        
        private void LeerTexto()
        {
            TextReader Leer = new StreamReader(Application.StartupPath + "/app/Recursos/Texto/Detalles");
            txtPrincipal.Text = Leer.ReadToEnd();
           
        }
    }
}
