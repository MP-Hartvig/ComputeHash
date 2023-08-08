using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeHash
{
    internal class HexConverter
    {
        public string GetHexFromString(string input)
        {
            byte[] ba = Encoding.Default.GetBytes(input);

            return BitConverter.ToString(ba);
        }
    }
}
