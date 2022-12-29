using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Common.Cache;


// Se supone que aqui no deberia estar el constructor de acceso a la base de datos, pero como era una externa me dio flojera cambiarlo :)

namespace Presentation.Formularios.FormulariosRecursos.Tienda
{
    public class ProductosDB
    {

        private int id_producto;
        private string nombreproducto;
        private string descripcion;
        private string precio;
        private byte[] imagen;
        private int epic;


        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombreproducto { get => nombreproducto; set => nombreproducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Precio { get => precio; set => precio = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public int Epic { get => epic; set => epic = value; }


        MySqlConnection conexion = new MySqlConnection("server = 54.39.207.75; database= Voltion; UserID = uplancher; Password = AU90drIqTObW9ZhpeESa");

        public void Llenarbotones(FlowLayoutPanel Contenedor)
        {

            conexion.Open();
            string transactSql = "Select * from shop_voltion";
            MySqlCommand comando = new MySqlCommand(transactSql, conexion);
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();



            while (reader.Read())
            {
                Id_producto = Convert.ToInt32(reader[0]);
                Nombreproducto = reader[1].ToString();
                Descripcion = reader[2].ToString();
                Precio = reader[3].ToString();
                // Imagen = ((byte[])reader[4]);
                //Imagen = byteArrayToImage(reader[4]);

                MemoryStream ms = new MemoryStream((byte[])reader[4]);
                Bitmap bm = new Bitmap(ms);

                Epic = Convert.ToInt32(reader[5]);

                FormProductosTienda btn = new FormProductosTienda();
                btn.Id = Id_producto;
                btn.Nombre = Nombreproducto;
                btn.Descripcion = Descripcion;
                btn.Precio = Precio;
                btn.Epic = Epic;
                btn.ImgProducto = bm;

                // MemoryStream ms = new MemoryStream(Imagen);
                // Image.FromStream(ms);



                Contenedor.Controls.Add(btn);


            }

            conexion.Close();
            conexion.Dispose();


        }
        // Obtener el registro desde la base de datos en formato byte[]
        public Image byteArrayToImage(byte[] byteBLOBData)
        {
            MemoryStream ms = new MemoryStream(byteBLOBData);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }




        #region Prueba Arquitectura en Capas para agregar Botones
        /*
        public void AgregarBotones(FlowLayoutPanel panelcontenedor)
        {

          

            
            if (TiendaCache.NombreProducto != null )
            {


                FormProductosTienda btn = new FormProductosTienda();
                btn.Id = TiendaCache.Id_Producto;
                btn.Nombre = TiendaCache.NombreProducto;
                btn.Descripcion = TiendaCache.Descripcion;
                btn.Precio = TiendaCache.Precio;
                btn.Epic = TiendaCache.Epic;
                MemoryStream ms = new MemoryStream(TiendaCache.Imagen);
                btn.ImgProducto = Image.FromStream(ms);



                panelcontenedor.Controls.Add(btn);

            

    }*/

        #endregion



    }
}
    

    

