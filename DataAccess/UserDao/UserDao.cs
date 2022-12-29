using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
using Common.Cache;
using System.IO;
using System.Drawing;

namespace DataAccess
{
    public class UserDao : Access_Main
    {

        public void editProfile(int id, string login, string pass, string nickname, string secretquestion, string secretanswer, string email, byte[] imagen)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update accounts set Login=@login, PasswordHash=@pass, NickName=@nickname, SecretQuestion=@secretquestion, SecretAnswer=@secretanswer, Email=@email, Imagen=@imagen where Id=@id";

                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@nickname", nickname);
                    command.Parameters.AddWithValue("@secretquestion", secretquestion);
                    command.Parameters.AddWithValue("@secretanswer", secretanswer);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@imagen", imagen );
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();


                }
            }
        }





        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from accounts where Login=@user and PasswordHash=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.Id = reader.GetInt32(0);
                            UserLoginCache.Login = reader.GetString(1);
                            UserLoginCache.PasswordHash = reader.GetString(2);
                            UserLoginCache.NickName = reader.GetString(3);
                            UserLoginCache.Role = reader.GetInt32(4);
                            UserLoginCache.SecretQuestion = reader.GetString(7);
                            UserLoginCache.SecretAnswer = reader.GetString(8);
                            UserLoginCache.Email = reader.GetString(11);
                            UserLoginCache.CreationDate = reader.GetDateTime(12);
                            UserLoginCache.LastConnection = reader.GetDateTime(16);
                            UserLoginCache.LastConnectedIp = reader.GetString(17);
                            UserLoginCache.IsJailed = reader.GetInt32(21);
                            UserLoginCache.IsBanned = reader.GetInt32(22);
                            //UserLoginCache.BanReason            = reader.GetString(23);
                            //UserLoginCache.BanEndDate           = reader.GetDateTime(24);
                            UserLoginCache.UserGroupId = reader.GetInt32(34);
                            UserLoginCache.Pass = reader.GetString(35);

                            

                            MemoryStream ms = new MemoryStream((byte[])reader[36]);
                            byte[] byteArray = ms.ToArray();
                            
                            UserLoginCache.Imagen = byteArray;
                        }


                        return true;
                    }
                    return false;
                }

            }

        }






        public void CreateAccount(int id, string login, string pass, string nickname, string secretquestion, string secretanswer, string email, DateTime fechacreacion, DateTime lastconnection, string lang, string lastconnectip, byte[] imagen)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insert into accounts(Login, PasswordHash, Nickname, SecretQuestion, SecretAnswer, Lang, Email, CreationDate, LastConnection, LastConnectedIp, Imagen) values( @login, @pass, @nickname, @secretquestion, @secretanswer,@lang, @email, @creationdate, @lastconnection, @lastconnectip, @imagen)";

                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@nickname", nickname);
                    command.Parameters.AddWithValue("@secretquestion", secretquestion);
                    command.Parameters.AddWithValue("@secretanswer", secretanswer);
                    command.Parameters.AddWithValue("@lang", lang);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@creationdate", fechacreacion);
                    command.Parameters.AddWithValue("@lastconnection", lastconnection);
                    command.Parameters.AddWithValue("@lastconnectip", lastconnectip);
                    command.Parameters.AddWithValue("@imagen", imagen);

                    //command.Parameters.AddWithValue("@imagen", imagen);
                    

                    //command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                   

                }
            }
        }


        public string recordarClave(string userRequesting)
        {


            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from accounts where Login=@login or Email=@mail";
                    command.Parameters.AddWithValue("@login", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3);
                        string userMail = reader.GetString(11);
                        string accountPassword = reader.GetString(2);

                        var mailService = new DiseñoIconos.CorreoElectronico.SystemSupportMail();
                        mailService.SendMail(
                            subject: "[Voltion 2.51] - Solicitud Recuperación de Contraseña",
                            body: "Hola, " + userName +
                            " \nTú solicitud de recuperación de contraseña mediante correo electronico se ha realizado con exito." +
                            "\n Tú contraseña de Dofus Voltion 2.51 es:  " + accountPassword +
                            "\n Sin embargo le pedimos que por favor cambie su contraseña una vez ingrese al sistema",
                            recipentMail: new List<string> { userMail }


                            );
                        return "Contraseña enviada a la dirección de correo electronico registrada";

                    }
                    else
                    {
                        return "Lo sentimos, no tiene una cuenta de usuario registrada con este correo electronico";
                    }


                }
                
            }
        }

       

        }



    }

    

