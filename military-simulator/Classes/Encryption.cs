using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace military_simulator.Classes
{
    class Encryption
    {
        public static string createHash(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            string result = BitConverter.ToString(bytes).Replace("-", String.Empty).ToLower();
            return result;
        }
        public static string createSalt()
        {
            var Salt = new byte[20];
            using (var RandomGenerator = RandomNumberGenerator.Create())
            {
                RandomGenerator.GetBytes(Salt);
            }
            return BitConverter.ToString(Salt).Replace("-", String.Empty).ToLower();
        }
        public static bool checkHash(string hash, string salt, string password)
        {
            if (createHash(hash + salt) == password)
            {   
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
