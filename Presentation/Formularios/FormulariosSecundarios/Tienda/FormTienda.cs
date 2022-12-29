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
using Common.Cache;
using MySqlConnector;
using Presentation.Formularios.FormulariosRecursos.Tienda;


namespace Presentation.Formularios.FormulariosRecursos
{
    public partial class FormTienda : Form
    {
        public FormTienda()
        {
            InitializeComponent();
            LlenarProductos();
            BotonAgregar();
        }

        private void LlenarProductos()
        {
            ProductosDB obj = new ProductosDB();
           // obj.AgregarBotones(flowLayoutPanel1);
            obj.Llenarbotones(flowLayoutPanel1);

        }

        private void BotonAgregar()
        {
            if (UserLoginCache.UserGroupId == 5)
            {
                btnAgregar.Visible = true;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtPrecio panelRegistro = new txtPrecio();
            panelRegistro.Show();
            
        }
    }
}
