using System;
using System.IO;
using System.Text;

namespace Library
{
    public class FileWrapper
    {

        private static String fileName { get; set; }

        public FileWrapper() { }

        public static void SetFileName(String _fileName)
        {
            fileName = _fileName;
        }

        public static String OpenFile()
        {
            String result = null;

            using (FileStream fs = File.Open(fileName, FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fs.Length];

                fs.Read(buffer, 0, buffer.Length);

                result = Encoding.Default.GetString(buffer);
            }

            return result;
        }

        public static void SaveFile(String text)
        {
            byte[] buffer = new byte[text.Length];
            buffer = Encoding.Default.GetBytes(text);

            using (FileStream sf = File.Open(fileName, FileMode.OpenOrCreate))
            {
                sf.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
