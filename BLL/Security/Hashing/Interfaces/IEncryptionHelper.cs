namespace BLL.Security
{
    public interface IEncryptionHelper
    {
        string Encrypt(string clearText);
        string Decrypt(string cipherText);
    }
}
