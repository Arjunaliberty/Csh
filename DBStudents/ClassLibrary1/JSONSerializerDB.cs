using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ClassLibrary1
{
    public class JSONSerializerDB : ISerializerDB
    {
        public String path { get; private set; }

        public JSONSerializerDB(String path)
        {
            this.path = path;
        }


        public List<Student> Load()
        {
            List<Student> st = new List<Student>();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Student>));

            try
            {
                using(FileStream fs = new FileStream(path, FileMode.Open))
                {
                    st = (List<Student>)json.ReadObject(fs);                    
                }
            }
            catch (IOException)
            {
                throw new IOException();
            }

            return st;
        }

        public void Save(List<Student> students)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Student>));

            try
            {
                using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    json.WriteObject(fs, students);
                }
            }
            catch (IOException)
            {
                throw new IOException();
            }
        }
    }
}
