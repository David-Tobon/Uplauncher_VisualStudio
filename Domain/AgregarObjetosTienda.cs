using DiseñoIconos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Capa de constructores para agregar objetos a la Tienda

namespace Domain
{
    public class AgregarObjetosTienda
    {

        UserDaoTienda agregarobjetotienda = new UserDaoTienda();

        private int Id_producto;
        private string Nombreproducto;
        private string Descripcion;
        private string Precio;
        private byte[] Imagen;
        private int Epic;

        /*
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombreproducto { get => nombreproducto; set => nombreproducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Precio { get => precio; set => precio = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public int Epic { get => epic; set => epic = value; }

        */

        public AgregarObjetosTienda(int id_producto, string nombreproducto, string descripcion, string precio, byte[] imagen, int epic)
        {
            Id_producto = id_producto;
            Nombreproducto = nombreproducto;
            Descripcion = descripcion;
            Precio = precio;
            Imagen = imagen;
            Epic = epic;


        }

        public string CrearObjeto()
        {

            try
            {
                agregarobjetotienda.CrearObjetoTienda(Id_producto, Nombreproducto, Descripcion,Precio,Imagen,Epic);
                
                return "Objeto de la tienda Agregado Correctamente.";


            }
            catch (Exception e)
            {
                return "Un error ha ocurrido, pero no se cual es :c.";
            }




        }
    }
    }
