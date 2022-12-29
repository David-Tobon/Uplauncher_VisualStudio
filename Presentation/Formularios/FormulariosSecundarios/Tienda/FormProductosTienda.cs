using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Formularios.FormulariosRecursos.Tienda
{
    public partial class FormProductosTienda : UserControl
    {

        private int id = 1;
        private string descripcion;
        private int epico = 0;
        //private int precio = 0;



        public FormProductosTienda()
        {
            IsEpic();
            InitializeComponent();
            
        }


        private int Angulo = 1;
        

        private void IsEpic()
        {
            if (epico == 1)
            {
                
                pctImagen.BorderColor = Color.Blue;
                pctImagen.BorderColor2 = Color.Gold;
                pctImagen.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
               
            }

            
        }



        private void pictureBox_Circular1_Click(object sender, EventArgs e)
        {

        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            pctImagen.GradientAngle = Angulo + DateTime.Now.Millisecond ;
           

          

            }
    // Variables 
        
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Nombre
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }

        }

        public string Precio
        {
            get { return lblPrecio.Text; }
            set { lblPrecio.Text = value; }
        }
        public int Epic
        {
            get { return epico; }
            set { epico = value; }

        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }

        }
        

        public Image ImgProducto
        {
            get { return pctImagen.Image; }
            set { pctImagen.Image = value; }
        }

        private void FormProductosTienda_Load(object sender, EventArgs e)
        {

        }

        private void pctImagen_Click(object sender, EventArgs e)
        {
            FormDetallesProducto pr = new FormDetallesProducto();
            pr.txtPrincipal.Text = this.Descripcion;
            pr.lblNombre.Text = this.Nombre;
            pr.lblPrecio.Text = this.Precio;
            pr.pctImagen.Image = this.ImgProducto;
            pr.ShowDialog();





        }
    }
}
