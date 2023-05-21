using System.Security.Cryptography;


public class SecurityTokenGenerator
{
    public static string GenerateSecurityToken(string firstName, string email)
    {
        string randomString = GenerateRandomString();
        string token = $"{randomString}-{email}-{firstName}";
        return DataEncryptor.Encrypt(token);
    }

    private static string GenerateRandomString()
    {
        byte[] randomBytes = new byte[32];

        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(randomBytes);
        }

        string token = Convert.ToBase64String(randomBytes);
        return token;
    }
}
