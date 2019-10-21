using System;
using System.IO;
using System.Security.Cryptography;

namespace HashDoDoHash
{
    class Encoding
    {
        public Encoding(string path)
        {
                this.Path = path;
                ComputeSHA1Checksum(Path);
                ComputeSHA256Checksum(Path);
                ComputeMD5Checksum(Path);
        }
        private string SHA1 { get; set; }
        private string SHA256 { get; set; }
        private string MD5 { get; set; }
        private string Path { get; set; }
        private byte[] ByteFile
        {
            get
            {
                try
                {
                    return File.ReadAllBytes(Path);
                }
                catch (Exception)
                {
                    throw new Exception("Ошибка с путём");
                }
            }
            set
            {
                ;
            }
        }


        void ComputeSHA1Checksum(string Path)
        {
            using (SHA1 sha1 = new SHA1CryptoServiceProvider())
            {
                byte[] checkSum = sha1.ComputeHash(ByteFile);
                SHA1 = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                Console.WriteLine("\nSHA1: " + SHA1.ToLower());
            }
        }
        void ComputeSHA256Checksum(string Path)
        {
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                byte[] checkSum = sha256.ComputeHash(ByteFile);
                SHA256 = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                Console.WriteLine("SHA256: " + SHA256.ToLower());
            }
        }

        void ComputeMD5Checksum(string Path)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] checkSum = md5.ComputeHash(ByteFile);
                MD5 = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                Console.WriteLine("MD5: " + MD5.ToLower());
            }
        }
    }
}
