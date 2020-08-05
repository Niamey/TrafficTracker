using System;
using System.Configuration;
using System.Security.Cryptography;

namespace Application_TrafficTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Aes myAes = Aes.Create())
            {
                // Encrypt the string to an array of bytes.
                byte[] encrypted = ConnectionEncriptor.EncryptStringToBytes_Aes(ConfigurationBuild.BuildConfiguration(args), myAes.Key, myAes.IV);

                //// Decrypt the bytes to a string.
                string roundtrip = ConnectionEncriptor.DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

                //Display the original data and the decrypted data.
                Console.WriteLine("Original:   {0}", "");
                Console.WriteLine("Round Trip: {0}", roundtrip);
            }
        }
    }
}
