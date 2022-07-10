using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9.Serialization
{
    //[Serializable]   - for binary
    [DataContract]
    public class Group
    {
        //[NonSerialized]  - for binary
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public string Name { get; set; }

        public Group() 
        {
            Number = rnd.Next(1, 10);
            Name = "Group" + rnd;
        }

        public Group(int number, string name)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
