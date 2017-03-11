using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Project1
{
    class Encoder
    {        
        MD5 coder;

        public Encoder()
        {
            coder = MD5.Create();
        }

        string GetMd5Hash(string message)
        {
            byte[] data = coder.ComputeHash(Encoding.UTF8.GetBytes(message));            
            StringBuilder sBuilder = new StringBuilder();            
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));            
            return sBuilder.ToString();
        }

    }
}
