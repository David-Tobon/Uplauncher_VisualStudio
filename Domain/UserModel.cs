using System;
using DataAccess;
using MySqlConnector;





// Capa de constructores para editar y conectarse a la base de datos

namespace Domain
{
    public class UserModel
    {

        UserDao userDao = new UserDao();

        private int Id;
        private string Login;
        private string PasswordHash;
        private string Nickname;
        private string SecretQuestion;
        private string SecretAnswer;
        private string Email;
        private DateTime FechaCreacion;
        private DateTime FechaUltInicio;
        private string Lang;
        private byte[] Imagen;
        private string LastConnectIP;
        

        public string recordarClave(string userRequesting)
        {
            return userDao.recordarClave(userRequesting);
        }
        public UserModel(int id, string login, string passwordHash, string nickname, string secretQuestion, string secretAnswer, string email)
        {
            Id = id;
            Login = login;
            PasswordHash = passwordHash;
            Nickname = nickname;
            SecretQuestion = secretQuestion;
            SecretAnswer = secretAnswer;
            Email = email;
        }
        public UserModel(int id, string login, string passwordHash, string nickname, string secretQuestion, string secretAnswer, string email, byte[] imagen)
        {
            Id = id;
            Login = login;
            PasswordHash = passwordHash;
            Nickname = nickname;
            SecretQuestion = secretQuestion;
            SecretAnswer = secretAnswer;
            Email = email;
            Imagen = imagen;
        }


        public UserModel()
        {

        }

        public UserModel(string login, string passwordHash, string nickname, string secretQuestion, string secretAnswer, string email, DateTime fechacreacion, DateTime fechaUltinicio)
        {
            Login = login;
            PasswordHash = passwordHash;
            Nickname = nickname;
            SecretQuestion = secretQuestion;
            SecretAnswer = secretAnswer;
            Email = email;
            FechaCreacion = fechacreacion;
            FechaUltInicio = fechaUltinicio;
        }
        public UserModel(string login, string passwordHash, string nickname, string secretQuestion, string secretAnswer, string email, DateTime fechacreacion, DateTime fechaUltinicio, string lang)
        {
            Login = login;
            PasswordHash = passwordHash;
            Nickname = nickname;
            SecretQuestion = secretQuestion;
            SecretAnswer = secretAnswer;
            Email = email;
            FechaCreacion = fechacreacion;
            FechaUltInicio = fechaUltinicio;
            Lang = lang;
           

        }
      
        public UserModel(string login, string passwordHash, string nickname, string secretQuestion, string secretAnswer, string email, DateTime fechacreacion, DateTime fechaUltinicio, string lang, string lastconnectip)
        {
            Login = login;
            PasswordHash = passwordHash;
            Nickname = nickname;
            SecretQuestion = secretQuestion;
            SecretAnswer = secretAnswer;
            Email = email;
            FechaCreacion = fechacreacion;
            FechaUltInicio = fechaUltinicio;
            Lang = lang;
            LastConnectIP = lastconnectip;
           



        }

        public UserModel(string login, string passwordHash, string nickname, string secretQuestion, string secretAnswer, string email, DateTime fechacreacion, DateTime fechaUltinicio, string lang, string lastconnectip, byte[] imagen)
        {
            Login = login;
            PasswordHash = passwordHash;
            Nickname = nickname;
            SecretQuestion = secretQuestion;
            SecretAnswer = secretAnswer;
            Email = email;
            FechaCreacion = fechacreacion;
            FechaUltInicio = fechaUltinicio;
            Lang = lang;
            LastConnectIP = lastconnectip;
            Imagen = imagen;




        }
        public string editUserProfile()
        {

            try { 
            userDao.editProfile(Id,Login,PasswordHash,Nickname,SecretQuestion,SecretAnswer,Email, Imagen);
            LoginUser(Login, PasswordHash);
                return "Tu perfil se ha actualizado correctamente.";


            }
            catch (Exception e)
            {
                

                return "Ha ocurrido un eror por favor verifica tus Datos " + e;
            }

        }


        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user,pass);

        }

        public string CreateAccount()
        {
            userDao.CreateAccount(Id, Login, PasswordHash, Nickname, SecretQuestion, SecretAnswer, Email, FechaCreacion, FechaUltInicio, Lang, LastConnectIP, Imagen);
            try
            {
              
                //LoginUser(Login, PasswordHash);
                return "Cuenta Creada Correctamente.";


            }
            catch (Exception ex)
            {
                return "Ha ocurrido un eror por favor verifica tus Datos " +ex;
            }

        }
    }



    
}
