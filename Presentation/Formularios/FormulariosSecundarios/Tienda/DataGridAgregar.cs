using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Formularios.FormulariosRecursos.Tienda
{
    public partial class txtPrecio : Form
    {
        public txtPrecio()
        {
            InitializeComponent();
        }


        MySqlConnection conexion = new MySqlConnection("server = 54.39.207.75; database=Voltion; UserID = uplancher; Password = AU90drIqTObW9ZhpeESa ");
        private void iconButton1_Click(object sender, EventArgs e)
        {
                abrirArchivos.Filter = "Archivos de Imagen .PNG |*.png| Archivos de Imagen .jpg |*.jpg| Archivos de Imagen .jpeg|*.jpeg| Todos los Archivos |*.*";
            abrirArchivos.Title = " Seleccionar Imagenes";
            DialogResult resultado = abrirArchivos.ShowDialog();


            if (resultado ==  DialogResult.OK)
            {
                imgAgregar.Image = Image.FromFile(abrirArchivos.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            imgAgregar.Image.Save(ms, ImageFormat.Png);

            byte[] aByte = ms.ToArray();


            conexion.Open();

            try
            {
                int epic = 0; 

                MySqlCommand comando = new MySqlCommand("Insert into shop_voltion( NombreProducto, Descripcion, Precio, Imagen, Epic) VALUES (@nombre, @descripcion, @precio, @imagen, @epic)", conexion);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                comando.Parameters.AddWithValue("@precio", txtprecio1.Text);
                comando.Parameters.AddWithValue("@imagen", aByte);
                comando.Parameters.AddWithValue("@epic", epic);

                comando.ExecuteNonQuery();

                MessageBox.Show("Imagen Guardada");


            }
            catch (Exception)
            {
                MessageBox.Show("Error :C");
                
            }








            /*
            ProductosDB objTienda = new ProductosDB();

            objTienda.Nombreproducto = txtNombre.Text;
            objTienda.Descripcion = txtDescripcion.Text ;
            objTienda.Precio = txtprecio1.Text;
            

            MemoryStream ms = new MemoryStream();
            imgAgregar.Image.Save(ms, ImageFormat.Png);
            byte[] aByte = ms.ToArray();
            string encoded = Convert.ToByte(aByte);

            objTienda.Imagen = encoded;
            txtDescripcion.Text = aByte.ToString();

           // MessageBox.Show(encoded);



            */

        }
    }
}
