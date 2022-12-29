using System;
using MySqlConnector;


// Capa de acceso a la base de datos principal con Usuario y contraseña de la Persona

namespace DataAccess
{
    public abstract class Access_Main
    {
        private readonly string ConnectionString;
        public Access_Main()
        {
              
            MySqlConnectionStringBuilder builder = new();

            builder.Server = "127.0.0.1";
            builder.Database = "auth";
            builder.UserID = "uplancher";
            builder.Password = "AU90drIqTObW9ZhpeESa";
            builder.Port = 3306;

            ConnectionString = builder.ToString();

        }
       

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
       
    }



}

