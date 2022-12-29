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

namespace Presentation.Formularios.FormulariosSecundarios.Actualizaciones
{
    public partial class FormActualizaciones : Form
    {
        public FormActualizaciones()
        {
            InitializeComponent();
            LeerTexto();

        }

        private void LeerTexto()
        {
            TextReader Leer = new StreamReader(Application.StartupPath + "/app/Recursos/Texto/Actualizaciones");
            txtPrincipal.Text = Leer.ReadToEnd();
        }
    }
}
