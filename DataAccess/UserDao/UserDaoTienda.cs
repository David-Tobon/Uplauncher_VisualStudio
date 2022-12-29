
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
using Common.Cache;
using DataAccess;

namespace DiseñoIconos
{
    public class UserDaoTienda : Access_Tienda

    {
        #region AbrirTienda
        public bool Tienda()
                {
                    using (var connection = GetConnectionTienda())
                    {
                        connection.Open();
                        using (var command = new MySqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "select *from shop_voltion";

                            command.CommandType = CommandType.Text;
                            MySqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    TiendaCache.Id_Producto = reader.GetInt32(0);
                                    TiendaCache.NombreProducto = reader.GetString(1);
                                    TiendaCache.Descripcion = reader.GetString(2);
                                    TiendaCache.Precio = reader.GetString(3);
                                    TiendaCache.Imagen = ((byte[])reader[4]);
                                    TiendaCache.Epic = reader.GetInt32(5);

                                }


                                return true;
                            }
                            return false;
                        }

                    }
                }

        #endregion





        #region CrearObjeto en la Tienda
        public void CrearObjetoTienda(int id, string nombre, string descripcion, string precio, byte[] imagen, int epic)
        {
            using (var connection = GetConnectionTienda())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert into shop_voltion(NombreProducto, Descripcion, Precio, Imagen, Epic) values(@nombre, @descripcion, @precio, @imagen, @epic)";

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@imagen", imagen);
                    command.Parameters.AddWithValue("@epic", epic);


                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }
        #endregion




    }
}

