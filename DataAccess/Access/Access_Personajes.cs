using System;
using MySqlConnector;


// Capa de acceso a la base de datos del personaje de la persona

namespace DataAccess
{
    public abstract class Access_Personajes
    {
        private readonly string ConnectionStringWorld;
        public Access_Personajes()
        {

            MySqlConnectionStringBuilder builder = new();

            builder.Server = "127.0.0.1";
            builder.Database = "world";
            builder.UserID = "uplancher";
            builder.Password = "AU90drIqTObW9ZhpeESa";
            builder.Port = 3306;

            ConnectionStringWorld = builder.ToString();

        }


        protected MySqlConnection GetConnectionPersonajes()
        {
            return new MySqlConnection(ConnectionStringWorld);
        }

    }



}

