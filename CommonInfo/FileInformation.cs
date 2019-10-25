using System;
using System.IO;

namespace CommonInfo
{
    class FileInformation
    {
        public FileInformation(string path)
        {
            this.Path = path;
            fileInfo();
        }
        private string Path { get; set; }
        public string extension { get; private set; }
        public string creation_Time { get; private set; }
        public string lastAccessTime { get; private set; }
        public string lastWriteTime { get; private set; }
        public string size { get; private set; }
        public string pathFullName { get; private set; }
        void fileInfo()
        {
            FileInfo fi = new FileInfo(Path);
            extension = "Extension: " + fi.Extension;
            pathFullName = "Path: " + fi.FullName;
            creation_Time = "Creation Time: " + fi.CreationTime;
            lastAccessTime = "LastAccessTime: " + fi.LastAccessTime;
            lastWriteTime = "LastWriteTime: " + fi.LastWriteTime;
            size = "Size: " + fi.Length / 1024 / 1024 + " Mb | " + fi.Length / 1024 + " Kb | " + fi.Length + " Byte";
        }
    }
}
