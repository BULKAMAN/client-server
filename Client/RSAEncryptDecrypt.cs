using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypt
{
    public class Class1
    {

        private static string key = "<RSAKeyValue><Modulus>4qplQ0beQpIwCBtWRLBaCT3GFGL9N1X6hM7oF0IrxkRne/C53TuuLRGf5ibuQRGo9QYMjdR6ndjYj8nHUkYRrF1gps+/37lIFfXwsG+PQ2kcX8FQtX+rguepj2arm3ayiCYINqjccIxFUUI57EDvFG4DpiKeE7/5NoDVm+HxtKk=</Modulus><Exponent>AQAB</Exponent><P>7ZdTwM3E8NpeXRy/9m9FFovlF03KS9LSRZwPQa+ap+aZXXGQDkPELtA02A70xY/6yhNqvEy5ois6w09838eQVw==</P><Q>9Dpbv4Ped+54oI/0ImsGMek3OszfNTs5NRkQL3KlmY9jd99JkDGOioDM3ilmAd3r9TsQ0PJbVWMM+ed4fxHC/w==</Q><DP>Xyn/x/gja/1rUoxTb1e+Knu6NQ1Ze+ljg7IwgjTeE2ZQA5ebBbuq9r06jVfgPsmewBXq6KUqrYP3M4fBErkSXQ==</DP><DQ>367ziRzGDSIk6Snvd/Z93gizxO8PIDn102P5JvviIBrsB0ZCogZBfykoefGAtAUFr71BUZ4neLUXlWsjOX6TEQ==</DQ><InverseQ>Be1d7KmH1G1G1albwmUoWtUUaN8qDdhQ1hSVqCzjg1K8dASkr7zFv+0zfvPNHXnsY1tDHNh8zEk+beq0vPTUIQ==</InverseQ><D>JICAUjdFb78PER8l42Xq+fYCwiG22YR1FZIkeipj1kgJykHYDLKhuAxQjcXTNJNdfCf/OY/wNx9GsNEz0iIKkkPXoCggfoIQG9nrSOXFuve3N/re30ufnC3lp2oJNrD6EQ1smgUk2f6w7WaEkiLZFLw/3J21cJ5h6hWCpRoTgQk=</D></RSAKeyValue>";


        public static string RsaEncrypt(string text)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(key);
                byte[] data = Encoding.UTF8.GetBytes(text);
                byte[] encryptedData = rsa.Encrypt(data, true);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public static string RsaDecrypt(string base64text)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(key);

                byte[] data = Convert.FromBase64String(base64text);
                byte[] decryptedData = rsa.Decrypt(data, false);
                return Encoding.UTF8.GetString(decryptedData);
            }
        }
    }
}

