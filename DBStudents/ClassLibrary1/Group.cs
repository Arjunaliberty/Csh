using System.Runtime.Serialization;

namespace ClassLibrary1
{
    public class Group
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int kurs { get; set; }

        public Group()
        {
            name = "";
            kurs = 0;
        }

        public Group (string name, int kurs)
        {
            this.name = name;
            this.kurs = kurs;
        }
    }
}
