using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace RPGAPI.Models
{
    public class Utils
    {

    }

    public class Criptografia
    {
        public static void CriarPasswordHash(string password, out byte[] hash, out byte[] salt){
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                salt = hmac.Key;
                hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}