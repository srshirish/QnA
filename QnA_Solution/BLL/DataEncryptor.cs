using System.Security.Cryptography;
using System.Text;

public class DataEncryptor
{
    public static string Encrypt(string data)
    {
        // Convert the data to bytes
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);

        using (SHA256 sha256 = SHA256.Create())
        {
            // Compute the hash of the data bytes
            byte[] hashBytes = sha256.ComputeHash(dataBytes);

            // Convert the hash bytes to a hexadecimal string
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("x2"));
            }

            // Return the encrypted data as a string
            return stringBuilder.ToString();
        }
    }
}
