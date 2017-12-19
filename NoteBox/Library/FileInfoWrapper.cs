using System;
using System.IO;
using System.Text;

namespace Library
{
    public class FileInfoWrapper
    {
        private String fileName { get; }

        public FileInfoWrapper(String fileName)
        {
            this.fileName = fileName;
        }

        public String OpenFile()
        {
            FileInfo fi = new FileInfo(fileName);
            String result = null;
            byte[] buffer = null;

            using (FileStream rf = fi.Open(FileMode.OpenOrCreate))
            {
                buffer = new byte[rf.Length];
                rf.Read(buffer, 0, buffer.Length);
                result = Encoding.Default.GetString(buffer);
            }
            return result;
        }

        public void SaveFile(String text)
        {
            FileInfo fi = new FileInfo(fileName);
            byte[] buffer = new byte[text.Length];
            buffer = Encoding.Default.GetBytes(text);

            using (FileStream wf = fi.Open(FileMode.OpenOrCreate))
            {
                wf.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
