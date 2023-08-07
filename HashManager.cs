using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ComputeHash
{
    internal class HashManager
    {
        public string GetMd5Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);

            var md5 = MD5.Create();

            var hashValue = md5.ComputeHash(temp);

            return Encoding.UTF8.GetString(hashValue);
        }

        public string GetShaHash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);

            var sha = SHA512.Create();

            var hashValue = sha.ComputeHash(temp);

            return Encoding.UTF8.GetString(hashValue);
        }

        //public string GetHmacHash(string input, string key)
        //{
        //    byte[] temp = 
        //}
    }
}
