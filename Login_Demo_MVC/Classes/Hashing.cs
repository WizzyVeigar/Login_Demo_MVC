using Login_Demo_MVC.DTO;
using System.Security.Cryptography;
using System.Text;

namespace Login_Demo_MVC.Classes
{
    public class Hashing
    {
        private const int keySize = 32;

        public static byte[] HashMyPassword(byte[] psw, byte[] salt, int iterations)
        {
            using (Rfc2898DeriveBytes hasher = new Rfc2898DeriveBytes(psw, salt, iterations))
            {
                return hasher.GetBytes(keySize);
            }            
        }

        public static byte[] GenerateSalt()
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                var randomNumber = new byte[keySize];
                rng.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        public static bool Login(User dbUser, byte[] pass)
        {
            byte[] dbHash = Convert.FromBase64String(dbUser.UPass);
            byte[] uHash = HashMyPassword(pass, Convert.FromBase64String(dbUser.USalt), 50000);

            if (CompareByteArrays(dbHash, uHash, dbHash.Length))
            {
                return true;
            }
            return false;
        }

        private static bool CompareByteArrays(byte[] a, byte[] b, int len)
        {
            for (int i = 0; i < len; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
