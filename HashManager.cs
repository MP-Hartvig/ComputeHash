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
        public string GetHash(string input, string type, string key = "")
        {
            byte[] tempInput = Encoding.UTF8.GetBytes(input);
            byte[] tempKey = Encoding.UTF8.GetBytes(key);

            if (type == "MD5")
            {
                MD5 md5 = MD5.Create();

                return Encoding.UTF8.GetString(md5.ComputeHash(tempInput));
            }
            else if (type == "SHA")
            {
                SHA512 sha = SHA512.Create();

                return Encoding.UTF8.GetString(sha.ComputeHash(tempInput));
            }
            else
            {
                byte[] hmac = HMACSHA512.HashData(tempKey, tempInput);

                return Encoding.UTF8.GetString(hmac);
            }
        }
    }
}
