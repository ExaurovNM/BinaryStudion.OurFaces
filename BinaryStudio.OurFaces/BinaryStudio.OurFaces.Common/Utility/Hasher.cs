using System.Security.Cryptography;

namespace BinaryStudio.OurFaces.Common.Utility
{
    public class Hasher
    {
        public string ComputeHash(string str)
        {
            var md5 = MD5.Create();
            var encoding = new System.Text.UTF8Encoding();
            var encodedString = encoding.GetBytes(str);
            var hashBytes = md5.ComputeHash(encodedString);
            var deEncodedHash = encoding.GetChars(hashBytes);
            return new string(deEncodedHash);
        }
    }
}
