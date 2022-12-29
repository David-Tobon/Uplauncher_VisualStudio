using System;
using MySqlConnector;


// Capa de acceso a la base de datos de la tienda del Launcher

namespace DataAccess
{
    public abstract class Access_Tienda
    {
        private readonly string ConnectionString;
        public Access_Tienda()
        {
              
            MySqlConnectionStringBuilder builder = new();

            builder.Server = "127.0.0.1";
            builder.Database = "voltion";
            builder.UserID = "uplancher";
            builder.Password = "AU90drIqTObW9ZhpeESa";
            builder.Port = 3306;

            ConnectionString = builder.ToString();

        }
       

        protected MySqlConnection GetConnectionTienda()
        {
            return new MySqlConnection(ConnectionString);
        }
       
    }



}

