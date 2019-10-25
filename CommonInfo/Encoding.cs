using System;
using System.IO;
using System.Security.Cryptography;

namespace CommonInfo
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
        public string SHA1 { get; private set; }
        public string SHA256 { get; private set; }
        public string MD5 { get; private set; }
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
                SHA1 = BitConverter.ToString(checkSum).Replace("-", String.Empty).ToLower();
            }
        }
        void ComputeSHA256Checksum(string Path)
        {
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                byte[] checkSum = sha256.ComputeHash(ByteFile);
                SHA256 = BitConverter.ToString(checkSum).Replace("-", String.Empty).ToLower();
            }
        }

        void ComputeMD5Checksum(string Path)
        {
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] checkSum = md5.ComputeHash(ByteFile);
                MD5 = BitConverter.ToString(checkSum).Replace("-", String.Empty).ToLower();
            }
        }
    }
}
