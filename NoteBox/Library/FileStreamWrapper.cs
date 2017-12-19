using System;
using System.IO;
using System.Text;

namespace Library
{
    public static class FileStreamWrapper
    {
        public static String fileName { get; set; }

        public static String OpenFile()
        {
            String result = null;

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                result = Encoding.Default.GetString(buffer);
            }
            return result;
        }

        public static void SaveFile(String str)
        {
            byte[] buffer = new byte[str.Length];
            buffer = Encoding.Default.GetBytes(str);
            using (FileStream fs = new FileStream(fileName,FileMode.OpenOrCreate))
            {
                fs.Write(buffer, 0, buffer.Length);
                fs.Flush();
            }
        }
    }
}
