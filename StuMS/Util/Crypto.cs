using System.Security.Cryptography;
using System.Text;

namespace StuMS.Util
{
    public static class Crypto
    {
        public static string Md5Encrypt(string s)
        {
            var md5 = MD5.Create();
            string m = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(s)), 4, 8);
            return m.Replace('-', char.MinValue);
        }
    }
}
