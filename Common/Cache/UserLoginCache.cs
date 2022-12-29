using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int Id { get; set; }                          // 0 Columna
        public static string Login { get; set; }                    // 1 Columna
        public static string PasswordHash { get; set; }             // 2 Columna
        public static string NickName { get; set; }                 // 3 Columna
        public static int Role { get; set; }                        // 4 Columna
        public static string SecretQuestion { get; set; }           // 7 Columna
        public static string SecretAnswer { get; set; }             // 8 Columna
        public static string Email { get; set; }                    // 11 Columna
        public static DateTime CreationDate { get; set; }           // 12 Columna
        public static DateTime LastConnection { get; set; }         // 16 Columna
        public static string LastConnectedIp { get; set; }          // 17 Columna
        public static int IsJailed { get; set; }                    // 21 Columna
        public static int IsBanned { get; set; }                    // 22 Columna

        // public static string BanReason { get; set; }             // 23 Columna   
        // public static DateTime BanEndDate { get; set; }          // 24 Columna
        public static int UserGroupId { get; set; }                 // 34 Columna
        public static string Pass { get; set; }                     // 35 Columna
        public static byte[] Imagen { get; set; }                   //36 Columna













    }
}
